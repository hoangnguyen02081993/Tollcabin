using Capture2014;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
    [DesignerGenerated]
    public partial class frmMain : Form
    {
        private delegate void MyDelegate(object str);


        [AccessedThroughProperty("UcComPort")]
        private UcSerialPort _UcComPort;

        [AccessedThroughProperty("TimerNgayGio")]
        private System.Windows.Forms.Timer _TimerNgayGio;

        [AccessedThroughProperty("pbClose")]
        private PictureBox _pbClose;

        [AccessedThroughProperty("lbMaVeXe")]
        private Label _lbMaVeXe;

        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        [AccessedThroughProperty("ssTime")]
        private StatusStrip _ssTime;

        [AccessedThroughProperty("tslbThongTin")]
        private ToolStripStatusLabel _tslbThongTin;

        [AccessedThroughProperty("lbTenTramThuPhi")]
        private Label _lbTenTramThuPhi;

        [AccessedThroughProperty("lbGiaVe")]
        private Label _lbGiaVe;

        [AccessedThroughProperty("lbPhanLoaiiii")]
        private Label _lbPhanLoaiiii;

        [AccessedThroughProperty("lbThongTinVe")]
        private Label _lbThongTinVe;

        [AccessedThroughProperty("lbBienSoXeCSDL")]
        private Label _lbBienSoXeCSDL;

        [AccessedThroughProperty("lbBienSoooo")]
        private Label _lbBienSoooo;

        [AccessedThroughProperty("pbBarrer")]
        private PictureBox _pbBarrer;

        [AccessedThroughProperty("pbTrangThaiLan")]
        private PictureBox _pbTrangThaiLan;

        [AccessedThroughProperty("pbTrangThaiMang")]
        private PictureBox _pbTrangThaiMang;

        [AccessedThroughProperty("pbAnhXeVaoLan")]
        private PictureBox _pbAnhXeVaoLan;

        [AccessedThroughProperty("TimerKiemTraDuLieuCu")]
        private System.Windows.Forms.Timer _TimerKiemTraDuLieuCu;

        [AccessedThroughProperty("lbBienSoDuoiLan")]
        private Label _lbBienSoDuoiLan;

        [AccessedThroughProperty("Controller")]
        private UcController _Controller;

        [AccessedThroughProperty("Console")]
        private UcConsole _Console;

        [AccessedThroughProperty("DocMaVach")]
        private UcDocMaVach _DocMaVach;

        [AccessedThroughProperty("pnStatusCarIn2")]
        private Panel _pnStatusCarIn2;

        [AccessedThroughProperty("pnStatusCarIn1")]
        private Panel _pnStatusCarIn1;

        [AccessedThroughProperty("tssNhanVien")]
        private ToolStripStatusLabel _tssNhanVien;

        [AccessedThroughProperty("tssCatruc")]
        private ToolStripStatusLabel _tssCatruc;

        [AccessedThroughProperty("tssCabin")]
        private ToolStripStatusLabel _tssCabin;

        [AccessedThroughProperty("ToolStripStatusLabel1")]
        private ToolStripStatusLabel _ToolStripStatusLabel1;

        [AccessedThroughProperty("lbPhanLoaiDuoiLan")]
        private Label _lbPhanLoaiDuoiLan;

        [AccessedThroughProperty("lbGio")]
        private Label _lbGio;

        [AccessedThroughProperty("pbPhone")]
        private PictureBox _pbPhone;

        [AccessedThroughProperty("pnVideo")]
        private Panel _pnVideo;

        [AccessedThroughProperty("Timer_ChupHinh")]
        private System.Windows.Forms.Timer _Timer_ChupHinh;

        [AccessedThroughProperty("Timer_docMaVach")]
        private System.Windows.Forms.Timer _Timer_docMaVach;

        [AccessedThroughProperty("Timer_KhoiTaoLai")]
        private System.Windows.Forms.Timer _Timer_KhoiTaoLai;

        [AccessedThroughProperty("lbPhuongTien")]
        private Label _lbPhuongTien;

        [AccessedThroughProperty("lbSoNguoi")]
        private Label _lbSoNguoi;

        [AccessedThroughProperty("lbSoNguoiiiii")]
        private Label _lbSoNguoiiiii;

        [AccessedThroughProperty("lbTTHangHoa")]
        private Label _lbTTHangHoa;

        [AccessedThroughProperty("lbTaiTrongHangHoaaa")]
        private Label _lbTaiTrongHangHoaaa;

        private bool _flagDangSaveVideo;

        private ClassTaoVideo _VideoXeQua;

        private DVR VideoData;

        private bool FlagUuTienDoan;

        private string SoVeUuTienDoan;

        private bool FlagUuTienLuot;

        private string SoVeUuTienTienLuot;

        private QueueXeQuaTram HangDoiXeVaoTram;

        private bool LenhNhanDangBienSo;

        private DateTime TimeReplication;

        private int DvrChanel;

        [AccessedThroughProperty("phone")]
        private VoicePhone _phone;

        private UcController.TrangThaiPortVao TrangThaiPortVao;

        private string VeLuotPhanLoaiTruoc;

        private bool FlagTinhNangThoai;

        private DateTime TimeUuTienLuot;

        private bool FlagHuyDuLieuXe;

        private bool FlagKiemTraVungTu;

        private string _IPdauGhiHinh;

        private int PhanLoaiXeVuaQua;

        [AccessedThroughProperty("_ChupHinhXe")]
        private VideoCapture __ChupHinhXe;

        private string _FileNameAnhXe;

        private bool _flagChupHinh;

        internal virtual UcSerialPort UcComPort
        {
            [DebuggerNonUserCode]
            get
            {
                return this._UcComPort;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                UcSerialPort.spNhanDang_DataReceiveEventHandler obj = new UcSerialPort.spNhanDang_DataReceiveEventHandler(this.UcComPort_spNhanDang_DataReceive);
                UcSerialPort.ErrorSerialPortEventHandler obj2 = new UcSerialPort.ErrorSerialPortEventHandler(this.UcComPort_ErrorSerialPort);
                if (this._UcComPort != null)
                {
                    this._UcComPort.spNhanDang_DataReceive -= obj;
                    this._UcComPort.ErrorSerialPort -= obj2;
                }
                this._UcComPort = value;
                if (this._UcComPort != null)
                {
                    this._UcComPort.spNhanDang_DataReceive += obj;
                    this._UcComPort.ErrorSerialPort += obj2;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer TimerNgayGio
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TimerNgayGio;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TimerNgayGio_Tick);
                if (this._TimerNgayGio != null)
                {
                    this._TimerNgayGio.Tick -= value2;
                }
                this._TimerNgayGio = value;
                if (this._TimerNgayGio != null)
                {
                    this._TimerNgayGio.Tick += value2;
                }
            }
        }

        internal virtual PictureBox pbClose
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbClose;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.pbClose_Click);
                if (this._pbClose != null)
                {
                    this._pbClose.Click -= value2;
                }
                this._pbClose = value;
                if (this._pbClose != null)
                {
                    this._pbClose.Click += value2;
                }
            }
        }

        internal virtual Label lbMaVeXe
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbMaVeXe;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbMaVeXe = value;
            }
        }

        internal virtual Label Label9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label9;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label9 = value;
            }
        }

        internal virtual Label Label8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label8;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual StatusStrip ssTime
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ssTime;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ssTime = value;
            }
        }

        internal virtual ToolStripStatusLabel tslbThongTin
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tslbThongTin;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tslbThongTin = value;
            }
        }

        internal virtual Label lbTenTramThuPhi
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbTenTramThuPhi;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.lbTenTramThuPhi_Click);
                if (this._lbTenTramThuPhi != null)
                {
                    this._lbTenTramThuPhi.Click -= value2;
                }
                this._lbTenTramThuPhi = value;
                if (this._lbTenTramThuPhi != null)
                {
                    this._lbTenTramThuPhi.Click += value2;
                }
            }
        }

        internal virtual Label lbGiaVe
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbGiaVe;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbGiaVe = value;
            }
        }

        internal virtual Label lbPhanLoaiiii
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbPhanLoaiiii;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbPhanLoaiiii = value;
            }
        }

        internal virtual Label lbThongTinVe
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbThongTinVe;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbThongTinVe = value;
            }
        }

        internal virtual Label lbBienSoXeCSDL
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbBienSoXeCSDL;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbBienSoXeCSDL = value;
            }
        }

        internal virtual Label lbBienSoooo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbBienSoooo;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbBienSoooo = value;
            }
        }

        internal virtual PictureBox pbBarrer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbBarrer;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbBarrer = value;
            }
        }

        internal virtual PictureBox pbTrangThaiLan
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbTrangThaiLan;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbTrangThaiLan = value;
            }
        }

        internal virtual PictureBox pbTrangThaiMang
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbTrangThaiMang;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbTrangThaiMang = value;
            }
        }

        internal virtual PictureBox pbAnhXeVaoLan
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbAnhXeVaoLan;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbAnhXeVaoLan = value;
            }
        }

        internal virtual System.Windows.Forms.Timer TimerKiemTraDuLieuCu
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TimerKiemTraDuLieuCu;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.TimerKiemTraDuLieuCu_Tick);
                if (this._TimerKiemTraDuLieuCu != null)
                {
                    this._TimerKiemTraDuLieuCu.Tick -= value2;
                }
                this._TimerKiemTraDuLieuCu = value;
                if (this._TimerKiemTraDuLieuCu != null)
                {
                    this._TimerKiemTraDuLieuCu.Tick += value2;
                }
            }
        }

        public virtual Label lbBienSoDuoiLan
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbBienSoDuoiLan;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbBienSoDuoiLan = value;
            }
        }

        internal virtual UcController Controller
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Controller;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                UcController.EventTrangThaiVungTuVaoEventHandler obj = new UcController.EventTrangThaiVungTuVaoEventHandler(this.Controller_EventTrangThaiVungTuVao);
                UcController.ControllerErrorEventHandler obj2 = new UcController.ControllerErrorEventHandler(this.Controller_ControllerError);
                UcController.CarOutEventHandler obj3 = new UcController.CarOutEventHandler(this.UcController1_CarOut);
                UcController.InPortEventHandler obj4 = new UcController.InPortEventHandler(this.UcController1_InPort);
                if (this._Controller != null)
                {
                    this._Controller.EventTrangThaiVungTuVao -= obj;
                    this._Controller.ControllerError -= obj2;
                    this._Controller.CarOut -= obj3;
                    this._Controller.InPort -= obj4;
                }
                this._Controller = value;
                if (this._Controller != null)
                {
                    this._Controller.EventTrangThaiVungTuVao += obj;
                    this._Controller.ControllerError += obj2;
                    this._Controller.CarOut += obj3;
                    this._Controller.InPort += obj4;
                }
            }
        }

        internal virtual UcConsole Console
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Console;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                UcConsole.DataReceiveEventHandler obj = new UcConsole.DataReceiveEventHandler(this.Console_DataReceive);
                UcConsole.ComPortErrorEventHandler obj2 = new UcConsole.ComPortErrorEventHandler(this.Console_ComPortError);
                if (this._Console != null)
                {
                    this._Console.DataReceive -= obj;
                    this._Console.ComPortError -= obj2;
                }
                this._Console = value;
                if (this._Console != null)
                {
                    this._Console.DataReceive += obj;
                    this._Console.ComPortError += obj2;
                }
            }
        }

        internal virtual UcDocMaVach DocMaVach
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DocMaVach;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                UcDocMaVach.TheCungEventHandler obj = new UcDocMaVach.TheCungEventHandler(this.DocMaVach_TheCung);
                UcDocMaVach.ComPortErrorEventHandler obj2 = new UcDocMaVach.ComPortErrorEventHandler(this.DocMaVach_ComPortError);
                UcDocMaVach.DataReceiveEventHandler obj3 = new UcDocMaVach.DataReceiveEventHandler(this.DocMaVach_DataReceive);
                if (this._DocMaVach != null)
                {
                    this._DocMaVach.TheCung -= obj;
                    this._DocMaVach.ComPortError -= obj2;
                    this._DocMaVach.DataReceive -= obj3;
                }
                this._DocMaVach = value;
                if (this._DocMaVach != null)
                {
                    this._DocMaVach.TheCung += obj;
                    this._DocMaVach.ComPortError += obj2;
                    this._DocMaVach.DataReceive += obj3;
                }
            }
        }

        internal virtual Panel pnStatusCarIn2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnStatusCarIn2;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnStatusCarIn2 = value;
            }
        }

        internal virtual Panel pnStatusCarIn1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnStatusCarIn1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnStatusCarIn1 = value;
            }
        }

        internal virtual ToolStripStatusLabel tssNhanVien
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tssNhanVien;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tssNhanVien = value;
            }
        }

        internal virtual ToolStripStatusLabel tssCatruc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tssCatruc;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tssCatruc = value;
            }
        }

        internal virtual ToolStripStatusLabel tssCabin
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tssCabin;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tssCabin = value;
            }
        }

        internal virtual ToolStripStatusLabel ToolStripStatusLabel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripStatusLabel1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripStatusLabel1 = value;
            }
        }

        internal virtual Label lbPhanLoaiDuoiLan
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbPhanLoaiDuoiLan;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbPhanLoaiDuoiLan = value;
            }
        }

        internal virtual Label lbGio
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbGio;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbGio = value;
            }
        }

        public virtual PictureBox pbPhone
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pbPhone;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbPhone = value;
            }
        }

        internal virtual Panel pnVideo
        {
            [DebuggerNonUserCode]
            get
            {
                return this._pnVideo;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pnVideo = value;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer_ChupHinh
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer_ChupHinh;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer_ChupHinh_Tick);
                if (this._Timer_ChupHinh != null)
                {
                    this._Timer_ChupHinh.Tick -= value2;
                }
                this._Timer_ChupHinh = value;
                if (this._Timer_ChupHinh != null)
                {
                    this._Timer_ChupHinh.Tick += value2;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer Timer_docMaVach
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer_docMaVach;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer_docMaVach_Tick);
                if (this._Timer_docMaVach != null)
                {
                    this._Timer_docMaVach.Tick -= value2;
                }
                this._Timer_docMaVach = value;
                if (this._Timer_docMaVach != null)
                {
                    this._Timer_docMaVach.Tick += value2;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer Timer_KhoiTaoLai
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Timer_KhoiTaoLai;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Timer_KhoiTaoLai_Tick);
                if (this._Timer_KhoiTaoLai != null)
                {
                    this._Timer_KhoiTaoLai.Tick -= value2;
                }
                this._Timer_KhoiTaoLai = value;
                if (this._Timer_KhoiTaoLai != null)
                {
                    this._Timer_KhoiTaoLai.Tick += value2;
                }
            }
        }

        internal virtual Label lbPhuongTien
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbPhuongTien;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbPhuongTien = value;
            }
        }

        internal virtual Label lbSoNguoi
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbSoNguoi;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbSoNguoi = value;
            }
        }

        internal virtual Label lbSoNguoiiiii
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbSoNguoiiiii;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbSoNguoiiiii = value;
            }
        }

        internal virtual Label lbTTHangHoa
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbTTHangHoa;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbTTHangHoa = value;
            }
        }

        internal virtual Label lbTaiTrongHangHoaaa
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lbTaiTrongHangHoaaa;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Label3_Click);
                if (this._lbTaiTrongHangHoaaa != null)
                {
                    this._lbTaiTrongHangHoaaa.Click -= value2;
                }
                this._lbTaiTrongHangHoaaa = value;
                if (this._lbTaiTrongHangHoaaa != null)
                {
                    this._lbTaiTrongHangHoaaa.Click += value2;
                }
            }
        }

        public virtual VoicePhone phone
        {
            [DebuggerNonUserCode]
            get
            {
                return this._phone;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                VoicePhone.StatusEventHandler obj = new VoicePhone.StatusEventHandler(this.VoiPhoneStatus);
                if (this._phone != null)
                {
                    this._phone.Status -= obj;
                }
                this._phone = value;
                if (this._phone != null)
                {
                    this._phone.Status += obj;
                }
            }
        }

        public virtual VideoCapture _ChupHinhXe
        {
            [DebuggerNonUserCode]
            get
            {
                return this.__ChupHinhXe;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                VideoCapture.CaptureHandler value2 = new VideoCapture.CaptureHandler(this.LuuHinhAnh);
                if (this.__ChupHinhXe != null)
                {
                    this.__ChupHinhXe.CaptureComplete -= value2;
                }
                this.__ChupHinhXe = value;
                if (this.__ChupHinhXe != null)
                {
                    this.__ChupHinhXe.CaptureComplete += value2;
                }
            }
        }

        public bool ConnectMayNhanDang
        {
            get
            {
                return this.pbTrangThaiMang.BackColor == Color.White;
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
            this.TimerNgayGio = new System.Windows.Forms.Timer(this.components);
            this.lbMaVeXe = new Label();
            this.lbPhanLoaiDuoiLan = new Label();
            this.lbBienSoDuoiLan = new Label();
            this.Label9 = new Label();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.ssTime = new StatusStrip();
            this.tslbThongTin = new ToolStripStatusLabel();
            this.tssNhanVien = new ToolStripStatusLabel();
            this.tssCatruc = new ToolStripStatusLabel();
            this.tssCabin = new ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
            this.lbTenTramThuPhi = new Label();
            this.lbGiaVe = new Label();
            this.lbPhanLoaiiii = new Label();
            this.lbThongTinVe = new Label();
            this.lbBienSoXeCSDL = new Label();
            this.lbBienSoooo = new Label();
            this.TimerKiemTraDuLieuCu = new System.Windows.Forms.Timer(this.components);
            this.pnStatusCarIn2 = new Panel();
            this.pnStatusCarIn1 = new Panel();
            this.lbGio = new Label();
            this.pbPhone = new PictureBox();
            this.pbBarrer = new PictureBox();
            this.pbTrangThaiLan = new PictureBox();
            this.pbTrangThaiMang = new PictureBox();
            this.pbClose = new PictureBox();
            this.pbAnhXeVaoLan = new PictureBox();
            this.pnVideo = new Panel();
            this.Timer_ChupHinh = new System.Windows.Forms.Timer(this.components);
            this.Timer_docMaVach = new System.Windows.Forms.Timer(this.components);
            this.Timer_KhoiTaoLai = new System.Windows.Forms.Timer(this.components);
            this.lbPhuongTien = new Label();
            this.lbSoNguoi = new Label();
            this.lbSoNguoiiiii = new Label();
            this.lbTTHangHoa = new Label();
            this.lbTaiTrongHangHoaaa = new Label();
            this.DocMaVach = new UcDocMaVach();
            this.Console = new UcConsole();
            this.Controller = new UcController();
            this.UcComPort = new UcSerialPort();
            this.ssTime.SuspendLayout();
            ((ISupportInitialize)this.pbPhone).BeginInit();
            ((ISupportInitialize)this.pbBarrer).BeginInit();
            ((ISupportInitialize)this.pbTrangThaiLan).BeginInit();
            ((ISupportInitialize)this.pbTrangThaiMang).BeginInit();
            ((ISupportInitialize)this.pbClose).BeginInit();
            ((ISupportInitialize)this.pbAnhXeVaoLan).BeginInit();
            this.SuspendLayout();
            this.TimerNgayGio.Enabled = true;
            this.TimerNgayGio.Interval = 1000;
            this.lbMaVeXe.Anchor = AnchorStyles.Bottom;
            this.lbMaVeXe.Font = new Font("Arial", 22f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbMaVeXe.ForeColor = Color.FromArgb(192, 192, 255);
            Control arg_2D6_0 = this.lbMaVeXe;
            Point location = new Point(251, 654);
            arg_2D6_0.Location = location;
            this.lbMaVeXe.Name = "lbMaVeXe";
            Control arg_300_0 = this.lbMaVeXe;
            Size size = new Size(343, 40);
            arg_300_0.Size = size;
            this.lbMaVeXe.TabIndex = 110;
            this.lbMaVeXe.Text = "K221107120000";
            this.lbMaVeXe.TextAlign = ContentAlignment.MiddleLeft;
            this.lbPhanLoaiDuoiLan.BackColor = Color.Transparent;
            this.lbPhanLoaiDuoiLan.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.lbPhanLoaiDuoiLan.ForeColor = Color.Red;
            Control arg_388_0 = this.lbPhanLoaiDuoiLan;
            location = new Point(251, 587);
            arg_388_0.Location = location;
            this.lbPhanLoaiDuoiLan.Name = "lbPhanLoaiDuoiLan";
            Control arg_3B2_0 = this.lbPhanLoaiDuoiLan;
            size = new Size(245, 53);
            arg_3B2_0.Size = size;
            this.lbPhanLoaiDuoiLan.TabIndex = 109;
            this.lbPhanLoaiDuoiLan.Text = "3";
            this.lbPhanLoaiDuoiLan.TextAlign = ContentAlignment.MiddleLeft;
            this.lbBienSoDuoiLan.BackColor = Color.Transparent;
            this.lbBienSoDuoiLan.FlatStyle = FlatStyle.Flat;
            this.lbBienSoDuoiLan.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbBienSoDuoiLan.ForeColor = Color.FromArgb(0, 192, 0);
            Control arg_449_0 = this.lbBienSoDuoiLan;
            location = new Point(251, 543);
            arg_449_0.Location = location;
            this.lbBienSoDuoiLan.Name = "lbBienSoDuoiLan";
            Control arg_473_0 = this.lbBienSoDuoiLan;
            size = new Size(229, 40);
            arg_473_0.Size = size;
            this.lbBienSoDuoiLan.TabIndex = 108;
            this.lbBienSoDuoiLan.Text = "54P4-8920";
            this.lbBienSoDuoiLan.TextAlign = ContentAlignment.MiddleLeft;
            this.Label9.Anchor = AnchorStyles.Bottom;
            this.Label9.AutoSize = true;
            this.Label9.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label9.ForeColor = Color.White;
            Control arg_4FC_0 = this.Label9;
            location = new Point(87, 599);
            arg_4FC_0.Location = location;
            this.Label9.Name = "Label9";
            Control arg_526_0 = this.Label9;
            size = new Size(144, 31);
            arg_526_0.Size = size;
            this.Label9.TabIndex = 106;
            this.Label9.Text = "Phân loại:";
            this.Label8.Anchor = AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label8.ForeColor = Color.White;
            Control arg_5A2_0 = this.Label8;
            location = new Point(87, 655);
            arg_5A2_0.Location = location;
            this.Label8.Name = "Label8";
            Control arg_5CC_0 = this.Label8;
            size = new Size(139, 31);
            arg_5CC_0.Size = size;
            this.Label8.TabIndex = 105;
            this.Label8.Text = "Mã vé xe:";
            this.Label7.Anchor = AnchorStyles.Bottom;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = Color.White;
            Control arg_648_0 = this.Label7;
            location = new Point(87, 543);
            arg_648_0.Location = location;
            this.Label7.Name = "Label7";
            Control arg_672_0 = this.Label7;
            size = new Size(158, 31);
            arg_672_0.Size = size;
            this.Label7.TabIndex = 104;
            this.Label7.Text = "Biển số xe:";
            this.ssTime.Items.AddRange(new ToolStripItem[]
            {
                this.tslbThongTin,
                this.tssNhanVien,
                this.tssCatruc,
                this.tssCabin,
                this.ToolStripStatusLabel1
            });
            Control arg_6ED_0 = this.ssTime;
            location = new Point(0, 736);
            arg_6ED_0.Location = location;
            this.ssTime.Name = "ssTime";
            Control arg_717_0 = this.ssTime;
            size = new Size(1366, 32);
            arg_717_0.Size = size;
            this.ssTime.TabIndex = 111;
            this.ssTime.Text = "StatusStrip1";
            this.tslbThongTin.AutoSize = false;
            this.tslbThongTin.BackColor = SystemColors.Control;
            this.tslbThongTin.BorderSides = ToolStripStatusLabelBorderSides.Right;
            this.tslbThongTin.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.tslbThongTin.ForeColor = Color.Red;
            this.tslbThongTin.Name = "tslbThongTin";
            ToolStripItem arg_7B3_0 = this.tslbThongTin;
            size = new Size(450, 27);
            arg_7B3_0.Size = size;
            this.tslbThongTin.Text = "Đưa thẻ nhân viên vào máy đọc thẻ";
            this.tslbThongTin.TextAlign = ContentAlignment.MiddleLeft;
            this.tssNhanVien.BackColor = SystemColors.Control;
            this.tssNhanVien.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
            this.tssNhanVien.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.tssNhanVien.ForeColor = Color.Black;
            this.tssNhanVien.Image = Properties.Resources.Employee;
            this.tssNhanVien.Name = "tssNhanVien";
            ToolStripItem arg_85E_0 = this.tssNhanVien;
            size = new Size(631, 27);
            arg_85E_0.Size = size;
            this.tssNhanVien.Spring = true;
            this.tssNhanVien.Text = "( chưa đăng nhập)";
            this.tssCatruc.AutoSize = false;
            this.tssCatruc.BackColor = SystemColors.Control;
            this.tssCatruc.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
            this.tssCatruc.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.tssCatruc.ForeColor = Color.Black;
            this.tssCatruc.Name = "tssCatruc";
            ToolStripItem arg_8F6_0 = this.tssCatruc;
            size = new Size(100, 27);
            arg_8F6_0.Size = size;
            this.tssCatruc.Text = "Ca trực: ";
            this.tssCabin.AutoSize = false;
            this.tssCabin.BackColor = SystemColors.Control;
            this.tssCabin.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
            this.tssCabin.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.tssCabin.ForeColor = Color.Black;
            this.tssCabin.Name = "tssCabin";
            ToolStripItem arg_982_0 = this.tssCabin;
            size = new Size(80, 27);
            arg_982_0.Size = size;
            this.tssCabin.Text = "Làn: ";
            this.ToolStripStatusLabel1.AutoSize = false;
            this.ToolStripStatusLabel1.BackColor = SystemColors.Control;
            this.ToolStripStatusLabel1.BorderSides = ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabel1.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.ToolStripStatusLabel1.ForeColor = Color.Black;
            this.ToolStripStatusLabel1.Image = Properties.Resources.test;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripItem arg_A29_0 = this.ToolStripStatusLabel1;
            size = new Size(90, 27);
            arg_A29_0.Size = size;
            this.ToolStripStatusLabel1.Text = "161114VD";
            this.lbTenTramThuPhi.Anchor = AnchorStyles.Top;
            this.lbTenTramThuPhi.AutoSize = true;
            this.lbTenTramThuPhi.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbTenTramThuPhi.ForeColor = Color.LightGreen;
            Control arg_A98_0 = this.lbTenTramThuPhi;
            location = new Point(305, 24);
            arg_A98_0.Location = location;
            this.lbTenTramThuPhi.Name = "lbTenTramThuPhi";
            Control arg_AC2_0 = this.lbTenTramThuPhi;
            size = new Size(757, 55);
            arg_AC2_0.Size = size;
            this.lbTenTramThuPhi.TabIndex = 112;
            this.lbTenTramThuPhi.Text = "TRẠM THU PHÍ ĐẠI YÊN - QL18";
            this.lbTenTramThuPhi.TextAlign = ContentAlignment.MiddleCenter;
            this.lbGiaVe.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.lbGiaVe.AutoSize = true;
            this.lbGiaVe.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbGiaVe.ForeColor = Color.SpringGreen;
            Control arg_B4F_0 = this.lbGiaVe;
            location = new Point(854, 681);
            arg_B4F_0.Location = location;
            Control arg_B69_0 = this.lbGiaVe;
            size = new Size(253, 30);
            arg_B69_0.MaximumSize = size;
            Control arg_B83_0 = this.lbGiaVe;
            size = new Size(420, 40);
            arg_B83_0.MinimumSize = size;
            this.lbGiaVe.Name = "lbGiaVe";
            Control arg_BAD_0 = this.lbGiaVe;
            size = new Size(420, 40);
            arg_BAD_0.Size = size;
            this.lbGiaVe.TabIndex = 129;
            this.lbGiaVe.Text = "NGÀY HẾT HẠN: 25/01/2009";
            this.lbGiaVe.TextAlign = ContentAlignment.MiddleCenter;
            this.lbPhanLoaiiii.Anchor = AnchorStyles.Bottom;
            this.lbPhanLoaiiii.AutoSize = true;
            this.lbPhanLoaiiii.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbPhanLoaiiii.ForeColor = Color.White;
            Control arg_C3C_0 = this.lbPhanLoaiiii;
            location = new Point(728, 292);
            arg_C3C_0.Location = location;
            this.lbPhanLoaiiii.Name = "lbPhanLoaiiii";
            Control arg_C66_0 = this.lbPhanLoaiiii;
            size = new Size(178, 31);
            arg_C66_0.Size = size;
            this.lbPhanLoaiiii.TabIndex = 128;
            this.lbPhanLoaiiii.Text = "Phương tiện:";
            this.lbThongTinVe.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.lbThongTinVe.AutoSize = true;
            this.lbThongTinVe.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbThongTinVe.ForeColor = Color.FromArgb(192, 192, 255);
            Control arg_CF8_0 = this.lbThongTinVe;
            location = new Point(854, 646);
            arg_CF8_0.Location = location;
            Control arg_D12_0 = this.lbThongTinVe;
            size = new Size(253, 30);
            arg_D12_0.MaximumSize = size;
            Control arg_D2C_0 = this.lbThongTinVe;
            size = new Size(420, 40);
            arg_D2C_0.MinimumSize = size;
            this.lbThongTinVe.Name = "lbThongTinVe";
            Control arg_D56_0 = this.lbThongTinVe;
            size = new Size(420, 40);
            arg_D56_0.Size = size;
            this.lbThongTinVe.TabIndex = 126;
            this.lbThongTinVe.Text = "VÉ SAI PHÂN LOẠI";
            this.lbThongTinVe.TextAlign = ContentAlignment.MiddleCenter;
            this.lbBienSoXeCSDL.Anchor = AnchorStyles.Bottom;
            this.lbBienSoXeCSDL.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbBienSoXeCSDL.ForeColor = Color.FromArgb(0, 192, 0);
            Control arg_DDD_0 = this.lbBienSoXeCSDL;
            location = new Point(913, 236);
            arg_DDD_0.Location = location;
            this.lbBienSoXeCSDL.Name = "lbBienSoXeCSDL";
            Control arg_E07_0 = this.lbBienSoXeCSDL;
            size = new Size(229, 40);
            arg_E07_0.Size = size;
            this.lbBienSoXeCSDL.TabIndex = 125;
            this.lbBienSoXeCSDL.Text = "54P4-8920";
            this.lbBienSoXeCSDL.TextAlign = ContentAlignment.MiddleLeft;
            this.lbBienSoooo.Anchor = AnchorStyles.Bottom;
            this.lbBienSoooo.AutoSize = true;
            this.lbBienSoooo.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbBienSoooo.ForeColor = Color.White;
            Control arg_E93_0 = this.lbBienSoooo;
            location = new Point(778, 243);
            arg_E93_0.Location = location;
            this.lbBienSoooo.Name = "lbBienSoooo";
            Control arg_EBD_0 = this.lbBienSoooo;
            size = new Size(128, 31);
            arg_EBD_0.Size = size;
            this.lbBienSoooo.TabIndex = 124;
            this.lbBienSoooo.Text = "Biển số :";
            this.TimerKiemTraDuLieuCu.Enabled = true;
            this.TimerKiemTraDuLieuCu.Interval = 120000;
            Control arg_F0F_0 = this.pnStatusCarIn2;
            location = new Point(8, 571);
            arg_F0F_0.Location = location;
            this.pnStatusCarIn2.Name = "pnStatusCarIn2";
            Control arg_F36_0 = this.pnStatusCarIn2;
            size = new Size(70, 70);
            arg_F36_0.Size = size;
            this.pnStatusCarIn2.TabIndex = 143;
            this.pnStatusCarIn1.BackColor = Color.Transparent;
            Control arg_F6F_0 = this.pnStatusCarIn1;
            location = new Point(8, 654);
            arg_F6F_0.Location = location;
            this.pnStatusCarIn1.Name = "pnStatusCarIn1";
            Control arg_F96_0 = this.pnStatusCarIn1;
            size = new Size(70, 70);
            arg_F96_0.Size = size;
            this.pnStatusCarIn1.TabIndex = 142;
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.lbGio.ForeColor = Color.Yellow;
            Control arg_FF8_0 = this.lbGio;
            location = new Point(3, 5);
            arg_FF8_0.Location = location;
            this.lbGio.Name = "lbGio";
            Control arg_1022_0 = this.lbGio;
            size = new Size(269, 29);
            arg_1022_0.Size = size;
            this.lbGio.TabIndex = 145;
            this.lbGio.Text = "08/08/2012 -  09:09:09";
            this.pbPhone.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.pbPhone.BackColor = Color.Black;
            Control arg_1078_0 = this.pbPhone;
            location = new Point(1106, 0);
            arg_1078_0.Location = location;
            this.pbPhone.Name = "pbPhone";
            Control arg_109F_0 = this.pbPhone;
            size = new Size(52, 48);
            arg_109F_0.Size = size;
            this.pbPhone.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 146;
            this.pbPhone.TabStop = false;
            this.pbBarrer.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.pbBarrer.Image = Properties.Resources.BarierRaDong;
            Control arg_1108_0 = this.pbBarrer;
            location = new Point(1210, 0);
            arg_1108_0.Location = location;
            this.pbBarrer.Name = "pbBarrer";
            Control arg_112F_0 = this.pbBarrer;
            size = new Size(52, 48);
            arg_112F_0.Size = size;
            this.pbBarrer.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbBarrer.TabIndex = 131;
            this.pbBarrer.TabStop = false;
            this.pbTrangThaiLan.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.pbTrangThaiLan.Image = Properties.Resources.LanDong;
            Control arg_1198_0 = this.pbTrangThaiLan;
            location = new Point(1158, 0);
            arg_1198_0.Location = location;
            this.pbTrangThaiLan.Name = "pbTrangThaiLan";
            Control arg_11BF_0 = this.pbTrangThaiLan;
            size = new Size(52, 48);
            arg_11BF_0.Size = size;
            this.pbTrangThaiLan.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbTrangThaiLan.TabIndex = 132;
            this.pbTrangThaiLan.TabStop = false;
            this.pbTrangThaiMang.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.pbTrangThaiMang.BackColor = Color.White;
            this.pbTrangThaiMang.Image = Properties.Resources.ketnoimang;
            Control arg_1238_0 = this.pbTrangThaiMang;
            location = new Point(1262, 0);
            arg_1238_0.Location = location;
            this.pbTrangThaiMang.Name = "pbTrangThaiMang";
            Control arg_125F_0 = this.pbTrangThaiMang;
            size = new Size(52, 48);
            arg_125F_0.Size = size;
            this.pbTrangThaiMang.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbTrangThaiMang.TabIndex = 130;
            this.pbTrangThaiMang.TabStop = false;
            this.pbClose.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.pbClose.Image = Properties.Resources.Close;
            Control arg_12C8_0 = this.pbClose;
            location = new Point(1314, 0);
            arg_12C8_0.Location = location;
            this.pbClose.Name = "pbClose";
            Control arg_12EF_0 = this.pbClose;
            size = new Size(52, 48);
            arg_12EF_0.Size = size;
            this.pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 102;
            this.pbClose.TabStop = false;
            this.pbAnhXeVaoLan.BackColor = Color.Gainsboro;
            // Hoang comment this.pbAnhXeVaoLan.Image = (Image)componentResourceManager.GetObject("pbAnhXeVaoLan.Image");
            Control arg_1356_0 = this.pbAnhXeVaoLan;
            location = new Point(93, 85);
            arg_1356_0.Location = location;
            this.pbAnhXeVaoLan.Name = "pbAnhXeVaoLan";
            Control arg_1383_0 = this.pbAnhXeVaoLan;
            size = new Size(576, 432);
            arg_1383_0.Size = size;
            this.pbAnhXeVaoLan.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbAnhXeVaoLan.TabIndex = 133;
            this.pbAnhXeVaoLan.TabStop = false;
            this.pnVideo.BackColor = Color.Silver;
            Control arg_13D2_0 = this.pnVideo;
            location = new Point(93, 85);
            arg_13D2_0.Location = location;
            this.pnVideo.Name = "pnVideo";
            Control arg_13FF_0 = this.pnVideo;
            size = new Size(576, 432);
            arg_13FF_0.Size = size;
            this.pnVideo.TabIndex = 147;
            this.Timer_ChupHinh.Enabled = true;
            this.Timer_ChupHinh.Interval = 200;
            this.Timer_docMaVach.Interval = 2000;
            this.Timer_KhoiTaoLai.Interval = 600000;
            this.lbPhuongTien.Anchor = AnchorStyles.Bottom;
            this.lbPhuongTien.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbPhuongTien.ForeColor = Color.FromArgb(0, 192, 0);
            Control arg_14A8_0 = this.lbPhuongTien;
            location = new Point(913, 286);
            arg_14A8_0.Location = location;
            this.lbPhuongTien.Name = "lbPhuongTien";
            Control arg_14D2_0 = this.lbPhuongTien;
            size = new Size(441, 40);
            arg_14D2_0.Size = size;
            this.lbPhuongTien.TabIndex = 148;
            this.lbPhuongTien.Text = "54P4-8920";
            this.lbPhuongTien.TextAlign = ContentAlignment.MiddleLeft;
            this.lbSoNguoi.Anchor = AnchorStyles.Bottom;
            this.lbSoNguoi.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbSoNguoi.ForeColor = Color.FromArgb(0, 192, 0);
            Control arg_155C_0 = this.lbSoNguoi;
            location = new Point(913, 336);
            arg_155C_0.Location = location;
            this.lbSoNguoi.Name = "lbSoNguoi";
            Control arg_1586_0 = this.lbSoNguoi;
            size = new Size(229, 40);
            arg_1586_0.Size = size;
            this.lbSoNguoi.TabIndex = 150;
            this.lbSoNguoi.Text = "54P4-8920";
            this.lbSoNguoi.TextAlign = ContentAlignment.MiddleLeft;
            this.lbSoNguoiiiii.Anchor = AnchorStyles.Bottom;
            this.lbSoNguoiiiii.AutoSize = true;
            this.lbSoNguoiiiii.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbSoNguoiiiii.ForeColor = Color.White;
            Control arg_1615_0 = this.lbSoNguoiiiii;
            location = new Point(767, 343);
            arg_1615_0.Location = location;
            this.lbSoNguoiiiii.Name = "lbSoNguoiiiii";
            Control arg_163F_0 = this.lbSoNguoiiiii;
            size = new Size(137, 31);
            arg_163F_0.Size = size;
            this.lbSoNguoiiiii.TabIndex = 149;
            this.lbSoNguoiiiii.Text = "Số người:";
            this.lbTTHangHoa.Anchor = AnchorStyles.Bottom;
            this.lbTTHangHoa.Font = new Font("Microsoft Sans Serif", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbTTHangHoa.ForeColor = Color.FromArgb(0, 192, 0);
            Control arg_16BC_0 = this.lbTTHangHoa;
            location = new Point(913, 388);
            arg_16BC_0.Location = location;
            this.lbTTHangHoa.Name = "lbTTHangHoa";
            Control arg_16E6_0 = this.lbTTHangHoa;
            size = new Size(229, 40);
            arg_16E6_0.Size = size;
            this.lbTTHangHoa.TabIndex = 152;
            this.lbTTHangHoa.Text = "54P4-8920";
            this.lbTTHangHoa.TextAlign = ContentAlignment.MiddleLeft;
            this.lbTaiTrongHangHoaaa.Anchor = AnchorStyles.Bottom;
            this.lbTaiTrongHangHoaaa.AutoSize = true;
            this.lbTaiTrongHangHoaaa.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbTaiTrongHangHoaaa.ForeColor = Color.White;
            Control arg_1775_0 = this.lbTaiTrongHangHoaaa;
            location = new Point(719, 395);
            arg_1775_0.Location = location;
            this.lbTaiTrongHangHoaaa.Name = "lbTaiTrongHangHoaaa";
            Control arg_179F_0 = this.lbTaiTrongHangHoaaa;
            size = new Size(187, 31);
            arg_179F_0.Size = size;
            this.lbTaiTrongHangHoaaa.TabIndex = 151;
            this.lbTaiTrongHangHoaaa.Text = "TT hàng hóa:";
            this.DocMaVach.CongComThat = true;
            Control arg_17E2_0 = this.DocMaVach;
            location = new Point(72, 37);
            arg_17E2_0.Location = location;
            this.DocMaVach.Name = "DocMaVach";
            Control arg_1809_0 = this.DocMaVach;
            size = new Size(111, 21);
            arg_1809_0.Size = size;
            this.DocMaVach.TabIndex = 139;
            this.DocMaVach.Visible = false;
            this.Console.BackColor = Color.White;
            this.Console.BaudRate = 0;
            this.Console.ComPortName = null;
            Control arg_1867_0 = this.Console;
            location = new Point(203, 57);
            arg_1867_0.Location = location;
            Control arg_187E_0 = this.Console;
            size = new Size(87, 22);
            arg_187E_0.MinimumSize = size;
            this.Console.Name = "Console";
            Control arg_18A5_0 = this.Console;
            size = new Size(87, 22);
            arg_18A5_0.Size = size;
            this.Console.TabIndex = 138;
            this.Console.Visible = false;
            this.Controller.BackColor = Color.Gainsboro;
            this.Controller.ForeColor = SystemColors.ButtonFace;
            Control arg_18F8_0 = this.Controller;
            location = new Point(12, 85);
            arg_18F8_0.Location = location;
            this.Controller.Name = "Controller";
            Control arg_191F_0 = this.Controller;
            size = new Size(59, 28);
            arg_191F_0.Size = size;
            this.Controller.TabIndex = 137;
            this.Controller.Visible = false;
            Control arg_1955_0 = this.UcComPort;
            location = new Point(12, 128);
            arg_1955_0.Location = location;
            Control arg_196C_0 = this.UcComPort;
            size = new Size(82, 31);
            arg_196C_0.MaximumSize = size;
            Control arg_1983_0 = this.UcComPort;
            size = new Size(82, 31);
            arg_1983_0.MinimumSize = size;
            this.UcComPort.Name = "UcComPort";
            Control arg_19AA_0 = this.UcComPort;
            size = new Size(82, 31);
            arg_19AA_0.Size = size;
            this.UcComPort.TabIndex = 4;
            this.UcComPort.Visible = false;
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            size = new Size(1366, 768);
            this.ClientSize = size;
            this.Controls.Add(this.lbTTHangHoa);
            this.Controls.Add(this.lbTaiTrongHangHoaaa);
            this.Controls.Add(this.lbSoNguoi);
            this.Controls.Add(this.lbSoNguoiiiii);
            this.Controls.Add(this.lbPhuongTien);
            this.Controls.Add(this.pnVideo);
            this.Controls.Add(this.pbPhone);
            this.Controls.Add(this.lbGio);
            this.Controls.Add(this.lbTenTramThuPhi);
            this.Controls.Add(this.pnStatusCarIn2);
            this.Controls.Add(this.pnStatusCarIn1);
            this.Controls.Add(this.DocMaVach);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.lbThongTinVe);
            this.Controls.Add(this.Controller);
            this.Controls.Add(this.pbBarrer);
            this.Controls.Add(this.pbTrangThaiLan);
            this.Controls.Add(this.pbTrangThaiMang);
            this.Controls.Add(this.lbGiaVe);
            this.Controls.Add(this.lbPhanLoaiiii);
            this.Controls.Add(this.lbBienSoXeCSDL);
            this.Controls.Add(this.lbBienSoooo);
            this.Controls.Add(this.ssTime);
            this.Controls.Add(this.lbMaVeXe);
            this.Controls.Add(this.lbPhanLoaiDuoiLan);
            this.Controls.Add(this.lbBienSoDuoiLan);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.UcComPort);
            this.Controls.Add(this.pbAnhXeVaoLan);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.ico.GetHicon());;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TollCabin";
            this.ssTime.ResumeLayout(false);
            this.ssTime.PerformLayout();
            ((ISupportInitialize)this.pbPhone).EndInit();
            ((ISupportInitialize)this.pbBarrer).EndInit();
            ((ISupportInitialize)this.pbTrangThaiLan).EndInit();
            ((ISupportInitialize)this.pbTrangThaiMang).EndInit();
            ((ISupportInitialize)this.pbClose).EndInit();
            ((ISupportInitialize)this.pbAnhXeVaoLan).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void pnStatusCar1SetColor(Color ColorName)
        {
            this.pnStatusCarIn1.BackColor = ColorName;
        }

        private void pnStatusCar2SetColor(Color ColorName)
        {
            this.pnStatusCarIn2.BackColor = ColorName;
        }

        private void lbBienSoDuoiLanSet(string str)
        {
            this.lbBienSoDuoiLan.Text = str;
        }

        private void lbBienSoXeCSDLSet(object str)
        {
            this.lbBienSoXeCSDL.Text = Conversions.ToString(str);
        }

        private void lbPhanLoaiXeDuoiLanSet(string str)
        {
            this.lbPhanLoaiDuoiLan.Text = str;
        }

        private void lbMaVeXeSet(string str)
        {
            this.lbMaVeXe.Text = str;
        }

        private void lbThongTinVeSet(string str)
        {
            this.lbThongTinVe.Text = str;
        }

        private void lbGiaVeSet(string str)
        {
            this.lbGiaVe.Text = str;
        }

        private void pbAnhXeVaoLanSet(Image imgs)
        {
            this.pbAnhXeVaoLan.Image = imgs;
        }

        public frmMain()
        {
            base.FormClosed += new FormClosedEventHandler(this.frmMain_FormClosed);
            base.Load += new EventHandler(this.frmMain_Load);
            this._flagDangSaveVideo = false;
            this.SoVeUuTienDoan = "";
            this.FlagUuTienLuot = false;
            this.SoVeUuTienTienLuot = "";
            this.LenhNhanDangBienSo = false;
            this.TrangThaiPortVao = UcController.TrangThaiPortVao.KhongKetNoi;
            this.VeLuotPhanLoaiTruoc = "";
            this.FlagTinhNangThoai = false;
            this.TimeUuTienLuot = DateAndTime.Now;
            this.FlagHuyDuLieuXe = true;
            this.FlagKiemTraVungTu = false;
            this.PhanLoaiXeVuaQua = 0;
            this._FileNameAnhXe = "";
            this._flagChupHinh = false;
            this.InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FlagUuTienDoan = false;
            this.HangDoiXeVaoTram = new QueueXeQuaTram();
            this.VideoData = new DVR();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this._VideoXeQua = new ClassTaoVideo();
            this._VideoXeQua.FlagLuuVideo = false;
            this.TimeReplication = DateAndTime.Now;
            this.TimeUuTienLuot = DateAndTime.Now;
            string userID = "";
            string passID = "";
            string initialCatalog = "";
            string str = "";
            string arg_A6_0 = MyProject.Application.Info.DirectoryPath + "\\TollcabinConfig.xml";
            int lanXeMain = (int)ModuleKhaiBaoConst.LanXeMain;
            bool arg_B3_0 = ModuleKhac.ReadConfig(arg_A6_0, ref initialCatalog, ref userID, ref passID, ref lanXeMain, ref ModuleKhaiBaoConst.IPMayGiamSatMain, ref ModuleKhaiBaoConst.IPMayNhanDangMain, ref ModuleKhaiBaoConst.LocalImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathBSMain, ref ModuleKhaiBaoConst.PortDuLieuChinhMain, ref ModuleKhaiBaoConst.PortDuLieuCuMain, ref ModuleKhaiBaoConst.PortGiupDoMain, ref ModuleKhaiBaoConst.PortMayNhanDangMain, ref ModuleKhaiBaoConst.TramIdMain, ref ModuleKhaiBaoConst.StatusMain, ref str);
            checked
            {
                ModuleKhaiBaoConst.LanXeMain = (byte)lanXeMain;
                if (!arg_B3_0)
                {
                    Interaction.MsgBox("Không đọc được file TollcabinConfig.xml", MsgBoxStyle.OkOnly, null);
                    frmConfig frmConfig = new frmConfig();
                    frmConfig.ShowDialog();
                    Application.Exit();
                    return;
                }
                this.SysTempLoad();
                if (Operators.CompareString(Conversions.ToString(ModuleKhaiBaoConst.ServerImagesPathMain[ModuleKhaiBaoConst.ServerImagesPathMain.Length - 1]), "\\", false) != 0)
                {
                    ModuleKhaiBaoConst.ServerImagesPathMain += "\\";
                }
                if (Operators.CompareString(Conversions.ToString(ModuleKhaiBaoConst.LocalImagesPathMain[ModuleKhaiBaoConst.LocalImagesPathMain.Length - 1]), "\\", false) != 0)
                {
                    ModuleKhaiBaoConst.LocalImagesPathMain += "\\";
                }
                ModuleKhaiBaoConst.StrConnectMain = ModuleKhac.KetNoi(Dns.GetHostName() + str, initialCatalog, userID, passID);
                if (Operators.CompareString(ModuleKhaiBaoConst.StrConnectMain, null, false) == 0)
                {
                    frmChoKetNoi frmChoKetNoi = new frmChoKetNoi();
                    frmChoKetNoi.ShowDialog();
                    ModuleKhaiBaoConst.StrConnectMain = ModuleKhac.KetNoi(Dns.GetHostName() + str, initialCatalog, userID, passID);
                    if (Operators.CompareString(ModuleKhaiBaoConst.StrConnectMain, null, false) == 0)
                    {
                        MessageBox.Show("Không kết nối được cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();
                        return;
                    }
                }
                this.tssCabin.Text = "Làn: " + Conversions.ToString(ModuleKhaiBaoConst.LanXeMain);
                this.Controller.MoLan = false;
                this.Controller.MoDenHongNgoai = false;
                this.Controller.PhanLoaiXe = 0;
                this.UcComPort.spLed_LanMo = false;
                this.ResetForm();
                try
                {
                    this._ChupHinhXe = new VideoCapture();
                    this._ChupHinhXe.InitDevice(this.pnVideo);
                }
                catch (Exception expr_240)
                {
                    ProjectData.SetProjectError(expr_240);
                    Interaction.MsgBox("Không kết nối được thiết bị video", MsgBoxStyle.OkOnly, null);
                    Application.Exit();
                    ProjectData.ClearProjectError();
                    return;
                }
                this.Timer_docMaVach.Enabled = true;
                this.tssNhanVien.ForeColor = Color.Black;
            }
        }

        private void SysTempLoad()
        {
            try
            {
                ProcessXML processXML = new ProcessXML("TollcabinConfig.xml");
                this.DvrChanel = Conversions.ToInteger(processXML.XmlNodeValue("DVRChanel", "NewInfo", ""));
                this.DvrChanel = Conversions.ToInteger(Interaction.IIf(this.DvrChanel > 0, this.DvrChanel, 0));
                int num = int.Parse(processXML.XmlNodeValue("Status", "General", ""));
                if (num == 101)
                {
                    ModuleKhaiBaoConst.ConsoleMain = true;
                }
                else
                {
                    ModuleKhaiBaoConst.ConsoleMain = false;
                }
                string text = processXML.XmlNodeValue("ComPortDieuKhien", "NewInfo", "");
                this.Controller.KhoiTao(text, 19200);
                if (Operators.CompareString(processXML.XmlNodeValue("TinhNangThoai", "NewInfo", "0"), "0", false) != 0)
                {
                    this.FlagTinhNangThoai = true;
                }
                else
                {
                    this.FlagTinhNangThoai = false;
                }
                bool arg_EE_0 = this.FlagTinhNangThoai;
                text = processXML.XmlNodeValue("ComPortBanPhim", "NewInfo", "");
                this.Console.KhoiTao(text, 4800);
                text = processXML.XmlNodeValue("ComPortBangDien", "NewInfo", "");
                this.UcComPort.OpenSpLed(text, 2400);
                num = int.Parse(processXML.XmlNodeValue("TenDauDoc", "NewInfo", "0"));
                text = processXML.XmlNodeValue("ComPortDauDoc", "NewInfo", "");
                this.DocMaVach.KhoiTao(text, 9600, 0 == num);
                this._IPdauGhiHinh = processXML.XmlNodeValue("videoCard", "NewInfo", "");
                this.VideoData.DVRIP = this._IPdauGhiHinh;
                this.Controller.MoLan = false;
                this.UcComPort.spLed_LanMo = false;
            }
            catch (Exception expr_1C9)
            {
                ProjectData.SetProjectError(expr_1C9);
                Interaction.MsgBox("Không đọc được tập tin cấu hình", MsgBoxStyle.OkOnly, null);
                frmConfig frmConfig = new frmConfig();
                frmConfig.ShowDialog();
                Application.Exit();
                ProjectData.ClearProjectError();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Timer_docMaVach.Enabled = false;
            bool arg_12_0 = this.FlagTinhNangThoai;
            this.Controller.MoLan = false;
            this.Controller.MoDenHongNgoai = false;
            this.Controller.PhanLoaiXe = 0;
            this.UcComPort.spLed_LanMo = false;
            this.Controller.CloseComPort();
            this.UcComPort.CloseSpLed();
            this.UcComPort.CloseSpNhanDang();
            this.Console.Close();
            this.DocMaVach.Close();
        }

        private void TimerNgayGio_Tick(object sender, EventArgs e)
        {
            this.lbGio.Text = Strings.Format(DateAndTime.Now, "dd/MM/yyyy - HH:mm:ss");
            if (DateAndTime.Now.Second % 15 == 0)
            {
                Thread thread = new Thread(delegate (object a0)
                {
                    ModuleKhac.PingGiamSat(Conversions.ToString(a0));
                });
                thread.SetApartmentState(ApartmentState.MTA);
                thread.Start(ModuleKhaiBaoConst.LanXeMain.ToString());
            }
            if (DateAndTime.Now.Second % 30 == 0)
            {
                Thread thread2 = new Thread(delegate (object a0)
                {
                    ModuleKhac.PingNhanDang((PictureBox)a0);
                });
                thread2.SetApartmentState(ApartmentState.MTA);
                thread2.Start(this.pbTrangThaiMang);
            }
        }

        private void UcComPort_ErrorSerialPort(string Message)
        {
            this.tslbThongTin.Text = Message;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerKiemTraDuLieuCu_Tick(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ModuleKhac.SendOldData));
            thread.SetApartmentState(ApartmentState.MTA);
            thread.Start();
            Thread thread2 = new Thread(new ThreadStart(ModuleKhac.CoppyHinhAnhLenServer));
            thread2.SetApartmentState(ApartmentState.MTA);
            thread2.Start();
            Thread thread3 = new Thread(new ThreadStart(ModuleKhac.CoppyVideoLenServer));
            thread3.SetApartmentState(ApartmentState.MTA);
            thread3.Start();
            if ((DateAndTime.Now - this.TimeReplication).TotalMinutes >= 120.0)
            {
                try
                {
                    if (File.Exists("SQLReplication.exe"))
                    {
                        Interaction.Shell("SQLReplication.exe", AppWinStyle.NormalNoFocus, false, -1);
                    }
                }
                catch (Exception expr_9D)
                {
                    ProjectData.SetProjectError(expr_9D);
                    ProjectData.ClearProjectError();
                }
                this.TimeReplication = DateAndTime.Now;
            }
        }

        private void UcComPort_spNhanDang_DataReceive(string Message)
        {
            this.XuLyXe(Message);
        }

        private void UcController1_InPort(byte NumberPort, bool TrangThai)
        {
            if (Operators.CompareString(Strings.Trim(ModuleKhaiBaoConst.MaNhanVienMain), "", false) == 0)
            {
                return;
            }
            if (TrangThai)
            {
                if (NumberPort == this.Controller.VungTuVao)
                {
                    Thread thread = new Thread(new ThreadStart(this.XeVaoVungTu));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else if (NumberPort == this.Controller.VungTuRa)
                {
                    if (this.FlagUuTienDoan)
                    {
                        this.HangDoiXeVaoTram.Insert(this.SoVeUuTienDoan, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                        this.HangDoiXeVaoTram.Send(true);
                        this.FlagHuyDuLieuXe = true;
                        this.UcComPort.spLed_MoiXeQua_UuTien = true;
                        this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                        this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                    }
                    if (this.FlagUuTienDoan | this.FlagUuTienLuot)
                    {
                        return;
                    }
                    if (this.HangDoiXeVaoTram.CoXeHopLe)
                    {
                        this.HangDoiXeVaoTram.Send(true);
                        if (this.PhanLoaiXeVuaQua >= 6)
                        {
                            this.HangDoiXeVaoTram.ResetFront();
                            this.HangDoiXeVaoTram.ResetFront();
                            this.PhanLoaiXeVuaQua = 0;
                        }
                        else if (this.HangDoiXeVaoTram.CoXe)
                        {
                            this.Controller.KiemTraPortVao = true;
                        }
                        if (!this.HangDoiXeVaoTram.CoXe)
                        {
                            this.ResetForm();
                            if (!this.FlagUuTienDoan)
                            {
                                this.UcComPort.spLed_LanMo = true;
                            }
                            else
                            {
                                this.lbThongTinVeSet("ĐOÀN ƯU TIÊN");
                            }
                            if (this.FlagUuTienLuot)
                            {
                                this.lbThongTinVeSet("XE ƯU TIÊN");
                            }
                            this.tslbThongTin.Text = "Hệ thống sẳn sàng";
                        }
                        this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                        this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                        this.FlagHuyDuLieuXe = true;
                        if (!this.HangDoiXeVaoTram.CoXeHopLe)
                        {
                            this.CloseBarrier();
                        }
                        if (!this.HangDoiXeVaoTram.CoXe)
                        {
                            Thread thread2 = new Thread(new ThreadStart(this.KhoiTaoLuuVideo));
                            thread2.SetApartmentState(ApartmentState.MTA);
                            thread2.Start();
                        }
                    }
                    else
                    {
                        this.FlagHuyDuLieuXe = false;
                    }
                }
                else if (NumberPort == this.Controller.BanDapKhanCap)
                {
                    this.Controller.MoChuongBao = true;
                }
                else if (NumberPort == this.Controller.BaoDong)
                {
                    this.Controller.MoChuongBao = true;
                }
            }
            else if (NumberPort != this.Controller.VungTuVao && NumberPort == this.Controller.VungTuRa)
            {
                if (!this.HangDoiXeVaoTram.CoXe)
                {
                    this.VideoData.ClearDVR(this.DvrChanel);
                }
                if (!this.FlagHuyDuLieuXe)
                {
                    this.HangDoiXeVaoTram.Send(true);
                    if (!this.HangDoiXeVaoTram.CoXe)
                    {
                        this.VideoData.ClearDVR(this.DvrChanel);
                        this.ResetForm();
                        if (!this.FlagUuTienDoan)
                        {
                            this.UcComPort.spLed_LanMo = true;
                        }
                        else
                        {
                            this.lbThongTinVeSet("ĐOÀN ƯU TIÊN");
                        }
                        if (this.FlagUuTienLuot)
                        {
                            this.lbThongTinVeSet("XE ƯU TIÊN");
                        }
                        this.tslbThongTin.Text = "Hệ thống sẳn sàng";
                    }
                    this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                    this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                    if (!this.HangDoiXeVaoTram.CoXeHopLe)
                    {
                        this.CloseBarrier();
                    }
                    if (!this.HangDoiXeVaoTram.CoXe)
                    {
                        Thread thread3 = new Thread(new ThreadStart(this.KhoiTaoLuuVideo));
                        thread3.SetApartmentState(ApartmentState.MTA);
                        thread3.Start();
                    }
                }
            }
        }

        private void UcController1_CarOut(int PhanLoaiXe)
        {
            if (Operators.CompareString(Strings.Trim(ModuleKhaiBaoConst.MaNhanVienMain), "", false) == 0)
            {
                return;
            }
            this.HangDoiXeVaoTram.Send(PhanLoaiXe);
            if (!this.HangDoiXeVaoTram.CoXe)
            {
                this.Controller.PhanLoaiXe = 0;
            }
        }

        private void Controller_ControllerError(string Message)
        {
            this.tslbThongTin.Text = Message;
        }

        private void Console_ComPortError(string Message)
        {
            this.tslbThongTin.Text = Message;
        }

        private void Console_DataReceive(int Message)
        {
            if (Operators.CompareString(Strings.Trim(ModuleKhaiBaoConst.MaNhanVienMain), "", false) == 0)
            {
                this.tslbThongTin.Text = "Nhân viên chưa đăng nhập";
                return;
            }
            if (Message == 99)
            {
                this.Controller.MoChuongBao = true;
            }
            else if (Message == 1)
            {
                if (!this.HangDoiXeVaoTram.CoXe)
                {
                    this.XeVaoVungTu();
                }
                XeQuaTram xeQuaTram = new XeQuaTram();
                string text = "";
                VeXe.ChangeVe16To13(ModuleKhaiBaoConst.EnumVe.CuongBuc, ref text);
                this.lbMaVeXeSet(text);
                xeQuaTram = this.HangDoiXeVaoTram.Insert(text, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                this.HangDoiXeVaoTram.Send(false);
                this.UcComPort.spLed_MoiXeQua = true;
                this.OpenBarrier(0, "VÉ CƯỠNG BỨC", "");
                this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                if (Operators.CompareString(xeQuaTram.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) != 0)
                {
                    this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                }
                else
                {
                    this.VideoData.TextOutDVR(this.DvrChanel, "----");
                }
            }
            else if (Message == 81)
            {
                string soVe13Char = "";
                VeXe.ChangeVe16To13(ModuleKhaiBaoConst.EnumVe.ToanQuoc, ref soVe13Char);
                this.XuLyQuetVe(soVe13Char);
            }
            else if (Message == 4)
            {
                string soVe13Char2 = "";
                VeXe.ChangeVe16To13(ModuleKhaiBaoConst.EnumVe.UuTien, ref soVe13Char2);
                this.XuLyQuetVe(soVe13Char2);
            }
            else if (Message == 6)
            {
                string soVe13Char3 = "";
                VeXe.ChangeVe16To13(ModuleKhaiBaoConst.EnumVe.UuTienDoan, ref soVe13Char3);
                this.XuLyQuetVe(soVe13Char3);
            }
            else if (Message == 7)
            {
                this.Controller.MoLan = true;
                this.UcComPort.spLed_LanMo = true;
                this.pbTrangThaiLan.Image = Properties.Resources.LanMo;
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Message == 8)
            {
                this.Controller.MoLan = false;
                this.UcComPort.spLed_LanMo = false;
                this.pbTrangThaiLan.Image = Properties.Resources.LanDong;
                this.Controller.MoLan = false;
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Message == 45)
            {
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.UcComPort.spLed_LanMo = true;
                this.Controller.OpenBarrier = false;
                this.Controller.PhanLoaiXe = 0;
                this.pbBarrer.Image = Properties.Resources.BarierRaDong;
                this.ResetForm();
                this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Message == 2)
            {
                if (!this.phone.TrangThaiKetNoi)
                {
                    if (ModuleKhaiBaoConst.StatusConnectGiamSatMain)
                    {
                        this.phone.CallVoid(ModuleKhaiBaoConst.IPMayGiamSatMain);
                    }
                    else
                    {
                        this.tslbThongTin.Text = "Không tìm thấy máy giám sát";
                    }
                }
                else
                {
                    this.phone.EndCall();
                    this.tslbThongTin.Text = "Đã dừng kết nối";
                }
            }
            else if (Message == 66)
            {
                this.LenhNhanDangBienSo = true;
                if (this.ConnectMayNhanDang)
                {
                    this.Controller.MoDenHongNgoai = true;
                    Thread thread = new Thread(new ThreadStart(this.NhanDangBienSo));
                    thread.SetApartmentState(ApartmentState.MTA);
                    thread.Start();
                }
            }
        }

        private void VoiPhoneStatus(int TrangThai, string TenMayKetNoi)
        {
            switch (TrangThai)
            {
                case 0:
                    this.tslbThongTin.Text = "Máy giám sát đang bận";
                    this.pbPhone.BackColor = Color.Black;
                    break;
                case 1:
                    this.tslbThongTin.Text = "Đã ngừng kết nối máy giám sát";
                    this.pbPhone.BackColor = Color.Black;
                    break;
                case 2:
                    this.tslbThongTin.Text = "Đã kết nối máy giám sát";
                    this.pbPhone.BackColor = Color.SpringGreen;
                    break;
                case 3:
                    this.tslbThongTin.Text = "Lỗi kết nối";
                    this.pbPhone.BackColor = Color.Black;
                    break;
                default:
                    this.pbPhone.BackColor = Color.Black;
                    break;
            }
        }

        private void KhoiTaoVideo()
        {
            DateTime now = DateAndTime.Now;
            while (this._flagDangSaveVideo)
            {
                Thread.Sleep(10);
                if ((DateAndTime.Now - now).TotalMilliseconds > 3000.0)
                {
                    break;
                }
            }
            this._flagDangSaveVideo = false;
            try
            {
                this._VideoXeQua.TaoVideo();
                this._VideoXeQua = new ClassTaoVideo();
                string text = "VIDEO\\" + this._FileNameAnhXe.Substring(2, 6);
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                this._VideoXeQua.DuongDanLuuVideo = text + "\\" + this._FileNameAnhXe + ".avi";
            }
            catch (Exception expr_9F)
            {
                ProjectData.SetProjectError(expr_9F);
                ProjectData.ClearProjectError();
            }
        }

        private void chupHinhXe()
        {
            Thread.Sleep(1500);
            this._flagChupHinh = true;
        }

        public void XeVaoVungTu()
        {
            this.VideoData.ClearDVR(this.DvrChanel);
            this.ResetForm();
            this.Controller.PhanLoaiXe = 0;
            try
            {
                XeQuaTram xeQuaTram = new XeQuaTram();
                string ngay = Strings.Format(DateAndTime.Now, "dd/MM/yyyy");
                string gio = Strings.Format(DateAndTime.Now, "HH:mm:ss");
                this._FileNameAnhXe = Strings.Format(ModuleKhaiBaoConst.LanXeMain, "0#") + Strings.Format(DateAndTime.Now, "yyMMdd") + Strings.Format(DateAndTime.Now, "HHmmss");
                this.HangDoiXeVaoTram.EnQueue(ngay, gio, ModuleKhaiBaoConst.MaNhanVienMain, checked((byte)ModuleKhaiBaoConst.CaTrucMain), ModuleKhaiBaoConst.LanXeMain, this._FileNameAnhXe);
                this.TrangThaiPortVao = UcController.TrangThaiPortVao.CoxeVao;
                this.tslbThongTin.Text = "Có xe vào";
                this.LenhNhanDangBienSo = true;
                if (this.ConnectMayNhanDang)
                {
                    this.Controller.MoDenHongNgoai = true;
                    Thread thread = new Thread(new ThreadStart(this.NhanDangBienSo));
                    thread.SetApartmentState(ApartmentState.MTA);
                    thread.Start();
                }
                if (this.FlagUuTienDoan)
                {
                    this.lbThongTinVeSet("ĐOÀN ƯU TIÊN");
                    this.UcComPort.spLed_MoiXeQua_UuTien = true;
                    this.VideoData.TextOutDVR(this.DvrChanel, "%%%%%%", this.SoVeUuTienDoan, 8, 0, ModuleKhaiBaoConst.MaNhanVienMain, 0);
                }
                else if (this.FlagUuTienLuot)
                {
                    this.lbThongTinVeSet("ƯU TIÊN LƯỢT");
                    xeQuaTram = this.HangDoiXeVaoTram.Insert(this.SoVeUuTienTienLuot, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                    this.FlagUuTienLuot = false;
                    this.UcComPort.spLed_MoiXeQua_UuTien = true;
                }
                else
                {
                    this.UcComPort.spLed_LaiXeDungNgangCabin = true;
                }
                this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                if (Operators.CompareString(xeQuaTram.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) != 0)
                {
                    this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                }
                this._flagChupHinh = true;
                Thread thread2 = new Thread(new ThreadStart(this.KhoiTaoVideo));
                thread2.SetApartmentState(ApartmentState.MTA);
                thread2.Start();
            }
            catch (Exception expr_240)
            {
                ProjectData.SetProjectError(expr_240);
                Exception ex = expr_240;
                ModuleKhac.SaveError(ex.Message, "XeVaoVungTu");
                ProjectData.ClearProjectError();
            }
        }

        private void KhoiTaoLuuVideo()
        {
            this._flagDangSaveVideo = true;
            try
            {
                this._VideoXeQua.TaoVideo();
            }
            catch (Exception expr_15)
            {
                ProjectData.SetProjectError(expr_15);
                ProjectData.ClearProjectError();
            }
            this._flagDangSaveVideo = false;
        }

        private void KiemTraNhanVienDangNhap(string MaNhanVien)
        {
            if (Operators.CompareString(MaNhanVien, ModuleKhaiBaoConst.MaNhanVienMain, false) == 0)
            {
                this.tslbThongTin.Text = "Nhân viên đang trực không thê giao ca";
                return;
            }
            string text = "";
            if (!CSDL.SelectNhanVien(ModuleKhaiBaoConst.StrConnectMain, MaNhanVien, ref text))
            {
                this.tslbThongTin.Text = "Mã nhân viên không hợp lệ";
                return;
            }
            if (ModuleKhac.CatrucHienTai() == ModuleKhaiBaoConst.CaTrucMain)
            {
                this.tslbThongTin.Text = "Chưa hết ca trực không thể giao ca";
                return;
            }
            this.tslbThongTin.Text = "Hệ thống sẳn sàng";
            ModuleKhaiBaoConst.CaTrucMain = ModuleKhac.CatrucHienTai();
            ModuleKhaiBaoConst.MaNhanVienMain = MaNhanVien;
            this.tssNhanVien.Text = text;
            this.tssCatruc.Text = "Ca trực: " + Conversions.ToString(ModuleKhaiBaoConst.CaTrucMain);
            CSDL.DeleteVeSuDung(ModuleKhaiBaoConst.StrConnectMain);
            string gio = Strings.Format(DateAndTime.Now, "HH:mm:ss");
            if (this.HangDoiXeVaoTram.CoXeKhongHopLe)
            {
                this.HangDoiXeVaoTram.EditQueue(gio, ModuleKhaiBaoConst.MaNhanVienMain, checked((byte)ModuleKhaiBaoConst.CaTrucMain));
            }
            try
            {
                if (File.Exists("Settime.bat"))
                {
                    Interaction.Shell("Settime.bat", AppWinStyle.NormalFocus, false, -1);
                }
                if (File.Exists("NetConnect.bat"))
                {
                    Interaction.Shell("NetConnect.bat", AppWinStyle.NormalFocus, false, -1);
                }
                if (File.Exists("SQLReplication.exe"))
                {
                    Interaction.Shell("SQLReplication.exe", AppWinStyle.NormalFocus, false, -1);
                }
            }
            catch (Exception expr_141)
            {
                ProjectData.SetProjectError(expr_141);
                ProjectData.ClearProjectError();
            }
            this.TimeReplication = DateAndTime.Now;
        }

        public void NhanDangBienSo()
        {
            bool flag = true;
            checked
            {
                string text;
                string text2;
                while (true)
                {
                    text = "";
                    byte[] array = new byte[1025];
                    text2 = "";
                    string text3 = "LAN" + ModuleKhaiBaoConst.LanXeMain.ToString();
                    try
                    {
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayNhanDangMain);
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
                        IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortMayNhanDangMain);
                        socket.Connect(remoteEP);
                        byte[] bytes = Encoding.ASCII.GetBytes(text3);
                        socket.Send(bytes, bytes.Length, SocketFlags.None);
                        socket.ReceiveTimeout = 3500;
                        int length = socket.Receive(array, array.Length, SocketFlags.None);
                        text3 = Encoding.ASCII.GetString(array, 0, array.Length);
                        text = text3.Substring(0, length);
                    }
                    catch (Exception expr_F0)
                    {
                        ProjectData.SetProjectError(expr_F0);
                        text = "";
                        ProjectData.ClearProjectError();
                    }
                    if (!(text.Length < 7 & flag))
                    {
                        break;
                    }
                    flag = false;
                    text2 = text;
                    Thread.Sleep(50);
                }
                if (text2.Length > text.Length)
                {
                    this.XuLyXe(text2);
                }
                else
                {
                    this.XuLyXe(text);
                }
            }
        }

        public void XuLyXe(string BienSo)
        {
            if (!this.LenhNhanDangBienSo)
            {
                return;
            }
            this.Controller.MoDenHongNgoai = false;
            this.LenhNhanDangBienSo = false;
            XeQuaTram xeQuaTram = new XeQuaTram();
            string soVeNull = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
            byte pLXeTruoc = 0;
            string str = "";
            BienSo = Strings.Trim(BienSo);
            this.lbBienSoDuoiLanSet(BienSo);
            if (Operators.CompareString(BienSo, "", false) != 0)
            {
                if (!(this.FlagUuTienDoan | this.FlagUuTienLuot))
                {
                    this.VideoData.TextOutDVR(this.DvrChanel, BienSo);
                }
                if (CSDL.TimVeThangTuBienSo(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref soVeNull, ref str))
                {
                    string str2 = "";
                    if (VeXe.LoaiVe(soVeNull) == 2)
                    {
                        str2 = "XE DÙNG VÉ THÁNG";
                    }
                    else if (VeXe.LoaiVe(soVeNull) == 3)
                    {
                        str2 = "XE DÙNG VÉ QUÍ";
                    }
                    this.lbThongTinVeSet(str2);
                    this.lbGiaVeSet("NGÀY HẾT HẠN: " + str);
                }
                string text = "";
                switch (CSDL.UuTienKhach(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref text))
                {
                    case CSDL.EUuTienKhach.HopLe:
                        xeQuaTram = this.HangDoiXeVaoTram.Insert(ModuleKhaiBaoConst.EnumVe.VeNoiBo13Char, 0L, BienSo, false);
                        this.OpenBarrier(0, "VÉ NỘI BỘ: " + BienSo, "NGÀY HẾT HẠN: " + text);
                        this.UcComPort.spLed_MoiXeQua_VeQuy = true;
                        this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                        break;
                    case CSDL.EUuTienKhach.HetHan:
                        this.lbThongTinVeSet("VÉ NỘI BỘ HẾT HẠN");
                        this.lbGiaVeSet(text);
                        break;
                }
                string str3 = "";
                if (CSDL.DanhSachDen(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref str3))
                {
                    this.lbThongTinVeSet(str3);
                    Thread thread = new Thread(new ThreadStart(this.ChangeColor3));
                    thread.Start();
                }
                string text2 = string.Empty ;
                string text3 = string.Empty;
                string text4 = string.Empty;
                if (CSDL.ThongTinDangKiem(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref text2, ref text3, ref text4))
                {
                    this.lbBienSoXeCSDL.Text = BienSo;
                    this.lbPhuongTien.Text = text2;
                    this.lbSoNguoi.Text = text3;
                    this.lbTTHangHoa.Text = text4;
                    this.lbPhanLoaiiii.ForeColor = Color.White;
                    this.lbBienSoooo.ForeColor = Color.White;
                    this.lbSoNguoiiiii.ForeColor = Color.White;
                    this.lbTaiTrongHangHoaaa.ForeColor = Color.White;
                }
                this.HangDoiXeVaoTram.Insert(BienSo, (int)pLXeTruoc);
                this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
            }
            else if (!(this.FlagUuTienDoan | this.FlagUuTienLuot))
            {
                this.VideoData.TextOutDVR(this.DvrChanel, "%%%%%%");
            }
        }

        public void ResetForm()
        {
            this.lbBienSoDuoiLanSet("");
            this.lbPhanLoaiXeDuoiLanSet("");
            this.lbGiaVeSet("");
            this.lbMaVeXeSet("");
            this.lbThongTinVeSet("");
            this.tslbThongTin.Text = "Hệ thống sẳn sàng";
            this.lbSoNguoi.Text = "";
            this.lbBienSoXeCSDL.Text = "";
            this.lbPhuongTien.Text = "";
            this.lbTTHangHoa.Text = "";
            this.lbPhanLoaiiii.ForeColor = Color.Black;
            this.lbBienSoooo.ForeColor = Color.Black;
            this.lbSoNguoiiiii.ForeColor = Color.Black;
            this.lbTaiTrongHangHoaaa.ForeColor = Color.Black;
        }

        private void OpenBarrier(int PhanLoaiXe, string strThongTinVe, string strGiaVe)
        {
            this.PhanLoaiXeVuaQua = PhanLoaiXe;
            this.lbThongTinVeSet(strThongTinVe);
            this.lbGiaVeSet(strGiaVe);
            this.Controller.OpenBarrier = true;
            this.pbBarrer.Image = Properties.Resources.BarierRaMo;
            this.Controller.PhanLoaiXe = PhanLoaiXe;
            this.tslbThongTin.Text = "Barrier mở mời xe qua";
        }

        private void CloseBarrier()
        {
            this.Controller.OpenBarrier = false;
            this.pbBarrer.Image = Properties.Resources.BarierRaDong;
        }

        private void ResetSizeVideo()
        {
            Thread.Sleep(1500);
            Control arg_22_0 = this.pnVideo;
            Size size = new Size(576, 432);
            arg_22_0.Size = size;
        }

        private void DocMaVach_DataReceive(string Message)
        {
            try
            {
                if (Operators.CompareString(Message.Substring(0, 4), ModuleKhaiBaoConst.IDMaTram, false) != 0 & Operators.CompareString(Message.Substring(0, 4), ModuleKhaiBaoConst.IDMaTram2, false) != 0)
                {
                    this.tslbThongTin.Text = "Vé không hợp lệ";
                }
                else
                {
                    string text = "";
                    if (!VeXe.ChangeVe16To13(Message, ref text))
                    {
                        this.tslbThongTin.Text = "Vé không hợp lệ";
                    }
                    else
                    {
                        string left = text.Substring(0, 1);
                        if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.TheNV, false) == 0)
                        {
                            string maNhanVien = Message.Substring(12, 4);
                            this.KiemTraNhanVienDangNhap(maNhanVien);
                        }
                        else if (Operators.CompareString(Strings.Trim(ModuleKhaiBaoConst.MaNhanVienMain), "", false) != 0)
                        {
                            this.XuLyQuetVe(text);
                        }
                        else
                        {
                            this.tslbThongTin.Text = "Nhân viên chưa đăng nhập";
                        }
                    }
                }
            }
            catch (Exception expr_CC)
            {
                ProjectData.SetProjectError(expr_CC);
                Exception ex = expr_CC;
                ModuleKhac.SaveError(ex.Message, "DocMaVach_DataReceive");
                ProjectData.ClearProjectError();
            }
        }

        public void XuLyQuetVe(string SoVe13Char)
        {
            XeQuaTram xeQuaTram = new XeQuaTram();
            try
            {
                int num = (int)VeXe.LoaiVe(SoVe13Char);
                int num2 = (int)VeXe.PhanLoaiVe(SoVe13Char);
                if (this.FlagUuTienDoan && num != 8)
                {
                    this.tslbThongTin.Text = "Đoàn xe ưu tiên đang qua trạm";
                }
                else if (num == 8)
                {
                    this.lbMaVeXeSet(SoVe13Char);
                    this.FlagUuTienLuot = false;
                    if (this.FlagUuTienDoan)
                    {
                        this.FlagUuTienDoan = false;
                        this.CloseBarrier();
                        this.SoVeUuTienDoan = "";
                        this.UcComPort.spLed_LanMo = true;
                        this.tslbThongTin.Text = "Hệ thống sẳn sàng";
                        this.lbThongTinVeSet("HẾT ƯU TIÊN ĐOÀN");
                        this.ResetForm();
                    }
                    else
                    {
                        if (this.HangDoiXeVaoTram.CoXeKhongHopLe)
                        {
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                        }
                        this.HangDoiXeVaoTram.Send(true);
                        if (this.HangDoiXeVaoTram.CoXeKhongHopLe)
                        {
                            this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                        }
                        this.HangDoiXeVaoTram.Send(true);
                        this.OpenBarrier(0, "ƯU TIÊN ĐOÀN", "");
                        this.FlagUuTienDoan = true;
                        this.SoVeUuTienDoan = SoVe13Char;
                        this.UcComPort.spLed_MoiXeQua_UuTien = true;
                        this.OpenBarrier(0, "ƯU TIÊN ĐOÀN", "");
                        if (Operators.CompareString(xeQuaTram.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) != 0)
                        {
                            this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                        }
                    }
                }
                else if (num == 6)
                {
                    if ((DateAndTime.Now - this.TimeUuTienLuot).TotalSeconds >= 4.0)
                    {
                        this.TimeUuTienLuot = DateAndTime.Now;
                        if (this.HangDoiXeVaoTram.CoXeKhongHopLe)
                        {
                            this.lbMaVeXeSet(SoVe13Char);
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                            this.HangDoiXeVaoTram.Send(false);
                            this.UcComPort.spLed_MoiXeQua_UuTien = true;
                            this.OpenBarrier(0, "VÉ MIỄN PHÍ LƯỢT", "");
                            if (Operators.CompareString(xeQuaTram.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) != 0)
                            {
                                this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                            }
                            this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                            this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                        }
                        else
                        {
                            this.FlagUuTienLuot = true;
                            this.SoVeUuTienTienLuot = SoVe13Char;
                            this.UcComPort.spLed_MoiXeQua_UuTien = true;
                            this.OpenBarrier(0, "VÉ MIỄN PHÍ LƯỢT", "");
                        }
                    }
                }
                else if (!this.HangDoiXeVaoTram.CoXe)
                {
                    this.TrangThaiPortVao = UcController.TrangThaiPortVao.KhongKetNoi;
                    this.FlagKiemTraVungTu = true;
                    this.Controller.KiemTraPortVao = true;
                    this.tslbThongTin.Text = "Không có xe vào trạm, đang tiến hành kiểm tra vùng từ";
                }
                else if (this.HangDoiXeVaoTram.XeChuaRaKhoiVungTu)
                {
                    this.tslbThongTin.Text = "Đang bận xử lý, vui lòng quét vé lại sau vài giây";
                }
                else
                {
                    switch (num)
                    {
                        case 1:
                            {
                                if (!CSDL.SelectVali(ModuleKhaiBaoConst.StrConnectMain, ModuleKhaiBaoConst.MaNhanVienMain, SoVe13Char, (int)ModuleKhaiBaoConst.LanXeMain, ModuleKhaiBaoConst.TramIdMain))
                                {
                                    this.lbThongTinVeSet("VÉ KHÔNG HỢP LỆ");
                                    return;
                                }
                                if (CSDL.SelectVeInVeSuDung(ModuleKhaiBaoConst.StrConnectMain, SoVe13Char))
                                {
                                    this.lbThongTinVeSet("VÉ ĐÃ SỬ DỤNG");
                                    return;
                                }
                                long phi = 0L;
                                long num3 = 0L;
                                long num4 = 0L;
                                this.lbMaVeXeSet(SoVe13Char);
                                CSDL.SelectMenhGiaVe(ModuleKhaiBaoConst.StrConnectMain, Conversions.ToString(num2), ref phi, ref num3, ref num4);
                                int phanLoaiXeTruoc = this.HangDoiXeVaoTram.PhanLoaiXeTruoc;
                                if (phanLoaiXeTruoc > 0 && (num2 != phanLoaiXeTruoc & Operators.CompareString(this.VeLuotPhanLoaiTruoc, SoVe13Char, false) != 0))
                                {
                                    this.lbThongTinVeSet("VÉ SAI PHÂN LOẠI");
                                    this.lbBienSoDuoiLanSet(Conversions.ToString(num2));
                                    this.VeLuotPhanLoaiTruoc = SoVe13Char;
                                    Thread thread = new Thread(new ThreadStart(this.ChangeColor));
                                    thread.Start();
                                    return;
                                }
                                this.UcComPort.spLed_MoiXeQua_Phi = Conversions.ToSingle(phi.ToString()).ToString();
                                this.OpenBarrier(num2, "VÉ SỬ DỤNG MỘT LẦN", "PHÍ :" + Strings.Format(Conversions.ToSingle(phi.ToString()), "#,# VNĐ"));
                                xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, phi, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                                this.HangDoiXeVaoTram.Send(false);
                                CSDL.InsertVeSuDung(ModuleKhaiBaoConst.StrConnectMain, SoVe13Char);
                                this.lbPhanLoaiDuoiLan.Text = VeXe.PhanLoaiVe(SoVe13Char).ToString();
                                this.VeLuotPhanLoaiTruoc = "";
                                goto IL_7AC;
                            }
                        case 2:
                            {
                                string text = "";
                                string str = "";
                                if (!CSDL.TimBienSoTuVeThang(ModuleKhaiBaoConst.StrConnectMain, SoVe13Char, ref text, ref str))
                                {
                                    this.lbThongTinVeSet("VÉ KHÔNG HỢP LỆ");
                                    return;
                                }
                                this.lbMaVeXeSet(SoVe13Char);
                                xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, text, false);
                                this.HangDoiXeVaoTram.Send(false);
                                this.lbPhanLoaiXeDuoiLanSet(Conversions.ToString(VeXe.PhanLoaiVe(SoVe13Char)));
                                this.UcComPort.spLed_MoiXeQua_VeThang = true;
                                this.OpenBarrier(num2, "VÉ THÁNG: " + text, "NGÀY HẾT HẠN: " + str);
                                if (xeQuaTram.TTXeQua == 5)
                                {
                                    Thread thread2 = new Thread(new ThreadStart(this.ChangeColor2));
                                    thread2.Start();
                                }
                                this.VeLuotPhanLoaiTruoc = "";
                                goto IL_7AC;
                            }
                        case 3:
                            {
                                string text2 = "";
                                string str2 = "";
                                if (!CSDL.TimBienSoTuVeThang(ModuleKhaiBaoConst.StrConnectMain, SoVe13Char, ref text2, ref str2))
                                {
                                    this.lbThongTinVeSet("VÉ KHÔNG HỢP LỆ");
                                    return;
                                }
                                this.lbMaVeXeSet(SoVe13Char);
                                xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, text2, false);
                                this.HangDoiXeVaoTram.Send(false);
                                this.lbPhanLoaiXeDuoiLanSet(Conversions.ToString(VeXe.PhanLoaiVe(SoVe13Char)));
                                this.UcComPort.spLed_MoiXeQua_VeQuy = true;
                                this.OpenBarrier(num2, "VÉ QUÍ: " + text2, "NGÀY HẾT HẠN: " + str2);
                                if (xeQuaTram.TTXeQua == 5)
                                {
                                    Thread thread3 = new Thread(new ThreadStart(this.ChangeColor2));
                                    thread3.Start();
                                }
                                this.VeLuotPhanLoaiTruoc = "";
                                goto IL_7AC;
                            }
                        case 7:
                            this.lbMaVeXeSet(SoVe13Char);
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                            this.HangDoiXeVaoTram.Send(false);
                            this.UcComPort.spLed_MoiXeQua_VeToanQuoc = true;
                            this.OpenBarrier(0, "VÉ TOÀN QUỐC", "");
                            goto IL_7AC;
                        case 9:
                            this.lbMaVeXeSet(SoVe13Char);
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                            this.HangDoiXeVaoTram.Send(false);
                            this.UcComPort.spLed_MoiXeQua = true;
                            this.OpenBarrier(0, "VÉ CƯỠNG BỨC", "");
                            this.VeLuotPhanLoaiTruoc = "";
                            goto IL_7AC;
                        case 11:
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, "", false);
                            this.OpenBarrier(num2, "ƯU TIÊN NỘI BỘ ", "");
                            this.UcComPort.spLed_MoiXeQua = true;
                            return;
                        case 12:
                            this.lbMaVeXeSet(SoVe13Char);
                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                            this.HangDoiXeVaoTram.Send(false);
                            this.UcComPort.spLed_MoiXeQua_VeToanQuoc = true;
                            this.OpenBarrier(0, "VÉ TOÀN QUỐC", "");
                            goto IL_7AC;
                    }
                    this.tslbThongTin.Text = "Vui lòng quét vé lại!";
                    return;
                IL_7AC:
                    this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                    this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                    if (Operators.CompareString(xeQuaTram.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) != 0)
                    {
                        this.VideoData.TextOutDVR(this.DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                    }
                    else
                    {
                        this.VideoData.TextOutDVR(this.DvrChanel, "----");
                    }
                }
            }
            catch (Exception expr_831)
            {
                ProjectData.SetProjectError(expr_831);
                Exception ex = expr_831;
                ModuleKhac.SaveError(ex.Message, "XyLyQuetVe");
                this.tslbThongTin.Text = "Vui lòng quét vé lại!!!";
                ProjectData.ClearProjectError();
            }
        }

        private void DocMaVach_ComPortError(string Message)
        {
            this.tslbThongTin.Text = Message;
        }

        private void Controller_EventTrangThaiVungTuVao(UcController.TrangThaiPortVao TrangThai)
        {
            if (TrangThai == UcController.TrangThaiPortVao.CoxeVao)
            {
                if (this.FlagKiemTraVungTu)
                {
                    Thread thread = new Thread(new ThreadStart(this.XeVaoVungTu));
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    this.FlagKiemTraVungTu = false;
                }
            }
            else if (TrangThai == UcController.TrangThaiPortVao.KhongCoXeVao)
            {
                this.TrangThaiPortVao = UcController.TrangThaiPortVao.KhongCoXeVao;
                if (this.FlagKiemTraVungTu)
                {
                    this.FlagKiemTraVungTu = false;
                }
                else
                {
                    this.HangDoiXeVaoTram.ResetFront();
                }
            }
        }

        private void lbTenTramThuPhi_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.ShowDialog();
        }

        private void TimerNhapNhay_Tick(object sender, EventArgs e)
        {
        }

        private void ChangeColor()
        {
            try
            {
                this.BackColor = Color.Red;
                Thread.Sleep(3000);
                this.BackColor = Color.Black;
            }
            catch (Exception expr_22)
            {
                ProjectData.SetProjectError(expr_22);
                ProjectData.ClearProjectError();
            }
        }

        private void ChangeColor2()
        {
            try
            {
                this.BackColor = Color.White;
                Thread.Sleep(2000);
                this.BackColor = Color.Black;
            }
            catch (Exception expr_22)
            {
                ProjectData.SetProjectError(expr_22);
                ProjectData.ClearProjectError();
            }
        }

        private void ChangeColor3()
        {
            try
            {
                this.BackColor = Color.Yellow;
                Thread.Sleep(2000);
                this.BackColor = Color.Black;
            }
            catch (Exception expr_22)
            {
                ProjectData.SetProjectError(expr_22);
                ProjectData.ClearProjectError();
            }
        }

        private void DocMaVach_TheCung(string Message)
        {
            if (Operators.CompareString(Message, ModuleKhaiBaoConst.MTTheCung.NhanDangLai, false) == 0)
            {
                this.LenhNhanDangBienSo = true;
                if (this.ConnectMayNhanDang)
                {
                    this.Controller.MoDenHongNgoai = true;
                    Thread thread = new Thread(new ThreadStart(this.NhanDangBienSo));
                    thread.SetApartmentState(ApartmentState.MTA);
                    thread.Start();
                }
            }
            else if (Operators.CompareString(Message, ModuleKhaiBaoConst.MTTheCung.MoLan, false) == 0)
            {
                this.Controller.MoLan = true;
                this.UcComPort.spLed_LanMo = true;
                this.pbTrangThaiLan.Image = Properties.Resources.LanMo;
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Operators.CompareString(Message, ModuleKhaiBaoConst.MTTheCung.DongLan, false) == 0)
            {
                this.Controller.MoLan = false;
                this.UcComPort.spLed_LanMo = false;
                this.pbTrangThaiLan.Image = Properties.Resources.LanDong;
                this.Controller.MoLan = false;
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Operators.CompareString(Message, ModuleKhaiBaoConst.MTTheCung.Reset, false) == 0)
            {
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.HangDoiXeVaoTram.ResetFront();
                this.UcComPort.spLed_LanMo = true;
                this.Controller.OpenBarrier = false;
                this.Controller.PhanLoaiXe = 0;
                this.pbBarrer.Image = Properties.Resources.BarierRaDong;
                this.ResetForm();
                this.pnStatusCar1SetColor(this.HangDoiXeVaoTram.CarFrontStatus);
                this.pnStatusCar2SetColor(this.HangDoiXeVaoTram.CarRearStatus);
                this.FlagUuTienDoan = false;
                this.FlagUuTienLuot = false;
            }
            else if (Operators.CompareString(Message, ModuleKhaiBaoConst.MTTheCung.KetNoiGiamSat, false) == 0)
            {
                if (!this.phone.TrangThaiKetNoi)
                {
                    if (ModuleKhaiBaoConst.StatusConnectGiamSatMain)
                    {
                        this.phone.CallVoid(ModuleKhaiBaoConst.IPMayGiamSatMain);
                    }
                    else
                    {
                        this.tslbThongTin.Text = "Không tìm thấy máy giám sát";
                    }
                }
                else
                {
                    this.phone.EndCall();
                    this.tslbThongTin.Text = "Đã dừng kết nối";
                }
            }
        }

        private void LuuHinhAnh(Bitmap Hinh_)
        {
            if (this._flagChupHinh)
            {
                Bitmap parameter = new Bitmap(Hinh_);
                Bitmap image = new Bitmap(Hinh_);
                this._flagChupHinh = false;
                Thread thread = new Thread(delegate (object a0)
                {
                    this.SaveImage((Bitmap)a0);
                });
                thread.Start(parameter);
                this.pbAnhXeVaoLan.Image = image;
                Control arg_56_0 = this.pnVideo;
                Size size = new Size(120, 100);
                arg_56_0.Size = size;
                Thread thread2 = new Thread(new ThreadStart(this.ResetSizeVideo));
                thread2.Start();
            }
            if (this._VideoXeQua.FlagLuuVideo)
            {
                Bitmap img = new Bitmap(Hinh_);
                this._VideoXeQua.ThemHinh(img);
            }
            try
            {
                Hinh_.Dispose();
            }
            catch (Exception expr_9E)
            {
                ProjectData.SetProjectError(expr_9E);
                ProjectData.ClearProjectError();
            }
        }

        public void SaveImage(Bitmap img)
        {
            ModuleKhac.SaveJpgAs(img, this._FileNameAnhXe + ".jpg", ModuleKhaiBaoConst.ServerImagesPathMain, ModuleKhaiBaoConst.LocalImagesPathMain);
            if (img != null)
            {
                img.Dispose();
            }
        }

        private void Timer_ChupHinh_Tick(object sender, EventArgs e)
        {
            if (this._flagChupHinh | (this._VideoXeQua.FlagLuuVideo & this._VideoXeQua.MaxFrame))
            {
                this._ChupHinhXe.ChupHinh();
            }
        }

        private void Timer_docMaVach_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.DocMaVach.DangMo)
                {
                    this.DocMaVach.MoLai();
                }
            }
            catch (Exception expr_1A)
            {
                ProjectData.SetProjectError(expr_1A);
                ProjectData.ClearProjectError();
            }
        }

        private void Timer_KhoiTaoLai_Tick(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }
    }
}
