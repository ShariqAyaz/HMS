namespace SHARIQHMS.Masters.Rooms
{
    partial class frmRoomEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxcat = new System.Windows.Forms.ComboBox();
            this.cboxrlink = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboxRoomprofile = new System.Windows.Forms.ComboBox();
            this.cboxRoomlocation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxRoomfloor = new System.Windows.Forms.ComboBox();
            this.cboxRoomname = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxcat);
            this.groupBox1.Controls.Add(this.cboxrlink);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboxRoomprofile);
            this.groupBox1.Controls.Add(this.cboxRoomlocation);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboxRoomfloor);
            this.groupBox1.Controls.Add(this.cboxRoomname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 234);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info:";
            // 
            // cboxcat
            // 
            this.cboxcat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxcat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxcat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxcat.FormattingEnabled = true;
            this.cboxcat.Location = new System.Drawing.Point(154, 180);
            this.cboxcat.Name = "cboxcat";
            this.cboxcat.Size = new System.Drawing.Size(142, 25);
            this.cboxcat.TabIndex = 17;
            this.cboxcat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // cboxrlink
            // 
            this.cboxrlink.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxrlink.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxrlink.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxrlink.FormattingEnabled = true;
            this.cboxrlink.Location = new System.Drawing.Point(154, 149);
            this.cboxrlink.Name = "cboxrlink";
            this.cboxrlink.Size = new System.Drawing.Size(142, 25);
            this.cboxrlink.TabIndex = 16;
            this.cboxrlink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Restaurant Profile: *";
            // 
            // cboxRoomprofile
            // 
            this.cboxRoomprofile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRoomprofile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRoomprofile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxRoomprofile.FormattingEnabled = true;
            this.cboxRoomprofile.Location = new System.Drawing.Point(154, 118);
            this.cboxRoomprofile.Name = "cboxRoomprofile";
            this.cboxRoomprofile.Size = new System.Drawing.Size(142, 25);
            this.cboxRoomprofile.TabIndex = 14;
            this.cboxRoomprofile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // cboxRoomlocation
            // 
            this.cboxRoomlocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRoomlocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRoomlocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxRoomlocation.FormattingEnabled = true;
            this.cboxRoomlocation.Location = new System.Drawing.Point(154, 56);
            this.cboxRoomlocation.Name = "cboxRoomlocation";
            this.cboxRoomlocation.Size = new System.Drawing.Size(142, 25);
            this.cboxRoomlocation.TabIndex = 13;
            this.cboxRoomlocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Location: *";
            // 
            // cboxRoomfloor
            // 
            this.cboxRoomfloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRoomfloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRoomfloor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxRoomfloor.FormattingEnabled = true;
            this.cboxRoomfloor.Location = new System.Drawing.Point(154, 87);
            this.cboxRoomfloor.Name = "cboxRoomfloor";
            this.cboxRoomfloor.Size = new System.Drawing.Size(142, 25);
            this.cboxRoomfloor.TabIndex = 11;
            this.cboxRoomfloor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // cboxRoomname
            // 
            this.cboxRoomname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxRoomname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxRoomname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboxRoomname.FormattingEnabled = true;
            this.cboxRoomname.Location = new System.Drawing.Point(154, 25);
            this.cboxRoomname.Name = "cboxRoomname";
            this.cboxRoomname.Size = new System.Drawing.Size(142, 25);
            this.cboxRoomname.TabIndex = 10;
            this.cboxRoomname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxRoomname_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Category: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Name/No: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipment Profile: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Floor: *";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(186, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel && Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(54, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmRoomEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 440);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRoomEntry";
            this.Text = "frmRoomEntry";
            this.Load += new System.EventHandler(this.frmRoomEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboxRoomname;
        private System.Windows.Forms.ComboBox cboxRoomfloor;
        private System.Windows.Forms.ComboBox cboxRoomprofile;
        private System.Windows.Forms.ComboBox cboxRoomlocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxrlink;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboxcat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}