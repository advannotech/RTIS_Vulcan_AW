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
using RTIS_Vulcan_AW.Controls.Settings;
using RTIS_Vulcan_AW.Controls.General;

namespace RTIS_Vulcan_AW.Controls
{
    public partial class ucLogin : UserControl
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
        public ucLogin(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucLogin_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            txtPassword.Focus();
            GlobalVars.focusedEdit = txtPassword;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            GlobalVars.lastControl = this;
            try
            {
                ucPassword pass = new ucPassword(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(pass);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = Client.Login(txtPassword.Text);
                if (login != string.Empty)
                {
                    switch (login.Split('*')[0])
                    {
                        case "1":
                            login = login.Remove(0, 2);
                            GlobalVars.userName = login;
                            main.lblUsername.Text = login;

                            GlobalVars.lastControl = this;
                            try
                            {
                                ucMenu menu = new ucMenu(parent, main);
                                main.pnlMain.Controls.Clear();
                                main.pnlMain.Controls.Add(menu);
                            }
                            catch (Exception ex)
                            {
                                ExHandler.showErrorEx(ex);
                            }
                            break;
                        case "0":
                            login = login.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", login, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            login = login.Remove(0, 3);
                            errMsg = login.Split('|')[0];
                            errInfo = login.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            login = login.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", login, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while logging in";
                            errInfo = "Unexpected error while logging in" + Environment.NewLine + "Data Returned:" + Environment.NewLine + login;
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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtPassword;
        }
    }
}
