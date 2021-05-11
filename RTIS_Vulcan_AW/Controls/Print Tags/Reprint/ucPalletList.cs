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

namespace RTIS_Vulcan_AW.Controls
{
    public partial class ucPalletList : UserControl
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

        public ucPalletList(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucPalletList_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getItems();
            if (pnlItems.Height < pnlParent.Height)
            {
                vsbFG.Visible = false;
                pnlItems.Dock = DockStyle.Fill;
            }
            else
            {
                vsbFG.Visible = true;
                vsbFG.BringToFront();
                pnlItems.Parent = pnlParent;
                pnlItems.Height = pnlItems.Height + 80;
                vsbFG.Maximum = pnlItems.Height - pnlParent.Height;
                vsbFG.LargeChange = vsbFG.Maximum / 6;
            }
        }
        public void getItems()
        {
            try
            {
                string pallets = Client.GetReprintTags(GlobalVars.PTJobNo);
                switch (pallets.Split('*')[0])
                {
                    case "1":
                        pallets = pallets.Remove(0, 2);
                        string[] allPallets = pallets.Split('~');
                        foreach (string item in allPallets)
                        {
                            if (item != string.Empty)
                            {
                                string palletNo = item.Split('|')[0];
                                string palletCode = item.Split('|')[1];
                                string itemCode = item.Split('|')[2];
                                string lotNum = item.Split('|')[3];
                                string qty = item.Split('|')[4];
                                cntrlPallet PalletItem = new cntrlPallet(palletNo, palletCode, itemCode, lotNum, qty, this);
                                PalletItem.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(PalletItem);
                            }
                        }
                        break;
                    case "0":
                        pallets = pallets.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", pallets, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        pallets = pallets.Remove(0, 3);
                        errMsg = pallets.Split('|')[0];
                        errInfo = pallets.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        pallets = pallets.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", pallets, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving pallet list for job";
                        errInfo = "Unexpected error while retreiving pallet list for job" + Environment.NewLine + "Data Returned:" + Environment.NewLine + pallets;
                        break;
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
                ucScanConfig_PT scanTag = new ucScanConfig_PT(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(scanTag);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            try
            {
                string palletNo = string.Empty;
                string palletCode = string.Empty;
                string Code = string.Empty;
                string lot = string.Empty;
                string qty = string.Empty;

                bool found = false;
                foreach (cntrlPallet item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        palletNo = item.palletNum;
                        palletCode = item.palletCode;
                        Code = item.code;
                        lot = item.lot;
                        qty = item.qty;
                    }
                }

                string labelInfo = Client.GetRerintTagInfo(Code + "|" + GlobalVars.PTJobNo);
                if (labelInfo != string.Empty)
                {
                    switch (labelInfo.Split('*')[0])
                    {
                        case "1":
                            string tagInfo = labelInfo.Remove(0, 2).Split('~')[0];
                            string unq = labelInfo.Split('~')[1];

                            string itemCode = tagInfo.Split('|')[0];
                            string barcode = tagInfo.Split('|')[1];
                            string simpleCode = tagInfo.Split('|')[2];
                            string binLocation = tagInfo.Split('|')[3];
                            string description1 = tagInfo.Split('|')[4];
                            string description2 = tagInfo.Split('|')[5];
                            string description3 = tagInfo.Split('|')[6];
                            string group = tagInfo.Split('|')[7];

                            XtraReport printLabel = GlobalVars.awTag;

                            printLabel.Parameters["_JobNo"].Value = GlobalVars.PTJobNo;
                            printLabel.Parameters["_ItemCode"].Value = itemCode;
                            printLabel.Parameters["_Lot"].Value = GlobalVars.PTLotNumber;
                            printLabel.Parameters["_Qty"].Value = qty;
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

                            break;
                        case "0":
                            labelInfo = labelInfo.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", labelInfo, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            labelInfo = labelInfo.Remove(0, 3);
                            errMsg = labelInfo.Split('|')[0];
                            errInfo = labelInfo.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            labelInfo = labelInfo.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", labelInfo, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while retreiving label information";
                            errInfo = "Unexpected error while retreiving label information" + Environment.NewLine + "Data Returned:" + Environment.NewLine + labelInfo;
                            break;
                    }
                }
                else
                {
                    st = new StackTrace(0, true);
                    msgStr = "No data was returned from the server";
                    errInfo = "No data was returned from the server";
                    ExHandler.showErrorST(st, msgStr, errInfo);
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
