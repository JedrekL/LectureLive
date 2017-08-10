using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener httpListener = new HttpListener();
            Console.WriteLine("Connecting.....");
            httpListener. ("http://localhost:8000");
            

            // Use the ipaddress as in the server program
            Console.WriteLine("Connected...");
            Console.Write("Enter the string to be sent: ");

            //String str = Console.ReadLine();
            //Stream stm = tcpclnt.GetStream();

            //ASCIIEncoding asen = new ASCIIEncoding();
            //byte[] ba = asen.GetBytes(str);
            //Console.WriteLine("Sending...");
            //stm.Write(ba, 0, ba.Length);
            //byte[] bb = new byte[100];
            //int k = stm.Read(bb, 0, 100);
            //for (int i = 0; i < k; i++)
            //    {
            //    Console.Write(Convert.ToChar(bb[i]));
            //    }
        }
    }
}
