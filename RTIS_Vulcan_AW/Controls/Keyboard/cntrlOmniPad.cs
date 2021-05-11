using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RTIS_Vulcan_AW.Classes;

namespace RTIS_Vulcan_AWW.Controls
{
    public partial class cntrlOmniPad : UserControl
    {
        public bool isUpper = false;

        public cntrlOmniPad()
        {
            InitializeComponent();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            if (isUpper == false)
            {
                isUpper = true;              
                allToUpper();
                btnCase.Text = btnCase.Text.ToUpper();
            }
            else
            {
                isUpper = false;
                allToLower();
                btnCase.Text = btnCase.Text.ToLower();
            }
        }

        public void allToUpper()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is SimpleButton)
                    {
                        item.Text = item.Text.ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        public void allToLower()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is SimpleButton)
                    {
                        item.Text = item.Text.ToLower();
                    }
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
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

        private void btnQ_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "Q" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "q" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "W" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "w" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "E" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "e" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "R" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "r" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "T" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "t" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "Y" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "t" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "U" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "u" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "I" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "i" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "O" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "o" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "P" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "p" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "A" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "a" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "S" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "s" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "D" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "d" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "F" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "f" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "G" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "g" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "H" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "h" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "J" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "j" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "K" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "k" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "L" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "l" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "Z" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "z" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "X" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "x" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "C" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "c" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "V" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "v" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "B" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "b" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "N" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "n" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            if (isUpper == true)
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "M" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
            else
            {
                GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "m" + GlobalVars.focusedEdit.Text.Substring(index);
                GlobalVars.focusedEdit.SelectionStart = index + 1;
            }
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + " " + GlobalVars.focusedEdit.Text.Substring(index);
            GlobalVars.focusedEdit.SelectionStart = index + 1;
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            int index = GlobalVars.focusedEdit.SelectionStart;
            GlobalVars.focusedEdit.Text = GlobalVars.focusedEdit.Text.Substring(0, index) + "-" + GlobalVars.focusedEdit.Text.Substring(index);
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
                    //GlobalVars.focusedEdit.Focus();
                    //GlobalVars.focusedEdit.SelectionStart = index + 1;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
