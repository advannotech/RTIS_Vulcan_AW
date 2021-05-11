using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_AW.Forms;
using System.Diagnostics;
using RTIS_Vulcan_AW.Classes;
using RTIS_Vulcan_AW.Controls.General;

namespace RTIS_Vulcan_AW.Controls.ReOpen_Job
{
    public partial class ucReOpeninfo : UserControl
    {
        #region Error handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        StackTrace st;
        string msgStr = string.Empty;
        string infoStr = string.Empty;
        #endregion

        public frmMain main;
        Panel parent;

        public ucReOpeninfo(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucReOpeninfo_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            lblItem.Text = GlobalVars.ROItemCode;
            lblLot.Text = GlobalVars.ROLotNumber;
            lblPGM.Text = GlobalVars.ROPGMCode;
            lblPGMLot.Text = GlobalVars.ROPGMLot;
            lblJobQty.Text = GlobalVars.ROJobQty;
            lblManufQty.Text = GlobalVars.ROManufQty;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
                ucReOpenOptions options = new ucReOpenOptions(parent, main);
                GlobalVars.lastControl = options;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(options);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                string reOpened = Client.reopenAWJob(GlobalVars.ROJobNumber + "|" + GlobalVars.userName);
                if (reOpened != string.Empty)
                {
                    switch (reOpened.Split('*')[0])
                    {
                        case "1":
                            msg = new frmMsg("Success", "The job has been reopened", GlobalVars.msgState.Success);
                            msg.ShowDialog();
                            ucMenu menu = new ucMenu(parent, main);
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(menu);
                            break;
                        case "0":
                            reOpened = reOpened.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", reOpened, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            reOpened = reOpened.Remove(0, 3);
                            errMsg = reOpened.Split('|')[0];
                            errInfo = reOpened.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            reOpened = reOpened.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", reOpened, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while logging in";
                            errInfo = "Unexpected error while logging in" + Environment.NewLine + "Data Returned:" + Environment.NewLine + reOpened;
                            break;
                    }
                }
                else
                {
                    msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
