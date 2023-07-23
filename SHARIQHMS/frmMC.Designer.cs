namespace SHARIQHMS
{
    partial class frmMC
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMC));
            this.DTcheckedGuestlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCheckedGuestlist = new SHARIQHMS.ds.dsCheckedGuestlist();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.tileRoomStatus = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tileNewReservation = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.TabControlReporting = new MetroFramework.Controls.MetroTabControl();
            this.tabReportingMonthView = new MetroFramework.Controls.MetroTabPage();
            this.btnLoadmonthview = new MetroFramework.Controls.MetroButton();
            this.lstvSingleDay = new System.Windows.Forms.ListView();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.dsCheckedGuestlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTcheckedGuestlistTableAdapter1 = new SHARIQHMS.ds.dsCheckedGuestlistTableAdapters.DTcheckedGuestlistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DTcheckedGuestlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlist)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.TabControlReporting.SuspendLayout();
            this.tabReportingMonthView.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DTcheckedGuestlistBindingSource
            // 
            this.DTcheckedGuestlistBindingSource.DataMember = "DTcheckedGuestlist";
            this.DTcheckedGuestlistBindingSource.DataSource = this.dsCheckedGuestlist;
            // 
            // dsCheckedGuestlist
            // 
            this.dsCheckedGuestlist.DataSetName = "dsCheckedGuestlist";
            this.dsCheckedGuestlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(1, 56);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1199, 439);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile8);
            this.metroTabPage1.Controls.Add(this.tileRoomStatus);
            this.metroTabPage1.Controls.Add(this.metroTile5);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.tileNewReservation);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1191, 397);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Reservation Management";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.ForeColor = System.Drawing.Color.Black;
            this.metroTile8.Location = new System.Drawing.Point(963, 17);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(234, 216);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile8.TabIndex = 5;
            this.metroTile8.Text = "Guest List";
            this.metroTile8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile8.TileCount = 5;
            this.metroTile8.UseCustomForeColor = true;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // tileRoomStatus
            // 
            this.tileRoomStatus.ActiveControl = null;
            this.tileRoomStatus.ForeColor = System.Drawing.Color.Black;
            this.tileRoomStatus.Location = new System.Drawing.Point(723, 17);
            this.tileRoomStatus.Name = "tileRoomStatus";
            this.tileRoomStatus.Size = new System.Drawing.Size(234, 216);
            this.tileRoomStatus.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileRoomStatus.TabIndex = 4;
            this.tileRoomStatus.Text = "Room Status";
            this.tileRoomStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileRoomStatus.TileCount = 4;
            this.tileRoomStatus.UseCustomForeColor = true;
            this.tileRoomStatus.UseSelectable = true;
            this.tileRoomStatus.Click += new System.EventHandler(this.tileRoomStatus_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.ForeColor = System.Drawing.Color.Black;
            this.metroTile5.Location = new System.Drawing.Point(483, 17);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(234, 216);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile5.TabIndex = 3;
            this.metroTile5.Text = "Customer\r\nManagement";
            this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile5.TileCount = 3;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(243, 17);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(234, 216);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Customer Receiveable";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileCount = 2;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // tileNewReservation
            // 
            this.tileNewReservation.ActiveControl = null;
            this.tileNewReservation.Location = new System.Drawing.Point(3, 17);
            this.tileNewReservation.Name = "tileNewReservation";
            this.tileNewReservation.Size = new System.Drawing.Size(234, 216);
            this.tileNewReservation.Style = MetroFramework.MetroColorStyle.Green;
            this.tileNewReservation.TabIndex = 0;
            this.tileNewReservation.Text = "Manage\r\nReservation / Booking";
            this.tileNewReservation.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileNewReservation.TileCount = 1;
            this.tileNewReservation.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileNewReservation.UseCustomForeColor = true;
            this.tileNewReservation.UseSelectable = true;
            this.tileNewReservation.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTile6);
            this.metroTabPage2.Controls.Add(this.metroTile3);
            this.metroTabPage2.Controls.Add(this.metroTile4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1191, 397);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Hotel Management";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.ForeColor = System.Drawing.Color.Black;
            this.metroTile6.Location = new System.Drawing.Point(483, 17);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(234, 216);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile6.TabIndex = 8;
            this.metroTile6.Text = "Equipment Entry";
            this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile6.TileCount = 3;
            this.metroTile6.UseCustomForeColor = true;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.ForeColor = System.Drawing.Color.Black;
            this.metroTile3.Location = new System.Drawing.Point(243, 17);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(234, 216);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "Equipment Profile";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileCount = 2;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(3, 17);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(234, 216);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "Room Management";
            this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile4.TileCount = 1;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.TabControlReporting);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1191, 397);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Reports && Statistics";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // TabControlReporting
            // 
            this.TabControlReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlReporting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlReporting.Controls.Add(this.tabReportingMonthView);
            this.TabControlReporting.Controls.Add(this.metroTabPage4);
            this.TabControlReporting.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.TabControlReporting.Location = new System.Drawing.Point(0, 0);
            this.TabControlReporting.Multiline = true;
            this.TabControlReporting.Name = "TabControlReporting";
            this.TabControlReporting.SelectedIndex = 0;
            this.TabControlReporting.Size = new System.Drawing.Size(1188, 394);
            this.TabControlReporting.Style = MetroFramework.MetroColorStyle.Green;
            this.TabControlReporting.TabIndex = 2;
            this.TabControlReporting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControlReporting.UseSelectable = true;
            // 
            // tabReportingMonthView
            // 
            this.tabReportingMonthView.Controls.Add(this.btnLoadmonthview);
            this.tabReportingMonthView.Controls.Add(this.lstvSingleDay);
            this.tabReportingMonthView.HorizontalScrollbarBarColor = true;
            this.tabReportingMonthView.HorizontalScrollbarHighlightOnWheel = false;
            this.tabReportingMonthView.HorizontalScrollbarSize = 10;
            this.tabReportingMonthView.Location = new System.Drawing.Point(4, 47);
            this.tabReportingMonthView.Name = "tabReportingMonthView";
            this.tabReportingMonthView.Size = new System.Drawing.Size(1180, 343);
            this.tabReportingMonthView.Style = MetroFramework.MetroColorStyle.Green;
            this.tabReportingMonthView.TabIndex = 0;
            this.tabReportingMonthView.Text = "Month View";
            this.tabReportingMonthView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabReportingMonthView.VerticalScrollbarBarColor = true;
            this.tabReportingMonthView.VerticalScrollbarHighlightOnWheel = false;
            this.tabReportingMonthView.VerticalScrollbarSize = 10;
            // 
            // btnLoadmonthview
            // 
            this.btnLoadmonthview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadmonthview.Highlight = true;
            this.btnLoadmonthview.Location = new System.Drawing.Point(1085, 3);
            this.btnLoadmonthview.Name = "btnLoadmonthview";
            this.btnLoadmonthview.Size = new System.Drawing.Size(92, 23);
            this.btnLoadmonthview.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLoadmonthview.TabIndex = 3;
            this.btnLoadmonthview.Text = "Load";
            this.btnLoadmonthview.UseSelectable = true;
            this.btnLoadmonthview.Click += new System.EventHandler(this.btnLoadmonthview_Click);
            // 
            // lstvSingleDay
            // 
            this.lstvSingleDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvSingleDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvSingleDay.Location = new System.Drawing.Point(2, 2);
            this.lstvSingleDay.Margin = new System.Windows.Forms.Padding(4);
            this.lstvSingleDay.Name = "lstvSingleDay";
            this.lstvSingleDay.Size = new System.Drawing.Size(1176, 339);
            this.lstvSingleDay.TabIndex = 2;
            this.lstvSingleDay.UseCompatibleStateImageBehavior = false;
            this.lstvSingleDay.View = System.Windows.Forms.View.Details;
            this.lstvSingleDay.SelectedIndexChanged += new System.EventHandler(this.lstvSingleDay_SelectedIndexChanged);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.reportViewer1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1180, 343);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "Currently Checked In";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSCheckedGuestList";
            reportDataSource1.Value = this.DTcheckedGuestlistBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SHARIQHMS.rp.internal.repCheckedGuestlist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1178, 341);
            this.reportViewer1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.metroTile2);
            this.tabPage1.Controls.Add(this.metroTile7);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1191, 397);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Administration";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.ForeColor = System.Drawing.Color.Black;
            this.metroTile2.Location = new System.Drawing.Point(243, 17);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(234, 216);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Warning...!\r\nBackup Restore";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileCount = 2;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(3, 17);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(234, 216);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile7.TabIndex = 3;
            this.metroTile7.Text = "Software Backup";
            this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile7.TileCount = 1;
            this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Highlight = true;
            this.btnExit.Location = new System.Drawing.Point(979, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 32);
            this.btnExit.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogout.ForeColor = System.Drawing.Color.Blue;
            this.btnLogout.Highlight = true;
            this.btnLogout.Location = new System.Drawing.Point(856, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 32);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dsCheckedGuestlistBindingSource
            // 
            this.dsCheckedGuestlistBindingSource.DataSource = this.dsCheckedGuestlist;
            this.dsCheckedGuestlistBindingSource.Position = 0;
            // 
            // dTcheckedGuestlistTableAdapter1
            // 
            this.dTcheckedGuestlistTableAdapter1.ClearBeforeFill = true;
            // 
            // frmMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1202, 494);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMC";
            this.Opacity = 0.98D;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Tag = "Management Console";
            this.Text = "Hotel Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMC_FormClosed);
            this.Load += new System.EventHandler(this.frmMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTcheckedGuestlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlist)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.TabControlReporting.ResumeLayout(false);
            this.tabReportingMonthView.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        public MetroFramework.Controls.MetroTile tileNewReservation;
        public MetroFramework.Controls.MetroTile metroTile1;
        public MetroFramework.Controls.MetroTile metroTile5;
        public MetroFramework.Controls.MetroTile metroTile4;
        public MetroFramework.Controls.MetroTile metroTile3;
        public MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Controls.MetroButton btnLogout;
        public MetroFramework.Controls.MetroButton btnExit;
        public MetroFramework.Controls.MetroTabControl TabControlReporting;
        private System.Windows.Forms.ListView lstvSingleDay;
        public MetroFramework.Controls.MetroTabPage tabReportingMonthView;
        private MetroFramework.Controls.MetroButton btnLoadmonthview;
        public MetroFramework.Controls.MetroTile tileRoomStatus;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTcheckedGuestlistBindingSource;
        private ds.dsCheckedGuestlist dsCheckedGuestlist;
        private System.Windows.Forms.BindingSource dsCheckedGuestlistBindingSource;
        private ds.dsCheckedGuestlistTableAdapters.DTcheckedGuestlistTableAdapter dTcheckedGuestlistTableAdapter1;
        public MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroTile metroTile7;
        public MetroFramework.Controls.MetroTile metroTile8;
    }
}