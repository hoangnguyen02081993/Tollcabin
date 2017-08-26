using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;
using System.IO.Ports;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Threading;

namespace Tollcabin
{
    [DesignerGenerated]
    public partial class UcController : UserControl
    {
        public enum TrangThaiPortVao
        {
            KhongKetNoi,
            CoxeVao,
            KhongCoXeVao
        }

        public delegate void ControllerErrorEventHandler(string Message);

        public delegate void InPortEventHandler(byte NumberPort, bool TrangThai);

        public delegate void CarOutEventHandler(int PhanLoaiXe);

        public delegate void EventTrangThaiVungTuVaoEventHandler(UcController.TrangThaiPortVao TrangThai);


        [AccessedThroughProperty("ComPort")]
        private SerialPort _ComPort;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        private const int L = 1;

        private const int S = 2;

        private const string STX = "$";

        private const string ETX = "#";

        private const string cmdMoBarrier = "B";

        private const string cmdDongBarrier = "A";

        private const string cmdMoLan = "D";

        private const string cmdDongLan = "C";

        private const string cmdMoCB = "G";

        private const string cmdTatCB = "H";

        private const string cmdModenHN = "E";

        private const string cmdTatDenHN = "F";

        private const string cmdPortRa = "I";

        private const string cmdPortVao = "J";

        private const string ACK = "ACK";

        private const string NCK = "NCK";

        private const string NAK = "NAK";

        private const string XeVaoVungTuVao = "INP";

        private const string XeRaVungTuVao = "OUT";

        private const string XeVaoVungTuRa = "BRI";

        private const string XeRaVungTuRa = "BRO";

        private const string CaBinOpen = "CBO";

        private const string CabinClose = "CBC";

        private const string EMR = "EMR";

        private UcController.ControllerErrorEventHandler ControllerErrorEvent;

        private UcController.InPortEventHandler InPortEvent;

        private UcController.CarOutEventHandler CarOutEvent;

        private bool FlagACK;

        private UcController.EventTrangThaiVungTuVaoEventHandler EventTrangThaiVungTuVaoEvent;

        public event UcController.ControllerErrorEventHandler ControllerError
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.ControllerErrorEvent = (UcController.ControllerErrorEventHandler)Delegate.Combine(this.ControllerErrorEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.ControllerErrorEvent = (UcController.ControllerErrorEventHandler)Delegate.Remove(this.ControllerErrorEvent, value);
            }
        }

