namespace DebraEventApp
{
    partial class SetTicketForm
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
            this.btnTicketUpdate = new System.Windows.Forms.Button();
            this.txtTicketDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreviousSetTicket = new System.Windows.Forms.Button();
            this.btnReleaseTicket = new System.Windows.Forms.Button();
            this.btnTicketCreate = new System.Windows.Forms.Button();
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnTicketUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.txtTicketDate);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviousSetTicket);
            this.splitContainer1.Panel1.Controls.Add(this.btnReleaseTicket);
            this.splitContainer1.Panel1.Controls.Add(this.btnTicketCreate);
            this.splitContainer1.Panel1.Controls.Add(this.txtTicketsSold);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtTicketPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtTicketEventName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTicketID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTicket);
            this.splitContainer1.Size = new System.Drawing.Size(1466, 646);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTicketUpdate
            // 
            this.btnTicketUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTicketUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketUpdate.Location = new System.Drawing.Point(129, 422);
            this.btnTicketUpdate.Name = "btnTicketUpdate";
            this.btnTicketUpdate.Size = new System.Drawing.Size(150, 43);
            this.btnTicketUpdate.TabIndex = 52;
            this.btnTicketUpdate.Text = "Update Ticket";
            this.btnTicketUpdate.UseVisualStyleBackColor = false;
            this.btnTicketUpdate.Click += new System.EventHandler(this.btnTicketUpdate_Click_1);
            // 
            // txtTicketDate
            // 
            this.txtTicketDate.Location = new System.Drawing.Point(204, 296);
            this.txtTicketDate.Name = "txtTicketDate";
            this.txtTicketDate.Size = new System.Drawing.Size(186, 22);
            this.txtTicketDate.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Date";
            // 
            // btnPreviousSetTicket
            // 
            this.btnPreviousSetTicket.BackColor = System.Drawing.Color.White;
            this.btnPreviousSetTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSetTicket.Location = new System.Drawing.Point(19, 596);
            this.btnPreviousSetTicket.Name = "btnPreviousSetTicket";
            this.btnPreviousSetTicket.Size = new System.Drawing.Size(82, 29);
            this.btnPreviousSetTicket.TabIndex = 49;
            this.btnPreviousSetTicket.Text = "Back";
            this.btnPreviousSetTicket.UseVisualStyleBackColor = false;
            this.btnPreviousSetTicket.Click += new System.EventHandler(this.btnPreviousSetTicket_Click);
            // 
            // btnReleaseTicket
            // 
            this.btnReleaseTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReleaseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleaseTicket.Location = new System.Drawing.Point(129, 496);
            this.btnReleaseTicket.Name = "btnReleaseTicket";
            this.btnReleaseTicket.Size = new System.Drawing.Size(150, 44);
            this.btnReleaseTicket.TabIndex = 48;
            this.btnReleaseTicket.Text = "Release Ticket";
            this.btnReleaseTicket.UseVisualStyleBackColor = false;
            this.btnReleaseTicket.Click += new System.EventHandler(this.btnReleaseTicket_Click);
            // 
            // btnTicketCreate
            // 
            this.btnTicketCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTicketCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketCreate.Location = new System.Drawing.Point(129, 353);
            this.btnTicketCreate.Name = "btnTicketCreate";
            this.btnTicketCreate.Size = new System.Drawing.Size(150, 43);
            this.btnTicketCreate.TabIndex = 45;
            this.btnTicketCreate.Text = "Add Ticket";
            this.btnTicketCreate.UseVisualStyleBackColor = false;
            this.btnTicketCreate.Click += new System.EventHandler(this.btnTicketCreate_Click);
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Location = new System.Drawing.Point(204, 248);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(186, 22);
            this.txtTicketsSold.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "is Sold";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(204, 204);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(186, 22);
            this.txtTicketPrice.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Price";
            // 
            // txtTicketEventName
            // 
            this.txtTicketEventName.Location = new System.Drawing.Point(204, 160);
            this.txtTicketEventName.Name = "txtTicketEventName";
            this.txtTicketEventName.Size = new System.Drawing.Size(186, 22);
            this.txtTicketEventName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Event Name";
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(204, 113);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(186, 22);
            this.txtTicketID.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ticket ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(45, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 55);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Add Ticket";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTicket.Location = new System.Drawing.Point(0, 0);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(1028, 646);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ticket View";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // SetTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 646);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SetTicketForm";
            this.Text = "SetTicketForm";
            this.Load += new System.EventHandler(this.SetTicketForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReleaseTicket;
        private System.Windows.Forms.Button btnPreviousSetTicket;
        private System.Windows.Forms.TextBox txtTicketDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnTicketCreate;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        public System.Windows.Forms.Button btnTicketUpdate;
    }
}