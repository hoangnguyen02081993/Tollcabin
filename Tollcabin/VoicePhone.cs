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
using System.Threading.Tasks;
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

        private VoicePhone.StatusEventHandler StatusEvent;

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

        public event VoicePhone.StatusEventHandler Status
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.StatusEvent = (VoicePhone.StatusEventHandler)Delegate.Combine(this.StatusEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.StatusEvent = (VoicePhone.StatusEventHandler)Delegate.Remove(this.StatusEvent, value);
            }
        }

        public bool TrangThaiKetNoi
        {
            get
            {
                return this.flagSrarting;
            }
        }

        public bool Initialize(Form MainForm, string Names)
        {
            checked
            {
                try
                {
                    this.NamesPhone = Names;
                    this.device = new Device();
                    this.device.SetCooperativeLevel(MainForm.Handle, Microsoft.DirectX.DirectSound.CooperativeLevel.Normal);
                    CaptureDevicesCollection captureDevicesCollection = new CaptureDevicesCollection();
                    this.cap = new Capture(captureDevicesCollection[0].DriverGuid);
                    short num = 1;
                    short num2 = 16;
                    int num3 = 22050;
                    this.waveFormat = new WaveFormat();
                    this.waveFormat.Channels = num;
                    this.waveFormat.FormatTag = WaveFormatTag.Pcm;
                    this.waveFormat.SamplesPerSecond = num3;
                    this.waveFormat.BitsPerSample = num2;
                    this.waveFormat.BlockAlign = (short)Math.Round(unchecked((double)num * ((double)num2 / 8.0)));
                    this.waveFormat.AverageBytesPerSecond = (int)this.waveFormat.BlockAlign * num3;
                    this.captureBufferDescription = new CaptureBufferDescription();
                    this.captureBufferDescription.BufferBytes = (int)Math.Round((double)this.waveFormat.AverageBytesPerSecond / 5.0);
                    this.captureBufferDescription.Format = this.waveFormat;
                    this.playbackBufferDescription = new BufferDescription();
                    this.playbackBufferDescription.BufferBytes = (int)Math.Round((double)this.waveFormat.AverageBytesPerSecond / 5.0);
                    this.playbackBufferDescription.Format = this.waveFormat;
                    this.playbackBufferDescription.ControlEffects = true;
                    this.playbackBufferDescription.GlobalFocus = true;
                    this.playbackBuffer = new SecondaryBuffer(this.playbackBufferDescription, this.device);
                    this.bufferSize = this.captureBufferDescription.BufferBytes;
                    Thread thread = new Thread(new ThreadStart(this.Process));
                    thread.Start();
                }
                catch (Exception expr_1A4)
                {
                    ProjectData.SetProjectError(expr_1A4);
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
                this.captureBuffer = new CaptureBuffer(this.captureBufferDescription, this.cap);
                this.CreateNotifyPositions();
                int num = checked((int)Math.Round((double)this.bufferSize / 2.0));
                this.captureBuffer.Start(true);
                bool flag = true;
                int num2 = 0;
                MemoryStream memoryStream = new MemoryStream(num);
                while (this.flagSrarting)
                {
                    this.autoResetEvent.WaitOne();
                    memoryStream.Seek(0L, SeekOrigin.Begin);
                    this.captureBuffer.Read(num2, memoryStream, num, 0);
                    flag = !flag;
                    num2 = (flag ? 0 : num);
                    byte[] buffer = memoryStream.GetBuffer();
                    this.udpSend.Send(buffer, buffer.Length, this.send_Com);
                }
            }
            catch (Exception expr_AA)
            {
                ProjectData.SetProjectError(expr_AA);
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.captureBuffer.Stop();
                this.captureBuffer.Dispose();
                this.udpSend.Close();
            }
        }

        private void Receive()
        {
            try
            {
                this.playbackBuffer = new SecondaryBuffer(this.playbackBufferDescription, this.device);
                while (this.flagSrarting)
                {
                    byte[] array = this.udpRecive.Receive(ref this.recive_Com);
                    byte[] array2 = new byte[checked(array.Length + 1)];
                    array2 = array;
                    this.playbackBuffer.Dispose();
                    this.playbackBuffer = new SecondaryBuffer(this.playbackBufferDescription, this.device);
                    this.playbackBuffer.Write(0, array2, 0);
                    this.playbackBuffer.Play(0, 0);
                }
                this.playbackBuffer.Dispose();
                this.udpRecive.Close();
            }
            catch (Exception expr_95)
            {
                ProjectData.SetProjectError(expr_95);
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
                    this.autoResetEvent = new AutoResetEvent(false);
                    this.notify = new Notify(this.captureBuffer);
                    BufferPositionNotify bufferPositionNotify = new BufferPositionNotify();
                    bufferPositionNotify.Offset = (int)Math.Round(unchecked((double)this.bufferSize / 2.0 - 1.0));
                    bufferPositionNotify.EventNotifyHandle = this.autoResetEvent.SafeWaitHandle.DangerousGetHandle();
                    BufferPositionNotify bufferPositionNotify2 = new BufferPositionNotify();
                    bufferPositionNotify2.Offset = this.bufferSize - 1;
                    bufferPositionNotify2.EventNotifyHandle = this.autoResetEvent.SafeWaitHandle.DangerousGetHandle();
                    this.notify.SetNotificationPositions(new BufferPositionNotify[]
                    {
                        bufferPositionNotify,
                        bufferPositionNotify2
                    });
                }
                catch (Exception expr_BF)
                {
                    ProjectData.SetProjectError(expr_BF);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void KiemTra()
        {
            checked
            {
                while (this.flagSrarting)
                {
                    if (this.countKiemTra >= 3)
                    {
                        this.flagSrarting = false;
                        this.countKiemTra = 0;
                        try
                        {
                            this.udpRecive.Close();
                        }
                        catch (Exception expr_31)
                        {
                            ProjectData.SetProjectError(expr_31);
                            ProjectData.ClearProjectError();
                        }
                        try
                        {
                            this.udpSend.Close();
                        }
                        catch (Exception expr_4C)
                        {
                            ProjectData.SetProjectError(expr_4C);
                            ProjectData.ClearProjectError();
                        }
                        this.flagSrarting = false;
                        this.countKiemTra = 0;
                        VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                        if (statusEvent != null)
                        {
                            statusEvent(1, this.TenMayDangGoi);
                        }
                        return;
                    }
                    Thread.Sleep(1000);
                    this.countKiemTra++;
                    this.Sendata("ONCALL");
                }
            }
        }

        public void Process()
        {
            checked
            {
                try
                {
                    while (true)
                    {
                        this.SocketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        this.SocketConnect.Blocking = true;
                        IPHostEntry hostEntry = Dns.GetHostEntry(MyProject.Computer.Name);
                        IPAddress[] addressList = hostEntry.AddressList;
                        IPAddress[] array = addressList;
                        IPAddress address = null;
                        for (int i = 0; i < array.Length; i++)
                        {
                            IPAddress iPAddress = array[i];
                            if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                            {
                                address = iPAddress;
                                break;
                            }
                        }
                        IPEndPoint localEP = new IPEndPoint(address, 15123);
                        this.SocketConnect.Bind(localEP);
                        this.SocketConnect.Listen(10);
                        while (true)
                        {
                            try
                            {
                                Socket socket = this.SocketConnect.Accept();
                                if (socket.Connected)
                                {
                                    Thread thread = new Thread(delegate (object a0)
                                    {
                                        this.XuLyData((Socket)a0);
                                    });
                                    thread.Start(socket);
                                }
                            }
                            catch (Exception expr_B8)
                            {
                                ProjectData.SetProjectError(expr_B8);
                                if (!this.flagClose)
                                {
                                    ProjectData.ClearProjectError();
                                    break;
                                }
                                ProjectData.ClearProjectError();
                                return;
                            }
                        }
                    }
                }
                catch (Exception expr_DB)
                {
                    ProjectData.SetProjectError(expr_DB);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public void XuLyData(Socket sock)
        {
            checked
            {
                try
                {
                    byte[] array = new byte[1025];
                    sock.ReceiveTimeout = 3000;
                    int length = sock.Receive(array, array.Length, SocketFlags.None);
                    string @string = Encoding.ASCII.GetString(array, 0, array.Length);
                    string text = @string.Substring(0, length);
                    string left = text;
                    if (Operators.CompareString(left, "ENDCALL", false) == 0)
                    {
                        this.flagSrarting = false;
                        this.countKiemTra = 0;
                        try
                        {
                            this.udpRecive.Close();
                        }
                        catch (Exception expr_6F)
                        {
                            ProjectData.SetProjectError(expr_6F);
                            ProjectData.ClearProjectError();
                        }
                        try
                        {
                            this.udpSend.Close();
                        }
                        catch (Exception expr_8B)
                        {
                            ProjectData.SetProjectError(expr_8B);
                            ProjectData.ClearProjectError();
                        }
                        this.flagSrarting = false;
                        this.countKiemTra = 0;
                        VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                        if (statusEvent != null)
                        {
                            statusEvent(1, this.TenMayDangGoi);
                        }
                    }
                    else if (Operators.CompareString(left, "BUSY", false) == 0)
                    {
                        VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                        if (statusEvent != null)
                        {
                            statusEvent(0, this.TenMayDangGoi);
                        }
                    }
                    else if (Operators.CompareString(left, "ONCALL", false) == 0)
                    {
                        this.countKiemTra = 0;
                    }
                    else if (Operators.CompareString(left, "OK", false) == 0)
                    {
                        this.flagSrarting = true;
                        IPHostEntry hostEntry = Dns.GetHostEntry(this.TenMayDangGoi);
                        IPAddress[] addressList = hostEntry.AddressList;
                        IPAddress[] array2 = addressList;
                        IPAddress address = null;
                        for (int i = 0; i < array2.Length; i++)
                        {
                            IPAddress iPAddress = array2[i];
                            if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                            {
                                address = iPAddress;
                                break;
                            }
                        }
                        this.udpSend = new UdpClient();
                        this.udpRecive = new UdpClient(15346);
                        this.send_Com = new IPEndPoint(address, 15345);
                        this.recive_Com = new IPEndPoint(address, 15346);
                        Thread thread = new Thread(new ThreadStart(this.Send));
                        thread.Start();
                        Thread thread2 = new Thread(new ThreadStart(this.Receive));
                        thread2.Start();
                        Thread thread3 = new Thread(new ThreadStart(this.KiemTra));
                        thread3.Start();
                        VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                        if (statusEvent != null)
                        {
                            statusEvent(2, this.TenMayDangGoi);
                        }
                    }
                    else if (this.flagSrarting)
                    {
                        this.Sendata("BUSY");
                    }
                    else
                    {
                        this.TenMayDangGoi = text;
                        this.flagSrarting = true;
                        this.Sendata("OK");
                        this.udpSend = new UdpClient();
                        this.udpRecive = new UdpClient(15345);
                        IPHostEntry hostEntry2 = Dns.GetHostEntry(this.TenMayDangGoi);
                        IPAddress[] addressList2 = hostEntry2.AddressList;
                        IPAddress[] array3 = addressList2;
                        IPAddress address2 = null;
                        for (int j = 0; j < array3.Length; j++)
                        {
                            IPAddress iPAddress2 = array3[j];
                            if (iPAddress2.AddressFamily == AddressFamily.InterNetwork)
                            {
                                address2 = iPAddress2;
                                break;
                            }
                        }
                        this.send_Com = new IPEndPoint(address2, 15346);
                        this.recive_Com = new IPEndPoint(address2, 15345);
                        Thread thread4 = new Thread(new ThreadStart(this.Send));
                        thread4.Start();
                        Thread thread5 = new Thread(new ThreadStart(this.Receive));
                        thread5.Start();
                        Thread thread6 = new Thread(new ThreadStart(this.KiemTra));
                        thread6.Start();
                        VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                        if (statusEvent != null)
                        {
                            statusEvent(2, this.TenMayDangGoi);
                        }
                    }
                }
                catch (Exception expr_349)
                {
                    ProjectData.SetProjectError(expr_349);
                    ProjectData.ClearProjectError();
                }
                sock.Close();
            }
        }

        public void CallVoid(string ComputerName)
        {
            this.TenMayDangGoi = ComputerName;
            this.Sendata(MyProject.Computer.Name);
        }

        public void EndCall()
        {
            this.flagSrarting = false;
            this.countKiemTra = 0;
            try
            {
                this.udpRecive.Close();
            }
            catch (Exception expr_1B)
            {
                ProjectData.SetProjectError(expr_1B);
                ProjectData.ClearProjectError();
            }
            try
            {
                this.udpSend.Close();
            }
            catch (Exception expr_36)
            {
                ProjectData.SetProjectError(expr_36);
                ProjectData.ClearProjectError();
            }
            this.flagSrarting = false;
            this.countKiemTra = 0;
            try
            {
                this.Sendata("ENDCALL");
            }
            catch (Exception expr_5F)
            {
                ProjectData.SetProjectError(expr_5F);
                ProjectData.ClearProjectError();
            }
            VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
            if (statusEvent != null)
            {
                statusEvent(1, this.TenMayDangGoi);
            }
        }

        public void Sendata(string data)
        {
            Thread thread = new Thread(delegate (object a0)
            {
                this.SENDDDD(Conversions.ToString(a0));
            });
            thread.Start(data);
        }

        private void SENDDDD(string data)
        {
            checked
            {
                try
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPHostEntry hostEntry = Dns.GetHostEntry(this.TenMayDangGoi);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array = addressList;
                    IPAddress address = null;
                    for (int i = 0; i < array.Length; i++)
                    {
                        IPAddress iPAddress = array[i];
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
                catch (Exception expr_84)
                {
                    ProjectData.SetProjectError(expr_84);
                    VoicePhone.StatusEventHandler statusEvent = this.StatusEvent;
                    if (statusEvent != null)
                    {
                        statusEvent(3, "Kết nối bị lỗi.");
                    }
                    ProjectData.ClearProjectError();
                }
            }
        }

        public void close()
        {
            if (this.flagSrarting)
            {
                this.EndCall();
            }
            this.flagSrarting = false;
            this.flagClose = true;
            this.SocketConnect.Close();
        }

        public VoicePhone()
        {
            this.flagClose = false;
            this.flagSrarting = false;
            this.countKiemTra = 0;
            this.TenMayDangGoi = "";
            this.NamesPhone = "";
            this.byteData = new byte[1024];
        }
    }
}
