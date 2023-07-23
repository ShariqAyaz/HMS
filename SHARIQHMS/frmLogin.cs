using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using logClass;
using inrClass;
using System.Data.SqlClient;

namespace SHARIQHMS
{
    public partial class frmLogin : Form
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        SqlConnection con1 = null;
        SqlCommand cmd1 = null;
        SqlDataReader rdr1 = null;
        #endregion Database string and connection
        string acc_code = "";
        string auth_code = "";
        string ui_code = "";
        string user_name = "";
        string date_string = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            log_ex log = new log_ex();
            #region Execute Login
            try
            {
                con = new SqlConnection(csh);
                con1 = new SqlConnection(csh);
                try
                {
                    cmd = new SqlCommand("SELECT * FROM u_code WHERE userid = '" + txtbusrid.Text + "' AND password= '" + txtbusrpass.Text + "' AND isactive='True' AND m_del='0'", con);
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        cmd1 = new SqlCommand("SELECT * FROM urms where uicode='" + Convert.ToString((string)rdr["uicode"]) + "'", con1);
                        con1.Open();
                        rdr1 = cmd1.ExecuteReader();
                        if (rdr1.Read())
                        {
                            acc_code = (Convert.ToString((string)rdr1["acc_level"]));
                            auth_code = (Convert.ToString((string)rdr1["Auth_code"]));
                            ui_code = (Convert.ToString((string)rdr1["uicode"]));
                            user_name = (Convert.ToString((string)rdr1["userid"]));
                        }
                        con1.Close();
                        //
                        log.insert_log_event(ui_code, "Successfully Logedin", "1", "1");
                        frmMC mainfrm = new frmMC(acc_code, auth_code, ui_code, user_name, date_string);
                        mainfrm.Show();
                        this.Hide();
                        //
                    }
                    else
                    {
                        MessageBox.Show("Please Enter valid id/password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbusrpass.Clear();
                        txtbusrpass.Clear();
                        txtbusrpass.Focus();
                        con.Close();
                        con1.Close();
                        log.insert_log_err("0", "Login Failed by User" + txtbusrid.Text, "0", "1");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion Execute Login
        }

        private void txtbuid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox tb = (TextBox)sender;
                if (tb.Name== "txtbuid")
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "USER NAME";
                        toolTip1.Show("Enter User Name", txtbusrid, 2500);
                    }
                    else
                    {
                        txtbusrpass.Focus();
                    }
                }
                else if (tb.Name == "txtbusrpass")
                {
                    if (tb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "PASSWORD";
                        toolTip1.Show("Enter Your Password", txtbusrpass, 2500);
                    }
                    else
                    {
                        btnlogin.PerformClick();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtbusrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbusrid.Text == "")
                {
                    
                }
                else
                {
                    txtbusrpass.Focus();
                }
            }
        }

        private void txtbusrpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbusrpass.Text == "")
                {

                }
                else
                {
                    btnlogin.PerformClick();
                }
            }
        }
    }
}
