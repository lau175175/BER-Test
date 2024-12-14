using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;  // TCP模块
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCom
{
    public class SocketCommunication
    {

        #region 参数定义声明
        private Socket socket;  //Socket类型的变量，用于与服务器建立连接，进行数据发送和接收。
        private string serverAddress;  //用于保存服务器的 IP 地址或主机名。
        private int serverPort;  //用于保存服务器的端口号。
        private const int BufferSize = 1024;
        // 这个常量用来定义网络通信中的缓冲区大小，即每次接收或发送的数据块的大小为 1024 字节。
        private int connectFlag = 0;  // 判断TCP是否打开的标志位
        public StringBuilder receivedData = new StringBuilder(); // 用来拼接所有接收到的数据
        // List<String> receivedData = new List<String>();

        public int connectFlagFuc
        {
            get { return connectFlag;}
            set { connectFlag = value;}
        }
        #endregion

        #region 初始化函数 TCP参数获取
        public void Initialize(string serverAddress, int serverPort)  //构建函数 
        {
            this.serverAddress = serverAddress;
            //使用 this 关键字将传入的参数 serverAddress 的值赋给类的成员变量 serverAddress。
            this.serverPort = serverPort;  //将传入的参数 serverPort 的值赋给类的成员变量 serverPort。
        }
        #endregion

        // 连接到远程设备**********************************************************************************
        #region TCP Connect
        public async Task Connect()  //socket连接方法, async是异步的关键字
        {
            try
            {
                // 创建一个Socket对象
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                /*AddressFamily.InterNetwork 指定地址族为InterNetwork，即IPv4。地址族
                SocketType.Stream 指定套接字类型为Stream，这通常用于TCP协议。会话类型
                ProtocolType.Tcp：指定协议类型为Tcp，即传输控制协议。协议类型*/

                // 获取服务器的IP地址
                IPAddress ipAddress = IPAddress.Parse(serverAddress);
                IPEndPoint endPoint = new IPEndPoint(ipAddress, serverPort);  //生成的是一个对象
                // socket.Listen(0);  //监听连接

                var connectTask = Task.Run(() => socket.ConnectAsync(endPoint));  //ConnectAsync异步执行
                var timeoutTask = Task.Delay(5000);  //创建timeout线程 5s

                var completeTask = await Task.WhenAny(connectTask, timeoutTask);  //await 异步等待先执行完成的Task

                // 连接到远程设备，打开TCP连接
                if (completeTask == connectTask && socket.Connected)  //判断是不是connectTask被执行了，且socket连接成功
                {
                    connectFlagFuc = 1;  //检查连接状态，并将bool值赋值给标志位
                                                                          // Console.WriteLine("Connected to the device at {0}:{1}", serverAddress, serverPort);
               
                    MessageBox.Show($"Connected to the device at {serverAddress}:{serverPort}:{connectFlag} success!",
                        "Connection Status", // 弹窗的标题
                        MessageBoxButtons.OK,  // 按钮的标题
                        MessageBoxIcon.Information);  // 弹窗的图标
                 
                }

                else  // 如果是执行的延时线程，则提示信息
                {
                    connectFlagFuc = 0;
                    MessageBox.Show("Connect time out， check address！",
                        "Connect Statu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error connecting to the server: " + ex.Message);
                MessageBox.Show("Error: " + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        // 发送数据到远程设备***************************************************************************
        #region TCP SendData
        public void SendData(string data)
        {
            try
            {
                if (socket == null || !socket.Connected) //判断是否打开TCP连接
                {
                    //Console.WriteLine("Socket is not connected.");
                    return;
                }

                // 将数据转换为字节数组
                byte[] dataBytes = Encoding.UTF8.GetBytes(data);  //通过UTF8 反编码要发送的数据

                // 发送数据
                socket.Send(dataBytes);  //发送数据
                // BitConverter.ToString(dataBytes);  // byte转字符串
                /*MessageBox.Show(
                    data,
                    "send info"
                    );*/
                // Console.WriteLine("Data sent: {0}", data);
            }
            catch (Exception ex)  //异常捕捉
            {
                // Console.WriteLine("Error sending data: " + ex.Message);
                MessageBox.Show("send error: " + ex, "send status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // 接收数据从远程设备
        #region TCP ReceiveData
        public async Task<StringBuilder> ReceiveData() // 返回接收到的字符串，用于BER的接收,[async Task<String>,有返回值的异步方法接收定义]
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    return null; // 如果没有连接，返回null，return null被执行后，后面while不会被执行
                }

                byte[] buffer = new byte[BufferSize];
                int bytesReceived;

                while (true)
                {
                    // 接收数据
                    bytesReceived = await Task.Run(() => socket.Receive(buffer));  // 接收数据存储到buffer，同步返回buffer count

                    await Task.Delay(10);
                    if (bytesReceived == 0)
                    {
                        break; // 如果接收的数据为空，跳出循环
                    }

                    // 将接收到的字节转换为字符串并拼接到receivedData
                    string chunk = Encoding.UTF8.GetString(buffer, 0, bytesReceived);  //解码接收到的字节

                    receivedData.Append(chunk); // 拼接接收到的数据
                    break;
                }

                // MessageBox.Show(receivedData.ToString(), "Device info");
                // 返回接收到的所有数据
                return receivedData;
            }
            catch (SocketException ex)
            {
                // 弹出消息框显示错误信息
                MessageBox.Show("Socket error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // 如果发生Socket异常，返回null
            }
            catch (Exception ex)
            {
                // 弹出消息框显示错误信息
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // 如果发生其他异常，返回null
            }
            /*finally
            {
                // 如果发生异常或连接关闭，关闭socket连接
                Close();
            }*/
        }
        #endregion

        #region TCP Close
        // 关闭socket连接
        public void  Close()
        {
            try
            {
                if (socket != null && socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();  //关闭 TCP
                    connectFlag = 0;  //检查连接状态，并将bool值赋值给标志位
                    MessageBox.Show("Connection closed",
                        "Connect Statu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("close error: " + ex, "close error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
