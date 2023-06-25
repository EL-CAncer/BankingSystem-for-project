namespace BankingSystem
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            AccNumlbl = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 89);
            panel1.TabIndex = 0;
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
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(79, 138);
            button1.Name = "button1";
            button1.Size = new Size(150, 28);
            button1.TabIndex = 8;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(485, 138);
            button2.Name = "button2";
            button2.Size = new Size(150, 28);
            button2.TabIndex = 9;
            button2.Text = "WITHDRAW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(79, 304);
            button5.Name = "button5";
            button5.Size = new Size(150, 28);
            button5.TabIndex = 12;
            button5.Text = "CHANGE PIN ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(485, 304);
            button6.Name = "button6";
            button6.Size = new Size(150, 28);
            button6.TabIndex = 13;
            button6.Text = "BALANCE";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 10);
            panel2.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(320, 417);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 15;
            label5.Text = "LOGOUT";
            label5.Click += label5_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AccNumlbl.Location = new Point(241, 92);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(140, 21);
            AccNumlbl.TabIndex = 16;
            AccNumlbl.Text = "Account Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 361);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(AccNumlbl);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "HOME";
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
        private Label AccNumlbl;
        private PictureBox pictureBox1;
    }
}