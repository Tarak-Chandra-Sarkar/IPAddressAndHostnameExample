using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressAndHostnameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = "127.0.0.1";
            var hostname = Dns.GetHostName();
            Console.WriteLine("This computer's Hostname is "+hostname);

            var ipHostEntry = Dns.GetHostEntry(ip);
            Console.WriteLine("This computer's Hostname of ip address "+ipHostEntry.HostName);

            var ipAddresses = Dns.GetHostAddresses(ipHostEntry.HostName);
            foreach (var ipAddress in ipAddresses)
            {
                if (ipAddress.AddressFamily== System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    Console.WriteLine("IPv4 Address is " + ipAddress);
                }
                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                {
                    Console.WriteLine("IPv6 Address is " + ipAddress);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
