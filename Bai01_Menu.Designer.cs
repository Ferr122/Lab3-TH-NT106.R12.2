namespace Lab3_25521671
{
    partial class Bai01_Menu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            btnOpenServer.Text = "Open UDP Server";
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
            btnOpenClient.Text = "Open new UDP Client";
            btnOpenClient.UseVisualStyleBackColor = false;
            btnOpenClient.Click += btnOpenClient_Click;
            // 
            // Bai01_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 236);
            Controls.Add(btnOpenClient);
            Controls.Add(btnOpenServer);
            Name = "Bai01_Menu";
            Text = "Lab03_Bai01";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenServer;
        private Button btnOpenClient;
    }
}
