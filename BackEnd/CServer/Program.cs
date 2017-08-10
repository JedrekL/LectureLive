using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CServer
{
    class Program
    {
        public static IPAddress ipAddress = IPAddress.Parse("167.220.100.62");
        static void Main(string[] args)
        {
            TcpListener myList = new TcpListener(ipAdress, 8000);
            
            //Display that the server is running
            Console.WriteLine("Server running - Port: 8000");
            Console.WriteLine("Local end point:" + myList.LocalEndpoint);
            Console.WriteLine("Waiting for connections...");

            Socket s = myList.AcceptSocket();

        }
    }
}
