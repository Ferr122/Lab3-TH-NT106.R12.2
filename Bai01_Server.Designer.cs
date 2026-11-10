namespace Lab3_25521671
{
    partial class Bai01_Server
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
            label1 = new Label();
            txtPort = new TextBox();
            label2 = new Label();
            txtLog = new TextBox();
            btnListen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 66);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(94, 66);
            txtPort.Multiline = true;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(261, 32);
            txtPort.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 3;
            label2.Text = "Receive Message";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(94, 207);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(648, 187);
            txtLog.TabIndex = 4;
            // 
            // btnListen
            // 
            btnListen.Font = new Font("Segoe UI", 12F);
            btnListen.Location = new Point(506, 66);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(236, 73);
            btnListen.TabIndex = 5;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click_1;
            // 
            // Bai01_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListen);
            Controls.Add(txtLog);
            Controls.Add(label2);
            Controls.Add(txtPort);
            Controls.Add(label1);
            Name = "Bai01_Server";
            Text = "Bai01 - UDP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtPort;
        private Label label2;
        private TextBox txtLog;
        private Button btnListen;
    }
}
