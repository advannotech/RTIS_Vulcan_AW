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
    public partial class ucSelectReopnLot : UserControl
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
        public ucSelectReopnLot(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucSelectReopnLot_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getItemLots();
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

        public void getItemLots()
        {
            try
            {
                string lots = Client.getAWReOpneJobLots(GlobalVars.ROItemCode + "|" + GlobalVars.lotLookupPeriod);
                switch (lots.Split('*')[0])
                {
                    case "1":
                        lots = lots.Remove(0, 2);
                        string[] allLots = lots.Split('~');
                        foreach (string item in allLots)
                        {
                            if (item != string.Empty)
                            {
                                cntrlROLot lot = new cntrlROLot(item, this);
                                lot.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(lot);
                            }
                        }
                        break;
                    case "0":
                        lots = lots.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", lots, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        lots = lots.Remove(0, 3);
                        errMsg = lots.Split('|')[0];
                        errInfo = lots.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        lots = lots.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", lots, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving warehouse transfer processes";
                        errInfo = "Unexpected error while retreiving warehouse transfer processes" + Environment.NewLine + "Data Returned:" + Environment.NewLine + lots;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void vsbFG_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlItems.Location;
            p.Y = 0 - e.NewValue;
            pnlItems.Location = p;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucManualReOpen scan = new ucManualReOpen(parent, main);
                GlobalVars.lastControl = scan;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(scan);
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
                bool found = false;
                foreach (cntrlROLot item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.ROLotNumber = item.code;
                    }
                }

                string jobInfo = Client.getAWJobInfoManual(GlobalVars.ROItemCode + "|" + GlobalVars.ROLotNumber);
                if (jobInfo != string.Empty)
                {
                    switch (jobInfo.Split('*')[0])
                    {
                        case "1":
                            jobInfo = jobInfo.Remove(0, 2);
                            GlobalVars.ROItemCode = jobInfo.Split('|')[0];
                            GlobalVars.ROLotNumber = jobInfo.Split('|')[1];
                            GlobalVars.ROPGMCode = jobInfo.Split('|')[2];
                            GlobalVars.ROPGMLot = jobInfo.Split('|')[3];
                            GlobalVars.ROJobQty = jobInfo.Split('|')[4];
                            GlobalVars.ROManufQty = jobInfo.Split('|')[5];
                            GlobalVars.ROJobNumber = jobInfo.Split('|')[6];

                            ucReOpeninfo options = new ucReOpeninfo(parent, main);
                            GlobalVars.lastControl = options;
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(options);
                            break;
                        case "0":
                            jobInfo = jobInfo.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", jobInfo, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            jobInfo = jobInfo.Remove(0, 3);
                            errMsg = jobInfo.Split('|')[0];
                            errInfo = jobInfo.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            jobInfo = jobInfo.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", jobInfo, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while logging in";
                            errInfo = "Unexpected error while logging in" + Environment.NewLine + "Data Returned:" + Environment.NewLine + jobInfo;
                            ExHandler.showErrorST(st, msgStr, errInfo);
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
