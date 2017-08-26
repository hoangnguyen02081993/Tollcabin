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
    public partial class UcConsole : UserControl
    {
        public enum LenhDieuKhien
        {
            ResetAll = 45,
            MoCuongBuc = 1,
            UuTien = 4,
            UuTienDoan = 6,
            MoLan,
            DongLan,
            LuiXe,
            KetNoiGiamSat = 2,
            ToanQuoc = 81,
            NhanDang = 66,
            BaoDong = 99
        }

        public enum LenhDieuKhien2
        {
            MoCuongBuc = 70,
            QuocLoLuot = 78,
            ToanQuoc = 81,
            UuTien = 85,
            UuTienDoan = 87,
            MoLan = 79,
            DongLan = 67,
            BaoDong = 65,
            NhanDang,
            Reset = 68,
            Enter = 13
        }

        public delegate void DataReceiveEventHandler(int Message);

        public delegate void ComPortErrorEventHandler(string Message);


        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("ComPort")]
        private SerialPort _ComPort;

        private int PhimBam;

        private DateTime TimePhimBam;

        private const string MoCuongBuc = "0";

        private const string MoLan = "A";

        private const string DongLan = "B";

        private const string LuiXe = "C";

        private const string ResetAll = "D";

        private const string CallGiamSat = "1";

        private int BaudRate_;

        private string ComPortName_;

        private UcConsole.DataReceiveEventHandler DataReceiveEvent;

        private UcConsole.ComPortErrorEventHandler ComPortErrorEvent;

        public event UcConsole.DataReceiveEventHandler DataReceive
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.DataReceiveEvent = (UcConsole.DataReceiveEventHandler)Delegate.Combine(this.DataReceiveEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.DataReceiveEvent = (UcConsole.DataReceiveEventHandler)Delegate.Remove(this.DataReceiveEvent, value);
            }
        }

        public event UcConsole.ComPortErrorEventHandler ComPortError
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.ComPortErrorEvent = (UcConsole.ComPortErrorEventHandler)Delegate.Combine(this.ComPortErrorEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.ComPortErrorEvent = (UcConsole.ComPortErrorEventHandler)Delegate.Remove(this.ComPortErrorEvent, value);
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

        public int BaudRate
        {
            get
            {
                return this.BaudRate_;
            }
            set
            {
                this.BaudRate_ = value;
            }
        }

        public string ComPortName
        {
            get
            {
                return this.ComPortName_;
            }
            set
            {
                this.ComPortName_ = value;
            }
        }

        public UcConsole()
        {
            this.PhimBam = -1;
            this.TimePhimBam = DateAndTime.Now;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.Label1 = new Label();
            this.ComPort = new SerialPort(this.components);
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            Control arg_76_0 = this.Label1;
            Point location = new Point(3, 0);
            arg_76_0.Location = location;
            this.Label1.Name = "Label1";
            Control arg_9D_0 = this.Label1;
            Size size = new Size(84, 16);
            arg_9D_0.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "UcConsole";
            this.ComPort.PortName = "COM3";
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.Label1);
            size = new Size(87, 22);
            this.MinimumSize = size;
            this.Name = "UcConsole";
            size = new Size(87, 22);
            this.Size = size;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void KhoiTao(string _ComPortName, int _BaudRate)
        {
            try
            {
                SerialPort comPort = this.ComPort;
                comPort.BaudRate = _BaudRate;
                comPort.DataBits = 8;
                comPort.StopBits = StopBits.One;
                comPort.Parity = Parity.None;
                comPort.ReceivedBytesThreshold = 1;
                comPort.PortName = _ComPortName;
                comPort.Open();
            }
            catch (Exception expr_3B)
            {
                ProjectData.SetProjectError(expr_3B);
                UcConsole.ComPortErrorEventHandler comPortErrorEvent = this.ComPortErrorEvent;
                if (comPortErrorEvent != null)
                {
                    comPortErrorEvent("ComPort Console Error");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void Close()
        {
            if (this.ComPort.IsOpen)
            {
                this.ComPort.Close();
            }
        }

        private void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(10);
            try
            {
                if (!this.ComPort.IsOpen)
                {
                    this.ComPort.Open();
                }
                if (ModuleKhaiBaoConst.ConsoleMain)
                {
                    string text = this.ComPort.ReadExisting();
                    if (text.Length >= 3)
                    {
                        string text2 = text.Substring(4, 1);
                        string left = text2;
                        if (Operators.CompareString(left, "1", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(2);
                            }
                        }
                        else if (Operators.CompareString(left, "0", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(1);
                            }
                        }
                        else if (Operators.CompareString(left, "A", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(7);
                            }
                        }
                        else if (Operators.CompareString(left, "B", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(8);
                            }
                        }
                        else if (Operators.CompareString(left, "C", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(9);
                            }
                        }
                        else if (Operators.CompareString(left, "D", false) == 0)
                        {
                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(45);
                            }
                        }
                    }
                }
                else
                {
                    byte[] array = new byte[101];
                    this.ComPort.Read(array, 0, 100);
                    int phimBam = (int)array[0];
                    switch (phimBam)
                    {
                        case 13:
                            if ((DateAndTime.Now - this.TimePhimBam).TotalSeconds <= 5.0)
                            {
                                switch (this.PhimBam)
                                {
                                    case 65:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(99);
                                            }
                                            break;
                                        }
                                    case 66:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(66);
                                            }
                                            break;
                                        }
                                    case 67:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(8);
                                            }
                                            break;
                                        }
                                    case 68:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(45);
                                            }
                                            break;
                                        }
                                    case 70:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(1);
                                            }
                                            break;
                                        }
                                    case 78:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(2);
                                            }
                                            break;
                                        }
                                    case 79:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(7);
                                            }
                                            break;
                                        }
                                    case 81:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(81);
                                            }
                                            break;
                                        }
                                    case 85:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(4);
                                            }
                                            break;
                                        }
                                    case 87:
                                        {
                                            UcConsole.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                                            if (dataReceiveEvent != null)
                                            {
                                                dataReceiveEvent(6);
                                            }
                                            break;
                                        }
                                }
                                this.PhimBam = -1;
                            }
                            break;
                        case 65:
                        case 66:
                        case 67:
                        case 68:
                        case 70:
                        case 78:
                        case 79:
                        case 81:
                        case 85:
                        case 87:
                            this.TimePhimBam = DateAndTime.Now;
                            this.PhimBam = phimBam;
                            break;
                    }
                }
            }
            catch (Exception expr_455)
            {
                ProjectData.SetProjectError(expr_455);
                Exception ex = expr_455;
                UcConsole.ComPortErrorEventHandler comPortErrorEvent = this.ComPortErrorEvent;
                if (comPortErrorEvent != null)
                {
                    comPortErrorEvent(ex.Message);
                }
                ProjectData.ClearProjectError();
            }
        }
    }
}
