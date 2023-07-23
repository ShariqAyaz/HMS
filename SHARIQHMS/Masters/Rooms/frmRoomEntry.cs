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
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace SHARIQHMS.Masters.Rooms
{
    public partial class frmRoomEntry : MetroForm
    {
        #region Database string and connections
        string csh = @"Data Source=Shariq-PC\SQLEXPRESS;database=shariqhms;Trusted_Connection=yes;connection timeout=30;";
        string csr = @"Data Source=Shariq-PC\SQLEXPRESS;database=SambaData2;Trusted_Connection=yes;connection timeout=30;";
        SqlConnection conloadprof = null;
        SqlCommand cmdloadprof = null;
        SqlDataReader rdrloadprof = null;
        //
        SqlConnection conloadr = null;
        SqlCommand cmdloadr = null;
        SqlDataReader rdrloadr = null;
        //
        SqlConnection conloadrlink = null;
        SqlCommand cmdloadrlink = null;
        SqlDataReader rdrloadrlink = null;
        //
        SqlConnection conupd = null;
        SqlCommand cmdupd = null;
        #endregion Database string and connections
        string ui_code = "";
        string atag = "0";
        public frmRoomEntry(string uicode)
        {
            InitializeComponent();
            ui_code = uicode;
        }

        private void loadroom()
        {
            cboxRoomname.Items.Clear();
            cboxRoomlocation.Items.Clear();
            cboxRoomfloor.Items.Clear();
            cboxcat.Items.Clear();
            conloadr = new SqlConnection(csh);
            cmdloadr = null;
            try
            {
                cmdloadr = new SqlCommand("select * from room_mast where m_del='0'", conloadr);
                conloadr.Open();
                rdrloadr = cmdloadr.ExecuteReader();
                while (rdrloadr.Read()==true)
                {
                    cboxRoomname.Items.Add((string)rdrloadr["rno"]);
                    cboxRoomlocation.Items.Add((string)rdrloadr["location"]);
                    cboxRoomfloor.Items.Add((string)rdrloadr["floor"]);
                    cboxcat.Items.Add((string)rdrloadr["rcat"]);
                }
                conloadr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadr.Close();
            }
        }

        private void loadrestaurantlink()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Restaurant Room ID", typeof(int));
            dt.Columns.Add("Room No", typeof(string));

            cboxrlink.Items.Clear();
            conloadrlink = new SqlConnection(csr);
            cmdloadrlink = null;
            try
            {
                cmdloadrlink = new SqlCommand("select * from Tables where Category!='Restaurant' AND Category!='Garden'", conloadrlink);
                conloadrlink.Open();
                rdrloadrlink = cmdloadrlink.ExecuteReader();
                while (rdrloadrlink.Read() == true)
                {
                    dt.Rows.Add(((Int32)rdrloadrlink["Id"]),((string)rdrloadrlink["name"]));
                }
                conloadrlink.Close();
                #region custom combobox
                // Bind the ComboBox to the DataTable
                this.cboxrlink.DataSource = dt;
                this.cboxrlink.DisplayMember = "Restaurant Room ID";
                this.cboxrlink.ValueMember = "Room No";

                // Enable the owner draw on the ComboBox.
                this.cboxrlink.DrawMode = DrawMode.OwnerDrawFixed;
                // Handle the DrawItem event to draw the items.
                this.cboxrlink.DrawItem += delegate (object cmb, DrawItemEventArgs args)
                {
                    // Draw the default background
                    args.DrawBackground();


                    // The ComboBox is bound to a DataTable,
                    // so the items are DataRowView objects.
                    DataRowView drv = (DataRowView)this.cboxrlink.Items[args.Index];

                    // Retrieve the value of each column.
                    string id = drv["Room No"].ToString();
                    string name = drv["Restaurant Room ID"].ToString();

                    // Get the bounds for the first column
                    Rectangle r1 = args.Bounds;
                    r1.Width /= 2;

                    // Draw the text on the first column
                    using (SolidBrush sb = new SolidBrush(args.ForeColor))
                    {
                        args.Graphics.DrawString(id, args.Font, sb, r1);
                    }

                    // Draw a line to isolate the columns 
                    using (Pen p = new Pen(Color.Black))
                    {
                        args.Graphics.DrawLine(p, r1.Right, 0, r1.Right, r1.Bottom);
                    }

                    // Get the bounds for the second column
                    Rectangle r2 = args.Bounds;
                    r2.X = args.Bounds.Width / 2;
                    r2.Width /= 2;

                    // Draw the text on the second column
                    using (SolidBrush sb = new SolidBrush(args.ForeColor))
                    {
                        args.Graphics.DrawString(name, args.Font, sb, r2);
                    }
                };
                #endregion custom combobox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conloadrlink.Close();
            }
        }

        private void loadattrprof()
        {
            cboxRoomprofile.Items.Clear();
            conloadprof = new SqlConnection(csh);
            cmdloadprof = null;
            cmdloadprof = new SqlCommand("select profname from attribute_prof where m_del='0'", conloadprof);
            conloadprof.Open();
            rdrloadprof = cmdloadprof.ExecuteReader();
            while (rdrloadprof.Read() == true)
            {
                cboxRoomprofile.Items.Add((string)rdrloadprof["profname"]);
            }
            conloadprof.Close();
        }

        private void frmRoomEntry_Load(object sender, EventArgs e)
        {
            loadroom();
            loadrestaurantlink();
            loadattrprof();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region authority
            #endregion authority
            inrcini insertcust = new inrcini();
            try
            {
                insertcust.insert_mast_room(cboxRoomname.Text, cboxRoomlocation.Text, cboxRoomfloor.Text, cboxRoomfloor.Text, cboxcat.Text, cboxrlink.Text, "", ui_code, "0");
                cboxRoomname.Items.Add(cboxRoomname.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(insertcust.errorcode + ex.ToString());
            }
            // operations
            try
            {
                insertcust.insert_room_operational(cboxRoomname.Text, "Ready", true, "", false, "NULL", "", ui_code, "0");
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, insertcust.errorcode + ex.ToString());
            }
            //
            cboxRoomname.Text = "";
            cboxRoomlocation.Text = "";
            cboxRoomfloor.Text = "";
            cboxRoomprofile.Text = "";
            cboxrlink.Text = "";
            cboxcat.Text = "";
            btnAdd.Text = "&Save";
            atag = "0";
            cboxRoomname.Focus();

        }

        private void cboxRoomname_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (cb.Name == "cboxRoomname")
                {
                    if (cb.Text == "" && !(cb.Items.Contains(cb.Text)))
                    {
                        toolTip1.ToolTipTitle = "Provide complete";
                        toolTip1.Show("Please Provide Complete info", cb, 2500);
                    }
                    else
                    {
                        cboxRoomlocation.Focus();
                    }

                }
                else if (cb.Name == "cboxRoomlocation")
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Provide complete";
                        toolTip1.Show("Please Provide Complete info", cb, 2500);
                    }
                    else
                    {
                        cboxRoomfloor.Focus();
                    }
                }
                else if (cb.Name == "cboxRoomfloor")
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Provide complete";
                        toolTip1.Show("Please Provide Complete info", cb, 2500);
                    }
                    else
                    {
                        cboxRoomprofile.Focus();
                    }
                }
                else if (cb.Name == "cboxRoomprofile")
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Provide complete";
                        toolTip1.Show("Please Provide Complete info", cb, 2500);
                    }
                    else
                    {
                        cboxrlink.Focus();
                    }
                }
                else if (cb.Name == "cboxrlink")
                {
                    if (cb.Text == "")
                    {
                        toolTip1.ToolTipTitle = "Provide complete";
                        toolTip1.Show("Please Provide Complete info", cb, 2500);
                    }
                    else
                    {
                        cboxcat.Focus();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
