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
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework;

namespace SHARIQHMS
{
    public partial class frmMC : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        // load available room
        SqlConnection concreatecol = null;
        SqlCommand cmdcreatecol = null;
        SqlDataReader rdrcreatecol = null;
        //
        SqlConnection confillcol = null;
        SqlCommand cmdfillcol = null;
        SqlDataReader rdrfillcol = null;
        //
        SqlConnection conroomload = null;
        SqlCommand cmdroomload = null;
        SqlDataReader rdrroomload = null;
        //
        //backup
        SqlConnection conbackup = null;
        SqlCommand cmdbackup = null;
        //
        SqlConnection conrestore = null;
        SqlCommand cmdrestore = null;
        //
        #endregion Database string and connection
        #region initiate actions
        string acc_code = "";
        string auth_code = "";
        string ui_code = "";
        string user_name = "";
        string date_string = "";
        #endregion initiate actions
        Boolean ctag,resno = false;
        //
        int colcounter=0;
        //
        public frmMC(string acccode, string authcode, string userid, string username, string datestring)
        {
            InitializeComponent();
            acc_code = acccode;
            auth_code = authcode;
            ui_code = userid;
            user_name = username;
            date_string = datestring;
        }
        
        private void frmMC_Load(object sender, EventArgs e)
        {
            loadmonthreport();
            try
            {
                this.dTcheckedGuestlistTableAdapter1.Fill(this.dsCheckedGuestlist.DTcheckedGuestlist);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.dTcheckedGuestlistTableAdapter1.Fill(this.dsCheckedGuestlist.DTcheckedGuestlist);
                this.reportViewer1.RefreshReport();
            }
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Reservations.frmReservation frmres = new Reservations.frmReservation(acc_code, auth_code, ui_code, user_name,"New Reservation","");
            frmres.ShowDialog();
            btnLoadmonthview.PerformClick();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Masters.Customers.frmNewCustomer frm = new Masters.Customers.frmNewCustomer(ui_code);
            frm.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Masters.Rooms.frmRoomEntry frm = new Masters.Rooms.frmRoomEntry(ui_code);
            frm.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Masters.Attributes.frmAttributeProfile frm = new Masters.Attributes.frmAttributeProfile(ui_code);
            frm.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Masters.Attributes.frmAttributeEntry frm = new Masters.Attributes.frmAttributeEntry(ui_code);
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ctag = false;
            frmLogin frmlogin = new frmLogin();
            this.Close();
            frmlogin.Show();
        }

