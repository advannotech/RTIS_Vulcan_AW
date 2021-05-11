using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_AW.Controls
{
    public partial class cntrlRPLot : UserControl
    {
        public string code { get; set; }
        public bool selected { get; set; }
        ucRPSelectLotNumbers parent { get; set; }
        public cntrlRPLot(string _code, ucRPSelectLotNumbers _parent)
        {
            InitializeComponent();
            code = _code;
            parent = _parent;
        }
        private void cntrlRPLot_Load(object sender, EventArgs e)
        {
            lblLot.Text = code;
        }

        private void lblLot_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblLot.BackColor = Color.LightBlue;
                foreach (cntrlRPLot item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLot.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        private void pnlBack_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblLot.BackColor = Color.LightBlue;
                foreach (cntrlRPLot item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLot.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
