﻿namespace RSSReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbFa = new System.Windows.Forms.ComboBox();
            this.tbRssName = new System.Windows.Forms.TextBox();
            this.btRegist = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btGet.Location = new System.Drawing.Point(906, 7);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(13, 88);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(210, 556);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(237, 85);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(814, 557);
            this.webView2.TabIndex = 3;
            this.webView2.ZoomFactor = 1D;
            // 
            // cbFa
            // 
            this.cbFa.FormattingEnabled = true;
            this.cbFa.Location = new System.Drawing.Point(299, 9);
            this.cbFa.Name = "cbFa";
            this.cbFa.Size = new System.Drawing.Size(583, 20);
            this.cbFa.TabIndex = 4;
            this.cbFa.Tag = "";
            // 
            // tbRssName
            // 
            this.tbRssName.Location = new System.Drawing.Point(299, 54);
            this.tbRssName.Name = "tbRssName";
            this.tbRssName.Size = new System.Drawing.Size(583, 19);
            this.tbRssName.TabIndex = 5;
            // 
            // btRegist
            // 
            this.btRegist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRegist.Location = new System.Drawing.Point(888, 50);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(75, 23);
            this.btRegist.TabIndex = 6;
            this.btRegist.Text = "登録";
            this.btRegist.UseVisualStyleBackColor = false;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 19);
            this.textBox1.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Delete.Location = new System.Drawing.Point(969, 50);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "消去";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 654);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.tbRssName);
            this.Controls.Add(this.cbFa);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.ComboBox cbFa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.TextBox tbRssName;
        private System.Windows.Forms.Button Delete;
    }
}

