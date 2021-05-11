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

namespace RTIS_Vulcan_AW.Controls.ReOpen_Job
{
    public partial class ucScanToReopen : UserControl
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
        public ucScanToReopen(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucScanToReopen_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem.Text != string.Empty)
                    {
                        if (txtItem.Text.Contains("A&W"))
                        {
                            string awInfo = Client.getAWJobInfo(txtItem.Text);
                            if (awInfo != string.Empty)
                            {
                                switch (awInfo.Split('*')[0])
                                {
                                    case "1":
                                        awInfo = awInfo.Remove(0, 2);
                                        GlobalVars.ROItemCode = awInfo.Split('|')[0];
                                        GlobalVars.ROLotNumber = awInfo.Split('|')[1];
                                        GlobalVars.ROPGMCode = awInfo.Split('|')[2];
                                        GlobalVars.ROPGMLot = awInfo.Split('|')[3];
                                        GlobalVars.ROJobQty = awInfo.Split('|')[4];
                                        GlobalVars.ROManufQty = awInfo.Split('|')[5];
                                        GlobalVars.ROJobNumber = txtItem.Text;

                                        ucReOpeninfo options = new ucReOpeninfo(parent, main);
                                        GlobalVars.lastControl = options;
                                        main.pnlMain.Controls.Clear();
                                        main.pnlMain.Controls.Add(options);
                                        break;
                                    case "0":
                                        txtItem.Text = string.Empty;
                                        awInfo = awInfo.Remove(0, 2);
                                        msg = new frmMsg("The following server side issue was encountered:", awInfo, GlobalVars.msgState.Error);
                                        msg.ShowDialog();
                                        txtItem.Focus();
                                        break;
                                    case "-1":
                                        txtItem.Text = string.Empty;
                                        awInfo = awInfo.Remove(0, 3);
                                        errMsg = awInfo.Split('|')[0];
                                        errInfo = awInfo.Split('|')[1];
                                        ExHandler.showErrorStr(errMsg, errInfo);
                                        txtItem.Focus();
                                        break;
                                    case "-2":
                                        txtItem.Text = string.Empty;
                                        awInfo = awInfo.Remove(0, 2);
                                        msg = new frmMsg("A connection level error has occured", awInfo, GlobalVars.msgState.Error);
                                        msg.ShowDialog();
                                        txtItem.Focus();
                                        break;
                                    default:
                                        txtItem.Text = string.Empty;
                                        st = new StackTrace(0, true);
                                        msgStr = "Unexpected error while logging in";
                                        errInfo = "Unexpected error while logging in" + Environment.NewLine + "Data Returned:" + Environment.NewLine + awInfo;
                                        txtItem.Focus();
                                        break;
                                }
                            }
                            else
                            {
                                txtItem.Text = string.Empty;
                                msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                txtItem.Focus();
                            }
                        }
                        else
                        {
                            txtItem.Text = string.Empty;
                            msg = new frmMsg("Cannot get barcode information", "Pleass can a valid A&W config tag", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            txtItem.Focus();
                        }
                    }
                    else
                    {
                        txtItem.Text = string.Empty;
                        msg = new frmMsg("Cannot get barcode information", "Pleass can a valid A&W config tag", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                txtItem.Text = string.Empty;
                ExHandler.showErrorEx(ex);
                txtItem.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void txtItem_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtItem;
        }
    }
}
