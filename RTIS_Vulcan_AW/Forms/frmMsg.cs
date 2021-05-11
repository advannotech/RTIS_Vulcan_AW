using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RTIS_Vulcan_AW.Classes.GlobalVars;

namespace RTIS_Vulcan_AW.Forms
{
    public partial class frmMsg : Form
    {
        string titel = string.Empty;
        string msg = string.Empty;
        msgState state;
        public frmMsg(string _titel, string _msg, msgState _state)
        {
            InitializeComponent();
            titel = _titel;
            msg = _msg;
            state = _state;
        }
        private void frmMsg_Load(object sender, EventArgs e)
        {
            xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            switch (state)
            {
                case msgState.Error:
                    if (titel.Length < 39)
                    {
                        lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        lblError.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    }
                    else
                    {
                        lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                        lblError.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
                    }
                    lblError.Text = titel;
                    meError.Text = msg;
                    xtcMain.SelectedTabPage = xtpError;                   
                    break;
                case msgState.Success:
                    lblSuc.Text = msg;
                    xtcMain.SelectedTabPage = xtpSuccess;
                    break;
                case msgState.Question:
                    lblQuest.Text = msg;
                    xtcMain.SelectedTabPage = xtpQuestion;
                    break;
                case msgState.First:
                    xtcMain.SelectedTabPage = xtpVir;
                    break;
                case msgState.Info:
                    lblInfoMsg.Text = msg;
                    lblInfoHeader.Text = titel;
                    xtcMain.SelectedTabPage = xtpInfo;
                    break;
                default:
                    break;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSucOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVirOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfoOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
