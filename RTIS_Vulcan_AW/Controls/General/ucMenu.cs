using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RTIS_Vulcan_AW.Forms;
using RTIS_Vulcan_AW.Classes;
using RTIS_Vulcan_AW.Controls.Open_Job;
using RTIS_Vulcan_AW.Controls.ReOpen_Job;

namespace RTIS_Vulcan_AW.Controls.General
{
    public partial class ucMenu : UserControl
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

        public ucMenu(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.userName = string.Empty;
                ucLogin login = new ucLogin(parent, main);
                GlobalVars.lastControl = login;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(login);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                string jobsRunning = Client.checkAWJobRunning();
                if (jobsRunning != string.Empty)
                {
                    switch (jobsRunning.Split('*')[0])
                    {
                        case "1":
                            ucOpenOptions itemInfo = new ucOpenOptions(parent, main);
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(itemInfo);
                            break;
                        case "0":
                            jobsRunning = jobsRunning.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", jobsRunning, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            jobsRunning = jobsRunning.Remove(0, 3);
                            errMsg = jobsRunning.Split('|')[0];
                            errInfo = jobsRunning.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            jobsRunning = jobsRunning.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", jobsRunning, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while retreiving data";
                            errInfo = "Unexpected error while retreiving data" + Environment.NewLine + "Data Returned:" + Environment.NewLine + jobsRunning;
                            ExHandler.showErrorST(st, msgStr, errInfo);
                            break;
                    }

                }
                else
                {
                    st = new StackTrace(0, true);
                    msgStr = "Unexpected error while retreiving data";
                    errInfo = "Unexpected error while retreiving data" + Environment.NewLine + "Data Returned:" + Environment.NewLine + jobsRunning;
                    ExHandler.showErrorST(st, msgStr, errInfo);
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnReprintConfigTags_Click(object sender, EventArgs e)
        {
            try
            {
                ucRPScanSheet itemInfo = new ucRPScanSheet(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(itemInfo);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnPrintTags_Click(object sender, EventArgs e)
        {
            try
            {
                ucScanConfig_PT itemInfo = new ucScanConfig_PT(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(itemInfo);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                ucScanTag_CJ itemInfo = new ucScanTag_CJ(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(itemInfo);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            try
            {
                ucReOpenOptions itemInfo = new ucReOpenOptions(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(itemInfo);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
