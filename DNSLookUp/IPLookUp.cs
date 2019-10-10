using System;
using System.Net;

namespace DNSLookUp
{
    class IPLookUp
    {
        static void Main(string[] args)
        {
            //IPAddress ip = IPAddress.Parse("127.0.0.1"); // Parse converts an IP-address string to an IPAddress instance.
            //Console.WriteLine("IP-address: " + ip);

            //string name = Dns.GetHostName(); // Gets the host name of the local computer.
            //Console.WriteLine("DNS Host Name: " + name);

            string name = "google.com";
            IPAddress[] addrs = Dns.GetHostEntry(name).AddressList;

            Console.WriteLine("Name: " + name);

            Console.WriteLine("IP-addresses: ");
            foreach (IPAddress ipAddress in addrs)
            {
                Console.WriteLine(ipAddress);
            }

            Console.WriteLine("ARGUMENTS TO MAIN");
            foreach (string argument in args)
            {
                Console.WriteLine(argument);
            }
        }
    }
}
