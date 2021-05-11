using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeWifi;

namespace RTIS_Vulcan_AW.Classes
{
    class WifiChecker
    {
        public static string getSignal()
        {
            WlanClient client = new WlanClient();
            try
            {
                string signalQuality = string.Empty;
                foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                    Wlan.Dot11Ssid ssid = wlanIface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
                    char[] _ssidChars = Encoding.ASCII.GetChars(ssid.SSID, 0, Convert.ToInt32(ssid.SSIDLength));
                    string _ssid = new string(_ssidChars);
                    Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                    foreach (Wlan.WlanAvailableNetwork network in networks)
                    {
                        if (network.networkConnectable == true)
                        {
                            if (network.profileName == _ssid)
                            {
                                signalQuality = network.wlanSignalQuality.ToString();
                            }
                        }
                    }
                }

                client.Dispose();
                if (signalQuality != string.Empty)
                {
                    return signalQuality;
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                client.Dispose();
                return "0";
            }
        }
    }
}
