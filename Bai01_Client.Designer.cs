namespace Lab3_25521671
{
    partial class Bai01_Client
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
            label2 = new Label();
            label3 = new Label();
            txtServerIP = new TextBox();
            txtServerPort = new TextBox();
            txtMessage = new TextBox();
            btnSend_click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(193, 36);
            label1.TabIndex = 0;
            label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(606, 51);
            label2.Name = "label2";
            label2.Size = new Size(62, 36);
            label2.TabIndex = 1;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(116, 36);
            label3.TabIndex = 2;
            label3.Text = "Message";
            // 
            // txtServerIP
            // 
            txtServerIP.Font = new Font("Segoe UI", 13F);
            txtServerIP.Location = new Point(12, 101);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(466, 42);
            txtServerIP.TabIndex = 3;
            // 
            // txtServerPort
            // 
            txtServerPort.Font = new Font("Segoe UI", 13F);
            txtServerPort.Location = new Point(595, 101);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(172, 42);
            txtServerPort.TabIndex = 4;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 10F);
            txtMessage.Location = new Point(12, 218);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(755, 145);
            txtMessage.TabIndex = 5;
            // 
            // btnSend_click
            // 
            btnSend_click.BackColor = SystemColors.ActiveBorder;
            btnSend_click.FlatAppearance.BorderColor = Color.AliceBlue;
            btnSend_click.FlatStyle = FlatStyle.Flat;
            btnSend_click.Font = new Font("Segoe UI", 13F);
            btnSend_click.ForeColor = SystemColors.ActiveCaptionText;
            btnSend_click.Location = new Point(38, 384);
            btnSend_click.Name = "btnSend_click";
            btnSend_click.Size = new Size(189, 43);
            btnSend_click.TabIndex = 6;
            btnSend_click.Text = "Send";
            btnSend_click.UseVisualStyleBackColor = false;
            btnSend_click.Click += btnSend_click_Click;
            // 
            // Bai01_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend_click);
            Controls.Add(txtMessage);
            Controls.Add(txtServerPort);
            Controls.Add(txtServerIP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai01_Client";
            Text = "Bai01 - UDP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtServerIP;
        private TextBox txtServerPort;
        private TextBox txtMessage;
        private Button btnSend_click;
    }
}
