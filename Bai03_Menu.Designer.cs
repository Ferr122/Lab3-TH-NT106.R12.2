namespace Lab3_25521671
{
    partial class Bai03_Menu
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
            btnOpenServer = new Button();
            btnOpenClient = new Button();
            SuspendLayout();
            // 
            // btnOpenServer
            // 
            btnOpenServer.BackColor = SystemColors.ActiveBorder;
            btnOpenServer.Font = new Font("Segoe UI", 15F);
            btnOpenServer.Location = new Point(95, 39);
            btnOpenServer.Name = "btnOpenServer";
            btnOpenServer.Size = new Size(571, 60);
            btnOpenServer.TabIndex = 0;
            btnOpenServer.Text = "Open TCP Server";
            btnOpenServer.UseVisualStyleBackColor = false;
            btnOpenServer.Click += btnOpenServer_Click;
            // 
            // btnOpenClient
            // 
            btnOpenClient.BackColor = SystemColors.ActiveBorder;
            btnOpenClient.Font = new Font("Segoe UI", 15F);
            btnOpenClient.Location = new Point(95, 132);
            btnOpenClient.Name = "btnOpenClient";
            btnOpenClient.Size = new Size(571, 60);
            btnOpenClient.TabIndex = 1;
            btnOpenClient.Text = "Open new TCP Client";
            btnOpenClient.UseVisualStyleBackColor = false;
            btnOpenClient.Click += btnOpenClient_Click;
            // 
            // Bai03_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 236);
            Controls.Add(btnOpenClient);
            Controls.Add(btnOpenServer);
            Name = "Bai03_Menu";
            Text = "Lab03_Bai03";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenServer;
        private Button btnOpenClient;
    }
}
