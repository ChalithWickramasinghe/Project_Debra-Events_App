namespace DebraEventApp
{
    partial class AdminEventView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAdminEventDelete = new System.Windows.Forms.Button();
            this.btnAdminEventUpdate = new System.Windows.Forms.Button();
            this.btnAdminEventView = new System.Windows.Forms.Button();
            this.txtAdminEventPartnerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminEventID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminEventDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdminPreviousViewEvent = new System.Windows.Forms.Button();
            this.txtAdminEventVenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminEventDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvAdminEventView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEventView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminEventDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminEventUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminEventView);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventPartnerID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminPreviousViewEvent);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventVenue);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminEventName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAdminEventView);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 555);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAdminEventDelete
            // 
            this.btnAdminEventDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdminEventDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEventDelete.Location = new System.Drawing.Point(266, 444);
            this.btnAdminEventDelete.Name = "btnAdminEventDelete";
            this.btnAdminEventDelete.Size = new System.Drawing.Size(107, 41);
            this.btnAdminEventDelete.TabIndex = 74;
            this.btnAdminEventDelete.Text = "Delete";
            this.btnAdminEventDelete.UseVisualStyleBackColor = false;
            this.btnAdminEventDelete.Click += new System.EventHandler(this.btnAdminEventDelete_Click);
            // 
            // btnAdminEventUpdate
            // 
            this.btnAdminEventUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminEventUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEventUpdate.Location = new System.Drawing.Point(161, 444);
            this.btnAdminEventUpdate.Name = "btnAdminEventUpdate";
            this.btnAdminEventUpdate.Size = new System.Drawing.Size(99, 41);
            this.btnAdminEventUpdate.TabIndex = 73;
            this.btnAdminEventUpdate.Text = "Update";
            this.btnAdminEventUpdate.UseVisualStyleBackColor = false;
            this.btnAdminEventUpdate.Click += new System.EventHandler(this.btnAdminEventUpdate_Click);
            // 
            // btnAdminEventView
            // 
            this.btnAdminEventView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminEventView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEventView.Location = new System.Drawing.Point(56, 444);
            this.btnAdminEventView.Name = "btnAdminEventView";
            this.btnAdminEventView.Size = new System.Drawing.Size(99, 41);
            this.btnAdminEventView.TabIndex = 72;
            this.btnAdminEventView.Text = "View";
            this.btnAdminEventView.UseVisualStyleBackColor = false;
            // 
            // txtAdminEventPartnerID
            // 
            this.txtAdminEventPartnerID.Location = new System.Drawing.Point(202, 147);
            this.txtAdminEventPartnerID.Name = "txtAdminEventPartnerID";
            this.txtAdminEventPartnerID.Size = new System.Drawing.Size(186, 22);
            this.txtAdminEventPartnerID.TabIndex = 71;
            this.txtAdminEventPartnerID.TextChanged += new System.EventHandler(this.txtEventPartnerID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Partner ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAdminEventID
            // 
            this.txtAdminEventID.Location = new System.Drawing.Point(202, 185);
            this.txtAdminEventID.Name = "txtAdminEventID";
            this.txtAdminEventID.Size = new System.Drawing.Size(186, 22);
            this.txtAdminEventID.TabIndex = 69;
            this.txtAdminEventID.TextChanged += new System.EventHandler(this.txtEventID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Event ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAdminEventDescription
            // 
            this.txtAdminEventDescription.Location = new System.Drawing.Point(202, 267);
            this.txtAdminEventDescription.Multiline = true;
            this.txtAdminEventDescription.Name = "txtAdminEventDescription";
            this.txtAdminEventDescription.Size = new System.Drawing.Size(186, 55);
            this.txtAdminEventDescription.TabIndex = 67;
            this.txtAdminEventDescription.TextChanged += new System.EventHandler(this.txtEventDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnAdminPreviousViewEvent
            // 
            this.btnAdminPreviousViewEvent.BackColor = System.Drawing.Color.White;
            this.btnAdminPreviousViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPreviousViewEvent.Location = new System.Drawing.Point(12, 511);
            this.btnAdminPreviousViewEvent.Name = "btnAdminPreviousViewEvent";
            this.btnAdminPreviousViewEvent.Size = new System.Drawing.Size(65, 29);
            this.btnAdminPreviousViewEvent.TabIndex = 65;
            this.btnAdminPreviousViewEvent.Text = "Back";
            this.btnAdminPreviousViewEvent.UseVisualStyleBackColor = false;
            this.btnAdminPreviousViewEvent.Click += new System.EventHandler(this.btnPreviousNewEvent_Click);
            // 
            // txtAdminEventVenue
            // 
            this.txtAdminEventVenue.Location = new System.Drawing.Point(202, 345);
            this.txtAdminEventVenue.Name = "txtAdminEventVenue";
            this.txtAdminEventVenue.Size = new System.Drawing.Size(186, 22);
            this.txtAdminEventVenue.TabIndex = 63;
            this.txtAdminEventVenue.TextChanged += new System.EventHandler(this.txtEventVenue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Venue";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAdminEventDate
            // 
            this.txtAdminEventDate.Location = new System.Drawing.Point(202, 390);
            this.txtAdminEventDate.Name = "txtAdminEventDate";
            this.txtAdminEventDate.Size = new System.Drawing.Size(186, 22);
            this.txtAdminEventDate.TabIndex = 61;
            this.txtAdminEventDate.TextChanged += new System.EventHandler(this.txtEventDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Event Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAdminEventName
            // 
            this.txtAdminEventName.Location = new System.Drawing.Point(202, 222);
            this.txtAdminEventName.Name = "txtAdminEventName";
            this.txtAdminEventName.Size = new System.Drawing.Size(186, 22);
            this.txtAdminEventName.TabIndex = 59;
            this.txtAdminEventName.TextChanged += new System.EventHandler(this.txtEventName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Event Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(25, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 55);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "Events Details";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvAdminEventView
            // 
            this.dgvAdminEventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminEventView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvAdminEventView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminEventView.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminEventView.Name = "dgvAdminEventView";
            this.dgvAdminEventView.RowHeadersWidth = 51;
            this.dgvAdminEventView.RowTemplate.Height = 24;
            this.dgvAdminEventView.Size = new System.Drawing.Size(582, 555);
            this.dgvAdminEventView.TabIndex = 0;
            this.dgvAdminEventView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminEventView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AdminEventView";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // AdminEventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 555);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminEventView";
            this.Text = "AdminEventView";
            this.Load += new System.EventHandler(this.AdminEventView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminEventView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAdminEventView;
        private System.Windows.Forms.TextBox txtAdminEventPartnerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminEventID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminEventDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdminPreviousViewEvent;
        private System.Windows.Forms.TextBox txtAdminEventVenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        public System.Windows.Forms.Button btnAdminEventDelete;
        public System.Windows.Forms.Button btnAdminEventUpdate;
        public System.Windows.Forms.Button btnAdminEventView;
    }
}