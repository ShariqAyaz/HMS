using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SHARIQHMS.frmRep
{
    public partial class frmGuestDetails : MetroForm
    {
        public frmGuestDetails()
        {
            InitializeComponent();
        }

        private void frmGuestDetails_Load(object sender, EventArgs e)
        {
            this.dTcheckedGuestlistTableAdapter1.Fill(this.dsCheckedGuestlist.DTcheckedGuestlist);
            this.reportViewer1.RefreshReport();
        }
    }
}
