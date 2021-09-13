using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_AW.Forms;
using System.Diagnostics;
using RTIS_Vulcan_AW.Classes;
using RTIS_Vulcan_AW.Controls.General;
using RTIS_Vulcan_AWW.Controls;

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class ucManualClose : UserControl
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

        public ucManualClose(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucManualClose_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlOmniPad omni = new cntrlOmniPad();
            omni.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(omni);

            txtLot.Focus();
            GlobalVars.focusedEdit = txtLot;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var response = Convert.ToInt32(Client.AWManualCloseJob(GlobalVars.focusedEdit.Text));
            if (Convert.ToBoolean(response))
            {
                msg = new frmMsg("Success", "The job has been closed successfully", GlobalVars.msgState.Success);
                msg.ShowDialog();
                this.RouteToMenu();
            }
            else
            {
                msg = new frmMsg("Error", "The job could not be closed. Check if you have entered the correct Lot number", GlobalVars.msgState.Error);
                msg.ShowDialog();
            }
        }
        public void RouteToMenu()
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

        private void txtLot_KeyDown(object sender, KeyEventArgs e)
        {
            GlobalVars.focusedEdit = txtLot;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.RouteToMenu();
        }
    }
}
