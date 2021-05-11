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
    public partial class frmConfirm : Form
    {
        public string msg { get; set; }
        public frmConfirm(string _msg)
        {
            InitializeComponent();
            msg = _msg;
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblConf.Text = msg;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
