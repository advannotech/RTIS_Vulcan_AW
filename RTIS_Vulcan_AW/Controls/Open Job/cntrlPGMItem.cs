using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_AW.Controls.Open_Job
{
    public partial class cntrlPGMItem : UserControl
    {
        public string itemCode { get; set; }
        public string lotNumber { get; set; }
        public string qty { get; set; }
        public string whseCode { get; set; }
        ucSelectPGM parent { get; set; }
        public bool selected { get; set; }
        public cntrlPGMItem(string _itemCode, string _lotNumber, string _qty, string _whseCode, ucSelectPGM _parent)
        {
            InitializeComponent();
            itemCode = _itemCode;
            lotNumber = _lotNumber;
            qty = _qty;
            parent = _parent;
            whseCode = _whseCode;
        }

        private void cntrlPGMItem_Load(object sender, EventArgs e)
        {
            lblItem.Text = itemCode;
            lblLotNumber.Text = lotNumber;
        }

        private void lblLotNumber_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblLotNumber.BackColor = Color.LightBlue;
                lblItem.BackColor = Color.LightBlue;
                foreach (cntrlPGMItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
                    }

                }

                foreach (cntrlPGMItem item in parent.pnlItemsIT.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
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
                lblLotNumber.BackColor = Color.LightBlue;
                lblItem.BackColor = Color.LightBlue;
                foreach (cntrlPGMItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
                    }

                }

                foreach (cntrlPGMItem item in parent.pnlItemsIT.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
        private void lblItem_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblLotNumber.BackColor = Color.LightBlue;
                lblItem.BackColor = Color.LightBlue;
                foreach (cntrlPGMItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
                    }

                }

                foreach (cntrlPGMItem item in parent.pnlItemsIT.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                        item.lblItem.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
