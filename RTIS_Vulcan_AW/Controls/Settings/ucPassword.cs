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
using RTIS_Vulcan_AW.Classes;

namespace RTIS_Vulcan_AW.Controls.Settings
{
    public partial class ucPassword : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;
        public frmMain main;
        Panel parent;
        public ucPassword(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            parent = _parent;
            main = _main;
        }

        private void ucPassword_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            txtPassword.Focus();
            GlobalVars.focusedEdit = txtPassword;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != string.Empty)
                {
                    if (txtPassword.Text == "62017")
                    {
                        ucSettings settings = new ucSettings(parent, main);
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(settings);
                    }
                    else
                    {
                        msg = new frmMsg("Error", "Please enter the correct password", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
                }
                else
                {
                    msg = new frmMsg("Error", "Please enter a password", GlobalVars.msgState.Error);
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
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtPassword;
        }
    }
}
