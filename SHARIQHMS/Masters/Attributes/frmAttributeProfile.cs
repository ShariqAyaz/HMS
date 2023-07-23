using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using logClass;
using inrClass;
using counterClass;

namespace SHARIQHMS.Masters.Attributes
{
    public partial class frmAttributeProfile : Form
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conloadc = null;
        SqlCommand cmdloadc = null;
        SqlDataReader rdrloadc = null;
        //
        SqlConnection conselprof = null;
        SqlCommand cmdselprof = null;
        SqlDataReader rdrselprof = null;
        //
        SqlConnection conupd = null;
        SqlCommand cmdupd = null;
        #endregion Database string and connections
        string ui_code = "";
        string atag = "0";
        public frmAttributeProfile(string uicode)
        {
            InitializeComponent();
            ui_code = uicode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadprof()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            //
            conloadc = new SqlConnection(csh);
            cmdloadc = null;
            cmdloadc = new SqlCommand("select name from attribute_mast where m_del='0'", conloadc);
            conloadc.Open();
            rdrloadc = cmdloadc.ExecuteReader();
            while (rdrloadc.Read() == true)
            {
                listBox1.Items.Add((string)rdrloadc["name"]);
            }
            conloadc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (button1.Text == "&Add")
            //{
            //    atag = "0";
            //    button1.Text = "&Save";
            //    listBox1.Enabled = true;
            //    listBox2.Enabled = true;
            //    cboxcustid.Text = "";
            //}
            //else if (button1.Text == "&Save")
            //{
            //    log_ex log = new log_ex();
            //    inrcini insertcust = new inrcini();
            //    //
            //    for (int i = 0; i < listBox1.Items.Count -1; i++)
            //    {
            //        MessageBox.Show(listBox1.Items.IndexOf(i).ToString());
            //    }
                
            //    atag = "1";
            //    listBox1.Enabled = true;
            //    listBox2.Enabled = true;
            //    cboxcustid.Text = "";
            //}
        }

        private void frmAttributeProfile_Load(object sender, EventArgs e)
        {
            loadprof();
            conloadc = new SqlConnection(csh);
            cmdloadc = null;
            cmdloadc = new SqlCommand("select DISTINCT(profname) from attribute_prof where m_del='0'", conloadc);
            conloadc.Open();
            rdrloadc = cmdloadc.ExecuteReader();
            while (rdrloadc.Read() == true)
            {
                cboxcustid.Items.Add((string)rdrloadc["profname"]);
            }
            conloadc.Close();
        }

        private void cboxcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //listBox1.Items.Clear();
            listBox2.Items.Clear();
            loadprof();
            conselprof = new SqlConnection(csh);
            cmdselprof = null;
            try
            {
                cmdselprof = new SqlCommand("select * from attribute_prof where m_del='0' AND profname='"+cboxcustid.Text+"'",conselprof);
                conselprof.Open();
                rdrselprof = cmdselprof.ExecuteReader();
                while (rdrselprof.Read()==true)
                {
                    listBox2.Items.Add((string)rdrselprof["attname"]);
                    listBox1.Items.Remove((string)rdrselprof["attname"]);
                }
                conselprof.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                conselprof.Close();
            }
        }

        private void btniAdd_Click(object sender, EventArgs e)
        {
            if (cboxcustid.Text == "")
            {

            }
            else
            {
                if (cboxcustid.Items.Contains(cboxcustid.Text)) { } else { cboxcustid.Items.Add(cboxcustid.Text); }
                log_ex log = new log_ex();
                inrcini insertcust = new inrcini();
                insertcust.insert_mast_attributeprof(cboxcustid.Text, Convert.ToString(listBox1.SelectedItem), ui_code, "0");
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btniDel_Click(object sender, EventArgs e)
        {
            if (cboxcustid.Text == "")
            {
                loadprof();
            }
            else
            {
                conupd = new SqlConnection(csh);
                cmdupd = null;
                try
                {
                    cmdupd = new SqlCommand("update attribute_prof set m_del='1' where m_del='0' AND attname='"+Convert.ToString(listBox2.SelectedItem)+"'", conupd);
                    conupd.Open();
                    cmdupd.ExecuteNonQuery();
                    conupd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conupd.Close();
                }
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void cboxcustid_Leave(object sender, EventArgs e)
        {
            if (cboxcustid.Text == "")
            {
                loadprof();
            }
            else
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                loadprof();
                conselprof = new SqlConnection(csh);
                cmdselprof = null;
                try
                {
                    cmdselprof = new SqlCommand("select * from attribute_prof where m_del='0' AND profname='" + cboxcustid.Text + "'", conselprof);
                    conselprof.Open();
                    rdrselprof = cmdselprof.ExecuteReader();
                    if (rdrselprof.Read() == true)
                    {
                        while (rdrselprof.Read() == true)
                        {
                            listBox2.Items.Add((string)rdrselprof["attname"]);
                            listBox1.Items.Remove((string)rdrselprof["attname"]);
                        }
                    }
                    
                    conselprof.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                    conselprof.Close();
                }
            }
        }
    }
}