using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test0615_ReadWriteFile {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // string s = "ABC中文字";
            // FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Create);
            // byte[] buffer = System.Text.Encoding.ASCII.GetBytes(s);
            // ----
            // FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Create);
            //byte[] buffer = System.Text.Encoding.Unicode.GetBytes(s);
            //// Byte Order Mark  (BOM)
            //fs.WriteByte(255); fs.WriteByte(254);
            //fs.Write(buffer, 0, buffer.Length);
            // --------
            // FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Create);
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(s);
            //// fs.WriteByte(239); fs.WriteByte(187); fs.WriteByte(191);
            //fs.Write(buffer, 0, buffer.Length);

            string s = "ABC中文字";
            FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Create);
            Encoding encoder = System.Text.Encoding.GetEncoding("BIG5"); // 950
            byte[] buffer = encoder.GetBytes(s);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
            

            
        }

        private void button2_Click(object sender, EventArgs e) {
            FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.Open);
            long fileLength = fs.Length;
            byte[] buffer = new byte[fileLength];
            fs.Read(buffer, 0, (int)fileLength);
            fs.Close();
            Encoding encoder = System.Text.Encoding.GetEncoding("BIG5"); // 950
            string s = encoder.GetString(buffer);
            button2.Text = s;
        }

        private void button3_Click(object sender, EventArgs e) {
            string s = "ABC中文字"; // + System.Environment.NewLine;
            StreamWriter w = new StreamWriter(@"c:\temp\test2.txt", false);
            w.WriteLine(s);
            w.WriteLine("Line2");
            w.Close();
        }
        private void button4_Click(object sender, EventArgs e) {
            //   ABC...\r\nLine2\r\n
            //                      ^ = End Of Stream
            StreamReader r = new StreamReader(@"c:\temp\test2.txt");
            while (!r.EndOfStream) {
                string s = r.ReadLine();
                MessageBox.Show(s);
            }
            r.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            StreamReader r = new StreamReader(@"c:\temp\test2.txt");
            string s = r.ReadToEnd();
            r.Close();
            MessageBox.Show(s);
        }
    }
}
