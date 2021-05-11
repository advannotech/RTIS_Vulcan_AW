using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIS_Vulcan_AW.Classes
{
    class Barcodes
    {
        public static string GetItemCode(string Barcode)
        {
            try
            {
                string itemcode = "";
                Barcode = Barcode.Replace("(", "*");
                Barcode = Barcode.Replace(")", "~");
                string[] Items = Barcode.Split('*');
                foreach (string item in Items)
                {
                    if (item != "")
                    {
                        if (item.Split('~')[0] == "240")
                        {
                            itemcode = item.Split('~')[1].TrimEnd();
                            break;
                        }
                    }
                }
                return itemcode;
            }
            catch (Exception)
            {
                return "NONE";
            }
        }
        public static string GetItemLot(string Barcode)
        {
            try
            {
                string itemlot = "";
                Barcode = Barcode.Replace("(", "*");
                Barcode = Barcode.Replace(")", "~");
                string[] Items = Barcode.Split('*');
                foreach (string item in Items)
                {
                    if (item != "")
                    {
                        if (item.Split('~')[0] == "10")
                        {
                            itemlot = item.Split('~')[1].TrimEnd();
                            break;
                        }
                    }
                }
                return itemlot;
            }
            catch (Exception)
            {
                return "NONE";
            }
        }
        public static string GetItemQty(string Barcode)
        {
            try
            {
                string itemqty = "";
                Barcode = Barcode.Replace("(", "*");
                Barcode = Barcode.Replace(")", "~");
                string[] Items = Barcode.Split('*');
                foreach (string item in Items)
                {
                    if (item != "")
                    {
                        if (item.Split('~')[0] == "30")
                        {
                            itemqty = item.Split('~')[1].TrimStart('0');
                            break;
                        }
                    }
                }
                return itemqty;
            }
            catch (Exception)
            {
                return "0";
            }
        }
        public static string GetUniqCode(string Barcode)
        {
            try
            {
                string uniq = "";
                Barcode = Barcode.Replace("(", "*");
                Barcode = Barcode.Replace(")", "~");
                string[] Items = Barcode.Split('*');
                foreach (string item in Items)
                {
                    if (item != "")
                    {
                        if (item.Split('~')[0] == "90")
                        {
                            uniq = item.Split('~')[1].TrimEnd();
                            break;
                        }
                    }
                }
                return uniq;
            }
            catch (Exception)
            {
                return "0";
            }
        }
    }
}
