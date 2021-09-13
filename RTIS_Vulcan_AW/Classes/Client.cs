using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RTIS_Vulcan_AW.Classes
{
    class Client
    {
        #region General
        public static string Login(string pin)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWLOGIN*@" + pin);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getAWItemCode(string baseCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWITEMCODE*@" + baseCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Open Job
        public static string checkAWJobRunning()
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWJOBRUNNING*@");
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }      
        public static string getRawMaterials(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWITEMPGMS*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string startAWJob(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*OPENAWJOB*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string startAWJobIT(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*OPENAWJOBFROMIT*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Reprint Job Tags
        public static string getValidAWJobLots(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWJOBLOTS*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string GetReprintJobInfo(string jobTag)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWGETREPRINTJOBINFO*@" + jobTag);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetReprintJobLabelInfo(string jobTag)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETREREPRINTAWJOBLABElINFO*@" + jobTag);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetReprintLabelInfo(string itemCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETREREPRINTAWJOBLABElINFO*@" + itemCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        #endregion

        #region Print Product Tags
        public static string getAWJobDetails(string jobNumber)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWJOBINFO*@" + jobNumber);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string printAWJobTags(string jobNumber)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWLOGPALLETPRINTED*@" + jobNumber);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string GetReprintTags(string jobTag)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWGETREPRINTPALLETS*@" + jobTag);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        public static string GetRerintTagInfo(string jobTag)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWGETTAGREPRINTINFO*@" + jobTag);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        #endregion

        #region Close Job
        public static string getAWJobDetailsToCloseJob(string jobNumber)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWJOBINFOCJ*@" + jobNumber);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string CloseJob(string jobInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWCLOSEJOB*@" + jobInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }
        #endregion

        #region Reopen Job
        public static string getAWReOpneJobLots(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWREOPENJOBLOTS*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getAWJobInfoManual(string jobInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETMANUALREOPENINFO*@" + jobInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getAWJobInfo(string jobNumber)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETAWJOBINFORO*@" + jobNumber);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string reopenAWJob(string jobInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*REOPENAWJOB*@" + jobInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Manual Close   

        public static string AWManualCloseJob(string lot)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*AWMANUALCLOSEJOB*@" + lot);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*" + ex.Message;
            }
        }

        #endregion
    }
}
