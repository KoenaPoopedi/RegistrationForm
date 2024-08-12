namespace Registration
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nameTxb = new TextBox();
            surnameTxb = new TextBox();
            label2 = new Label();
            genderCbx = new ComboBox();
            label3 = new Label();
            emailTxb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            citizenshipCbx = new ComboBox();
            registerBtn = new Button();
            cancelBtn = new Button();
            welcomMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image00012;
            pictureBox1.Location = new Point(56, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 427);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // nameTxb
            // 
            nameTxb.Location = new Point(143, 417);
            nameTxb.Name = "nameTxb";
            nameTxb.Size = new Size(147, 25);
            nameTxb.TabIndex = 2;
            // 
            // surnameTxb
            // 
            surnameTxb.Location = new Point(143, 448);
            surnameTxb.Name = "surnameTxb";
            surnameTxb.Size = new Size(147, 25);
            surnameTxb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 456);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // genderCbx
            // 
            genderCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCbx.FormattingEnabled = true;
            genderCbx.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderCbx.Location = new Point(143, 479);
            genderCbx.Name = "genderCbx";
            genderCbx.Size = new Size(147, 25);
            genderCbx.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 487);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // emailTxb
            // 
            emailTxb.Location = new Point(143, 506);
            emailTxb.Name = "emailTxb";
            emailTxb.Size = new Size(147, 25);
            emailTxb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 514);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 546);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 10;
            label5.Text = "Citizenship";
            // 
            // citizenshipCbx
            // 
            citizenshipCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            citizenshipCbx.FormattingEnabled = true;
            citizenshipCbx.Items.AddRange(new object[] { "South African", "Non South African" });
            citizenshipCbx.Location = new Point(143, 538);
            citizenshipCbx.Name = "citizenshipCbx";
            citizenshipCbx.Size = new Size(147, 25);
            citizenshipCbx.TabIndex = 9;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Peru;
            registerBtn.ForeColor = SystemColors.ActiveCaptionText;
            registerBtn.Location = new Point(196, 591);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 36);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Gray;
            cancelBtn.FlatStyle = FlatStyle.Popup;
            cancelBtn.ForeColor = Color.Linen;
            cancelBtn.Location = new Point(41, 591);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 36);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // welcomMsg
            // 
            welcomMsg.AutoSize = true;
            welcomMsg.BackColor = Color.Black;
            welcomMsg.ForeColor = SystemColors.ButtonHighlight;
            welcomMsg.Location = new Point(73, 46);
            welcomMsg.Name = "welcomMsg";
            welcomMsg.Size = new Size(217, 17);
            welcomMsg.TabIndex = 13;
            welcomMsg.Text = "Welcome to Koena's casting agency";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(387, 639);
            Controls.Add(welcomMsg);
            Controls.Add(cancelBtn);
            Controls.Add(registerBtn);
            Controls.Add(label5);
            Controls.Add(citizenshipCbx);
            Controls.Add(emailTxb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(genderCbx);
            Controls.Add(surnameTxb);
            Controls.Add(label2);
            Controls.Add(nameTxb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nameTxb;
        private TextBox surnameTxb;
        private Label label2;
        private ComboBox genderCbx;
        private Label label3;
        private TextBox emailTxb;
        private Label label4;
        private Label label5;
        private ComboBox citizenshipCbx;
        private Button registerBtn;
        private Button cancelBtn;
        private Label welcomMsg;
    }
}
