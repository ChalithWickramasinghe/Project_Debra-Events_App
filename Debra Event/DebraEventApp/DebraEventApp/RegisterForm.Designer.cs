namespace DebraEventApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegisterRegister = new System.Windows.Forms.Button();
            this.btnRegisterLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainMenuRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 28F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(256, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 64);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Wanna Join?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(557, 105);
            this.txtRegisterName.Multiline = true;
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(222, 25);
            this.txtRegisterName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(557, 150);
            this.txtRegisterEmail.Multiline = true;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(222, 25);
            this.txtRegisterEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(557, 199);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(222, 25);
            this.txtRegisterPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // txtRegisterConfirmPassword
            // 
            this.txtRegisterConfirmPassword.Location = new System.Drawing.Point(557, 245);
            this.txtRegisterConfirmPassword.Multiline = true;
            this.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            this.txtRegisterConfirmPassword.Size = new System.Drawing.Size(222, 25);
            this.txtRegisterConfirmPassword.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password";
            // 
            // btnRegisterRegister
            // 
            this.btnRegisterRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRegister.Location = new System.Drawing.Point(482, 305);
            this.btnRegisterRegister.Name = "btnRegisterRegister";
            this.btnRegisterRegister.Size = new System.Drawing.Size(171, 42);
            this.btnRegisterRegister.TabIndex = 12;
            this.btnRegisterRegister.Text = "Register";
            this.btnRegisterRegister.UseVisualStyleBackColor = false;
            this.btnRegisterRegister.Click += new System.EventHandler(this.btnRegisterRegister_Click);
            // 
            // btnRegisterLogin
            // 
            this.btnRegisterLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegisterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterLogin.Location = new System.Drawing.Point(640, 420);
            this.btnRegisterLogin.Name = "btnRegisterLogin";
            this.btnRegisterLogin.Size = new System.Drawing.Size(130, 33);
            this.btnRegisterLogin.TabIndex = 13;
            this.btnRegisterLogin.Text = "Click Here";
            this.btnRegisterLogin.UseVisualStyleBackColor = false;
            this.btnRegisterLogin.Click += new System.EventHandler(this.btnRegisterLogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(383, 427);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Already have an account?";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-100, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 365);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainMenuRegister
            // 
            this.btnMainMenuRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMainMenuRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuRegister.Location = new System.Drawing.Point(517, 353);
            this.btnMainMenuRegister.Name = "btnMainMenuRegister";
            this.btnMainMenuRegister.Size = new System.Drawing.Size(96, 29);
            this.btnMainMenuRegister.TabIndex = 50;
            this.btnMainMenuRegister.Text = "Main Menu";
            this.btnMainMenuRegister.UseVisualStyleBackColor = false;
            this.btnMainMenuRegister.Click += new System.EventHandler(this.btnMainMenuRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnMainMenuRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRegisterLogin);
            this.Controls.Add(this.btnRegisterRegister);
            this.Controls.Add(this.txtRegisterConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegisterConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegisterRegister;
        private System.Windows.Forms.Button btnRegisterLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainMenuRegister;
    }
}