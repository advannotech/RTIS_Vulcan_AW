using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace RTIS_Vulcan_AW.Classes
{
    public class GlobalVars
    {
        public static string sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public static Control lastControl;
        public static string RSCFolder = string.Empty;
        public static string SettingsDB = string.Empty;
        public static string Printer = string.Empty;
        public static TextEdit focusedEdit = new TextEdit();
        public enum msgState { Error, Success, Question, First, Info }
        public static string userName { get; set; }

        public static string lotLookupPeriod { get; set; }

        #region Settings
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static string awWhse { get; set; }
        public static string awIT { get; set; }
        public static string configLoc { get; set; }
        public static string awLoc { get; set; }

        public static XtraReport configTag { get; set; }
        public static XtraReport awTag { get; set; }
        #endregion

        #region Open Job
        public static string  OJItemCode { get; set; }
        public static string OJLotNumber { get; set; }
        public static string OJPGMCode { get; set; }
        public static string OJPGMLot { get; set; }
        public static string OJPGMWeight { get; set; }
        public static string OJPGMWhse { get; set; }
        #endregion

        #region Reprint Job Tags
        public static string RPItemCode { get; set; }
        public static string RPLotNumber { get; set; }
        public static string RPPGMCode { get; set; }
        public static string RPPGMLot { get; set; }
        public static string RPJobNumber { get; set; }
        #endregion

        #region Print Product Tags
        public static string PTJobNo { get; set; }
        public static string PTItemCode { get; set; }
        public static string PTLotNumber { get; set; }
        public static string PTPGMCode { get; set; }
        public static string PTJPGMLot { get; set; }
        public static string PTJobQty { get; set; }
        public static string PTManufQty { get; set; }
        #endregion

        #region Close Job
        public static string CJJobNo { get; set; }
        public static string CJItemCode { get; set; }
        public static string CJLotNumber { get; set; }
        public static string CJPGMCode { get; set; }
        public static string CJPGMLot { get; set; }
        public static string CJJobQty { get; set; }
        public static string CJManufQty { get; set; }
        #endregion

        #region Reopen Job
        public static string ROJobNumber { get; set; }
        public static string ROItemCode { get; set; }
        public static string ROLotNumber { get; set; }
        public static string ROPGMCode { get; set; }
        public static string ROPGMLot { get; set; }
        public static string ROJobQty { get; set; }
        public static string ROManufQty { get; set; }
        #endregion
    }
}
