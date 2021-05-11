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

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class ucScanToOpen : UserControl
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

        public ucScanToOpen(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucScanToOpen_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
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
                        if (txtItem.Text.Contains("(") && txtItem.Text.Contains(")"))
                        {
                            string itemCode = Barcodes.GetItemCode(txtItem.Text);
                            string lot = Barcodes.GetItemLot(txtItem.Text);
                            string qty = Barcodes.GetItemQty(txtItem.Text);

                            //string baseItem = itemCode.Replace("-1st COAT", string.Empty).Replace("-2nd COAT", string.Empty).Replace("-3rd COAT", string.Empty).Replace("-4rd COAT", string.Empty).Replace(" - 1st COAT", string.Empty).Replace(" - 2nd COAT", string.Empty).Replace(" - 3rd COAT", string.Empty).Replace(" - 4rd COAT", string.Empty).Replace(" ", string.Empty);
                            string awCode = Client.getAWItemCode(itemCode);
                            if (awCode != string.Empty)
                            {
                                switch (awCode.Split('*')[0])
                                {
                                    case "1":
                                        awCode = awCode.Remove(0, 2);
                                        GlobalVars.OJItemCode = awCode;
                                        GlobalVars.OJLotNumber = lot;

                                        ucSelectPGM scan = new ucSelectPGM(parent, main);
                                        main.pnlMain.Controls.Clear();
                                        main.pnlMain.Controls.Add(scan);
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
                            msg = new frmMsg("Cannot get barcode information", "Pleass can a valid ZECT tag", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            txtItem.Focus();
                        }
                    }
                    else
                    {
                        txtItem.Text = string.Empty;
                        msg = new frmMsg("Cannot get barcode information", "Pleass can a valid ZECT tag", GlobalVars.msgState.Error);
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

        private void txtItem_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtItem;
        }
    }
}
