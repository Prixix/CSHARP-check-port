using System;
using System.Net.Sockets;

namespace Check_Port
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public static bool CheckOnlineState(String hostname, int port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(hostname, port);
                    Console.WriteLine("Connection open");
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Connection closed");
                    return false;
                }
            }
        }
    }
}
