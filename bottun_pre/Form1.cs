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

        string[] htmlFile = new string[5];      // ファイル名を保存する
        int cnt = 0;                            // ボタンの表示数をカウント
        Button[] buttons = new Button[5];       // ボタンの情報を保持する

        private void button1_Click(object sender, EventArgs e)
        {

            // ！”プレビューを表示する前にデータの保存が必要です”
            // 取得するファイルをlistBoxで表現


            // 同じものは表示しない
            Boolean flg = true;
            foreach (string oldTitle in htmlFile) {
                if (cnt == 5 || oldTitle == listBox1.SelectedItem.ToString())
                {
                    flg = false;
                    MessageBox.Show("重複で表示はできないよ！または、これ以上表示できないよ！的な");
                }
            }

            if (flg == true)
            {
                // ファイル名を保持する
                htmlFile[cnt] = listBox1.SelectedItem.ToString();
                label1.Text = listBox1.SelectedItem.ToString();

                // ファイルの読み込み
                StreamReader sr = new StreamReader("../../../html/" + htmlFile[cnt], Encoding.GetEncoding("UTF-8"));
                string str = sr.ReadToEnd();
                sr.Close();


                // title取得
                int start = str.IndexOf("<title>");
                int end = str.IndexOf("</title>");
                // str.Substring(開始位置,取り出す文字数)
                string title = str.Substring(start + 7, end - (start + 7));

                int Numcnt = 0;
                // ボタンを配置する
                for(int i = 0; buttons[cnt] != null; i++)
                {
                    Numcnt++;
                }

                if (Numcnt == 0)
                {
                    //buttonName.Text = title;
                    //buttonName.Name = title;
                    buttons[cnt] = pureButton1;
                    pureButton1.Text = label1.Text;
                    pureButton1.Name = label1.Text;
                    pureButton1.Visible = true;
                }
                else if(Numcnt == 1)
                {
                    buttons[cnt] = pureButton2;
                    pureButton2.Text = label1.Text;
                    pureButton2.Name = label1.Text;
                    pureButton2.Visible = true;
                }
                else if(Numcnt == 2)
                {
                    buttons[cnt] = pureButton3;
                    pureButton3.Text = label1.Text;
                    pureButton3.Name = label1.Text;
                    pureButton3.Visible = true;
                }
                cnt++;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            for (int l = 0; l <= 5; l++)
            {
                buttons[--cnt].Visible = false;                               // 改善要
                htmlFile[cnt] = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // testボタンの処理なので関係ないです
            webBrowser1.Navigate("file:///C:/Users/S3A2/source/repos/bottun_pre/html/hello.html");
        }

        private void pureButton1_Click(object sender, EventArgs e)
        {
            // 動的に表示されたボタンを押すとWeb表示
            webBrowser1.Navigate("file:///C:/Users/S3A2/source/repos/bottun_pre/html/" + pureButton1.Text);
        }
        private void pureButton2_Click(object sender, EventArgs e)
        {
            // 動的に表示されたボタンを押すとWeb表示
            webBrowser1.Navigate("file:///C:/Users/S3A2/source/repos/bottun_pre/html/" + pureButton2.Text);
        }
    }
}
