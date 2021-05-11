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
using DevExpress.XtraReports.UI;

namespace RTIS_Vulcan_AW.Controls.Print_Tags
{
    public partial class ucQtyToPrint : UserControl
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
        public ucQtyToPrint(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucQtyToPrint_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            lblItem.Text = GlobalVars.PTItemCode;
            lblLot.Text = GlobalVars.PTLotNumber;
            lblOutQty.Text = GlobalVars.PTJobQty;
            lblManufQty.Text = GlobalVars.PTManufQty;

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            txtQty.Focus();
            GlobalVars.focusedEdit = txtQty;
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtQty;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text != string.Empty)
                {
                    double printQty = Convert.ToDouble(txtQty.Text.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep));
                    double manufQty = Convert.ToDouble(lblManufQty.Text.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep));
                    double jcQty = Convert.ToDouble(lblOutQty.Text.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep));
                    if (printQty + manufQty <= jcQty)
                    {
                        string manufactured = Client.printAWJobTags(GlobalVars.PTJobNo + "|" + GlobalVars.PTItemCode + "|" + GlobalVars.PTLotNumber + "|" + printQty + "|" + GlobalVars.userName);
                        if (manufactured != string.Empty)
                        {
                            switch (manufactured.Split('*')[0])
                            {
                                case "1":
                                    string tagInfo = manufactured.Remove(0, 2).Split('~')[0];
                                    string unq = manufactured.Split('~')[1];

                                    string palletCode = tagInfo.Split('|')[0];
                                    string palletNo = tagInfo.Split('|')[1];
                                    string itemCode = tagInfo.Split('|')[2];
                                    string barcode = tagInfo.Split('|')[3];
                                    string simpleCode = tagInfo.Split('|')[4];
                                    string binLocation = tagInfo.Split('|')[5];
                                    string description1 = tagInfo.Split('|')[6];
                                    string description2 = tagInfo.Split('|')[7];
                                    string description3 = tagInfo.Split('|')[8];
                                    string group = tagInfo.Split('|')[9];

                                    XtraReport printLabel = GlobalVars.awTag;
                                    printLabel.Parameters["_JobNo"].Value = GlobalVars.PTJobNo;
                                    printLabel.Parameters["_ItemCode"].Value = itemCode;
                                    printLabel.Parameters["_Lot"].Value = GlobalVars.PTLotNumber;
                                    printLabel.Parameters["_Qty"].Value = txtQty.Text;
                                    printLabel.Parameters["_RT2D"].Value = unq;
                                    printLabel.Parameters["_barcode"].Value = barcode;
                                    printLabel.Parameters["_bin"].Value = binLocation;
                                    printLabel.Parameters["_Date"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                                    printLabel.Parameters["_Description1"].Value = description1;
                                    printLabel.Parameters["_Description2"].Value = description2;
                                    printLabel.Parameters["_Description3"].Value = description3;
                                    printLabel.Parameters["_Group"].Value = group;
                                    printLabel.Parameters["_SimpleCode"].Value = simpleCode;
                                    printLabel.Parameters["_palletNo"].Value = palletNo;

                                    printLabel.CreateDocument();
                                    ReportPrintTool prtTool = new ReportPrintTool(printLabel);
                                    prtTool.PrinterSettings.Copies = Convert.ToInt16(1);
                                    prtTool.Print(GlobalVars.Printer);


                                    msg = new frmMsg("Success:", "the pallet quantity has been recorded", GlobalVars.msgState.Success);
                                    if (lblManufQty.Text == string.Empty)
                                    {
                                        lblManufQty.Text = "0";
                                    }
                                    lblManufQty.Text = Convert.ToString(Convert.ToDecimal(lblManufQty.Text.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep)) + Convert.ToDecimal(txtQty.Text.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep)));
                                    msg.ShowDialog();
                                    txtQty.Text = string.Empty;
                                    break;
                                    break;
                                case "0":
                                    manufactured = manufactured.Remove(0, 2);
                                    msg = new frmMsg("The following server side issue was encountered:", manufactured, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    txtQty.Text = string.Empty;
                                    break;
                                case "-1":
                                    manufactured = manufactured.Remove(0, 3);
                                    errMsg = manufactured.Split('|')[0];
                                    errInfo = manufactured.Split('|')[1];
                                    ExHandler.showErrorStr(errMsg, errInfo);
                                    txtQty.Text = string.Empty;
                                    break;
                                case "-2":
                                    manufactured = manufactured.Remove(0, 2);
                                    msg = new frmMsg("A connection level error has occured", manufactured, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    txtQty.Text = string.Empty;
                                    break;
                                default:
                                    st = new StackTrace(0, true);
                                    msgStr = "Unexpected error while printing tag";
                                    errInfo = "Unexpected error while printing tag" + Environment.NewLine + "Data Returned:" + Environment.NewLine + manufactured;
                                    txtQty.Text = string.Empty;
                                    break;
                            }
                        }
                        else
                        {
                            st = new StackTrace(0, true);
                            msgStr = "No data was returned from the server";
                            errInfo = "No data was returned from the server";
                            ExHandler.showErrorST(st, msgStr, errInfo);
                            txtQty.Text = string.Empty;
                        }
                    }
                    else
                    {
                        msg = new frmMsg("invalid Quantity", "The quantity entered would exceed the total quantity of the job", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtQty.Text = string.Empty;
                    }
                }
                else
                {
                    msg = new frmMsg("No quantity", "Please enter a pallet quantity", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                    txtQty.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
                txtQty.Text = string.Empty;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = new ucPrintType(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
