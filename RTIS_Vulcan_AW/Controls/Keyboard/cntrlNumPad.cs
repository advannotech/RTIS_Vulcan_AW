using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_AW.Classes;

namespace RTIS_Vulcan_AW.Controls
{
    public partial class cntrlNumPad : UserControl
    {
        public cntrlNumPad()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "1" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "2" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "3" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "4" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "5" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "6" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "7" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "8" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "9" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "0" + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVars.focusedEdit.Text.Length != 0)
                {
                    int index = GlobalVars.focusedEdit.SelectionStart;
                    GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Remove(GlobalVars.focusedEdit.SelectionStart - 1, 1);
                    GlobalVars.focusedEdit.Select(index - 1, 1);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text;
        }
    }
}
