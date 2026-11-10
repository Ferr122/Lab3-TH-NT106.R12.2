namespace Lab3_25521671
{
    partial class Bai04_Client
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
            txtLog = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 12);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(765, 234);
            txtLog.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 260);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 1;
            label1.Text = "Your name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 295);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 42);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 350);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 3;
            label2.Text = "Message";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 396);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(535, 42);
            txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveBorder;
            btnSend.Font = new Font("Segoe UI", 13F);
            btnSend.Location = new Point(611, 386);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(166, 54);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Bai04_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtLog);
            Name = "Bai04_Client";
            Text = "Bai04 - Chat Client";
            FormClosing += ChatClientForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLog;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtMessage;
        private Button btnSend;
    }
}
