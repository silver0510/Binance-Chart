using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Binance_Chart
{
    public class Authentication
    {
        
        
        /// <summary>
        /// Gets the MAC address of the current PC.
        /// </summary>
        /// <returns></returns>
        private static List<String> GetMacAddress()
        {
            List<String> lstMac = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces and Wifi
                //if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                //    nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                //{
                    lstMac.Add(nic.GetPhysicalAddress().ToString());
                //}
            }
            return lstMac;
        }

        /// <summary>
        /// Check Mac Registered
        /// </summary>
        public static bool checkMac()
        {
            List<string> registeredMacs = new List<string>();
            registeredMacs.Add("1B01041771C09");
            registeredMacs.Add("N5103H341C09");
            registeredMacs.Add("94SFM3771C09");

            registeredMacs.ForEach(mac => mac = mac.Trim('-'));

            List<string> lstMACIP = GetMacAddress();

            //Check list Mac IP with DB in server if registered then return for
            foreach(string mac in lstMACIP)
            {
                //check
                if (registeredMacs.Exists(registered => registered == mac)) return true;
            }

            return false;
        }
    }
}
