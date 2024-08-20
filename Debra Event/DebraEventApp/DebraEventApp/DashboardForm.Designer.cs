namespace DebraEventApp
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnSetTickets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainMenuDashboard = new System.Windows.Forms.Button();
            this.btnLogoutDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 28F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(214, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 66);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "DASHBOARD";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(262, 84);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Where Events Come to Life";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.Location = new System.Drawing.Point(308, 155);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(184, 33);
            this.btnCreateEvent.TabIndex = 2;
            this.btnCreateEvent.Text = "Create New Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnSetTickets
            // 
            this.btnSetTickets.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSetTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTickets.Location = new System.Drawing.Point(308, 209);
            this.btnSetTickets.Name = "btnSetTickets";
            this.btnSetTickets.Size = new System.Drawing.Size(184, 33);
            this.btnSetTickets.TabIndex = 3;
            this.btnSetTickets.Text = "Set Tickets";
            this.btnSetTickets.UseVisualStyleBackColor = false;
            this.btnSetTickets.Click += new System.EventHandler(this.btnSetTickets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-46, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 265);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainMenuDashboard
            // 
            this.btnMainMenuDashboard.BackColor = System.Drawing.Color.White;
            this.btnMainMenuDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuDashboard.Location = new System.Drawing.Point(651, 374);
            this.btnMainMenuDashboard.Name = "btnMainMenuDashboard";
            this.btnMainMenuDashboard.Size = new System.Drawing.Size(120, 29);
            this.btnMainMenuDashboard.TabIndex = 50;
            this.btnMainMenuDashboard.Text = "Main Menu";
            this.btnMainMenuDashboard.UseVisualStyleBackColor = false;
            this.btnMainMenuDashboard.Click += new System.EventHandler(this.btnMainMenuDashboard_Click);
            // 
            // btnLogoutDashboard
            // 
            this.btnLogoutDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogoutDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutDashboard.Location = new System.Drawing.Point(651, 409);
            this.btnLogoutDashboard.Name = "btnLogoutDashboard";
            this.btnLogoutDashboard.Size = new System.Drawing.Size(120, 29);
            this.btnLogoutDashboard.TabIndex = 53;
            this.btnLogoutDashboard.Text = "Logout";
            this.btnLogoutDashboard.UseVisualStyleBackColor = false;
            this.btnLogoutDashboard.Click += new System.EventHandler(this.btnLogoutDashboard_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogoutDashboard);
            this.Controls.Add(this.btnMainMenuDashboard);
            this.Controls.Add(this.btnSetTickets);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnSetTickets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainMenuDashboard;
        private System.Windows.Forms.Button btnLogoutDashboard;
    }
}