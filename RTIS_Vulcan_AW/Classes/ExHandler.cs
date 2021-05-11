using RTIS_Vulcan_AW.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RTIS_Vulcan_AW.Classes
{
    class ExHandler
    {
        public static void showErrorEx(Exception exc)
        {
            try
            {
                string msg = exc.Message;
                string info = string.Empty;
                StackTrace st = new StackTrace(exc, true);
                //StackFrame frame = st.GetFrame(0);
                string line = string.Empty;
                string name = string.Empty;
                string meth = string.Empty;
                foreach (StackFrame frame in st.GetFrames())
                {
                    try
                    {
                        line = frame.GetFileLineNumber().ToString();
                        name = frame.GetFileName().ToString();
                        meth = frame.GetMethod().ToString();
                    }
                    catch (Exception)
                    { }
                }
                info = "Method:" + Environment.NewLine + meth + Environment.NewLine + Environment.NewLine + "File: " + Environment.NewLine + name + Environment.NewLine + Environment.NewLine + "Line Number: " + Environment.NewLine + line + Environment.NewLine + Environment.NewLine + exc.ToString();
                frmError err = new frmError(msg, info);
                err.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RTIS Vulcan Error log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void showErrorST(StackTrace st, string msgStr, string infoStr)
        {
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            string file = sf.GetFileName();
            string line = sf.GetFileLineNumber().ToString();
            string name = sf.GetFileName().ToString();
            string meth = sf.GetMethod().ToString();
            infoStr += Environment.NewLine + Environment.NewLine + "Method:" + Environment.NewLine + meth + Environment.NewLine + Environment.NewLine + "File: " + Environment.NewLine + name + Environment.NewLine + Environment.NewLine + "Line Number: " + Environment.NewLine + line;
            frmError err = new frmError(msgStr, infoStr);
            err.ShowDialog();
        }
        public static void showErrorStr(string msg, string info)
        {
            frmError err = new frmError(msg, info);
            err.ShowDialog();
        }
        public static string returnErrorEX(Exception exc)
        {
            string msg = exc.Message;
            string info = string.Empty;
            StackTrace st = new StackTrace(exc, true);
            //StackFrame frame = st.GetFrame(0);
            string line = string.Empty;
            string name = string.Empty;
            string meth = string.Empty;
            foreach (StackFrame frame in st.GetFrames())
            {
                try
                {
                    line = frame.GetFileLineNumber().ToString();
                    name = frame.GetFileName().ToString();
                    meth = frame.GetMethod().ToString();
                }
                catch (Exception)
                { }
            }
            info = exc.ToString() + Environment.NewLine + Environment.NewLine + "Method:" + Environment.NewLine + meth + Environment.NewLine + Environment.NewLine + "File: " + Environment.NewLine + name + Environment.NewLine + Environment.NewLine + "Line Number: " + Environment.NewLine + line;
            string _return = "-1*" + msg + "|" + info;
            return _return;
        }
        public static string returnErrorST(StackTrace st, string msgStr, string infoStr)
        {
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            string file = sf.GetFileName();
            string line = sf.GetFileLineNumber().ToString();
            string name = sf.GetFileName().ToString();
            string meth = sf.GetMethod().ToString();
            infoStr += Environment.NewLine + Environment.NewLine + "Method:" + Environment.NewLine + meth + Environment.NewLine + Environment.NewLine + "File: " + Environment.NewLine + name + Environment.NewLine + Environment.NewLine + "Line Number: " + Environment.NewLine + line;
            return "-1*" + msgStr + "|" + infoStr;
        }
    }
}
