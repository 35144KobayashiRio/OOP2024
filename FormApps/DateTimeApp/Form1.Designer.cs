
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
            btDateCount = new Button();
            dtpBirthday = new DateTimePicker();
            tbDisp = new TextBox();
            label1 = new Label();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            btDayafter = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // btDateCount
            // 
            btDateCount.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDateCount.Location = new Point(400, 48);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(200, 54);
            btDateCount.TabIndex = 0;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += button1_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(142, 22);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(199, 39);
            dtpBirthday.TabIndex = 1;
            dtpBirthday.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(132, 308);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(427, 66);
            tbDisp.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(52, 24);
            label1.Name = "label1";
            label1.Size = new Size(71, 37);
            label1.TabIndex = 3;
            label1.Text = "日付";
            label1.Click += label1_Click;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(78, 163);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(190, 43);
            nudDay.TabIndex = 4;
            nudDay.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefore.Location = new Point(319, 133);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(134, 47);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayafter
            // 
            btDayafter.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayafter.Location = new Point(319, 197);
            btDayafter.Name = "btDayafter";
            btDayafter.Size = new Size(134, 50);
            btDayafter.TabIndex = 6;
            btDayafter.Text = "日後";
            btDayafter.UseVisualStyleBackColor = true;
            btDayafter.Click += btDayafter_Click;
            // 
            // btAge
            // 
            btAge.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAge.Location = new Point(479, 197);
            btAge.Name = "btAge";
            btAge.Size = new Size(121, 50);
            btAge.TabIndex = 7;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 440);
            Controls.Add(btAge);
            Controls.Add(btDayafter);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(label1);
            Controls.Add(tbDisp);
            Controls.Add(dtpBirthday);
            Controls.Add(btDateCount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private Button btDateCount;
        private DateTimePicker dtpBirthday;
        private TextBox tbDisp;
        private Label label1;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button btDayafter;
        private Button btAge;
    }
}
