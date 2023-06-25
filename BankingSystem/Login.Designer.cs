namespace BankingSystem
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AccNumTb = new TextBox();
            PinTb = new TextBox();
            button1 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 17);
            label1.Name = "label1";
            label1.Size = new Size(184, 40);
            label1.TabIndex = 1;
            label1.Text = "BankSystem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(306, 91);
            label2.Name = "label2";
            label2.Size = new Size(106, 40);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 167);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 3;
            label3.Text = "ACC NUM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 243);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 4;
            label4.Text = "PIN CODE";
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(232, 174);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(233, 23);
            AccNumTb.TabIndex = 5;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // PinTb
            // 
            PinTb.Location = new Point(232, 252);
            PinTb.Name = "PinTb";
            PinTb.Size = new Size(233, 23);
            PinTb.TabIndex = 6;
            PinTb.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(245, 329);
            button1.Name = "button1";
            button1.Size = new Size(190, 34);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(306, 386);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "SIGNUP";
            label5.Click += label5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 10);
            panel2.TabIndex = 15;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(PinTb);
            Controls.Add(AccNumTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Button button1;
        private Label label5;
        private Panel panel2;
    }
}