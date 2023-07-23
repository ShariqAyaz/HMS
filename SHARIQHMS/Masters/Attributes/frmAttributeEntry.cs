using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using logClass;
using inrClass;

namespace SHARIQHMS.Masters.Attributes
{
    public partial class frmAttributeEntry : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conloadc = null;
        SqlCommand cmdloadc = null;
        SqlDataReader rdrloadc = null;
        #endregion Database string and connections
        string ui_code = "";
        public frmAttributeEntry(string uicode)
        {
            InitializeComponent();
            ui_code = uicode;
        }
        private void loadc()
        {
            conloadc = new SqlConnection(csh);
            cmdloadc = null;
            cmdloadc = new SqlCommand("select name,cat from attribute_mast where m_del='0'", conloadc);
            conloadc.Open();
            rdrloadc = cmdloadc.ExecuteReader();
            while (rdrloadc.Read() == true)
            {
                cboxattrname.Items.Add((string)rdrloadc["name"]);
                cboxattrcat.Items.Add((string)rdrloadc["cat"]);
            }
            conloadc.Close();
        }

        private void frmAttributeEntry_Load(object sender, EventArgs e)
        {
            loadc();
        }

        private void btniAdd_Click(object sender, EventArgs e)
        {
            #region make sure required fields are available
            if (cboxattrname.Text == "") { MessageBox.Show("Please Enter Equipment Name"); return; }
            if (cboxattrcat.Text == "") { MessageBox.Show("Please Enter or select catagory"); return; }
            if (cboxmen.Text == "") { MessageBox.Show("Please specify equipment requirement"); return; }
            if (cboxattrname.Items.Contains(cboxattrname.Text)) { MessageBox.Show("Provided information is Already Entered"); return; }
            #endregion make sure required fields are available
            log_ex log = new log_ex();
            inrcini insertcust = new inrcini();
            try
            {
                insertcust.insert_mast_attribute(cboxattrname.Text, cboxmen.Text, cboxattrcat.Text, ui_code, "0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(insertcust.errorcode + " \n" + ex.ToString());
                log.insert_log_err(ui_code, insertcust.errorcode, "2", "0");
            }
            #region Success loging
            log.insert_log_event(ui_code, "Successfully Entered new attrinute: " + cboxattrname, "4", "0");
            #endregion Success login
            cboxattrname.Items.Add(cboxattrname.Text);
            cboxattrcat.Items.Add(cboxattrcat.Text);
            ListViewItem lst = new ListViewItem();
            lst.SubItems.Add(cboxattrname.Text);
            lst.SubItems.Add(cboxattrcat.Text);
            listView1.Items.Add(lst);
            //// Adds a new group that has a left-aligned header
            //listView1.Groups.Add(new ListViewGroup("List item text", HorizontalAlignment.Left));
            //int i = 0;
            //listView1.Items[0].Group = listView1.Groups[1];
            cboxattrname.Text = "";
            cboxattrcat.Text = "";
            cboxattrname.Focus();
            //i++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxattrname_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (cb.Name == "cboxattrname") // 9
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "CNIC/Passport";
                        toolTip1.Show("Enter CNIC or Passport", cb, 2500);
                    }
                    else
                    {
                        cboxattrcat.Focus();
                    }
                }
                else if (cb.Name == "cboxattrcat") // 10
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Nationality";
                        toolTip1.Show("Enter Nationality", cb, 2500);
                    }
                    else
                    {
                        btniAdd.PerformClick();
                    }
                }
            }
        }
    }
}
