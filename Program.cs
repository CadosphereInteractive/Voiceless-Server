using System;
using System.Threading;
using System.Net;

namespace Voiceless_Server
{
    class Program
    {
        public static string currentIP; 
        public static readonly int port = 31337;

        static void Main(string[] args)
        {
            // Prints out welome messages and covers some simple info
            WriteOut.PrintLine("Starting Voiceless server 2b046ed");
            WriteOut.PrintLine("Voiceless server started at => " + IPCode());
            WriteOut.PrintLine("Server listening at port *:" + port.ToString());

            Thread mainListener = new Thread(new ThreadStart(Listener.MainLoop));
            mainListener.Start();
        }

        private static string IPCode() 
        {
            string externalIP = new WebClient().DownloadString("http://ipinfo.io/ip");      
            string[] splitIP = externalIP.Split('.');
            string ipCode = "";

            foreach(string field in splitIP)
            {
                string tempString = IPBindings.Words[Int32.Parse(field)] + " ";
                ipCode += tempString;
            }

            currentIP = externalIP;
            return ipCode;  
        }
    }
}
