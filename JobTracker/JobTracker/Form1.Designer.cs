namespace JobTracker
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tracker = new System.Windows.Forms.GroupBox();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.lblcompany = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dtDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.Tracker.SuspendLayout();
            this.Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tracker
            // 
            this.Tracker.BackColor = System.Drawing.Color.White;
            this.Tracker.Controls.Add(this.dateTimePicker1);
            this.Tracker.Controls.Add(this.dtDataGridView);
            this.Tracker.Controls.Add(this.txtsearch);
            this.Tracker.Controls.Add(this.txtdate);
            this.Tracker.Controls.Add(this.txtposition);
            this.Tracker.Controls.Add(this.txtcompany);
            this.Tracker.Controls.Add(this.lblsearch);
            this.Tracker.Controls.Add(this.lbldate);
            this.Tracker.Controls.Add(this.lblposition);
            this.Tracker.Controls.Add(this.lblcompany);
            this.Tracker.Location = new System.Drawing.Point(5, 23);
            this.Tracker.Name = "Tracker";
            this.Tracker.Size = new System.Drawing.Size(788, 692);
            this.Tracker.TabIndex = 0;
            this.Tracker.TabStop = false;
            this.Tracker.Text = "groupBox1";
            // 
            // Operations
            // 
            this.Operations.BackColor = System.Drawing.Color.SteelBlue;
            this.Operations.Controls.Add(this.btnexcel);
            this.Operations.Controls.Add(this.btndelete);
            this.Operations.Controls.Add(this.btnupdate);
            this.Operations.Controls.Add(this.btnsave);
            this.Operations.Location = new System.Drawing.Point(799, 33);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(313, 682);
            this.Operations.TabIndex = 1;
            this.Operations.TabStop = false;
            this.Operations.Text = "groupBox1";
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblcompany.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompany.Location = new System.Drawing.Point(6, 43);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(175, 25);
            this.lblcompany.TabIndex = 0;
            this.lblcompany.Text = "Company Name:";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblposition.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.Location = new System.Drawing.Point(7, 118);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(143, 20);
            this.lblposition.TabIndex = 1;
            this.lblposition.Text = "Position Applied:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(7, 187);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(115, 20);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date Applied:";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblsearch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(6, 297);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(208, 20);
            this.lblsearch.TabIndex = 3;
            this.lblsearch.Text = "Search by Company Name:";
            // 
            // txtcompany
            // 
            this.txtcompany.Location = new System.Drawing.Point(197, 31);
            this.txtcompany.Multiline = true;
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(317, 37);
            this.txtcompany.TabIndex = 4;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(197, 118);
            this.txtposition.Multiline = true;
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(307, 37);
            this.txtposition.TabIndex = 5;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(197, 187);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(294, 37);
            this.txtdate.TabIndex = 6;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(233, 280);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(370, 37);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dtDataGridView
            // 
            this.dtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDataGridView.Location = new System.Drawing.Point(0, 376);
            this.dtDataGridView.Name = "dtDataGridView";
            this.dtDataGridView.RowHeadersWidth = 51;
            this.dtDataGridView.RowTemplate.Height = 24;
            this.dtDataGridView.Size = new System.Drawing.Size(716, 310);
            this.dtDataGridView.TabIndex = 8;
            this.dtDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDataGridView_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 348);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(19, 78);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(253, 67);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(19, 216);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(253, 67);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(19, 353);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(253, 67);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Location = new System.Drawing.Point(19, 500);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(253, 67);
            this.btnexcel.TabIndex = 3;
            this.btnexcel.Text = "Export in Excel";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 727);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.Tracker);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tracker.ResumeLayout(false);
            this.Tracker.PerformLayout();
            this.Operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Tracker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtDataGridView;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lblcompany;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
    }
}

