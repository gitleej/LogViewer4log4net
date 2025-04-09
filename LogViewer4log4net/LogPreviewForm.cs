using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogViewer4log4net
{
    public partial class LogPreviewForm : Form
    {
        private TextBox textBox;
        public LogPreviewForm(string message)
        {
            InitializeComponent();

            textBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Both,
                Dock = DockStyle.Fill,
                WordWrap = false,
                Text = message,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // 禁用自动全选
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
            // 支持 Ctrl+C
            textBox.ShortcutsEnabled = true;

            this.Controls.Add(textBox);
        }

        public void UpdateLocation(Point screenLocation)
        {
            this.Location = screenLocation;
        }

        public void UpdateText(string message)
        {
            textBox.Text = message;
        }
    }
}
