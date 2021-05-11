using RTIS_Vulcan_AW.Classes;
using RTIS_Vulcan_AW.Controls;
using RTIS_Vulcan_AW.Controls.Settings;
using RTIS_Vulcan_AW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_AW
{
    public partial class frmMain : Form
    {
        public string returnString { get; set; }
        public string errMsg = string.Empty;
        public string errInfo = string.Empty;
        public frmMsg msg;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrBat.Start();
            tmrWifi.Start();

            lblDT.Text = DateTime.Now.ToString("dd/MM/yy hh:mm");
            lblVersion.Text = Application.ProductVersion.ToString();
            lblUsername.Text = "Reltech";

            GlobalVars.RSCFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\RSC";
            GlobalVars.SettingsDB = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\RSC\\SettingDB.db3";
            string init = SQLite.InitSettingsDB();
            switch (init.Split('*')[0])
            {
                case "1":
                    string labelInitialized = Labels.setupConfigTag();
                    switch (labelInitialized.Split('*')[0])
                    {
                        case "1":
                            //Label Initialized
                            break;
                        case "0":
                            labelInitialized = labelInitialized.Remove(0, 2);
                            msg = new frmMsg("Config tag not found", labelInitialized, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            labelInitialized = labelInitialized.Remove(0, 3);
                            errMsg = labelInitialized.Split('|')[0];
                            errInfo = labelInitialized.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        default:
                            StackTrace st2 = new StackTrace(0, true);
                            string msgStr2 = "Unexpected error initializing zect config tag";
                            string infoStr2 = "Unexpected error initializing zect config tag";
                            ExHandler.showErrorST(st2, msgStr2, infoStr2);
                            Application.Exit();
                            break;
                    }

                    string awLabelInitialized = Labels.setupAWTag();
                    switch (awLabelInitialized.Split('*')[0])
                    {
                        case "1":
                            //Label Initialized
                            break;
                        case "0":
                            awLabelInitialized = awLabelInitialized.Remove(0, 2);
                            msg = new frmMsg("ZECT tag not found", awLabelInitialized, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            awLabelInitialized = awLabelInitialized.Remove(0, 3);
                            errMsg = awLabelInitialized.Split('|')[0];
                            errInfo = awLabelInitialized.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        default:
                            StackTrace st3 = new StackTrace(0, true);
                            string msgStr3 = "Unexpected error initializing labels";
                            string infoStr3 = "Unexpected error initializing labels";
                            ExHandler.showErrorST(st3, msgStr3, infoStr3);
                            Application.Exit();
                            break;
                    }

                    ucLogin login = new ucLogin(pnlMain, this);
                    pnlMain.Controls.Add(login);
                    break;
                case "0":
                    this.Width = 0;
                    returnString = "0";
                    msg = new frmMsg(string.Empty, string.Empty, GlobalVars.msgState.First);
                    msg.ShowDialog();
                    ucSettings settings2 = new ucSettings(pnlMain, this);
                    pnlMain.Controls.Add(settings2);
                    break;
                case "-1":
                    this.Width = 0;
                    returnString = "-1";
                    init = init.Split('*')[1];
                    errMsg = init.Split('|')[0];
                    errInfo = init.Split('|')[1];
                    ExHandler.showErrorStr(errMsg, errInfo);
                    break;
                default:
                    this.Width = 0;
                    returnString = "-1";
                    StackTrace st = new StackTrace(0, true);
                    string msgStr = "Unexpected error initializing db";
                    string infoStr = "Unexpected error initializing db";
                    ExHandler.showErrorST(st, msgStr, infoStr);
                    Application.Exit();
                    break;
            }
        }
        private void tmrBat_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrBat.Stop();
                lblDT.Text = DateTime.Now.ToString("dd/MM/yy hh:mm");
                string messaeg = string.Empty;

                PowerStatus status = SystemInformation.PowerStatus;
                float percent = (status.BatteryLifePercent * 100);
                BatteryChargeStatus powerLevel = status.BatteryChargeStatus;
                string charging = status.PowerLineStatus.ToString();

                if (charging == "Online")
                {
                    if (percent > 90)
                    {
                        pbxBattery.Image = Properties.Resources.chargefull;
                    }
                    else if (percent <= 90 && percent >= 70)
                    {
                        pbxBattery.Image = Properties.Resources.chargeafull;
                    }
                    else if (percent <= 70 && percent >= 50)
                    {
                        pbxBattery.Image = Properties.Resources.chargeahalf;
                    }
                    else if (percent <= 50 && percent >= 30)
                    {
                        pbxBattery.Image = Properties.Resources.chargehalf;
                    }
                    else if (percent <= 30 && percent >= 20)
                    {
                        pbxBattery.Image = Properties.Resources.chargeaempty;
                    }
                    else if (percent <= 20)
                    {
                        pbxBattery.Image = Properties.Resources.chargeempty;
                    }
                }
                else
                {
                    if (percent > 90)
                    {
                        pbxBattery.Image = Properties.Resources.levelfull;
                    }
                    else if (percent <= 90 && percent >= 70)
                    {
                        pbxBattery.Image = Properties.Resources.levelafull;
                    }
                    else if (percent <= 70 && percent >= 50)
                    {
                        pbxBattery.Image = Properties.Resources.levelahalf;
                    }
                    else if (percent <= 50 && percent >= 30)
                    {
                        pbxBattery.Image = Properties.Resources.levelhalf;
                    }
                    else if (percent <= 30 && percent >= 20)
                    {
                        pbxBattery.Image = Properties.Resources.levelaempty;
                    }
                    else if (percent <= 20)
                    {
                        pbxBattery.Image = Properties.Resources.levelempty;
                    }
                }
                tmrBat.Start();
            }
            catch (Exception)
            {

            }
        }

        private void tmrWifi_Tick(object sender, EventArgs e)
        {
            int sigStrength = Convert.ToInt32(WifiChecker.getSignal());
            if (sigStrength > 70)
            {
                pbXWifi.Image = Properties.Resources.signalhigh;
            }
            else if (sigStrength <= 70 && sigStrength >= 40)
            {
                pbXWifi.Image = Properties.Resources.signalmedium;
            }
            else if (sigStrength < 40 && sigStrength >= 1)
            {
                pbXWifi.Image = Properties.Resources.signallow;
            }
            else
            {
                pbXWifi.Image = Properties.Resources.notfound2;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlMain.Controls.Count != 0)
                {
                    GlobalVars.lastControl = pnlMain.Controls[0];
                }
                ucPassword settings = new ucPassword(pnlMain, this);
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(settings);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
