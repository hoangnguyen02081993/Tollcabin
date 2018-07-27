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
    public partial class UcSerialPort : UserControl
    {
        public delegate void spConsole_DataReceiveEventHandler(string Message);

        public delegate void spNhanDang_DataReceiveEventHandler(string Message);

        public delegate void ErrorSerialPortEventHandler(string Message);

        [AccessedThroughProperty("spLed")]
        private SerialPort _spLed;

        [AccessedThroughProperty("pbSerialPort")]
        private PictureBox _pbSerialPort;

        [AccessedThroughProperty("spNhanDang")]
        private SerialPort _spNhanDang;

        private UcSerialPort.spConsole_DataReceiveEventHandler spConsole_DataReceiveEvent;

        private UcSerialPort.spNhanDang_DataReceiveEventHandler spNhanDang_DataReceiveEvent;

        private UcSerialPort.ErrorSerialPortEventHandler ErrorSerialPortEvent;

        public event UcSerialPort.spConsole_DataReceiveEventHandler spConsole_DataReceive
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.spConsole_DataReceiveEvent = (UcSerialPort.spConsole_DataReceiveEventHandler)Delegate.Combine(this.spConsole_DataReceiveEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.spConsole_DataReceiveEvent = (UcSerialPort.spConsole_DataReceiveEventHandler)Delegate.Remove(this.spConsole_DataReceiveEvent, value);
            }
        }

        public event UcSerialPort.spNhanDang_DataReceiveEventHandler spNhanDang_DataReceive
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.spNhanDang_DataReceiveEvent = (UcSerialPort.spNhanDang_DataReceiveEventHandler)Delegate.Combine(this.spNhanDang_DataReceiveEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.spNhanDang_DataReceiveEvent = (UcSerialPort.spNhanDang_DataReceiveEventHandler)Delegate.Remove(this.spNhanDang_DataReceiveEvent, value);
            }
        }

        public event UcSerialPort.ErrorSerialPortEventHandler ErrorSerialPort
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.ErrorSerialPortEvent = (UcSerialPort.ErrorSerialPortEventHandler)Delegate.Combine(this.ErrorSerialPortEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.ErrorSerialPortEvent = (UcSerialPort.ErrorSerialPortEventHandler)Delegate.Remove(this.ErrorSerialPortEvent, value);
            }
        }

        internal virtual SerialPort spLed
        {
            [DebuggerNonUserCode]
            get
            {
                return this._spLed;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._spLed = value;
            }
        }

        internal virtual PictureBox pbSerialPort
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbSerialPort;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbSerialPort = value;
            }
        }

        internal virtual SerialPort spNhanDang
        {
            [DebuggerNonUserCode]
            get
            {
                return this._spNhanDang;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                SerialDataReceivedEventHandler value2 = new SerialDataReceivedEventHandler(this.spNhanDang_DataReceived);
                if (this._spNhanDang != null)
                {
                    this._spNhanDang.DataReceived -= value2;
                }
                this._spNhanDang = value;
                if (this._spNhanDang != null)
                {
                    this._spNhanDang.DataReceived += value2;
                }
            }
        }

        public string CanTroGiup
        {
            get
            {
                return "CANGIUPDO";
            }
        }

        public string XeVuotTram
        {
            get
            {
                return "XEVUOTTRAM";
            }
        }

        public string XeDoiBienSo
        {
            get
            {
                return "XEDOIBIENSO";
            }
        }

        public string PhanLoaiSai
        {
            get
            {
                return "PHANLOAISAI";
            }
        }

        public string MoLan
        {
            get
            {
                return "MOLAN";
            }
        }

        public string DongLan
        {
            get
            {
                return "DONGLAN";
            }
        }

        public string DongCuongBuc
        {
            get
            {
                return "DONGCUONGBUC";
            }
        }

        public bool spLed_LaiXeDungNgangCabin
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("LÀI XE DôNG NGANG CABIN");
                }
            }
        }

        public string spLed_MoiXeQua_Phi
        {
            set
            {
                this.spLedSendMessage("  MéI XE QUA!  PHÛ:" + value);
            }
        }

        public bool spLed_MoiXeQua
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!");
                }
            }
        }

        public bool spLed_MoiXeQua_QuocLoLuot
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("       VÏ QUçC           Lè LœíT");
                }
            }
        }

        public bool spLed_MoiXeQua_VeToanQuoc
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("      VÏ DîNG        TOªN QUçC");
                }
            }
        }

        public bool spLed_MoiXeQua_VeThang
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!     VÏ THÀNG");
                }
            }
        }

        public bool spLed_MoiXeQua_VeNam
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!       VÏ N–M");
                }
            }
        }

        public bool spLed_MoiXeQua_VeQuy
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!       VÏ QUÛ");
                }
            }
        }

        public bool spLed_MoiXeQua_ChucBinhAn
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!  VÏ THU HäI");
                }
            }
        }

        public bool spLed_MoiXeQua_UuTien
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!  XE œU TI™N");
                }
            }
        }

        public bool spLed_YeuCauLuuXe
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("      Y™U CÇU            LîI XE ");
                }
            }
        }

        public bool spLed_LanMo
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  KIÓM TRA VÏ    TÁI CABIN");
                }
                else
                {
                    this.spLedSendMessage("    LªN ˜âNG       CÊM XE VªO");
                }
            }
        }
        public bool spLed_MoiXeQua_giamGia
        {
            set
            {
                if (value)
                {
                    this.spLedSendMessage("  MéI XE QUA!   VÏ GI¶M GIÀ");
                }
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.spLed = new SerialPort(this.components);
            this.pbSerialPort = new PictureBox();
            this.spNhanDang = new SerialPort(this.components);
            ((ISupportInitialize)this.pbSerialPort).BeginInit();
            this.SuspendLayout();
            this.spLed.BaudRate = 2400;
            this.spLed.PortName = "COM2";
            this.pbSerialPort.Image = Properties.Resources.SerialPort;
            Control arg_89_0 = this.pbSerialPort;
            Point location = new Point(4, 4);
            arg_89_0.Location = location;
            this.pbSerialPort.Name = "pbSerialPort";
            Control arg_B0_0 = this.pbSerialPort;
            Size size = new Size(74, 24);
            arg_B0_0.Size = size;
            this.pbSerialPort.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pbSerialPort.TabIndex = 0;
            this.pbSerialPort.TabStop = false;
            this.spNhanDang.PortName = "COM4";
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.pbSerialPort);
            size = new Size(82, 31);
            this.MaximumSize = size;
            size = new Size(82, 31);
            this.MinimumSize = size;
            this.Name = "UcSerialPort";
            size = new Size(82, 31);
            this.Size = size;
            ((ISupportInitialize)this.pbSerialPort).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public UcSerialPort()
        {
            this.InitializeComponent();
        }

        private void spLedSendMessage(string message)
        {
            try
            {
                if (!this.spLed.IsOpen)
                {
                    this.spLed.Open();
                }
            }
            catch (Exception expr_1A)
            {
                ProjectData.SetProjectError(expr_1A);
                ProjectData.ClearProjectError();
            }
            int charCode = checked(message.Length + 2);
            string s;
            if (ModuleKhaiBaoConst.LanXeMain <= 4)
            {
                s = string.Concat(new string[]
                {
                    Conversions.ToString(Strings.Chr(255)),
                    "$",
                    Conversions.ToString(Strings.Chr(255)),
                    Conversions.ToString(Strings.Chr(charCode)),
                    message,
                    "\0#"
                });
            }
            else
            {
                s = string.Concat(new string[]
                {
                    Conversions.ToString(Strings.Chr(255)),
                    "$1",
                    Conversions.ToString(Strings.Chr(charCode)),
                    message,
                    "\0#"
                });
            }
            byte[] bytes = Encoding.Default.GetBytes(s);
            try
            {
                this.spLed.Write(bytes, 0, bytes.Length);
            }
            catch (Exception expr_104)
            {
                ProjectData.SetProjectError(expr_104);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent(this.spLed.PortName);
                }
                ProjectData.ClearProjectError();
            }
        }

        public void OpenSpLed(string PortName, int BaudRate)
        {
            try
            {
                this.spLed.BaudRate = BaudRate;
                this.spLed.DataBits = 8;
                this.spLed.StopBits = StopBits.One;
                this.spLed.Parity = Parity.None;
                this.spLed.ReceivedBytesThreshold = 1;
                this.spLed.PortName = PortName;
                this.spLed.Open();
            }
            catch (Exception expr_55)
            {
                ProjectData.SetProjectError(expr_55);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent("Khởi tạo spLed lỗi");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void CloseSpLed()
        {
            try
            {
                if (this.spLed.IsOpen)
                {
                    this.spLed.Close();
                }
            }
            catch (Exception expr_1A)
            {
                ProjectData.SetProjectError(expr_1A);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent("CloseSpLed lỗi");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void OpenSpNhanDang(string PortName, int BaudRate)
        {
            try
            {
                this.spNhanDang.BaudRate = BaudRate;
                this.spNhanDang.DataBits = 8;
                this.spNhanDang.StopBits = StopBits.One;
                this.spNhanDang.Parity = Parity.None;
                this.spNhanDang.ReceivedBytesThreshold = 1;
                this.spNhanDang.PortName = PortName;
                this.spNhanDang.Open();
            }
            catch (Exception expr_55)
            {
                ProjectData.SetProjectError(expr_55);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent("Khởi tạo spNhanDang  lỗi");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void CloseSpNhanDang()
        {
            try
            {
                if (this.spNhanDang.IsOpen)
                {
                    this.spNhanDang.Close();
                }
            }
            catch (Exception expr_1A)
            {
                ProjectData.SetProjectError(expr_1A);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent("CloseSpNhanDang  lỗi");
                }
                ProjectData.ClearProjectError();
            }
        }

        private void spNhanDang_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(150);
            string text = this.spNhanDang.ReadExisting();
            if (text.Length < 4)
            {
                UcSerialPort.spNhanDang_DataReceiveEventHandler spNhanDang_DataReceiveEventHandler = this.spNhanDang_DataReceiveEvent;
                if (spNhanDang_DataReceiveEventHandler != null)
                {
                    spNhanDang_DataReceiveEventHandler("");
                    return;
                }
            }
            else
            {
                text = text.Substring(1, checked(text.Length - 2));
                UcSerialPort.spNhanDang_DataReceiveEventHandler spNhanDang_DataReceiveEventHandler = this.spNhanDang_DataReceiveEvent;
                if (spNhanDang_DataReceiveEventHandler != null)
                {
                    spNhanDang_DataReceiveEventHandler(text);
                }
            }
        }

        private void spNhanDangSendMessage(string message)
        {
            try
            {
                if (!this.spNhanDang.IsOpen)
                {
                    this.spNhanDang.Open();
                }
            }
            catch (Exception expr_1A)
            {
                ProjectData.SetProjectError(expr_1A);
                ProjectData.ClearProjectError();
            }
            int num = checked(message.Length + 2);
            string s = Conversions.ToString(Strings.Chr(255)) + message + Conversions.ToString(Strings.Chr(255));
            byte[] bytes = Encoding.Default.GetBytes(s);
            try
            {
                this.spNhanDang.Write(bytes, 0, bytes.Length);
            }
            catch (Exception expr_74)
            {
                ProjectData.SetProjectError(expr_74);
                UcSerialPort.ErrorSerialPortEventHandler errorSerialPortEvent = this.ErrorSerialPortEvent;
                if (errorSerialPortEvent != null)
                {
                    errorSerialPortEvent(this.spNhanDang.PortName);
                }
                ProjectData.ClearProjectError();
            }
        }

        public void NhanDangBienSo()
        {
            this.spNhanDangSendMessage("BIENSO");
        }
    }

}
