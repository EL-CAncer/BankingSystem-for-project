namespace BankingSystem
{
    partial class Account
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
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            AccNumTb = new TextBox();
            AccNametb = new TextBox();
            FanameTb = new TextBox();
            Addresstb = new TextBox();
            PhoneTb = new TextBox();
            pintb = new TextBox();
            educationcb = new ComboBox();
            dobdate = new DateTimePicker();
            button1 = new Button();
            panel2 = new Panel();
            label12 = new Label();
            occupationtb = new TextBox();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 145);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "ACC NUM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 187);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 10;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 230);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "FNAME";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 275);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "ADDRESS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(413, 271);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 13;
            label6.Text = "PHONE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(413, 191);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 14;
            label7.Text = "EDUCATION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(413, 234);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 15;
            label8.Text = "OCCUPATION";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(413, 320);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 16;
            label9.Text = "DOB";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(413, 145);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 17;
            label10.Text = "PIN";
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(157, 142);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(157, 23);
            AccNumTb.TabIndex = 19;
            // 
            // AccNametb
            // 
            AccNametb.Location = new Point(157, 188);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(157, 23);
            AccNametb.TabIndex = 20;
            // 
            // FanameTb
            // 
            FanameTb.Location = new Point(157, 231);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(157, 23);
            FanameTb.TabIndex = 21;
            // 
            // Addresstb
            // 
            Addresstb.Location = new Point(157, 272);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(157, 86);
            Addresstb.TabIndex = 22;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(532, 268);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(157, 23);
            PhoneTb.TabIndex = 23;
            // 
            // pintb
            // 
            pintb.Location = new Point(532, 145);
            pintb.Name = "pintb";
            pintb.Size = new Size(157, 23);
            pintb.TabIndex = 24;
            // 
            // educationcb
            // 
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(532, 192);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(157, 23);
            educationcb.TabIndex = 29;
            // 
            // dobdate
            // 
            dobdate.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dobdate.Location = new Point(532, 313);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(186, 22);
            dobdate.TabIndex = 31;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(301, 439);
            button1.Name = "button1";
            button1.Size = new Size(190, 34);
            button1.TabIndex = 32;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 537);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 21);
            panel2.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(361, 486);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 34;
            label12.Text = "LOGOUT";
            label12.Click += label12_Click;
            // 
            // occupationtb
            // 
            occupationtb.Location = new Point(532, 234);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(157, 23);
            occupationtb.TabIndex = 35;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 558);
            Controls.Add(occupationtb);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(dobdate);
            Controls.Add(educationcb);
            Controls.Add(pintb);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Account";
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox AccNumTb;
        private TextBox AccNametb;
        private TextBox FanameTb;
        private TextBox Addresstb;
        private TextBox PhoneTb;
        private TextBox pintb;
        private ComboBox educationcb;
        private DateTimePicker dobdate;
        private Button button1;
        private Panel panel2;
        private Label label12;
        private TextBox occupationtb;
    }
}