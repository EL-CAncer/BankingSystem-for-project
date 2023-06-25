namespace BankingSystem
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            wdTb = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            balancelbl = new Label();
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
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(299, 92);
            label2.Name = "label2";
            label2.Size = new Size(182, 40);
            label2.TabIndex = 35;
            label2.Text = "WITHDRAW";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 420);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 34;
            label3.Text = "Back";
            label3.Click += Label3_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(289, 343);
            button1.Name = "button1";
            button1.Size = new Size(178, 31);
            button1.TabIndex = 33;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // wdTb
            // 
            wdTb.Location = new Point(289, 233);
            wdTb.Name = "wdTb";
            wdTb.Size = new Size(178, 23);
            wdTb.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 236);
            label5.Name = "label5";
            label5.Size = new Size(195, 20);
            label5.TabIndex = 31;
            label5.Text = "AMOUNT TO WITHDRAW:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 10);
            panel2.TabIndex = 36;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            balancelbl.Location = new Point(299, 178);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(168, 21);
            balancelbl.TabIndex = 37;
            balancelbl.Text = "AVAILABLE BALANCE";
            balancelbl.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 342);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(balancelbl);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(wdTb);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Withdraw";
            Text = "Withdraw";
            Load += Withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox wdTb;
        private Label label5;
        private Panel panel2;
        private Label balancelbl;
        private PictureBox pictureBox1;
    }
}