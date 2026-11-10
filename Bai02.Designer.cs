namespace Lab3_25521671
{
    partial class Bai02
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListen = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.BackColor = SystemColors.ActiveBorder;
            btnListen.Font = new Font("Segoe UI", 13F);
            btnListen.Location = new Point(541, 32);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(228, 63);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click_1;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 117);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(757, 321);
            txtLog.TabIndex = 1;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLog);
            Controls.Add(btnListen);
            Name = "Bai02";
            Text = "Lab03_Bai02";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private TextBox txtLog;
    }
}
