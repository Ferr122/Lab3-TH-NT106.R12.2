namespace Lab3_25521671
{
    partial class Bai03_Client
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
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveBorder;
            btnSend.Font = new Font("Segoe UI", 15F);
            btnSend.Location = new Point(127, 26);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(503, 60);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send Message";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Bai03_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 121);
            Controls.Add(btnSend);
            Name = "Bai03_Client";
            Text = "Bai03 - TCP Client";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
    }
}
