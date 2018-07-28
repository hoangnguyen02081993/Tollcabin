using Microsoft.DirectX.DirectSound;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using Tollcabin.My;

namespace Tollcabin
{
    public class VoicePhone
    {
        public delegate void StatusEventHandler(int TrangThai, string NamesConnect);

        public enum TrangThai
        {
            Busy,
            EndCall,
            Connected,
            Error_
        }

        private bool flagClose;

        private Socket SocketConnect;

        private bool flagSrarting;

        private UdpClient udpSend;

        private UdpClient udpRecive;

        private const int ListenPort = 15123;

        private const int PortChuDongSendData = 15345;

        private const int PortBiDongSendData = 15346;

        private int countKiemTra;

        private string TenMayDangGoi;

        private IPEndPoint send_Com;

        private IPEndPoint recive_Com;

        public const string _EndCall = "ENDCALL";

        public const string _Busy = "BUSY";

        public const string _OnCall = "ONCALL";

        public const string _OK = "OK";

        private StatusEventHandler StatusEvent;

        private string NamesPhone;

        private CaptureBufferDescription captureBufferDescription;

        private AutoResetEvent autoResetEvent;

        private Notify notify;

        private WaveFormat waveFormat;

        private Capture cap;

        private int bufferSize;

        private CaptureBuffer captureBuffer;

        private Device device;

        private SecondaryBuffer playbackBuffer;

        private BufferDescription playbackBufferDescription;

        private byte[] byteData;

        public bool TrangThaiKetNoi => flagSrarting;