        private void frmMC_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ctag == true)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void lstvSingleDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadmonthview_Click(object sender, EventArgs e)
        {
            resno = true;
            loadmonthreport();
        }

        private void tileRoomStatus_Click(object sender, EventArgs e)
        {
            Reservations.frmRoomStatus frmroomstatus = new Reservations.frmRoomStatus(acc_code, auth_code, ui_code, user_name, "New Reservation", "");
            frmroomstatus.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Software Backup\nSelect folder where save backup file";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                conbackup = new SqlConnection(csh);
                cmdbackup = null;
                try
                {
                    cmdbackup = new SqlCommand("backup database [shariqhms] to disk='" + fbd.SelectedPath.ToString() + @"\SOHMS-" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak" + "'  with init,stats=10", conbackup);
                    conbackup.Open();
                    cmdbackup.ExecuteNonQuery();
                    conbackup.Close();
                    MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "\nError Operation terminate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conbackup.Close();
                }
            }
            else
            {
                MessageBox.Show("Canceled Action");
                fbd.Reset();
                return;
            }
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File |*.bak";
            ofd.Title = "Select Backup | bak file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                if (filename.Contains("SOHMS"))
                {
                    conrestore = new SqlConnection(csh);
                    //USE Master ALTER DATABASE [wsmdb] SET Single_User WITH Rollback Immediate Restore database [wsmdb] FROM disk='' WITH REPLACE ALTER DATABASE [wsmdb] SET Multi_User
                    cmdrestore = null;
                    try
                    {
                        cmdrestore = new SqlCommand("USE Master ALTER DATABASE [shariqhms] SET Single_User WITH Rollback Immediate Restore database [shariqhms] FROM disk='" + filename + "' WITH REPLACE ALTER DATABASE [shariqhms] SET Multi_User", conrestore);
                        conrestore.Open();
                        cmdrestore.ExecuteNonQuery();
                        conrestore.Close();
                        MessageBox.Show("Successfully performed Restore | OK to restart", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        conrestore.Close();
                    }
                }
                else
                {
                    MessageBox.Show("INVALID BACKUP FILE!", "STOP | رکیں", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            frmRep.frmGuestDetails glist = new frmRep.frmGuestDetails();
            glist.ShowDialog();
        }

        public void loadmonthreport()
        {
            lstvSingleDay.Clear();
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var enddate = startDate.AddMonths(1).AddDays(-1);
            //
            lstvSingleDay.Columns.Add("", 0, HorizontalAlignment.Center);
            lstvSingleDay.Columns.Add("Room#", 65, HorizontalAlignment.Center);

            #region Load SIngle day listview
            #region create date column First
            concreatecol = new SqlConnection(csh);
            cmdcreatecol = null;
            try
            {
                cmdcreatecol = new SqlCommand("select * from operational_room where room_no='01' ORDER BY date", concreatecol);
                concreatecol.Open();
                rdrcreatecol = cmdcreatecol.ExecuteReader();
                while (rdrcreatecol.Read() == true)
                {
                    lstvSingleDay.Columns.Add(((DateTime)rdrcreatecol["date"]).ToString("dd/MM"), 74, HorizontalAlignment.Center);
                }
                concreatecol.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.ToString());
                concreatecol.Close();
            }
            #endregion create date Coumn first
            #region fill data
            conroomload = new SqlConnection(csh);
            cmdroomload = null;
            try
            {
                cmdroomload = new SqlCommand("select rno from room_mast where m_del='0'", conroomload);
                conroomload.Open();
                rdrroomload = cmdroomload.ExecuteReader();
                while (rdrroomload.Read() == true)
                {
                    ListViewItem lsti = new ListViewItem();
                    lsti.UseItemStyleForSubItems = false;
                    lsti.SubItems.Add((string)rdrroomload["rno"]);
                    lsti.SubItems[lsti.SubItems.Count - 1].BackColor = Color.Orange;
                    lsti.SubItems[lsti.SubItems.Count - 1].Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular);
                    //Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    confillcol = new SqlConnection(csh);
                    cmdfillcol = null;
                    try
                    {
                        cmdfillcol = new SqlCommand("select * from operational_room where room_no='" + (string)rdrroomload["rno"] + "' ORDER BY room_no", confillcol);
                        confillcol.Open();
                        rdrfillcol = cmdfillcol.ExecuteReader();
                        while (rdrfillcol.Read() == true)// = true;
                        {
                            if ((string)rdrfillcol["room_status"] == "Ready")
                            {
                                lsti.SubItems.Add("");
                            }
                            else
                            {
                                if (resno == false)
                                {
                                    lsti.SubItems.Add((string)rdrfillcol["room_status"]);
                                }
                                else if(resno == true)
                                {
                                    lsti.SubItems.Add((string)rdrfillcol["current_refno"]);
                                }
                            }
                            //lsti.SubItems.Add(" ");
                            if ((string)rdrfillcol["room_status"] == "Reserved")
                            {
                                lsti.SubItems[lsti.SubItems.Count - 1].BackColor = Color.GreenYellow;
                                //lsti.SubItems[lsti.SubItems.Count - 1].Font = new Font("Microsoft Sans Serif", 16.25F, FontStyle.Regular);
                            }
                            else if ((string)rdrfillcol["room_status"] == "Maintenance")
                            {
                                lsti.SubItems[lsti.SubItems.Count - 1].BackColor = Color.Red;
                            }
                            else if ((string)rdrfillcol["room_status"] == "Checkedin")
                            {
                                lsti.SubItems[lsti.SubItems.Count - 1].BackColor = Color.LimeGreen;
                            }
                            else if ((string)rdrfillcol["room_status"] == "Checkedout")
                            {
                                lsti.SubItems[lsti.SubItems.Count - 1].BackColor = Color.Green;
                            }
                        }
                        confillcol.Close();

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.ToString());
                        confillcol.Close();
                    }
                    lstvSingleDay.Items.Add(lsti);
                }
                conroomload.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conroomload.Close();
            }
            #endregion fill data
            #endregion load single day listview
        }
        
    }
}