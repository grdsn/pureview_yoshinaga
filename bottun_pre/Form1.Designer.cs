namespace bottun_pre
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pureButton1 = new System.Windows.Forms.Button();
            this.pureButton2 = new System.Windows.Forms.Button();
            this.pureButton3 = new System.Windows.Forms.Button();
            this.pureButton4 = new System.Windows.Forms.Button();
            this.pureButton5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(353, 425);
            this.webBrowser1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.webBrowser1, "プレビューが表示される");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "プレビュー作成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "hello.html",
            "aaaaaaaa.html",
            "asd.html"});
            this.listBox1.Location = new System.Drawing.Point(389, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 184);
            this.listBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listBox1, "選択して");
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.pureButton1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pureButton2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pureButton3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pureButton4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.pureButton5, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(389, 285);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(127, 129);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // pureButton1
            // 
            this.pureButton1.Location = new System.Drawing.Point(3, 3);
            this.pureButton1.Name = "pureButton1";
            this.pureButton1.Size = new System.Drawing.Size(121, 19);
            this.pureButton1.TabIndex = 0;
            this.pureButton1.UseVisualStyleBackColor = true;
            this.pureButton1.Visible = false;
            this.pureButton1.Click += new System.EventHandler(this.pureButton1_Click);
            // 
            // pureButton2
            // 
            this.pureButton2.Location = new System.Drawing.Point(3, 28);
            this.pureButton2.Name = "pureButton2";
            this.pureButton2.Size = new System.Drawing.Size(121, 19);
            this.pureButton2.TabIndex = 1;
            this.pureButton2.UseVisualStyleBackColor = true;
            this.pureButton2.Visible = false;
            // 
            // pureButton3
            // 
            this.pureButton3.Location = new System.Drawing.Point(3, 53);
            this.pureButton3.Name = "pureButton3";
            this.pureButton3.Size = new System.Drawing.Size(121, 19);
            this.pureButton3.TabIndex = 2;
            this.pureButton3.UseVisualStyleBackColor = true;
            this.pureButton3.Visible = false;
            // 
            // pureButton4
            // 
            this.pureButton4.Location = new System.Drawing.Point(3, 78);
            this.pureButton4.Name = "pureButton4";
            this.pureButton4.Size = new System.Drawing.Size(121, 19);
            this.pureButton4.TabIndex = 3;
            this.pureButton4.UseVisualStyleBackColor = true;
            this.pureButton4.Visible = false;
            // 
            // pureButton5
            // 
            this.pureButton5.Location = new System.Drawing.Point(3, 103);
            this.pureButton5.Name = "pureButton5";
            this.pureButton5.Size = new System.Drawing.Size(121, 23);
            this.pureButton5.TabIndex = 4;
            this.pureButton5.UseVisualStyleBackColor = true;
            this.pureButton5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "←選択されているファイルを表示します";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(535, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "削除";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pureButton1;
        private System.Windows.Forms.Button pureButton2;
        private System.Windows.Forms.Button pureButton3;
        private System.Windows.Forms.Button pureButton4;
        private System.Windows.Forms.Button pureButton5;
    }
}