        public event StatusEventHandler Status
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            add
            {
                StatusEvent = (StatusEventHandler)Delegate.Combine(StatusEvent, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [DebuggerNonUserCode]
            remove
            {
                StatusEvent = (StatusEventHandler)Delegate.Remove(StatusEvent, value);
            }
        }

        public bool Initialize(Form MainForm, string Names)
        {
            checked
            {
                try
                {
                    NamesPhone = Names;
                    device = new Device();
                    device.SetCooperativeLevel(MainForm, CooperativeLevel.Normal);
                    CaptureDevicesCollection captureDevicesCollection = new CaptureDevicesCollection();
                    cap = new Capture(captureDevicesCollection[0].DriverGuid);
                    short num = 1;
                    short num2 = 16;
                    int num3 = 22050;
                    waveFormat = new WaveFormat();
                    waveFormat.Channels = num;
                    waveFormat.FormatTag = WaveFormatTag.Pcm;
                    waveFormat.SamplesPerSecond = num3;
                    waveFormat.BitsPerSample = num2;
                    waveFormat.BlockAlign = (short)Math.Round(unchecked((double)num * ((double)num2 / 8.0)));
                    waveFormat.AverageBytesPerSecond = waveFormat.BlockAlign * num3;
                    captureBufferDescription = new CaptureBufferDescription();
                    captureBufferDescription.BufferBytes = (int)Math.Round(unchecked((double)waveFormat.AverageBytesPerSecond / 5.0));
                    captureBufferDescription.Format = waveFormat;
                    playbackBufferDescription = new BufferDescription();
                    playbackBufferDescription.BufferBytes = (int)Math.Round(unchecked((double)waveFormat.AverageBytesPerSecond / 5.0));
                    playbackBufferDescription.Format = waveFormat;
                    playbackBufferDescription.ControlEffects = true;
                    playbackBufferDescription.GlobalFocus = true;
                    playbackBuffer = new SecondaryBuffer(playbackBufferDescription, device);
                    bufferSize = captureBufferDescription.BufferBytes;
                    Thread thread = new Thread(Process);
                    thread.Start();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    bool result = false;
                    ProjectData.ClearProjectError();
                    return result;
                }
                return true;
            }
        }

        private void Send()
        {
            try
            {
                captureBuffer = new CaptureBuffer(captureBufferDescription, cap);
                CreateNotifyPositions();
                int num = checked((int)Math.Round(unchecked((double)bufferSize / 2.0)));
                captureBuffer.Start(true);
                bool flag = true;
                int bufferStartingLocation = 0;
                MemoryStream memoryStream = new MemoryStream(num);
                while (flagSrarting)
                {
                    autoResetEvent.WaitOne();
                    memoryStream.Seek(0L, SeekOrigin.Begin);
                    captureBuffer.Read(bufferStartingLocation, memoryStream, num, LockFlag.None);
                    flag = !flag;
                    bufferStartingLocation = ((!flag) ? num : 0);
                    byte[] buffer = memoryStream.GetBuffer();
                    udpSend.Send(buffer, buffer.Length, send_Com);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            finally
            {
                captureBuffer.Stop();
                captureBuffer.Dispose();
                udpSend.Close();
            }
        }

        private void Receive()
        {
            try
            {
                playbackBuffer = new SecondaryBuffer(playbackBufferDescription, device);
                while (flagSrarting)
                {
                    byte[] array = udpRecive.Receive(ref recive_Com);
                    byte[] array2 = new byte[checked(array.Length + 1)];
                    array2 = array;
                    playbackBuffer.Dispose();
                    playbackBuffer = new SecondaryBuffer(playbackBufferDescription, device);
                    playbackBuffer.Write(0, array2, LockFlag.None);
                    playbackBuffer.Play(0, BufferPlayFlags.Default);
                }
                playbackBuffer.Dispose();
                udpRecive.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            finally
            {
            }
        }

        private void CreateNotifyPositions()
        {
            checked
            {
                try
                {
                    autoResetEvent = new AutoResetEvent(false);
                    notify = new Notify(captureBuffer);
                    BufferPositionNotify bufferPositionNotify = new BufferPositionNotify();
                    bufferPositionNotify.Offset = (int)Math.Round(unchecked((double)bufferSize / 2.0 - 1.0));
                    bufferPositionNotify.EventNotifyHandle = autoResetEvent.SafeWaitHandle.DangerousGetHandle();
                    BufferPositionNotify bufferPositionNotify2 = new BufferPositionNotify();
                    bufferPositionNotify2.Offset = bufferSize - 1;
                    bufferPositionNotify2.EventNotifyHandle = autoResetEvent.SafeWaitHandle.DangerousGetHandle();
                    notify.SetNotificationPositions(new BufferPositionNotify[2]
                    {
                    bufferPositionNotify,
                    bufferPositionNotify2
                    });
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void KiemTra()
        {
            checked
            {
                while (true)
                {
                    if (flagSrarting)
                    {
                        if (countKiemTra < 3)
                        {
                            Thread.Sleep(1000);
                            countKiemTra++;
                            Sendata("ONCALL");
                            continue;
                        }
                        break;
                    }
                    return;
                }
                flagSrarting = false;
                countKiemTra = 0;
                try
                {
                    udpRecive.Close();
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    ProjectData.ClearProjectError();
                }
                try
                {
                    udpSend.Close();
                }
                catch (Exception ex3)
                {
                    ProjectData.SetProjectError(ex3);
                    Exception ex4 = ex3;
                    ProjectData.ClearProjectError();
                }
                flagSrarting = false;
                countKiemTra = 0;
                StatusEventHandler statusEvent = StatusEvent;
                statusEvent?.Invoke(1, TenMayDangGoi);
            }
        }

        public void Process()
        {
            try
            {
                while (true)
                {
                    IL_0000:
                    SocketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    SocketConnect.Blocking = true;
                    IPHostEntry hostEntry = Dns.GetHostEntry(MyProject.Computer.Name);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array = addressList;
                    IPAddress address = default(IPAddress);
                    foreach (IPAddress iPAddress in array)
                    {
                        if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            address = iPAddress;
                            break;
                        }
                    }
                    IPEndPoint localEP = new IPEndPoint(address, 15123);
                    SocketConnect.Bind(localEP);
                    SocketConnect.Listen(10);
                    while (true)
                    {
                        try
                        {
                            Socket socket = SocketConnect.Accept();
                            if (socket.Connected)
                            {
                                Thread thread = new Thread(delegate (object a0)
                                {
                                    XuLyData((Socket)a0);
                                });
                                thread.Start(socket);
                            }
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            Exception ex2 = ex;
                            if (!flagClose)
                            {
                                ProjectData.ClearProjectError();
                                goto IL_0000;
                            }
                            ProjectData.ClearProjectError();
                            return;
                        }
                    }
                }
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                ProjectData.ClearProjectError();
            }
        }

        public void XuLyData(Socket sock)
        {
            string text = "";
            try
            {
                byte[] array = new byte[1025];
                sock.ReceiveTimeout = 3000;
                int length = sock.Receive(array, array.Length, SocketFlags.None);
                text = Encoding.ASCII.GetString(array, 0, array.Length);
                string text2 = text.Substring(0, length);
                string left = text2;
                if (Operators.CompareString(left, "ENDCALL", false) == 0)
                {
                    flagSrarting = false;
                    countKiemTra = 0;
                    try
                    {
                        udpRecive.Close();
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        ProjectData.ClearProjectError();
                    }
                    try
                    {
                        udpSend.Close();
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        ProjectData.ClearProjectError();
                    }
                    flagSrarting = false;
                    countKiemTra = 0;
                    StatusEventHandler statusEvent = StatusEvent;
                    statusEvent?.Invoke(1, TenMayDangGoi);
                }
                else if (Operators.CompareString(left, "BUSY", false) == 0)
                {
                    StatusEventHandler statusEvent = StatusEvent;
                    statusEvent?.Invoke(0, TenMayDangGoi);
                }
                else if (Operators.CompareString(left, "ONCALL", false) == 0)
                {
                    countKiemTra = 0;
                }
                else if (Operators.CompareString(left, "OK", false) == 0)
                {
                    flagSrarting = true;
                    IPHostEntry hostEntry = Dns.GetHostEntry(TenMayDangGoi);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array2 = addressList;
                    IPAddress address = default(IPAddress);
                    foreach (IPAddress iPAddress in array2)
                    {
                        if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            address = iPAddress;
                            break;
                        }
                    }
                    udpSend = new UdpClient();
                    udpRecive = new UdpClient(15346);
                    send_Com = new IPEndPoint(address, 15345);
                    recive_Com = new IPEndPoint(address, 15346);
                    Thread thread = new Thread(Send);
                    thread.Start();
                    Thread thread2 = new Thread(Receive);
                    thread2.Start();
                    Thread thread3 = new Thread(KiemTra);
                    thread3.Start();
                    StatusEventHandler statusEvent = StatusEvent;
                    statusEvent?.Invoke(2, TenMayDangGoi);
                }
                else if (flagSrarting)
                {
                    Sendata("BUSY");
                }
                else
                {
                    TenMayDangGoi = text2;
                    flagSrarting = true;
                    Sendata("OK");
                    udpSend = new UdpClient();
                    udpRecive = new UdpClient(15345);
                    IPHostEntry hostEntry2 = Dns.GetHostEntry(TenMayDangGoi);
                    IPAddress[] addressList2 = hostEntry2.AddressList;
                    IPAddress[] array3 = addressList2;
                    IPAddress address2 = default(IPAddress);
                    foreach (IPAddress iPAddress2 in array3)
                    {
                        if (iPAddress2.AddressFamily == AddressFamily.InterNetwork)
                        {
                            address2 = iPAddress2;
                            break;
                        }
                    }
                    send_Com = new IPEndPoint(address2, 15346);
                    recive_Com = new IPEndPoint(address2, 15345);
                    Thread thread4 = new Thread(Send);
                    thread4.Start();
                    Thread thread5 = new Thread(Receive);
                    thread5.Start();
                    Thread thread6 = new Thread(KiemTra);
                    thread6.Start();
                    StatusEventHandler statusEvent = StatusEvent;
                    statusEvent?.Invoke(2, TenMayDangGoi);
                }
            }
            catch (Exception ex5)
            {
                ProjectData.SetProjectError(ex5);
                Exception ex6 = ex5;
                ProjectData.ClearProjectError();
            }
            sock.Close();
        }

        public void CallVoid(string ComputerName)
        {
            TenMayDangGoi = ComputerName;
            Sendata(MyProject.Computer.Name);
        }

        public void EndCall()
        {
            flagSrarting = false;
            countKiemTra = 0;
            try
            {
                udpRecive.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            try
            {
                udpSend.Close();
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                ProjectData.ClearProjectError();
            }
            flagSrarting = false;
            countKiemTra = 0;
            try
            {
                Sendata("ENDCALL");
            }
            catch (Exception ex5)
            {
                ProjectData.SetProjectError(ex5);
                Exception ex6 = ex5;
                ProjectData.ClearProjectError();
            }
            StatusEventHandler statusEvent = StatusEvent;
            statusEvent?.Invoke(1, TenMayDangGoi);
        }

        public void Sendata(string data)
        {
            Thread thread = new Thread(delegate (object a0)
            {
                SENDDDD(Conversions.ToString(a0));
            });
            thread.Start(data);
        }

        private void SENDDDD(string data)
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry hostEntry = Dns.GetHostEntry(TenMayDangGoi);
                IPAddress[] addressList = hostEntry.AddressList;
                IPAddress[] array = addressList;
                IPAddress address = default(IPAddress);
                foreach (IPAddress iPAddress in array)
                {
                    if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        address = iPAddress;
                        break;
                    }
                }
                IPEndPoint remoteEP = new IPEndPoint(address, 15123);
                socket.SendTimeout = 1000;
                socket.Connect(remoteEP);
                byte[] bytes = Encoding.ASCII.GetBytes(data);
                socket.Send(bytes, bytes.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                StatusEventHandler statusEvent = StatusEvent;
                statusEvent?.Invoke(3, "Kết nối bị lỗi.");
                ProjectData.ClearProjectError();
            }
        }

        public void close()
        {
            if (flagSrarting)
            {
                EndCall();
            }
            flagSrarting = false;
            flagClose = true;
            SocketConnect.Close();
        }

        public VoicePhone()
        {
            flagClose = false;
            flagSrarting = false;
            countKiemTra = 0;
            TenMayDangGoi = "";
            NamesPhone = "";
            byteData = new byte[1024];
        }
    }
}
