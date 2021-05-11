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
    public partial class ucSelectPGM : UserControl
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
        public ucSelectPGM(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucSelectPGM_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getWIPItems();
            if (pnlItems.Height < pnlParent.Height)
            {
                vsbrM.Visible = false;
                pnlItems.Dock = DockStyle.Fill;
            }
            else
            {
                vsbrM.Visible = true;
                vsbrM.BringToFront();
                pnlItems.Parent = pnlParent;
                pnlItems.Height = pnlItems.Height + 80;
                vsbrM.Maximum = pnlItems.Height - pnlParent.Height;
                vsbrM.LargeChange = vsbrM.Maximum / 6;
            }

            getITItems();
            if (pnlItemsIT.Height < pnlParent.Height)
            {
                vsbRM2.Visible = false;
                pnlItemsIT.Dock = DockStyle.Fill;
            }
            else
            {
                vsbRM2.Visible = true;
                vsbRM2.BringToFront();
                pnlItemsIT.Parent = pnlParent;
                pnlItemsIT.Height = pnlItemsIT.Height + 80;
                vsbRM2.Maximum = pnlItemsIT.Height - pnlParent.Height;
                vsbRM2.LargeChange = vsbRM2.Maximum / 6;
            }

        }
        public void getWIPItems()
        {
            try
            {
                string pgms = Client.getRawMaterials(GlobalVars.OJItemCode + "|" + GlobalVars.awWhse);
                switch (pgms.Split('*')[0])
                {
                    case "1":
                        pgms = pgms.Remove(0, 2);
                        string[] allPgms = pgms.Split('~');
                        foreach (string item in allPgms)
                        {
                            if (item != string.Empty)
                            {
                                cntrlPGMItem PGM = new cntrlPGMItem(item.Split('|')[0], item.Split('|')[1], item.Split('|')[2], GlobalVars.awWhse, this);
                                PGM.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(PGM);
                            }
                        }
                        break;
                    case "0":
                        pgms = pgms.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", pgms, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        pgms = pgms.Remove(0, 3);
                        errMsg = pgms.Split('|')[0];
                        errInfo = pgms.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        pgms = pgms.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", pgms, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving data";
                        errInfo = "Unexpected error while retreiving data" + Environment.NewLine + "Data Returned:" + Environment.NewLine + pgms;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void vsbrM_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlItems.Location;
            p.Y = 0 - e.NewValue;
            pnlItems.Location = p;
        }
        public void getITItems()
        {
            try
            {
                string pgms = Client.getRawMaterials(GlobalVars.OJItemCode + "|" + GlobalVars.awIT);
                switch (pgms.Split('*')[0])
                {
                    case "1":
                        pgms = pgms.Remove(0, 2);
                        string[] allPgms = pgms.Split('~');
                        foreach (string item in allPgms)
                        {
                            if (item != string.Empty)
                            {
                                cntrlPGMItem PGM = new cntrlPGMItem(item.Split('|')[0], item.Split('|')[1], item.Split('|')[2], GlobalVars.awIT, this);
                                PGM.Dock = DockStyle.Top;
                                pnlItemsIT.Controls.Add(PGM);
                            }
                        }
                        break;
                    case "0":
                        pgms = pgms.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", pgms, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        pgms = pgms.Remove(0, 3);
                        errMsg = pgms.Split('|')[0];
                        errInfo = pgms.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        pgms = pgms.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", pgms, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving data";
                        errInfo = "Unexpected error while retreiving data" + Environment.NewLine + "Data Returned:" + Environment.NewLine + pgms;
                        ExHandler.showErrorST(st, msgStr, errInfo);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void vsbRM2_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlItemsIT.Location;
            p.Y = 0 - e.NewValue;
            pnlItems.Location = p;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (cntrlPGMItem item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.OJPGMCode = item.itemCode;
                        GlobalVars.OJPGMLot = item.lotNumber;
                        GlobalVars.OJPGMWeight = item.qty;
                        GlobalVars.OJPGMWhse = item.whseCode;
                    }
                }

                foreach (cntrlPGMItem item in pnlItemsIT.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.OJPGMCode = item.itemCode;
                        GlobalVars.OJPGMLot = item.lotNumber;
                        GlobalVars.OJPGMWeight = item.qty;
                        GlobalVars.OJPGMWhse = item.whseCode;
                    }
                }

                if (found == true)
                {
                    ucJobQty jobQty = new ucJobQty(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(jobQty);
                }
                else
                {
                    msg = new frmMsg("Cannot Continue", "Please select a PGM", GlobalVars.msgState.Error);
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
    }
}
