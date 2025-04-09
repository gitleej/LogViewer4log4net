using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace LogViewer4log4net
{
    public partial class MainForm : Form
    {
        private static readonly Regex logLineRegex = new Regex(
            @"^(?<timestamp>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2},\d{3}) \[(?<thread>\d+)\] (?<level>[A-Z]+)\s+-\s+(?<message>.*)",
            RegexOptions.Compiled);

        private List<LogEntry> _allEntries = new List<LogEntry>();

        private LogPreviewForm _previewForm = null;
        private Timer _hoverTimer = null;
        private Timer _closeTimer = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadLog_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.IsFolderPicker = true;
                dialog.Title = "请选择日志文件夹";
                if (dialog.ShowDialog( )== CommonFileDialogResult.Ok)
                {
                    tbLogDir.Text = dialog.FileName;
                    // 读取所有日志行
                    _allEntries = GetAllLogLines(dialog.FileName);
                    ShowLogs(_allEntries);
                    groupBox1.Enabled = true;
                }
            }
        }

        private void ShowLogs(List<LogEntry> logs)
        {
            if (logs.Count != 0)
            {
                dtpBegin.Value = logs[0].Timestamp;
                dtpEnd.Value = logs[logs.Count - 1].Timestamp;
            }
            dgvLogViewer.Rows.Clear();
            foreach (var entry in logs)
            {
                dgvLogViewer.Rows.Add(entry.Index,
                    entry.Timestamp.ToString("yyyy-MM-dd HH:mm:ss,fff"), entry.ThreadId,
                    entry.Level, entry.Message);
                LogLevel level = (LogLevel)Enum.Parse(typeof(LogLevel),
                    dgvLogViewer.Rows[dgvLogViewer.Rows.Count - 1].Cells["Level"].Value.ToString());
                switch (level)
                {
                    case LogLevel.ALL:
                        break;
                    case LogLevel.DEBUG:
                        dgvLogViewer.Rows[dgvLogViewer.Rows.Count - 1].DefaultCellStyle.ForeColor =
                            Color.Blue;
                        break;
                    case LogLevel.INFO:
                        dgvLogViewer.Rows[dgvLogViewer.Rows.Count - 1].DefaultCellStyle.ForeColor =
                            Color.Green;
                        break;
                    case LogLevel.WARNING:
                        dgvLogViewer.Rows[dgvLogViewer.Rows.Count - 1].DefaultCellStyle.ForeColor =
                            Color.Yellow;
                        break;
                    case LogLevel.ERROR:
                    case LogLevel.FATAL:
                        dgvLogViewer.Rows[dgvLogViewer.Rows.Count - 1].DefaultCellStyle.ForeColor =
                            Color.Red;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// 从文件名中提取日志文件索引：
        /// 对于格式 xxx.log 视为索引 0，xxx.log.1、xxx.log.2 则提取后缀数字
        /// </summary>
        private int GetLogIndex(string filename)
        {
            Regex regex = new Regex(@"\.log(?:\.(\d+))?$", RegexOptions.IgnoreCase);
            Match m = regex.Match(filename);
            if (m.Success)
            {
                if (string.IsNullOrEmpty(m.Groups[1].Value))
                    return 0;
                else
                    return int.Parse(m.Groups[1].Value);
            }
            return 0;
        }

        /// <summary>
        /// 获取指定文件夹下所有日志文件内容（按 *.log* 匹配），
        /// 根据索引降序排序后依次连接各个文件的日志行
        /// </summary>
        private List<LogEntry> GetAllLogLines(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "ALL.log*");
            if (files.Length == 0)
            {
                MessageBox.Show("未找到匹配的日志文件！");
                return new List<LogEntry>();
            }
            // 按索引值降序排序，索引值最大的文件排在最前面
            var sortedFiles = files.OrderByDescending(f => GetLogIndex(f)).ToList();

            int index = 1;
            List<LogEntry> entries = new List<LogEntry>();
            foreach (var file in sortedFiles)
            {
                foreach (var line in File.ReadLines(file))
                {
                    var match = logLineRegex.Match(line);
                    if (match.Success)
                    {
                        entries.Add(new LogEntry
                        {
                            Index = index++,
                            Timestamp = DateTime.ParseExact(match.Groups["timestamp"].Value,
                                "yyyy-MM-dd HH:mm:ss,fff", null),
                            ThreadId = match.Groups["thread"].Value,
                            Level = match.Groups["level"].Value,
                            Message = match.Groups["message"].Value
                        });
                    }
                    else if (entries.Any())
                    {
                        // 若不匹配正则表达式，则视为堆栈跟踪或日志异常，追加到上一条日志。
                        entries.Last().Message += Environment.NewLine + line;
                    }
                }
            }
            return entries;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var level in Enum.GetNames(typeof(LogLevel)))
            {
                cbLogLevel.Items.Add(level);
            }

            cbLogLevel.SelectedIndex = 0;
            groupBox1.Enabled = false;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ShowLogs(ApplyFilter());
        }

        private List<LogEntry> ApplyFilter()
        {
            DateTime begin = dtpBegin.Value;
            DateTime end = dtpEnd.Value;
            string level = cbLogLevel.SelectedItem.ToString();
            string pattern = tbKeyWords.Text;
            bool useRegex = checkBoxRegExp.Checked;

            Regex regex = null;
            if (useRegex && !string.IsNullOrWhiteSpace(pattern))
            {
                try
                {
                    regex = new Regex(pattern);
                }
                catch (Exception e)
                {
                    MessageBox.Show("正则表达式错误：" + e);
                    return new List<LogEntry>();
                }
            }

            var filtered = _allEntries.Where(e =>
                e.Timestamp >= begin && 
                e.Timestamp <= end &&
                (string.IsNullOrWhiteSpace(level) || level == "ALL" || e.Level == level) &&
                (useRegex
                    ? (regex == null || regex.IsMatch(e.Message))
                    : (string.IsNullOrWhiteSpace(pattern) || e.Message.Contains(pattern))));

            return filtered.ToList();
        }

        private void dgvLogViewer_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                StartHoverTimer(e.RowIndex, e.ColumnIndex);
            }
        }

        private void dgvLogViewer_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            StopHoverTimer();
            StartCloseTimer();
        }
        private void StartHoverTimer(int rowIndex, int columnIndex)
        {
            StopHoverTimer();

            _hoverTimer = new Timer();
            _hoverTimer.Interval = 300; // 鼠标悬停 0.3 秒后显示
            _hoverTimer.Tick += (s, ev) =>
            {
                _hoverTimer.Stop();
                ShowPreview(rowIndex, columnIndex);
            };
            _hoverTimer.Start();
        }

        private void StopHoverTimer()
        {
            _hoverTimer?.Stop();
            _hoverTimer?.Dispose();
            _hoverTimer = null;
        }

        private void StartCloseTimer()
        {
            // StopCloseTimer();
            //
            // _closeTimer = new Timer();
            // _closeTimer.Interval = 2000; // 鼠标离开 0.8 秒后关闭
            // _closeTimer.Tick += (s, ev) =>
            // {
            //     _closeTimer.Stop();
            //     ClosePreviewForm();
            // };
            // _closeTimer.Start();
            StopCloseTimer();

            _closeTimer = new Timer();
            _closeTimer.Interval = 300;
            _closeTimer.Tick += (s, e) =>
            {
                var mousePos = Cursor.Position;

                // 鼠标是否在 DataGridView 的日志内容列上
                bool overLogContentCell = false;

                var clientPos = dgvLogViewer.PointToClient(mousePos);
                var hitTest = dgvLogViewer.HitTest(clientPos.X, clientPos.Y);

                if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.ColumnIndex == 4)
                {
                    overLogContentCell = true;
                }

                // 鼠标是否在预览弹窗内
                bool overPreview = _previewForm != null && _previewForm.Bounds.Contains(mousePos);

                if (!overLogContentCell && !overPreview)
                {
                    ClosePreviewForm();
                }

                _closeTimer.Stop();
            };
            _closeTimer.Start();
        }

        private void StopCloseTimer()
        {
            _closeTimer?.Stop();
            _closeTimer?.Dispose();
            _closeTimer = null;
        }

        private void ShowPreview(int rowIndex, int columnIndex)
        {
            var cell = dgvLogViewer.Rows[rowIndex].Cells[columnIndex];
            var value = cell.Value?.ToString();
            if (string.IsNullOrWhiteSpace(value)) return;

            var cellDisplayRect = dgvLogViewer.GetCellDisplayRectangle(columnIndex, rowIndex, true);
            var location = dgvLogViewer.PointToScreen(new Point(cellDisplayRect.Left, cellDisplayRect.Bottom));

            if (_previewForm == null)
            {
                _previewForm = new LogPreviewForm(value);
                _previewForm.Show();
            }
            else
            {
                _previewForm.UpdateText(value);
            }

            _previewForm.UpdateLocation(location);
        }

        // 鼠标彻底离开后关闭窗口
        private void ClosePreviewForm()
        {
            _previewForm?.Close();
            _previewForm?.Dispose();
            _previewForm = null;
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            ShowLogs(_allEntries);
        }
    }

    public class LogEntry
    {
        public int Index { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string ThreadId { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
    }

    public enum LogLevel
    {
        ALL = 0,
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        FATAL
    }
}
