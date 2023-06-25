namespace BankingSystem
{
    partial class Deposit
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
            label3 = new Label();
            button1 = new Button();
            DepoAmtTb = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
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
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 27);
            label1.Name = "label1";
            label1.Size = new Size(431, 40);
            label1.TabIndex = 2;
            label1.Text = "Select Your Transaction Please";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(390, 276);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 28;
            label3.Text = "BACK";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(342, 223);
            button1.Name = "button1";
            button1.Size = new Size(178, 31);
            button1.TabIndex = 27;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Location = new Point(342, 156);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(178, 23);
            DepoAmtTb.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(230, 159);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 25;
            label5.Text = "AMOUNT:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 10);
            panel2.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(359, 92);
            label2.Name = "label2";
            label2.Size = new Size(135, 40);
            label2.TabIndex = 30;
            label2.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(DepoAmtTb);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Deposit";
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private TextBox DepoAmtTb;
    }
}