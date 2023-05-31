namespace SinhVienProject
{
    partial class fLogin
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
            panel1 = new Panel();
            Exitbtn = new Button();
            button1 = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Exitbtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 432);
            panel1.TabIndex = 0;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = SystemColors.Control;
            Exitbtn.Location = new Point(616, 223);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(94, 29);
            Exitbtn.TabIndex = 3;
            Exitbtn.Text = "Thoát";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(516, 223);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(791, 92);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(611, 27);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 33);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 93);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(611, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Exitbtn;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "fLogin";
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Button Exitbtn;
        private Button button1;
    }
}