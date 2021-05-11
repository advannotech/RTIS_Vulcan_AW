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
using RTIS_Vulcan_AW.Controls.Print_Tags;
using RTIS_Vulcan_AW.Controls.General;

namespace RTIS_Vulcan_AW.Controls
{
    public partial class ucScanConfig_PT : UserControl
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
        public ucScanConfig_PT(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucScanConfig_PT_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem.Text.Substring(0, 4) == "A&W_")
                    {
                        string jobNo = txtItem.Text; //.Remove(0, 4);
                        string jobInfo = Client.getAWJobDetails(jobNo);
                        if (jobInfo != string.Empty)
                        {
                            switch (jobInfo.Split('*')[0])
                            {
                                case "1":
                                    jobInfo = jobInfo.Remove(0, 2);
                                    GlobalVars.PTJobNo = txtItem.Text;
                                    GlobalVars.PTItemCode = jobInfo.Split('|')[0];
                                    GlobalVars.PTLotNumber = jobInfo.Split('|')[1];
                                    GlobalVars.PTPGMCode = jobInfo.Split('|')[2];
                                    GlobalVars.PTLotNumber = jobInfo.Split('|')[3];
                                    GlobalVars.PTJobQty = jobInfo.Split('|')[4];
                                    GlobalVars.PTManufQty = jobInfo.Split('|')[5];

                                    ucPrintType printType = new ucPrintType(parent, main);
                                    main.pnlMain.Controls.Clear();
                                    main.pnlMain.Controls.Add(printType);
                                    break;
                                case "0":
                                    txtItem.Text = string.Empty;
                                    txtItem.Focus();
                                    jobInfo = jobInfo.Remove(0, 2);
                                    msg = new frmMsg("The following server side issue was encountered:", jobInfo, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    break;
                                case "-1":
                                    txtItem.Text = string.Empty;
                                    txtItem.Focus();
                                    jobInfo = jobInfo.Remove(0, 3);
                                    errMsg = jobInfo.Split('|')[0];
                                    errInfo = jobInfo.Split('|')[1];
                                    ExHandler.showErrorStr(errMsg, errInfo);
                                    break;
                                case "-2":
                                    txtItem.Text = string.Empty;
                                    txtItem.Focus();
                                    jobInfo = jobInfo.Remove(0, 2);
                                    msg = new frmMsg("A connection level error has occured", jobInfo, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    break;
                                default:
                                    txtItem.Text = string.Empty;
                                    txtItem.Focus();
                                    st = new StackTrace(0, true);
                                    msgStr = "Unexpected error while printing job tags";
                                    errInfo = "Unexpected error while printing job tags" + Environment.NewLine + "Data Returned:" + Environment.NewLine + jobInfo;
                                    ExHandler.showErrorST(st, msgStr, errInfo);
                                    break;
                            }
                        }
                        else
                        {
                            txtItem.Text = string.Empty;
                            txtItem.Focus();
                            st = new StackTrace(0, true);
                            msgStr = "No data was returned from the server";
                            errInfo = "No data was returned from the server";
                            ExHandler.showErrorST(st, msgStr, errInfo);
                        }
                    }
                    else
                    {
                        txtItem.Text = string.Empty;
                        txtItem.Focus();
                        msg = new frmMsg("Invalid Tag", "Please scan a valid A&W job tag", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                txtItem.Text = string.Empty;
                txtItem.Focus();
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucMenu menu = new ucMenu(parent, main);
                GlobalVars.lastControl = menu;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(menu);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }

        }
    }
}
