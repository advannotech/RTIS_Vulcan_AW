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
using RTIS_Vulcan_AW.Controls.General;

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class ucJobQty : UserControl
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
        public ucJobQty(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucJobQty_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            lblItem.Text = GlobalVars.OJItemCode;
            lblLot.Text = GlobalVars.OJLotNumber;
            lblPGM.Text = GlobalVars.OJPGMCode;
            lblPGMLot.Text = GlobalVars.OJPGMLot;
        }
        private void txtQty_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtQty;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string jobOpened =string.Empty;
                if (GlobalVars.OJPGMWhse == GlobalVars.awIT)
                {
                    jobOpened = Client.startAWJobIT(GlobalVars.OJItemCode + "|" + GlobalVars.OJLotNumber + "|" + GlobalVars.OJPGMCode + "|" + GlobalVars.OJPGMLot + "|" + GlobalVars.OJPGMWeight + "|" + txtQty.Text + "|" + GlobalVars.userName + "|" + GlobalVars.awIT + "|" + GlobalVars.awWhse);
                }
                else
                {
                    jobOpened = Client.startAWJob(GlobalVars.OJItemCode + "|" + GlobalVars.OJLotNumber + "|" + GlobalVars.OJPGMCode + "|" + GlobalVars.OJPGMLot + "|" + txtQty.Text + "|" + GlobalVars.userName);
                }
                if (jobOpened != string.Empty)
                {
                    switch (jobOpened.Split('*')[0])
                    {
                        case "1":
                            string labelInfo = jobOpened.Remove(0, 2);
                            string barcode = jobOpened.Split('|')[0];
                            string simpleCode = jobOpened.Split('|')[2];
                            string bin = jobOpened.Split('|')[2];
                            string desc = jobOpened.Split('|')[3];
                            string desc2 = jobOpened.Split('|')[4];
                            string desc3 = jobOpened.Split('|')[5];
                            string group = jobOpened.Split('|')[6];
                            string jobNumber = jobOpened.Split('|')[7];

                            XtraReport printLabel = GlobalVars.configTag;

                            printLabel.Parameters["_barcode"].Value = barcode;
                            printLabel.Parameters["_bin"].Value = bin;
                            printLabel.Parameters["_Date"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                            printLabel.Parameters["_Description1"].Value = desc;
                            printLabel.Parameters["_Description2"].Value = desc2;
                            printLabel.Parameters["_Description3"].Value = desc3;
                            printLabel.Parameters["_Group"].Value = group;
                            printLabel.Parameters["_SimpleCode"].Value = simpleCode;

                            printLabel.Parameters["_ItemCode"].Value = GlobalVars.OJItemCode;
                            printLabel.Parameters["_Lot"].Value = GlobalVars.OJLotNumber;
                            printLabel.Parameters["_PGM"].Value = GlobalVars.OJPGMCode;
                            printLabel.Parameters["_PGMLot"].Value = GlobalVars.OJPGMLot;
                            printLabel.Parameters["_Qty"].Value = txtQty.Text;
                            printLabel.Parameters["_RT2D"].Value = jobNumber;

                            printLabel.CreateDocument();
                            ReportPrintTool prtTool = new ReportPrintTool(printLabel);
                            prtTool.PrinterSettings.Copies = Convert.ToInt16(2);
                            prtTool.Print(GlobalVars.Printer);

                            msg = new frmMsg("Success", "The job has been opened", GlobalVars.msgState.Success);
                            msg.ShowDialog();
                            ucMenu menu = new ucMenu(parent, main);
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(menu);
                            break;
                        case "0":
                            jobOpened = jobOpened.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", jobOpened, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            jobOpened = jobOpened.Remove(0, 3);
                            errMsg = jobOpened.Split('|')[0];
                            errInfo = jobOpened.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            jobOpened = jobOpened.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", jobOpened, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while printing job tags";
                            errInfo = "Unexpected error while printing job tags" + Environment.NewLine + "Data Returned:" + Environment.NewLine + jobOpened;
                            ExHandler.showErrorST(st, msgStr, errInfo);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucSelectPGM selectPGM = new ucSelectPGM(parent, main);
                GlobalVars.lastControl = selectPGM;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(selectPGM);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
