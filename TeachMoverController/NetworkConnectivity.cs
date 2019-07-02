using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
namespace ArmBot
{
    class NetworkConnectivity
    {
        public static bool Server(string ip, string message, string port)
        {
            bool check = false;
            IPAddress ipAddress = IPAddress.Parse(ip);
            int Port = int.Parse(port);
            IPEndPoint iedp = new IPEndPoint(ipAddress, Port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(iedp);
            server.Listen(10);
            byte[] data = Encoding.UTF8.GetBytes(message);
            Socket client = server.Accept();
            if (client.Connected)
            {
                while (client.Connected)
                {
                    client.Send(data); // data sent to the connected client
                }
            }
            else
            {
                Console.WriteLine("Error Occured");
            }

            server.Disconnect(true);
            return check;
        }

        public static bool Client(string ip,string message,string port)
        {
            bool check = false;
            IPAddress ipAddress = IPAddress.Parse(ip);
            int Port = int.Parse(port);
            IPEndPoint iedp = new IPEndPoint(ipAddress, Port);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iedp);
            if (client.Connected)
            {
              client.Send(Encoding.UTF8.GetBytes(message)); // got the data from the server
            }else
            {
                Console.WriteLine("Client could not connect to the server..");
            }
            client.Close();
            return check;
        }
    }
}