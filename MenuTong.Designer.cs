namespace Lab3_25521671
{
    partial class MenuTong
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
            btnBai01 = new Button();
            btnBai02 = new Button();
            btnBai03 = new Button();
            btnBai04 = new Button();
            SuspendLayout();
            // 
            // btnBai01
            // 
            btnBai01.BackColor = SystemColors.ActiveBorder;
            btnBai01.Font = new Font("Segoe UI", 14F);
            btnBai01.Location = new Point(95, 30);
            btnBai01.Name = "btnBai01";
            btnBai01.Size = new Size(571, 60);
            btnBai01.TabIndex = 0;
            btnBai01.Text = "Bài 01 - UDP Client / Server";
            btnBai01.UseVisualStyleBackColor = false;
            btnBai01.Click += btnBai01_Click;
            // 
            // btnBai02
            // 
            btnBai02.BackColor = SystemColors.ActiveBorder;
            btnBai02.Font = new Font("Segoe UI", 14F);
            btnBai02.Location = new Point(95, 110);
            btnBai02.Name = "btnBai02";
            btnBai02.Size = new Size(571, 60);
            btnBai02.TabIndex = 1;
            btnBai02.Text = "Bài 02 - TCP Server (Telnet)";
            btnBai02.UseVisualStyleBackColor = false;
            btnBai02.Click += btnBai02_Click;
            // 
            // btnBai03
            // 
            btnBai03.BackColor = SystemColors.ActiveBorder;
            btnBai03.Font = new Font("Segoe UI", 14F);
            btnBai03.Location = new Point(95, 190);
            btnBai03.Name = "btnBai03";
            btnBai03.Size = new Size(571, 60);
            btnBai03.TabIndex = 2;
            btnBai03.Text = "Bài 03 - TCP Client / Server";
            btnBai03.UseVisualStyleBackColor = false;
            btnBai03.Click += btnBai03_Click;
            // 
            // btnBai04
            // 
            btnBai04.BackColor = SystemColors.ActiveBorder;
            btnBai04.Font = new Font("Segoe UI", 14F);
            btnBai04.Location = new Point(95, 270);
            btnBai04.Name = "btnBai04";
            btnBai04.Size = new Size(571, 60);
            btnBai04.TabIndex = 3;
            btnBai04.Text = "Bài 04 - TCP Chat Room";
            btnBai04.UseVisualStyleBackColor = false;
            btnBai04.Click += btnBai04_Click;
            // 
            // MenuTong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 370);
            Controls.Add(btnBai04);
            Controls.Add(btnBai03);
            Controls.Add(btnBai02);
            Controls.Add(btnBai01);
            Name = "MenuTong";
            Text = "Lab03 - 25521671";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBai01;
        private Button btnBai02;
        private Button btnBai03;
        private Button btnBai04;
    }
}
