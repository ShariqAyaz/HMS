namespace SHARIQHMS.Masters.Attributes
{
    partial class frmAttributeEntry
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btniDel = new System.Windows.Forms.Button();
            this.btniAdd = new System.Windows.Forms.Button();
            this.cboxattrname = new System.Windows.Forms.ComboBox();
            this.cboxattrcat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboxmen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Attribute Entry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SHARIQHMS.Properties.Resources.acquisition;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(174, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxmen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.btniDel);
            this.groupBox3.Controls.Add(this.btniAdd);
            this.groupBox3.Controls.Add(this.cboxattrname);
            this.groupBox3.Controls.Add(this.cboxattrcat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(11, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 229);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attribute Entry";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(19, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 98);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Attribute Name";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Attribute Catagory";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 177;
            // 
            // btniDel
            // 
            this.btniDel.Enabled = false;
            this.btniDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniDel.Location = new System.Drawing.Point(370, 56);
            this.btniDel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btniDel.Name = "btniDel";
            this.btniDel.Size = new System.Drawing.Size(50, 25);
            this.btniDel.TabIndex = 11;
            this.btniDel.Text = "Delete";
            this.btniDel.UseVisualStyleBackColor = true;
            // 
            // btniAdd
            // 
            this.btniAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniAdd.Location = new System.Drawing.Point(370, 31);
            this.btniAdd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btniAdd.Name = "btniAdd";
            this.btniAdd.Size = new System.Drawing.Size(50, 25);
            this.btniAdd.TabIndex = 10;
            this.btniAdd.Text = "Add ";
            this.btniAdd.UseVisualStyleBackColor = true;
            this.btniAdd.Click += new System.EventHandler(this.btniAdd_Click);
            // 
            // cboxattrname
            // 
            this.cboxattrname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxattrname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxattrname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxattrname.FormattingEnabled = true;
            this.cboxattrname.Location = new System.Drawing.Point(164, 28);
            this.cboxattrname.Name = "cboxattrname";
            this.cboxattrname.Size = new System.Drawing.Size(149, 25);
            this.cboxattrname.TabIndex = 0;
            this.cboxattrname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxattrname_KeyDown);
            // 
            // cboxattrcat
            // 
            this.cboxattrcat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxattrcat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxattrcat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxattrcat.FormattingEnabled = true;
            this.cboxattrcat.Location = new System.Drawing.Point(163, 59);
            this.cboxattrcat.Name = "cboxattrcat";
            this.cboxattrcat.Size = new System.Drawing.Size(150, 25);
            this.cboxattrcat.TabIndex = 2;
            this.cboxattrcat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxattrname_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Attribute Name: *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Attribute Catagory: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mandatory: *";
            // 
            // cboxmen
            // 
            this.cboxmen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxmen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxmen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxmen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxmen.FormattingEnabled = true;
            this.cboxmen.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cboxmen.Location = new System.Drawing.Point(163, 90);
            this.cboxmen.Name = "cboxmen";
            this.cboxmen.Size = new System.Drawing.Size(150, 25);
            this.cboxmen.TabIndex = 14;
            // 
            // frmAttributeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(462, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttributeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAttributeEntry";
            this.Load += new System.EventHandler(this.frmAttributeEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxattrname;
        private System.Windows.Forms.ComboBox cboxattrcat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btniDel;
        private System.Windows.Forms.Button btniAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cboxmen;
        private System.Windows.Forms.Label label2;
    }
}