using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Fonts;
using MetroFramework.Interfaces;
using MetroFramework;
using System.Globalization;
using System.Data.SqlClient;

namespace SHARIQHMS.Reservations
{

    public partial class frmRoomStatus : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        // load available room
        SqlConnection conrstatus = null;
        SqlCommand cmdrstatus = null;
        SqlDataReader rdrrstatus = null;
        #endregion
        string acc_code, user_name, nowdate, checkoutDate, checkinDate, ui_code, auth_code, usr_action, ref_code, res_date, rettype;
        public frmRoomStatus(string acccode, string authcode, string uicode, string username, string action, string refcode)
        {
            InitializeComponent();
            acc_code = acccode;
            auth_code = authcode;
            ui_code = uicode;
            user_name = username;
            auth_code = authcode;
            usr_action = action;
            ref_code = refcode;
        }

        private void frmRoomStatus_Load(object sender, EventArgs e)
        {
            #region load date & time
            string nowdate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");
            dtpCheckin.CustomFormat = "dd/MM/yy";
            dtpCheckin.Format = DateTimePickerFormat.Custom;
            //dtpCheckin.Text = DateTime.Now.ToString("dd/MM/yy");
            #endregion load date & Time
            //tile01.Style = styleGreen.Style;
            loadroomstatus(this.Controls);
        }

        private void tile01_Click(object sender, EventArgs e)
        {
            Button tile = (Button)sender;
            if (tile.Name == "tile01" || tile.Name == "tile02" || tile.Name == "tile03" || 
                tile.Name == "tile04" || tile.Name == "tile05" || tile.Name == "tile106" || 
                tile.Name == "tile107" || tile.Name == "tile108" || tile.Name == "tile109"||
                tile.Name == "tile110" || tile.Name == "tile111" || tile.Name == "tile112" ||
                tile.Name == "tile113" || tile.Name == "tile214" || tile.Name == "tile215" ||
                tile.Name == "tile216" || tile.Name == "tile217" || tile.Name == "tile218" ||
                tile.Name == "tile319" || tile.Name == "tile320" || tile.Name == "tile321" || tile.Name == "tile322")
            {
                if (tile.Tag.ToString() == "")
                {
                    MessageBox.Show("Clicked Room look like 'Ready' OR might not linked with" + tile.Name.Replace("tile", ""));
                }
                else
                {
                    Reservations.frmReservation frmres = new Reservations.frmReservation(acc_code, auth_code, ui_code, user_name, "Checkin", tile.Tag.ToString());
                    frmres.ShowDialog();
                    this.Close();
                }
            }
        }

        private void loadroomstatus(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                Button tile = ctrl as Button;
                if (tile != null)
                {
                    #region get formated date
                    string dcon = dtpCheckin.Text;
                    DateTime dt = DateTime.ParseExact(dcon, "dd/MM/yy", CultureInfo.InvariantCulture);
                    string checkinDate = dt.ToString("yyyy/MM/dd");
                    #endregion get formated date
                    string strroom = tile.Name.Replace("tile", "");
                    conrstatus = new SqlConnection(csh);
                    cmdrstatus = null;
                    try
                    {
                        cmdrstatus = new SqlCommand("select * from operational_room where room_no='" + strroom + "' AND date BETWEEN '" + Convert.ToDateTime(checkinDate).ToString("yyyy/MM/dd") + "' AND '" + Convert.ToDateTime(checkinDate).ToString("yyyy/MM/dd") + "'", conrstatus);
                        conrstatus.Open();
                        rdrrstatus = cmdrstatus.ExecuteReader();
                        if (rdrrstatus.Read() == true)
                        {
                            tile.Text = ((string)rdrrstatus["current_refno"])+ "\n" + tile.Name.Replace("tile", "");
                            //tile.Text = ((string)rdrrstatus["current_refno"])+ "\n" + ((string)rdrrstatus["rguestname"]) + "\n" + tile.Name.Replace("tile", "");
                            tile.Tag = ((string)rdrrstatus["current_refno"]);
                            #region Coloring as per status
                            if (tile.Name == "tile01")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile01.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile01.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile02")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile02.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile02.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile03")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile03.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile03.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile04")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile04.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile04.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile05")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile05.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile05.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile106")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile106.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile106.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile107")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile107.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile107.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile108")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile108.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile108.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile109")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile109.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile109.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile110")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile110.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile110.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile111")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile111.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile111.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile112")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile112.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile112.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile113")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile113.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile113.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile214")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile214.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile214.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile215")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile215.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile215.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile216")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile216.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile216.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile217")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile217.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile217.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile218")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile218.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile218.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile319")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile319.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile319.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile320")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile320.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile320.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile321")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile321.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile321.Style = styleWhite.Style;
                                }
                            }
                            //
                            if (tile.Name == "tile322")
                            {
                                if ((Boolean)rdrrstatus["isCheckedIn"] == true)
                                {
                                    tile322.Style = styleGreen.Style;
                                }
                                else// if ((Boolean)rdrrstatus["isCancel"] == false)
                                {
                                    tile322.Style = styleWhite.Style;
                                }
                            }
                            #endregion Coloring as per status
                        }
                        else
                        {
                            #region else make it normal
                            tile.Text = tile.Name.Replace("tile", "");
                            tile.Tag = "";
                            if (tile.Name == "tile01")
                            {
                                tile01.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile02")
                            {
                                tile02.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile03")
                            {
                                tile03.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile04")
                            {
                                tile04.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile05")
                            {
                                tile05.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile106")
                            {
                                tile106.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile107")
                            {
                                tile107.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile108")
                            {
                                tile108.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile109")
                            {
                                tile109.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile110")
                            {
                                tile110.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile111")
                            {
                                tile111.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile112")
                            {
                                tile112.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile113")
                            {
                                tile113.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile214")
                            {
                                tile214.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile215")
                            {
                                tile215.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile216")
                            {
                                tile216.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile217")
                            {
                                tile217.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile218")
                            {
                                tile218.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile319")
                            {
                                tile319.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile320")
                            {
                                tile320.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile321")
                            {
                                tile321.Style = styleWhite.Style;
                            }
                            if (tile.Name == "tile322")
                            {
                                tile322.Style = styleWhite.Style;
                            }
                            #endregion else make it normal
                        }
                        conrstatus.Close();
                    }
                    catch (Exception ex)
                    {
                        conrstatus.Close();
                    }
                }
                else
                {
                    loadroomstatus(ctrl.Controls);
                }
            }
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {
            loadroomstatus(this.Controls);
        }
    }
}