        public event UcController.InPortEventHandler InPort
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.InPortEvent = (UcController.InPortEventHandler)Delegate.Combine(this.InPortEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.InPortEvent = (UcController.InPortEventHandler)Delegate.Remove(this.InPortEvent, value);
            }
        }

        public event UcController.CarOutEventHandler CarOut
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.CarOutEvent = (UcController.CarOutEventHandler)Delegate.Combine(this.CarOutEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.CarOutEvent = (UcController.CarOutEventHandler)Delegate.Remove(this.CarOutEvent, value);
            }
        }

        public event UcController.EventTrangThaiVungTuVaoEventHandler EventTrangThaiVungTuVao
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.EventTrangThaiVungTuVaoEvent = (UcController.EventTrangThaiVungTuVaoEventHandler)Delegate.Combine(this.EventTrangThaiVungTuVaoEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.EventTrangThaiVungTuVaoEvent = (UcController.EventTrangThaiVungTuVaoEventHandler)Delegate.Remove(this.EventTrangThaiVungTuVaoEvent, value);
            }
        }

        internal virtual SerialPort ComPort
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ComPort;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                SerialDataReceivedEventHandler value2 = new SerialDataReceivedEventHandler(this.ComPort_DataReceived);
                if (this._ComPort != null)
                {
                    this._ComPort.DataReceived -= value2;
                }
                this._ComPort = value;
                if (this._ComPort != null)
                {
                    this._ComPort.DataReceived += value2;
                }
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }

        public bool KiemTraPortVao
        {
            set
            {
                if (value)
                {
                    this.SendData("J");
                }
            }
        }

        public int PhanLoaiXe
        {
            set
            {
                this.SendData(Strings.Format(value, "0"));
            }
        }

        public bool OpenBarrier
        {
            set
            {
                if (value)
                {
                    this.SendData("B");
                }
                else
                {
                    this.SendData("A");
                }
            }
        }

        public bool MoLan
        {
            set
            {
                if (value)
                {
                    this.SendData("D");
                }
                else
                {
                    this.SendData("C");
                }
            }
        }

        public bool MoChuongBao
        {
            set
            {
                if (value)
                {
                    this.SendData("G");
                    Thread thread = new Thread(new ThreadStart(this.TatChuongBao));
                    thread.Start();
                }
                else
                {
                    this.SendData("H");
                }
            }
        }

        public bool MoChuong1000
        {
            set
            {
                if (value)
                {
                    this.SendData("G");
                    Thread thread = new Thread(delegate (object a0)
                    {
                        this.TatChuong(Conversions.ToInteger(a0));
                    });
                    thread.Start(1000);
                }
            }
        }

        public bool MoDenHongNgoai
        {
            set
            {
                if (value)
                {
                    this.SendData("E");
                }
                else
                {
                    this.SendData("F");
                }
            }
        }

        public byte VungTuVao
        {
            get
            {
                return 0;
            }
        }

        public byte VungTuRa
        {
            get
            {
                return 1;
            }
        }

        public byte VungTuCuoi
        {
            get
            {
                return 2;
            }
        }

        public byte BanDapKhanCap
        {
            get
            {
                return 3;
            }
        }

        public byte Cabin
        {
            get
            {
                return 4;
            }
        }

        public byte BaoDong
        {
            get
            {
                return 5;
            }
        }

        public UcController()
        {
            this.FlagACK = true;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.ComPort = new SerialPort(this.components);
            this.Label1 = new Label();
            this.SuspendLayout();
            this.ComPort.BaudRate = 4800;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Navy;
            Control arg_88_0 = this.Label1;
            Point location = new Point(16, 14);
            arg_88_0.Location = location;
            this.Label1.Name = "Label1";
            Control arg_AF_0 = this.Label1;
            Size size = new Size(65, 16);
            arg_AF_0.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Controller";
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.Label1);
            this.Name = "UcController";
            size = new Size(101, 42);
            this.Size = size;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void KhoiTao(string PortName, int BaudRate)
        {
            try
            {
                this.ComPort.BaudRate = BaudRate;
                this.ComPort.DataBits = 8;
                this.ComPort.StopBits = StopBits.One;
                this.ComPort.Parity = Parity.None;
                this.ComPort.ReceivedBytesThreshold = 1;
                this.ComPort.PortName = PortName;
                this.ComPort.Open();
            }
            catch (Exception expr_55)
            {
                ProjectData.SetProjectError(expr_55);
                UcController.ControllerErrorEventHandler controllerErrorEvent = this.ControllerErrorEvent;
                if (controllerErrorEvent != null)
                {
                    controllerErrorEvent("Khởi tạo Comport controller lỗi");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void SendData(string CommandData)
        {
            try
            {
                if (!this.ComPort.IsOpen)
                {
                    this.ComPort.Open();
                }
                string s = Conversions.ToString(Strings.Chr(255)) + "$C" + CommandData + "#";
                byte[] bytes = Encoding.Default.GetBytes(s);
                this.ComPort.Write(bytes, 0, bytes.Length);
                this.FlagACK = false;
            }
            catch (Exception expr_5D)
            {
                ProjectData.SetProjectError(expr_5D);
                UcController.ControllerErrorEventHandler controllerErrorEvent = this.ControllerErrorEvent;
                if (controllerErrorEvent != null)
                {
                    controllerErrorEvent("Lỗi Comport controller");
                }
                ProjectData.ClearProjectError();
            }
        }

        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            checked
            {
                try
                {
                    if (this.ComPort.IsOpen)
                    {
                        Thread.Sleep(50);
                        char[] separator = Conversions.ToCharArrayRankOne("$");
                        string text = this.ComPort.ReadExisting();
                        text = text.Remove(0, 1);
                        string[] array = text.Split(separator);
                        int arg_49_0 = 0;
                        int num = array.Length - 1;
                        for (int i = arg_49_0; i <= num; i++)
                        {
                            string text2 = array[i];
                            if (text2.Length >= 4)
                            {
                                string text3 = text2.Substring(0, 1);
                                string left = text3;
                                if (Operators.CompareString(left, "A", false) != 0)
                                {
                                    if (Operators.CompareString(left, "N", false) != 0)
                                    {
                                        if (Operators.CompareString(left, "B", false) != 0)
                                        {
                                            if (Operators.CompareString(left, "I", false) != 0)
                                            {
                                                if (Operators.CompareString(left, "M", false) != 0)
                                                {
                                                    if (Operators.CompareString(left, "E", false) != 0)
                                                    {
                                                        if (Operators.CompareString(left, "C", false) != 0)
                                                        {
                                                            if (Operators.CompareString(left, "O", false) != 0)
                                                            {
                                                                goto IL_10F;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                text2 = text2.Substring(0, 3);
                                this.XuLyData(text2);
                            }
                        IL_10F:;
                        }
                    }
                }
                catch (Exception expr_11D)
                {
                    ProjectData.SetProjectError(expr_11D);
                    Exception ex = expr_11D;
                    ModuleKhac.SaveError("ComPort_DataReceived", ex.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void XuLyData(string dulieu)
        {
            if (Operators.CompareString(dulieu, "ACK", false) == 0)
            {
                this.FlagACK = true;
            }
            else if (Operators.CompareString(dulieu, "NCK", false) != 0)
            {
                if (Operators.CompareString(dulieu, "NAK", false) != 0)
                {
                    if (Operators.CompareString(dulieu, "INP", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.VungTuVao, true);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "OUT", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.VungTuVao, false);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "BRI", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.VungTuRa, true);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "BRO", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.VungTuRa, false);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "CBO", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.Cabin, true);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "CBC", false) == 0)
                    {
                        UcController.InPortEventHandler inPortEvent = this.InPortEvent;
                        if (inPortEvent != null)
                        {
                            inPortEvent(this.Cabin, false);
                        }
                    }
                    else if (Operators.CompareString(dulieu, "EMR", false) == 0)
                    {
                        this.MoChuongBao = true;
                    }
                    else
                    {
                        string text = dulieu.Substring(0, 1);
                        string left = text;
                        if (Operators.CompareString(left, "N", false) == 0)
                        {
                            byte b = checked((byte)Strings.Asc(dulieu.Substring(1, 1)));
                            if ((b & 1) == 0)
                            {
                                UcController.EventTrangThaiVungTuVaoEventHandler eventTrangThaiVungTuVaoEvent = this.EventTrangThaiVungTuVaoEvent;
                                if (eventTrangThaiVungTuVaoEvent != null)
                                {
                                    eventTrangThaiVungTuVaoEvent(UcController.TrangThaiPortVao.CoxeVao);
                                }
                            }
                            else
                            {
                                UcController.EventTrangThaiVungTuVaoEventHandler eventTrangThaiVungTuVaoEvent = this.EventTrangThaiVungTuVaoEvent;
                                if (eventTrangThaiVungTuVaoEvent != null)
                                {
                                    eventTrangThaiVungTuVaoEvent(UcController.TrangThaiPortVao.KhongCoXeVao);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void XuLyData(byte[] dulieu)
        {
            int num = (int)dulieu[1];
            int num2 = (int)dulieu[2];
            int num3 = num | num2 << 8;
            int num4;
            double num6;
            double num7;
            checked
            {
                num3 *= 2;
                num = (int)dulieu[3];
                num2 = (int)dulieu[4];
                num4 = (num | num2 << 8);
                num4 *= 2;
                num = (int)dulieu[5];
                num2 = (int)dulieu[6];
                int num5 = num | num2 << 8;
                num5 *= 2;
                num6 = 3.0 / (double)num3;
                num7 = 3.0 / (double)num5;
            }
            double num8 = (num7 + num6) / 2.0;
            double num9 = num8 * (double)num4 + 2.0;
            if (num9 <= 5.0)
            {
                UcController.CarOutEventHandler carOutEvent = this.CarOutEvent;
                if (carOutEvent != null)
                {
                    carOutEvent(2);
                    return;
                }
            }
            else if (num9 <= 7.8)
            {
                UcController.CarOutEventHandler carOutEvent = this.CarOutEvent;
                if (carOutEvent != null)
                {
                    carOutEvent(3);
                    return;
                }
            }
            else if (num9 <= 13.4)
            {
                UcController.CarOutEventHandler carOutEvent = this.CarOutEvent;
                if (carOutEvent != null)
                {
                    carOutEvent(4);
                    return;
                }
            }
            else if (num9 <= 15.8)
            {
                UcController.CarOutEventHandler carOutEvent = this.CarOutEvent;
                if (carOutEvent != null)
                {
                    carOutEvent(5);
                    return;
                }
            }
            else
            {
                UcController.CarOutEventHandler carOutEvent = this.CarOutEvent;
                if (carOutEvent != null)
                {
                    carOutEvent(6);
                }
            }
        }

        public void CloseComPort()
        {
            if (this.ComPort.IsOpen)
            {
                this.ComPort.Close();
            }
        }

        private void TatChuongBao()
        {
            Thread.Sleep(10000);
            this.SendData("H");
        }

        private void TatChuong(int ThoiGian)
        {
            Thread.Sleep(ThoiGian);
            this.SendData("H");
        }
    }
}
