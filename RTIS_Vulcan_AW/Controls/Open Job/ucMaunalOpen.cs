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
using RTIS_Vulcan_AWW.Controls;

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class ucMaunalOpen : UserControl
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
        public ucMaunalOpen(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucMaunalOpen_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlOmniPad omni = new cntrlOmniPad();
            omni.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(omni);

            txtItem.Focus();
            GlobalVars.focusedEdit = txtItem;
        }
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem.Text != string.Empty)
                    {
                        string baseItem = txtItem.Text;
                        string awCode = Client.getAWItemCode(baseItem);
                        if (awCode != string.Empty)
                        {
                            switch (awCode.Split('*')[0])
                            {
                                case "1":
                                    awCode = awCode.Remove(0, 2);
                                    GlobalVars.OJItemCode = awCode;
                                    GlobalVars.focusedEdit = txtBatch;
                                    txtBatch.Focus();
                                    break;
                                case "0":
                                    txtItem.Text = string.Empty;
                                    awCode = awCode.Remove(0, 2);
                                    msg = new frmMsg("The following server side issue was encountered:", awCode, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    txtItem.Focus();
                                    break;
                                case "-1":
                                    txtItem.Text = string.Empty;
                                    awCode = awCode.Remove(0, 3);
                                    errMsg = awCode.Split('|')[0];
                                    errInfo = awCode.Split('|')[1];
                                    ExHandler.showErrorStr(errMsg, errInfo);
                                    txtItem.Focus();
                                    break;
                                case "-2":
                                    txtItem.Text = string.Empty;
                                    awCode = awCode.Remove(0, 2);
                                    msg = new frmMsg("A connection level error has occured", awCode, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    txtItem.Focus();
                                    break;
                                default:
                                    txtItem.Text = string.Empty;
                                    st = new StackTrace(0, true);
                                    msgStr = "Unexpected error while logging in";
                                    errInfo = "Unexpected error while logging in" + Environment.NewLine + "Data Returned:" + Environment.NewLine + awCode;
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
                        msg = new frmMsg("Cannot get barcode information", "Pleass can a valid barcode", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBatch.Text != string.Empty)
                {
                    GlobalVars.OJLotNumber = txtBatch.Text;
                    ucSelectPGM pgm = new ucSelectPGM(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(pgm);
                }
                else
                {
                    msg = new frmMsg("Unable to continue", "Please enter a lot number", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucOpenOptions options = new ucOpenOptions(parent, main);
                GlobalVars.lastControl = options;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(options);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void txtBatch_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtBatch;
        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtItem;
        }
    }
}
