using System;
using System.Net;
using System.Threading.Tasks;

using System.Net.Sockets;
using NetCoreFrame.Core.CommonHelper;
using System.Threading;
using System.Text;

namespace NetCoreFrame.SocketConsole
{
    internal class Program
    {
        static Socket serverSocket;
        static Socket serverSocket2;
        static void Main(string[] args)
        {
            Console.WriteLine("启动成功!");
           
            Task.Run(() =>
            {
                Console.WriteLine("启动一个Socket服务端");

                int port = Convert.ToInt32(6009);
                string host ="192.168.0.114";//服务器端ip地址

                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);

                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(ipe);
                serverSocket.Listen(10);
                Console.WriteLine("等待客户端连接...");
                LogHelper.WriteLogs("等待客户端连接...");
                try
                {
                    ThreadPool.QueueUserWorkItem(state => ListenClientSocket()); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Socket Error:" + ex.Message);
                }
                finally
                {
                    // serverSocket.Close(); 
                }
            });
            Task.Run(() =>
            {
                Console.WriteLine("启动一个Socket服务端2");

                int port = Convert.ToInt32(7009);
                string host = "192.168.0.114";//服务器端ip地址

                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);

                serverSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket2.Bind(ipe);
                serverSocket2.Listen(10); 
                try
                {
                    ThreadPool.QueueUserWorkItem(state => ListenClientSocket2());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Socket Error:" + ex.Message);
                }
                finally
                {
                    // serverSocket.Close(); 
                }
            });
            Console.WriteLine("运行中请勿关闭！");
            Console.ReadLine();
        }

        static void ListenClientSocket()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                Console.WriteLine("6009连接已建立....");
                #region 消息回发
                byte[] sendByte = Encoding.ASCII.GetBytes("success!");
                clientSocket.Send(sendByte, sendByte.Length, 0);
                #endregion

                #region 连接客户端，解析数据,多线程
                ThreadPool.QueueUserWorkItem(state => ReceiveSocket(clientSocket)); 
                #endregion

            }
        }
        static void ListenClientSocket2()
        {
            while (true)
            {
                Socket clientSocket = serverSocket2.Accept();
                Console.WriteLine("7009连接已建立....");
                #region 消息回发
                byte[] sendByte = Encoding.ASCII.GetBytes("success!");
                clientSocket.Send(sendByte, sendByte.Length, 0);
                #endregion

                #region 连接客户端，解析数据,多线程
                ThreadPool.QueueUserWorkItem(state => ReceiveSocket2(clientSocket));
                #endregion

            }
        }

        static void ReceiveSocket(object clientsocket)
        {
            Socket myclientSocket = (Socket)clientsocket;
            while (true)
            {
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = myclientSocket.Receive(recBytes, recBytes.Length, 0);

                recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
                string RetMsg = $"客户端:{myclientSocket.RemoteEndPoint.ToString()},消息：{recStr},时间:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                LogHelper.WriteLogs($"Receive Message：{RetMsg}");
                //业务代码
            }
        }
        static void ReceiveSocket2(object clientsocket)
        {
            Socket myclientSocket = (Socket)clientsocket;
            while (true)
            {
                string recStr = "";
                byte[] recBytes = new byte[4096];
                int bytes = myclientSocket.Receive(recBytes, recBytes.Length, 0);

                recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
                string RetMsg = $"客户端:{myclientSocket.RemoteEndPoint.ToString()},消息：{recStr},时间:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
                LogHelper.WriteLogs($"Receive Message：{RetMsg}");
                //业务代码
            }
        }
    }


    
}
