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
using RTIS_Vulcan_AW.Controls.General;

namespace RTIS_Vulcan_AW.Controls
{
    public partial class ucRPScanSheet : UserControl
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

        public ucRPScanSheet(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucRPScanSheet_Load(object sender, EventArgs e)
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
                        GlobalVars.RPItemCode = txtItem.Text;
                        ucRPSelectLotNumbers lotNums = new ucRPSelectLotNumbers(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(lotNums);
                    }
                    else
                    {
                        msg = new frmMsg("No barcode", "Please scan the check sheet barcode", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
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
                GlobalVars.lastControl = new ucMenu(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
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
