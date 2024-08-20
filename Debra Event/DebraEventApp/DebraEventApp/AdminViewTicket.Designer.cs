namespace DebraEventApp
{
    partial class AdminViewTicket
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
            this.txtAdminTicketCommision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdminTicketDelete = new System.Windows.Forms.Button();
            this.btnAdminTicketUpdate = new System.Windows.Forms.Button();
            this.txtAdminTicketDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdminPreviousViewTicket = new System.Windows.Forms.Button();
            this.btnAdminTicketView = new System.Windows.Forms.Button();
            this.txtAdminTicketsSold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminTicketPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminTicketEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminTicketID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvAdminTicketView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTicketView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketCommision);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminTicketDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminTicketUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketDate);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminPreviousViewTicket);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdminTicketView);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketsSold);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketEventName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdminTicketID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAdminTicketView);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 664);
            this.splitContainer1.SplitterDistance = 463;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtAdminTicketCommision
            // 
            this.txtAdminTicketCommision.Location = new System.Drawing.Point(213, 375);
            this.txtAdminTicketCommision.Name = "txtAdminTicketCommision";
            this.txtAdminTicketCommision.ReadOnly = true;
            this.txtAdminTicketCommision.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketCommision.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Commision";
            // 
            // btnAdminTicketDelete
            // 
            this.btnAdminTicketDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdminTicketDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminTicketDelete.Location = new System.Drawing.Point(275, 436);
            this.btnAdminTicketDelete.Name = "btnAdminTicketDelete";
            this.btnAdminTicketDelete.Size = new System.Drawing.Size(108, 38);
            this.btnAdminTicketDelete.TabIndex = 67;
            this.btnAdminTicketDelete.Text = "Remove";
            this.btnAdminTicketDelete.UseVisualStyleBackColor = false;
            this.btnAdminTicketDelete.Click += new System.EventHandler(this.btnAdminTicketDelete_Click);
            // 
            // btnAdminTicketUpdate
            // 
            this.btnAdminTicketUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminTicketUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminTicketUpdate.Location = new System.Drawing.Point(170, 436);
            this.btnAdminTicketUpdate.Name = "btnAdminTicketUpdate";
            this.btnAdminTicketUpdate.Size = new System.Drawing.Size(99, 38);
            this.btnAdminTicketUpdate.TabIndex = 66;
            this.btnAdminTicketUpdate.Text = "Update";
            this.btnAdminTicketUpdate.UseVisualStyleBackColor = false;
            this.btnAdminTicketUpdate.Click += new System.EventHandler(this.btnAdminTicketUpdate_Click);
            // 
            // txtAdminTicketDate
            // 
            this.txtAdminTicketDate.Location = new System.Drawing.Point(213, 329);
            this.txtAdminTicketDate.Name = "txtAdminTicketDate";
            this.txtAdminTicketDate.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketDate.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Date";
            // 
            // btnAdminPreviousViewTicket
            // 
            this.btnAdminPreviousViewTicket.BackColor = System.Drawing.Color.White;
            this.btnAdminPreviousViewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPreviousViewTicket.Location = new System.Drawing.Point(12, 623);
            this.btnAdminPreviousViewTicket.Name = "btnAdminPreviousViewTicket";
            this.btnAdminPreviousViewTicket.Size = new System.Drawing.Size(60, 29);
            this.btnAdminPreviousViewTicket.TabIndex = 63;
            this.btnAdminPreviousViewTicket.Text = "Back";
            this.btnAdminPreviousViewTicket.UseVisualStyleBackColor = false;
            this.btnAdminPreviousViewTicket.Click += new System.EventHandler(this.btnAdminPreviousViewTicket_Click);
            // 
            // btnAdminTicketView
            // 
            this.btnAdminTicketView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminTicketView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminTicketView.Location = new System.Drawing.Point(65, 436);
            this.btnAdminTicketView.Name = "btnAdminTicketView";
            this.btnAdminTicketView.Size = new System.Drawing.Size(99, 38);
            this.btnAdminTicketView.TabIndex = 61;
            this.btnAdminTicketView.Text = "View";
            this.btnAdminTicketView.UseVisualStyleBackColor = false;
            // 
            // txtAdminTicketsSold
            // 
            this.txtAdminTicketsSold.Location = new System.Drawing.Point(213, 281);
            this.txtAdminTicketsSold.Name = "txtAdminTicketsSold";
            this.txtAdminTicketsSold.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketsSold.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Is Sold";
            // 
            // txtAdminTicketPrice
            // 
            this.txtAdminTicketPrice.Location = new System.Drawing.Point(213, 237);
            this.txtAdminTicketPrice.Name = "txtAdminTicketPrice";
            this.txtAdminTicketPrice.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketPrice.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Price";
            // 
            // txtAdminTicketEventName
            // 
            this.txtAdminTicketEventName.Location = new System.Drawing.Point(213, 193);
            this.txtAdminTicketEventName.Name = "txtAdminTicketEventName";
            this.txtAdminTicketEventName.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketEventName.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Event Name";
            // 
            // txtAdminTicketID
            // 
            this.txtAdminTicketID.Location = new System.Drawing.Point(213, 146);
            this.txtAdminTicketID.Name = "txtAdminTicketID";
            this.txtAdminTicketID.Size = new System.Drawing.Size(186, 22);
            this.txtAdminTicketID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Ticket ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 57);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "Tickets Details";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvAdminTicketView
            // 
            this.dgvAdminTicketView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminTicketView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvAdminTicketView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminTicketView.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminTicketView.Name = "dgvAdminTicketView";
            this.dgvAdminTicketView.RowHeadersWidth = 51;
            this.dgvAdminTicketView.RowTemplate.Height = 24;
            this.dgvAdminTicketView.Size = new System.Drawing.Size(630, 664);
            this.dgvAdminTicketView.TabIndex = 0;
            this.dgvAdminTicketView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminTicketView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "AdminTicketView";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // AdminViewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 664);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminViewTicket";
            this.Text = "AdminViewTicket";
            this.Load += new System.EventHandler(this.AdminViewTicket_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminTicketView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Button btnAdminTicketDelete;
        public System.Windows.Forms.Button btnAdminTicketUpdate;
        private System.Windows.Forms.TextBox txtAdminTicketDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdminPreviousViewTicket;
        private System.Windows.Forms.TextBox txtAdminTicketsSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminTicketPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminTicketEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminTicketID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnAdminTicketView;
        private System.Windows.Forms.DataGridView dgvAdminTicketView;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox txtAdminTicketCommision;
        private System.Windows.Forms.Label label5;
    }
}