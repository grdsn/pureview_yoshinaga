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
        private Button[] buttons;
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // ファイルの読み込み
            StreamReader sr = new StreamReader(@"../../../html/hello.html", Encoding.GetEncoding("Shift_JIS"));
            string str = sr.ReadToEnd();
            sr.Close();

            // title取得
            int start = str.IndexOf("<title>");
            int end = str.IndexOf("</title>");
            // str.Substring(開始位置,取り出す文字数)
            string title = str.Substring(start + 7, end - (start + 7));

            //挿入位置
            int insertRow = 0;
            int insertColumn = 0;

            if (tableLayoutPanel.GetControlFromPosition(insertColumn, insertRow) == null)
            {
                Button newButton = new Button();
                newButton.Text = title;
                tableLayoutPanel.Controls.Add(newButton, insertColumn, insertRow);
            }

                //プロパティ設定
                this.buttons[cnt].Location = new Point(400,150);
                this.buttons[cnt].Name = "btn" + cnt.ToString();
                this.buttons[cnt].Text = title;
                this.buttons[cnt].Top = cnt * 30;

                //コントロールをフォームに追加
                this.Controls.Add(this.buttons[cnt]);

                cnt++;

            //this.buttons[cnt].Click += new System.EventHandler(btnclick);
        }

        private void btnclick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            webBrowser1.Navigate("../../../../tset03_pure/" + btn.Name);
        }
    }
}
