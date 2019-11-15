using System;
using System.Net.Sockets;
using System.Text;
using System.Net;

namespace Voiceless_Server
{
    class Listener
    {
        public static void MainLoop()
        {
            UdpClient listener = new UdpClient(Program.port);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, Program.port);

            while(true)
            {
                Console.WriteLine("Waiting for broadcast");
                byte[] bytes = listener.Receive(ref groupEP);
                
                Console.WriteLine($"Received broadcast from {groupEP} :");
                Console.WriteLine($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");
            }
        }
    }
}