using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0615_MyBrowser {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // System.Diagnostics.Process.Start(@"c:\temp\test1.txt");
            // System.Diagnostics.Process.Start("Notepad");
            System.Diagnostics.Process.Start("http://www.hinet.net");
        }

        private void goButton_Click(object sender, EventArgs e) {
            webBrowser1.Navigate(urlTextBox.Text);
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
