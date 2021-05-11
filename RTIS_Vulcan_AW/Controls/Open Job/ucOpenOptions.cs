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
using RTIS_Vulcan_AW.Controls.General;
using RTIS_Vulcan_AW.Classes;

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class ucOpenOptions : UserControl
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

        public ucOpenOptions(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucOpenOptions_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }
        private void btnScanToOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ucScanToOpen scan = new ucScanToOpen(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(scan);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                ucMaunalOpen manual = new ucMaunalOpen(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(manual);
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
    }
}
