using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bottun_pre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String[] htmlFile;
        int cnt = 0;

        //挿入位置
        int insertRow = 0;
        int insertColumn = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            // ファイル名を保存する
            if(this.htmlFile[cnt] == null && cnt <= 5) { }

            htmlFile[cnt] = listBox1.SelectedItem.ToString();

            // ファイルの読み込み
            StreamReader sr = new StreamReader(@"../../../html/" + htmlFile, Encoding.GetEncoding("UTF-8"));
            string str = sr.ReadToEnd();
            sr.Close();

            // title取得
            int start = str.IndexOf("<title>");
            int end = str.IndexOf("</title>");
            // str.Substring(開始位置,取り出す文字数)
            string title = str.Substring(start + 7, end - (start + 7));

            if (tableLayoutPanel.GetControlFromPosition(insertColumn, insertRow) == null)
            {
                Button newButton = new Button();
                newButton.Text = title;
                newButton.Name = "titleButton" + cnt;
                tableLayoutPanel.Controls.Add(newButton, insertColumn++, insertRow++);
            }

            //listBox1.Items.Add(title);
        }

        private void btnclick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            webBrowser1.Navigate("../../../../tset03_pure/" + btn.Name);
        }
    }
}
