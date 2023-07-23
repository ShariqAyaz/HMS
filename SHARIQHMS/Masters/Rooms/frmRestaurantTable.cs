using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SHARIQHMS.Masters.Rooms
{
   
    public partial class frmRestaurantTable : Form
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conloadc = null;
        SqlCommand cmdloadc = null;
        SqlDataReader rdrloadc = null;
        //
        #endregion Database string and connections
        string ui_code = "";
        public frmRestaurantTable(string uicode)
        {
            InitializeComponent();
            ui_code = uicode;
        }

        private void loadc()
        {
            conloadc = new SqlConnection(csr);
            cmdloadc = null;
            cmdloadc = new SqlCommand("select name from Tables where Category!='GROUND' AND Category!='Restaurant' AND Category!='Garden'", conloadc);
            conloadc.Open();
            rdrloadc = cmdloadc.ExecuteReader();
            while (rdrloadc.Read() == true)
            {
                listBox1.Items.Add((string)rdrloadc["name"]);
            }
            conloadc.Close();
        }

        private void frmRestaurantTable_Load(object sender, EventArgs e)
        {
            loadc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
