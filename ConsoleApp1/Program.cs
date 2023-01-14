using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// Simple Example


//namespace ConsoleApp1
//{
//    public class Program
//    {


//        //static void Main(string[] args)
//        //{
//        //    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
//        //    var ipAddress = IPAddress.Parse("104.21.70.39"); // Google's IP Address
//        //    var port = 80;
//        //    IPEndPoint endPoint = new IPEndPoint(ipAddress, port);
//        //    try
//        //    {
//        //        socket.Connect(endPoint);
//        //        if(socket.Connected)
//        //        {
//        //            string str = $@"GET / HTTP / 1.1\r\nHost {ipAddress}\r\nConnection:
//        //                            Close\r\n\r\n";
//        //            var bytes = Encoding.ASCII.GetBytes(str);
//        //            socket.Send(bytes);

//        //            var length = 0;
//        //            var buffer = new byte[1500];
//        //            do
//        //            {
//        //                length = socket.Receive(buffer);
//        //                var response = Encoding.ASCII.GetString(buffer);
//        //                Console.WriteLine(response);
//        //            } while (length>0);
//        //        }
//        //    }
//        //    catch (Exception)
//        //    {

//        //        throw;
//        //    }
//        //}

//    }
//}




// Server Example

//namespace Server
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var ipAddress = IPAddress.Parse("10.2.11.129");
//            var port = 26000;
//            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                var endPoint = new IPEndPoint(ipAddress, port);
//                socket.Bind(endPoint);
//                socket.Listen(10);
//                Console.WriteLine($"Listen Over {socket.LocalEndPoint}");
//                while (true)
//                {
//                    var client = socket.Accept();
//                    Task.Run(() =>
//                    {
//                        Console.WriteLine($"{client.RemoteEndPoint} connected....");
//                        var length = 0;
//                        var bytes = new byte[1024];
//                        do
//                        {
//                            length = client.Receive(bytes);
//                            var msg = Encoding.UTF8.GetString(bytes, 0, length);
//                            Console.WriteLine($"Client : {client.RemoteEndPoint} : {msg}");
//                            if (msg == "Exit")
//                            {
//                                client.Shutdown(SocketShutdown.Both);
//                                client.Dispose();
//                                break;
//                            }
//                        } while (true);
//                    });
//                }
//            }

//        }
//    }
//}



//namespace Client
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//            var ipAddress = IPAddress.Parse("10.2.11.129");
//            var port = 27001;
//            var ep  = new IPEndPoint(ipAddress, port);
//            try
//            {
//                socket.Connect(ep);
//                if(socket.Connected)
//                {
//                    Console.WriteLine("Connected to server . . . ");
//                    while (true)
//                    {
//                        var msg = Console.ReadLine();
//                        var bytes = Encoding.UTF8.GetBytes(msg);
//                        socket.Send(bytes);
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("Can not connect to the server . . .");
//            }
//        }
//    }
//}