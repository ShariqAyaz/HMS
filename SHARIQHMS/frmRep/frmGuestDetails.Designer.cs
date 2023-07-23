namespace SHARIQHMS.frmRep
{
    partial class frmGuestDetails
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCheckedGuestlist = new SHARIQHMS.ds.dsCheckedGuestlist();
            this.dsCheckedGuestlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTcheckedGuestlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTcheckedGuestlistTableAdapter1 = new SHARIQHMS.ds.dsCheckedGuestlistTableAdapters.DTcheckedGuestlistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTcheckedGuestlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 24);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 29;
            reportDataSource2.Name = "dsDetailsGuestList";
            reportDataSource2.Value = this.DTcheckedGuestlistBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SHARIQHMS.rp.internal.repGuestDetailsList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(725, 351);
            this.reportViewer1.TabIndex = 1;
            // 
            // dsCheckedGuestlist
            // 
            this.dsCheckedGuestlist.DataSetName = "dsCheckedGuestlist";
            this.dsCheckedGuestlist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCheckedGuestlistBindingSource
            // 
            this.dsCheckedGuestlistBindingSource.DataSource = this.dsCheckedGuestlist;
            this.dsCheckedGuestlistBindingSource.Position = 0;
            // 
            // DTcheckedGuestlistBindingSource
            // 
            this.DTcheckedGuestlistBindingSource.DataMember = "DTcheckedGuestlist";
            this.DTcheckedGuestlistBindingSource.DataSource = this.dsCheckedGuestlist;
            // 
            // dTcheckedGuestlistTableAdapter1
            // 
            this.dTcheckedGuestlistTableAdapter1.ClearBeforeFill = true;
            // 
            // frmGuestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 441);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGuestDetails";
            this.Text = "Guest List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGuestDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCheckedGuestlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTcheckedGuestlistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTcheckedGuestlistBindingSource;
        private ds.dsCheckedGuestlist dsCheckedGuestlist;
        private System.Windows.Forms.BindingSource dsCheckedGuestlistBindingSource;
        private ds.dsCheckedGuestlistTableAdapters.DTcheckedGuestlistTableAdapter dTcheckedGuestlistTableAdapter1;
    }
}