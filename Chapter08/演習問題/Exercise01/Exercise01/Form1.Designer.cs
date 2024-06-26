namespace Exercise01 {
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
            btEx8_1 = new Button();
            tbEx8_2 = new Button();
            tbDisp = new TextBox();
            tbEx8_3 = new Button();
            SuspendLayout();
            // 
            // btEx8_1
            // 
            btEx8_1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEx8_1.Location = new Point(104, 33);
            btEx8_1.Name = "btEx8_1";
            btEx8_1.Size = new Size(143, 75);
            btEx8_1.TabIndex = 0;
            btEx8_1.Text = "問題8.1";
            btEx8_1.UseVisualStyleBackColor = true;
            btEx8_1.Click += btEx8_1_Click;
            // 
            // tbEx8_2
            // 
            tbEx8_2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbEx8_2.Location = new Point(318, 48);
            tbEx8_2.Name = "tbEx8_2";
            tbEx8_2.Size = new Size(138, 60);
            tbEx8_2.TabIndex = 1;
            tbEx8_2.Text = "問題8.2";
            tbEx8_2.UseVisualStyleBackColor = true;
            tbEx8_2.Click += tbEx8_2_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(181, 173);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(358, 265);
            tbDisp.TabIndex = 2;
            tbDisp.TextChanged += tbDisp_TextChanged;
            // 
            // tbEx8_3
            // 
            tbEx8_3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbEx8_3.Location = new Point(529, 26);
            tbEx8_3.Name = "tbEx8_3";
            tbEx8_3.Size = new Size(154, 82);
            tbEx8_3.TabIndex = 3;
            tbEx8_3.Text = "問題8.3";
            tbEx8_3.UseVisualStyleBackColor = true;
            tbEx8_3.Click += tbEx8_3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbEx8_3);
            Controls.Add(tbDisp);
            Controls.Add(tbEx8_2);
            Controls.Add(btEx8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEx8_1;
        private Button tbEx8_2;
        private TextBox tbDisp;
        private Button tbEx8_3;
    }
}
