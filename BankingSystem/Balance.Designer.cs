namespace BankingSystem
{
    partial class Balance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            Balancelbl = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            AccNumberlbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 89);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 25);
            label1.Name = "label1";
            label1.Size = new Size(184, 40);
            label1.TabIndex = 1;
            label1.Text = "BankSystem";
            label1.Click += label1_Click;
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Balancelbl.Location = new Point(388, 215);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(93, 20);
            Balancelbl.TabIndex = 19;
            Balancelbl.Text = "BalanceinRs";
            Balancelbl.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 10);
            panel2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(312, 417);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 21;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(248, 139);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 16;
            label5.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(248, 215);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 17;
            label2.Text = "Your Balance:";
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AccNumberlbl.Location = new Point(388, 139);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(69, 20);
            AccNumberlbl.TabIndex = 18;
            AccNumberlbl.Text = "AccNum\r\n";
            AccNumberlbl.Click += AccNumberlbl_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumberlbl);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Balance";
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label Balancelbl;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label AccNumberlbl;
    }
}