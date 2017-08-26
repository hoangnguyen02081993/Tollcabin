using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.CompilerServices;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic;

namespace Tollcabin
{
    [DesignerGenerated]
    public partial class UcDocMaVach : UserControl
    {
        public delegate void DataReceiveEventHandler(string Message);

        public delegate void ComPortErrorEventHandler(string Message);

        public delegate void TheCungEventHandler(string Message);


        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("ComPort")]
        private SerialPort _ComPort;

        private string Buffer;

        private bool CongComThat_;

        private UcDocMaVach.DataReceiveEventHandler DataReceiveEvent;

        private UcDocMaVach.ComPortErrorEventHandler ComPortErrorEvent;

        private UcDocMaVach.TheCungEventHandler TheCungEvent;

        private bool flagVe;

        private bool FlagTheCung;

        private string _PortName;

        public event UcDocMaVach.DataReceiveEventHandler DataReceive
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.DataReceiveEvent = (UcDocMaVach.DataReceiveEventHandler)Delegate.Combine(this.DataReceiveEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.DataReceiveEvent = (UcDocMaVach.DataReceiveEventHandler)Delegate.Remove(this.DataReceiveEvent, value);
            }
        }

        public event UcDocMaVach.ComPortErrorEventHandler ComPortError
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.ComPortErrorEvent = (UcDocMaVach.ComPortErrorEventHandler)Delegate.Combine(this.ComPortErrorEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.ComPortErrorEvent = (UcDocMaVach.ComPortErrorEventHandler)Delegate.Remove(this.ComPortErrorEvent, value);
            }
        }

        public event UcDocMaVach.TheCungEventHandler TheCung
        {
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                this.TheCungEvent = (UcDocMaVach.TheCungEventHandler)Delegate.Combine(this.TheCungEvent, value);
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                this.TheCungEvent = (UcDocMaVach.TheCungEventHandler)Delegate.Remove(this.TheCungEvent, value);
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

        public bool CongComThat
        {
            get
            {
                return this.CongComThat_;
            }
            set
            {
                this.CongComThat_ = value;
            }
        }

        public bool DangMo
        {
            get
            {
                return this.ComPort.IsOpen;
            }
        }

        public UcDocMaVach()
        {
            this.CongComThat_ = true;
            this.flagVe = false;
            this.FlagTheCung = false;
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
            this.Label1.ForeColor = Color.DarkCyan;
            Control arg_76_0 = this.Label1;
            Point location = new Point(3, 0);
            arg_76_0.Location = location;
            this.Label1.Name = "Label1";
            Control arg_9D_0 = this.Label1;
            Size size = new Size(97, 16);
            arg_9D_0.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Đọc mã vạch";
            this.ComPort.PortName = "COM9";
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.Label1);
            this.Name = "UcDocMaVach";
            size = new Size(111, 21);
            this.Size = size;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void MoLai()
        {
            try
            {
                this.ComPort.Open();
            }
            catch (Exception expr_0D)
            {
                ProjectData.SetProjectError(expr_0D);
                UcDocMaVach.ComPortErrorEventHandler comPortErrorEvent = this.ComPortErrorEvent;
                if (comPortErrorEvent != null)
                {
                    comPortErrorEvent("Mở ComPort đọc mã vạch lỗi ");
                }
                ProjectData.ClearProjectError();
            }
        }

        public void KhoiTao(string _ComPortName, int _BaudRate, bool CongComThatVatLy)
        {
            try
            {
                SerialPort comPort = this.ComPort;
                comPort.BaudRate = _BaudRate;
                comPort.DataBits = 8;
                comPort.StopBits = StopBits.One;
                comPort.Parity = Parity.None;
                comPort.ReceivedBytesThreshold = 1;
                this._PortName = _ComPortName;
                comPort.PortName = _ComPortName;
                comPort.Open();
                this.CongComThat = CongComThatVatLy;
            }
            catch (Exception expr_49)
            {
                ProjectData.SetProjectError(expr_49);
                UcDocMaVach.ComPortErrorEventHandler comPortErrorEvent = this.ComPortErrorEvent;
                if (comPortErrorEvent != null)
                {
                    comPortErrorEvent("Mở ComPort đọc mã vạch lỗi ");
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
            checked
            {
                try
                {
                    if (!this.ComPort.IsOpen)
                    {
                        this.ComPort.Open();
                    }
                    if (this.CongComThat)
                    {
                        Thread.Sleep(60);
                        string text = this.ComPort.ReadExisting();
                        if (text.Length >= 16)
                        {
                            text = text.Substring(0, 16);
                            UcDocMaVach.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(text);
                            }
                        }
                        else if (text.Length == 12)
                        {
                            UcDocMaVach.TheCungEventHandler theCungEvent = this.TheCungEvent;
                            if (theCungEvent != null)
                            {
                                theCungEvent(text);
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(20);
                        if (this.ComPort.BytesToRead == 16)
                        {
                            this.Buffer = "";
                            int num = 0;
                            do
                            {
                                this.Buffer += Conversions.ToString(Strings.Chr(this.ComPort.ReadChar()));
                                num++;
                            }
                            while (num <= 15);
                            string buffer = this.Buffer;
                            UcDocMaVach.DataReceiveEventHandler dataReceiveEvent = this.DataReceiveEvent;
                            if (dataReceiveEvent != null)
                            {
                                dataReceiveEvent(buffer);
                            }
                        }
                        if (this.ComPort.BytesToRead == 12)
                        {
                            this.Buffer = "";
                            int num2 = 0;
                            do
                            {
                                this.Buffer += Conversions.ToString(Strings.Chr(this.ComPort.ReadChar()));
                                num2++;
                            }
                            while (num2 <= 11);
                            string buffer2 = this.Buffer;
                            UcDocMaVach.TheCungEventHandler theCungEvent = this.TheCungEvent;
                            if (theCungEvent != null)
                            {
                                theCungEvent(buffer2);
                            }
                        }
                        this.ComPort.ReadExisting();
                    }
                }
                catch (Exception expr_17A)
                {
                    ProjectData.SetProjectError(expr_17A);
                    UcDocMaVach.ComPortErrorEventHandler comPortErrorEvent = this.ComPortErrorEvent;
                    if (comPortErrorEvent != null)
                    {
                        comPortErrorEvent("Nhận dữ liệu từ máy đọc mã vạch lỗi");
                    }
                    ProjectData.ClearProjectError();
                }
            }
        }
    }
}
