using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;

namespace CServer
{
    class Program
    {
        public static IPAddress ipAddress = IPAddress.Parse("localhost");
        static void Main(string[] args)
        {
            HttpListener myList = new HttpListener();
            myList.Prefixes.Add("http://localhost:8000");
            myList.Start();

            //Display that the server is running
            Console.WriteLine("Server running - Port: 8000");
            Console.WriteLine("Local end point:" + myList.Prefixes);
            Console.WriteLine("Waiting for connections...");

            
            //HttpListenerContext client = myList.GetContext();
            // When accepted
            //Console.WriteLine("Connection accepted from " + client.);
            
            //byte[] b = new byte[100];
            //int k = client. (b);
            //Console.WriteLine("Recieved...");
            //for (int i = 0; i < k; i++)
            //    {
            //    Console.Write(Convert.ToChar(b[i]));
            //    }

            //ASCIIEncoding asen = new ASCIIEncoding();
            //s.Send(asen.GetBytes("Automatic message:" + "String received by server!"));
            //Console.WriteLine("\n Automatic message sent!");

            //s.Close();
            //myList.Stop();
        }
    }
}
