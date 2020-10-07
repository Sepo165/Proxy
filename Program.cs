using System;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace Proxy
{
    class Programm
    {
        static void Main(string[] args)
        {
            Ping myPing = new Ping();
            PingReply pingReply = myPing.Send("IP");
            if (pingReply.Status == IPStatus.Success)
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyEnable", 0, RegistryValueKind.DWord);
            else
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "ProxyEnable", 1, RegistryValueKind.DWord);
        }
    }
}