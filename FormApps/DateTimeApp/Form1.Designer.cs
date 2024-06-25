namespace DateTimeApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpBirthday = new DateTimePicker();
            bpDateCount = new Button();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            btalld = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 169);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(331, 162);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 39);
            dtpBirthday.TabIndex = 1;
            // 
            // bpDateCount
            // 
            bpDateCount.Location = new Point(354, 232);
            bpDateCount.Name = "bpDateCount";
            bpDateCount.Size = new Size(177, 41);
            bpDateCount.TabIndex = 2;
            bpDateCount.Text = "今日までの日数";
            bpDateCount.UseVisualStyleBackColor = true;
            bpDateCount.Click += bpDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(212, 389);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(319, 39);
            tbDisp.TabIndex = 3;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(212, 311);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 46);
            nudDay.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Location = new Point(354, 279);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(75, 46);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Location = new Point(456, 279);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(75, 46);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // btalld
            // 
            btalld.Location = new Point(354, 340);
            btalld.Name = "btalld";
            btalld.Size = new Size(75, 43);
            btalld.TabIndex = 6;
            btalld.Text = "button1";
            btalld.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btalld);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(bpDateCount);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button bpDateCount;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button btalld;
    }
}
