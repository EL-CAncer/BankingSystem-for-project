namespace BankingSystem
{
    partial class ChangePin
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
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            Pin2Tb = new TextBox();
            Pin1Tb = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 210);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 19;
            label2.Text = "CONFIRM PIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(62, 134);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 18;
            label5.Text = "NEW PIN:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 89);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 29);
            label1.Name = "label1";
            label1.Size = new Size(184, 40);
            label1.TabIndex = 1;
            label1.Text = "BankSystem";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(196, 272);
            button1.Name = "button1";
            button1.Size = new Size(158, 31);
            button1.TabIndex = 23;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Location = new Point(196, 209);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(158, 23);
            Pin2Tb.TabIndex = 22;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Location = new Point(196, 131);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(158, 23);
            Pin1Tb.TabIndex = 21;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(242, 333);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 24;
            label3.Text = "Back";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 10);
            panel2.TabIndex = 25;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 363);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label5);
            Name = "ChangePin";
            Text = "ChangePin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox Pin2Tb;
        private TextBox Pin1Tb;
        private Label label3;
        private Panel panel2;
    }
}