namespace DebraEventApp
{
    partial class CreateEventForm
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
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.txtEventPartnerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreviousNewEvent = new System.Windows.Forms.Button();
            this.btnEventCreate = new System.Windows.Forms.Button();
            this.txtEventVenue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnEventDelete);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventPartnerID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviousNewEvent);
            this.splitContainer1.Panel1.Controls.Add(this.btnEventCreate);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventVenue);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtEventName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEvent);
            this.splitContainer1.Size = new System.Drawing.Size(1451, 551);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEventDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDelete.Location = new System.Drawing.Point(261, 427);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(137, 35);
            this.btnEventDelete.TabIndex = 57;
            this.btnEventDelete.Text = "Delete Event";
            this.btnEventDelete.UseVisualStyleBackColor = false;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click_1);
            // 
            // txtEventPartnerID
            // 
            this.txtEventPartnerID.Location = new System.Drawing.Point(233, 125);
            this.txtEventPartnerID.Name = "txtEventPartnerID";
            this.txtEventPartnerID.Size = new System.Drawing.Size(186, 22);
            this.txtEventPartnerID.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Partner ID";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(233, 163);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(186, 22);
            this.txtEventID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Event ID";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(233, 245);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(186, 55);
            this.txtEventDescription.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Description";
            // 
            // btnPreviousNewEvent
            // 
            this.btnPreviousNewEvent.BackColor = System.Drawing.Color.White;
            this.btnPreviousNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousNewEvent.Location = new System.Drawing.Point(12, 510);
            this.btnPreviousNewEvent.Name = "btnPreviousNewEvent";
            this.btnPreviousNewEvent.Size = new System.Drawing.Size(70, 29);
            this.btnPreviousNewEvent.TabIndex = 50;
            this.btnPreviousNewEvent.Text = "Back";
            this.btnPreviousNewEvent.UseVisualStyleBackColor = false;
            this.btnPreviousNewEvent.Click += new System.EventHandler(this.btnPreviousNewEvent_Click);
            // 
            // btnEventCreate
            // 
            this.btnEventCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEventCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventCreate.Location = new System.Drawing.Point(93, 427);
            this.btnEventCreate.Name = "btnEventCreate";
            this.btnEventCreate.Size = new System.Drawing.Size(142, 35);
            this.btnEventCreate.TabIndex = 29;
            this.btnEventCreate.Text = "Create Event";
            this.btnEventCreate.UseVisualStyleBackColor = false;
            this.btnEventCreate.Click += new System.EventHandler(this.btnEventCreate_Click);
            // 
            // txtEventVenue
            // 
            this.txtEventVenue.Location = new System.Drawing.Point(233, 323);
            this.txtEventVenue.Name = "txtEventVenue";
            this.txtEventVenue.Size = new System.Drawing.Size(186, 22);
            this.txtEventVenue.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Venue";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(233, 368);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(186, 22);
            this.txtEventDate.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Event Date";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(233, 200);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(186, 22);
            this.txtEventName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Event Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 61);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Create New Event";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEvent
            // 
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvent.Location = new System.Drawing.Point(0, 0);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.RowHeadersWidth = 51;
            this.dgvEvent.RowTemplate.Height = 24;
            this.dgvEvent.Size = new System.Drawing.Size(953, 551);
            this.dgvEvent.TabIndex = 0;
            this.dgvEvent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Events";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1451, 551);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateEventForm";
            this.Text = "CreateEventForm";
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.TextBox txtEventPartnerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPreviousNewEvent;
        private System.Windows.Forms.TextBox txtEventVenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEventCreate;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}