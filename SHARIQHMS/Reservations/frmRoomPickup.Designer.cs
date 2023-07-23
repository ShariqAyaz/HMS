namespace SHARIQHMS.Reservations
{
    partial class frmRoomPickup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomPickup));
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.pnlGinfo = new MetroFramework.Controls.MetroPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbaddress = new MetroFramework.Controls.MetroTextBox();
            this.lblnodays = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chkboxAll = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxrno = new MetroFramework.Controls.MetroComboBox();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.txtbRate = new MetroFramework.Controls.MetroTextBox();
            this.pnlRinfo = new MetroFramework.Controls.MetroPanel();
            this.lstvRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label17 = new System.Windows.Forms.Label();
            this.cboxrefno = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbphone = new MetroFramework.Controls.MetroTextBox();
            this.cboxCNIC = new System.Windows.Forms.ComboBox();
            this.txtbfname = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxaction = new MetroFramework.Controls.MetroComboBox();
            this.pnlGinfo.SuspendLayout();
            this.pnlRinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(480, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(583, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // pnlGinfo
            // 
            this.pnlGinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pnlGinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlGinfo.Controls.Add(this.label10);
            this.pnlGinfo.Controls.Add(this.label9);
            this.pnlGinfo.Controls.Add(this.txtbaddress);
            this.pnlGinfo.Controls.Add(this.lblnodays);
            this.pnlGinfo.Controls.Add(this.label26);
            this.pnlGinfo.Controls.Add(this.chkboxAll);
            this.pnlGinfo.Controls.Add(this.label2);
            this.pnlGinfo.Controls.Add(this.cboxrno);
            this.pnlGinfo.Controls.Add(this.dtpCheckout);
            this.pnlGinfo.Controls.Add(this.dtpCheckin);
            this.pnlGinfo.Controls.Add(this.txtbRate);
            this.pnlGinfo.Controls.Add(this.pnlRinfo);
            this.pnlGinfo.Controls.Add(this.cboxrefno);
            this.pnlGinfo.Controls.Add(this.label8);
            this.pnlGinfo.Controls.Add(this.label12);
            this.pnlGinfo.Controls.Add(this.label7);
            this.pnlGinfo.Controls.Add(this.label6);
            this.pnlGinfo.Controls.Add(this.txtbphone);
            this.pnlGinfo.Controls.Add(this.cboxCNIC);
            this.pnlGinfo.Controls.Add(this.txtbfname);
            this.pnlGinfo.Controls.Add(this.label5);
            this.pnlGinfo.Controls.Add(this.label4);
            this.pnlGinfo.Controls.Add(this.label3);
            this.pnlGinfo.Controls.Add(this.label1);
            this.pnlGinfo.Controls.Add(this.cboxaction);
            this.pnlGinfo.HorizontalScrollbarBarColor = true;
            this.pnlGinfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGinfo.HorizontalScrollbarSize = 10;
            this.pnlGinfo.Location = new System.Drawing.Point(23, 63);
            this.pnlGinfo.Name = "pnlGinfo";
            this.pnlGinfo.Size = new System.Drawing.Size(657, 284);
            this.pnlGinfo.Style = MetroFramework.MetroColorStyle.Silver;
            this.pnlGinfo.TabIndex = 7;
            this.pnlGinfo.UseCustomBackColor = true;
            this.pnlGinfo.UseCustomForeColor = true;
            this.pnlGinfo.UseStyleColors = true;
            this.pnlGinfo.VerticalScrollbarBarColor = true;
            this.pnlGinfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGinfo.VerticalScrollbarSize = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(208, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 101;
            this.label10.Text = "Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(8, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 100;
            this.label9.Text = "Address:";
            // 
            // txtbaddress
            // 
            // 
            // 
            // 
            this.txtbaddress.CustomButton.Image = null;
            this.txtbaddress.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.txtbaddress.CustomButton.Name = "";
            this.txtbaddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbaddress.CustomButton.TabIndex = 1;
            this.txtbaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbaddress.CustomButton.UseSelectable = true;
            this.txtbaddress.CustomButton.Visible = false;
            this.txtbaddress.Lines = new string[0];
            this.txtbaddress.Location = new System.Drawing.Point(71, 246);
            this.txtbaddress.MaxLength = 32767;
            this.txtbaddress.Name = "txtbaddress";
            this.txtbaddress.PasswordChar = '\0';
            this.txtbaddress.PromptText = "Address";
            this.txtbaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbaddress.SelectedText = "";
            this.txtbaddress.SelectionLength = 0;
            this.txtbaddress.SelectionStart = 0;
            this.txtbaddress.ShortcutsEnabled = true;
            this.txtbaddress.Size = new System.Drawing.Size(310, 23);
            this.txtbaddress.TabIndex = 8;
            this.txtbaddress.UseSelectable = true;
            this.txtbaddress.WaterMark = "Address";
            this.txtbaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblnodays
            // 
            this.lblnodays.AutoSize = true;
            this.lblnodays.BackColor = System.Drawing.Color.Transparent;
            this.lblnodays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnodays.Font = new System.Drawing.Font("Eras Bold ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnodays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblnodays.Location = new System.Drawing.Point(473, 251);
            this.lblnodays.Name = "lblnodays";
            this.lblnodays.Size = new System.Drawing.Size(2, 18);
            this.lblnodays.TabIndex = 99;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(393, 247);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 16);
            this.label26.TabIndex = 98;
            this.label26.Text = "Total Days:";
            // 
            // chkboxAll
            // 
            this.chkboxAll.AutoSize = true;
            this.chkboxAll.BackColor = System.Drawing.Color.Transparent;
            this.chkboxAll.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkboxAll.Location = new System.Drawing.Point(590, 246);
            this.chkboxAll.Name = "chkboxAll";
            this.chkboxAll.Size = new System.Drawing.Size(48, 25);
            this.chkboxAll.TabIndex = 97;
            this.chkboxAll.Text = "All";
            this.chkboxAll.UseSelectable = true;
            this.chkboxAll.CheckedChanged += new System.EventHandler(this.chkboxAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(452, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Room#";
            // 
            // cboxrno
            // 
            this.cboxrno.FormattingEnabled = true;
            this.cboxrno.ItemHeight = 23;
            this.cboxrno.Location = new System.Drawing.Point(510, 21);
            this.cboxrno.Name = "cboxrno";
            this.cboxrno.PromptText = "Room#";
            this.cboxrno.Size = new System.Drawing.Size(131, 29);
            this.cboxrno.TabIndex = 95;
            this.cboxrno.UseSelectable = true;
            this.cboxrno.SelectedIndexChanged += new System.EventHandler(this.cboxrno_SelectedIndexChanged);
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Enabled = false;
            this.dtpCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckout.Location = new System.Drawing.Point(208, 110);
            this.dtpCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckout.MaxDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.dtpCheckout.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(173, 21);
            this.dtpCheckout.TabIndex = 94;
            this.dtpCheckout.Value = new System.DateTime(2016, 11, 24, 7, 8, 0, 0);
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Enabled = false;
            this.dtpCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckin.Location = new System.Drawing.Point(208, 56);
            this.dtpCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCheckin.MaxDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.dtpCheckin.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(173, 21);
            this.dtpCheckin.TabIndex = 93;
            this.dtpCheckin.Value = new System.DateTime(2016, 11, 24, 7, 8, 0, 0);
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // txtbRate
            // 
            this.txtbRate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtbRate.CustomButton.Image = null;
            this.txtbRate.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtbRate.CustomButton.Name = "";
            this.txtbRate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtbRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbRate.CustomButton.TabIndex = 1;
            this.txtbRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbRate.CustomButton.UseSelectable = true;
            this.txtbRate.CustomButton.Visible = false;
            this.txtbRate.DisplayIcon = true;
            this.txtbRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbRate.Icon = ((System.Drawing.Image)(resources.GetObject("txtbRate.Icon")));
            this.txtbRate.Lines = new string[0];
            this.txtbRate.Location = new System.Drawing.Point(208, 206);
            this.txtbRate.MaxLength = 32767;
            this.txtbRate.Name = "txtbRate";
            this.txtbRate.PasswordChar = '\0';
            this.txtbRate.PromptText = "Rate (Rs)";
            this.txtbRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbRate.SelectedText = "";
            this.txtbRate.SelectionLength = 0;
            this.txtbRate.SelectionStart = 0;
            this.txtbRate.ShortcutsEnabled = true;
            this.txtbRate.Size = new System.Drawing.Size(173, 29);
            this.txtbRate.Style = MetroFramework.MetroColorStyle.White;
            this.txtbRate.TabIndex = 92;
            this.txtbRate.UseCustomBackColor = true;
            this.txtbRate.UseSelectable = true;
            this.txtbRate.WaterMark = "Rate (Rs)";
            this.txtbRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbRate.Click += new System.EventHandler(this.txtbRate_Click);
            this.txtbRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRate_KeyPress);
            // 
            // pnlRinfo
            // 
            this.pnlRinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pnlRinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRinfo.Controls.Add(this.lstvRoom);
            this.pnlRinfo.Controls.Add(this.label17);
            this.pnlRinfo.HorizontalScrollbarBarColor = true;
            this.pnlRinfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRinfo.HorizontalScrollbarSize = 10;
            this.pnlRinfo.Location = new System.Drawing.Point(390, 56);
            this.pnlRinfo.Name = "pnlRinfo";
            this.pnlRinfo.Size = new System.Drawing.Size(251, 184);
            this.pnlRinfo.Style = MetroFramework.MetroColorStyle.Silver;
            this.pnlRinfo.TabIndex = 48;
            this.pnlRinfo.UseCustomBackColor = true;
            this.pnlRinfo.UseCustomForeColor = true;
            this.pnlRinfo.UseStyleColors = true;
            this.pnlRinfo.VerticalScrollbarBarColor = true;
            this.pnlRinfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRinfo.VerticalScrollbarSize = 10;
            // 
            // lstvRoom
            // 
            this.lstvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvRoom.CheckBoxes = true;
            this.lstvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader13});
            this.lstvRoom.FullRowSelect = true;
            this.lstvRoom.Location = new System.Drawing.Point(6, 21);
            this.lstvRoom.Name = "lstvRoom";
            this.lstvRoom.Size = new System.Drawing.Size(242, 159);
            this.lstvRoom.TabIndex = 80;
            this.lstvRoom.UseCompatibleStateImageBehavior = false;
            this.lstvRoom.View = System.Windows.Forms.View.Details;
            this.lstvRoom.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvRoom_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Room";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 55;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Room Status";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 85;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Room && Guest Information";
            // 
            // cboxrefno
            // 
            this.cboxrefno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxrefno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxrefno.FormattingEnabled = true;
            this.cboxrefno.Location = new System.Drawing.Point(11, 49);
            this.cboxrefno.Name = "cboxrefno";
            this.cboxrefno.Size = new System.Drawing.Size(173, 28);
            this.cboxrefno.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(8, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Booking / Reservation Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Eras Demi ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(8, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 89;
            this.label12.Text = "CNIC / Passport#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 88;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "First && Last Name";
            // 
            // txtbphone
            // 
            this.txtbphone.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtbphone.CustomButton.Image = null;
            this.txtbphone.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtbphone.CustomButton.Name = "";
            this.txtbphone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtbphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbphone.CustomButton.TabIndex = 1;
            this.txtbphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbphone.CustomButton.UseSelectable = true;
            this.txtbphone.CustomButton.Visible = false;
            this.txtbphone.DisplayIcon = true;
            this.txtbphone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbphone.Icon = ((System.Drawing.Image)(resources.GetObject("txtbphone.Icon")));
            this.txtbphone.Lines = new string[0];
            this.txtbphone.Location = new System.Drawing.Point(11, 154);
            this.txtbphone.MaxLength = 32767;
            this.txtbphone.Name = "txtbphone";
            this.txtbphone.PasswordChar = '\0';
            this.txtbphone.PromptText = "Phone No";
            this.txtbphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbphone.SelectedText = "";
            this.txtbphone.SelectionLength = 0;
            this.txtbphone.SelectionStart = 0;
            this.txtbphone.ShortcutsEnabled = true;
            this.txtbphone.Size = new System.Drawing.Size(173, 29);
            this.txtbphone.Style = MetroFramework.MetroColorStyle.White;
            this.txtbphone.TabIndex = 86;
            this.txtbphone.UseCustomBackColor = true;
            this.txtbphone.UseSelectable = true;
            this.txtbphone.WaterMark = "Phone No";
            this.txtbphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboxCNIC
            // 
            this.cboxCNIC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxCNIC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCNIC.FormattingEnabled = true;
            this.cboxCNIC.Location = new System.Drawing.Point(11, 206);
            this.cboxCNIC.Name = "cboxCNIC";
            this.cboxCNIC.Size = new System.Drawing.Size(173, 28);
            this.cboxCNIC.TabIndex = 85;
            // 
            // txtbfname
            // 
            this.txtbfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbfname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtbfname.CustomButton.Image = null;
            this.txtbfname.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtbfname.CustomButton.Name = "";
            this.txtbfname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtbfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbfname.CustomButton.TabIndex = 1;
            this.txtbfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbfname.CustomButton.UseSelectable = true;
            this.txtbfname.CustomButton.Visible = false;
            this.txtbfname.DisplayIcon = true;
            this.txtbfname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbfname.Icon = ((System.Drawing.Image)(resources.GetObject("txtbfname.Icon")));
            this.txtbfname.Lines = new string[0];
            this.txtbfname.Location = new System.Drawing.Point(11, 103);
            this.txtbfname.MaxLength = 32767;
            this.txtbfname.Name = "txtbfname";
            this.txtbfname.PasswordChar = '\0';
            this.txtbfname.PromptText = "First";
            this.txtbfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbfname.SelectedText = "";
            this.txtbfname.SelectionLength = 0;
            this.txtbfname.SelectionStart = 0;
            this.txtbfname.ShortcutsEnabled = true;
            this.txtbfname.Size = new System.Drawing.Size(173, 29);
            this.txtbfname.Style = MetroFramework.MetroColorStyle.White;
            this.txtbfname.TabIndex = 84;
            this.txtbfname.UseCustomBackColor = true;
            this.txtbfname.UseSelectable = true;
            this.txtbfname.WaterMark = "First";
            this.txtbfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbfname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(205, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Check Out [date]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(205, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Check In [date]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(208, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rooms Selection";
            // 
            // cboxaction
            // 
            this.cboxaction.Enabled = false;
            this.cboxaction.FormattingEnabled = true;
            this.cboxaction.ItemHeight = 23;
            this.cboxaction.Items.AddRange(new object[] {
            "Reservation",
            "Check In",
            "Check Out"});
            this.cboxaction.Location = new System.Drawing.Point(208, 154);
            this.cboxaction.Name = "cboxaction";
            this.cboxaction.PromptText = "Status && Action";
            this.cboxaction.Size = new System.Drawing.Size(176, 29);
            this.cboxaction.TabIndex = 30;
            this.cboxaction.UseSelectable = true;
            // 
            // frmRoomPickup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.pnlGinfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmRoomPickup";
            this.Text = "frmRoomPickup";
            this.Load += new System.EventHandler(this.frmRoomPickup_Load);
            this.pnlGinfo.ResumeLayout(false);
            this.pnlGinfo.PerformLayout();
            this.pnlRinfo.ResumeLayout(false);
            this.pnlRinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroPanel pnlGinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroComboBox cboxaction;
        public MetroFramework.Controls.MetroTextBox txtbphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxrefno;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroPanel pnlRinfo;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.ListView lstvRoom;
        public System.Windows.Forms.ComboBox cboxCNIC;
        public MetroFramework.Controls.MetroTextBox txtbfname;
        public MetroFramework.Controls.MetroTextBox txtbRate;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        public MetroFramework.Controls.MetroComboBox cboxrno;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox chkboxAll;
        private System.Windows.Forms.Label lblnodays;
        private System.Windows.Forms.Label label26;
        private MetroFramework.Controls.MetroTextBox txtbaddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}