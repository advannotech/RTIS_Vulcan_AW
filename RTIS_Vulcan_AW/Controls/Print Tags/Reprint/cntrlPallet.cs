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
    public partial class cntrlPallet : UserControl
    {
        public string palletNum { get; set; }
        public string palletCode { get; set; }
        public string code { get; set; }
        public string lot { get; set; }
        public string qty { get; set; }
        public bool selected { get; set; }
        ucPalletList parent { get; set; }
        public cntrlPallet(string _palletNum, string _palletCode, string _code, string _lot, string _qty, ucPalletList _parent)
        {
            InitializeComponent();
            palletNum = _palletNum;
            palletCode = _palletCode;
            code = _code;
            lot = _lot;
            qty = _qty;
            parent = _parent;
        }
        private void cntrlPallet_Load(object sender, EventArgs e)
        {
            lblPalletNo.Text = palletNum;
            lblItemCode.Text = code;
            lblLot.Text = lot;
            lblQty.Text = qty;
        }
        private void lblPalletNo_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }                
            }
            catch (Exception)
            {

            }
        }

        private void lblItemCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblLot_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblQty_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }     
    }
}
