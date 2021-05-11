using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_AW.Forms
{
    public partial class frmError : DevExpress.XtraEditors.XtraForm
    {
        string msg = string.Empty;
        string inform = string.Empty;
        public frmError(string _msg, string _inform)
        {
            InitializeComponent();
            msg = _msg;
            inform = _inform;
        }
        private void frmError_Load(object sender, EventArgs e)
        {
            meMsg.Text = msg + Environment.NewLine + Environment.NewLine + "For more information, please select the information tab.";
            meInfo.Text = inform;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
