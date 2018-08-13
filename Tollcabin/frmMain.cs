using CaptureTollCabinLib;
using Infrastructure.cs.Helpers;
using Infrastructure.intefaces;
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
using System.Net.NetworkInformation;
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
        private IVideoCapture __ChupHinhXe;

        private string _FileNameAnhXe;

        private bool _flagChupHinh;

        private ConfigAxis configAxis = null;

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

        public virtual IVideoCapture _ChupHinhXe
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
                this.__ChupHinhXe = value;
                if (this.__ChupHinhXe != null)
                {
                    this.__ChupHinhXe.CaptureComplete += LuuHinhAnh;
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
            TimeReplication = DateAndTime.Now;
            TimeUuTienLuot = DateAndTime.Now;
            string userID = "";
            string passID = "";
            string initialCatalog = "";
            string str = "";
            string filePath = MyProject.Application.Info.DirectoryPath + "\\TollcabinConfig.xml";
            int lanXeMain = ModuleKhaiBaoConst.LanXeMain;
            bool num = ModuleKhac.ReadConfig(filePath, ref initialCatalog, ref userID, ref passID, ref lanXeMain, ref ModuleKhaiBaoConst.IPMayGiamSatMain, ref ModuleKhaiBaoConst.IPMayNhanDangMain, ref ModuleKhaiBaoConst.LocalImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathBSMain, ref ModuleKhaiBaoConst.PortDuLieuChinhMain, ref ModuleKhaiBaoConst.PortDuLieuCuMain, ref ModuleKhaiBaoConst.PortGiupDoMain, ref ModuleKhaiBaoConst.PortMayNhanDangMain, ref ModuleKhaiBaoConst.TramIdMain, ref ModuleKhaiBaoConst.StatusMain, ref str);
            checked
            {
                ModuleKhaiBaoConst.LanXeMain = (byte)lanXeMain;
                if (!num)
                {
                    Interaction.MsgBox("Không đọc được file TollcabinConfig.xml", MsgBoxStyle.OkOnly, null);
                    frmConfig frmConfig = new frmConfig();
                    frmConfig.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    SysTempLoad();
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
                    tssCabin.Text = "Làn: " + Conversions.ToString(ModuleKhaiBaoConst.LanXeMain);
                    Controller.MoLan = false;
                    Controller.MoDenHongNgoai = false;
                    Controller.PhanLoaiXe = 0;
                    UcComPort.spLed_LanMo = false;
                    ResetForm();
                    try
                    {
                        this.configAxis = new ConfigAxis(Directory.GetCurrentDirectory() + "/axis/AxisManager.cfg");
                        this.configAxis.Load();
                        if (this.CheckNetWork(configAxis.CameraIp))
                        {
                            this._ChupHinhXe = new AxisCapture();
                            // Hoang example
                            this._ChupHinhXe.InitDevice(this.pnVideo, this.configAxis.CameraIp);
                        }
                        else
                        {
                            this._ChupHinhXe = new VideoCapture();
                            this._ChupHinhXe.InitDevice(this.pnVideo);
                        }
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        Interaction.MsgBox("Không kết nối được thiết bị video", MsgBoxStyle.OkOnly, null);
                        Application.Exit();
                        ProjectData.ClearProjectError();
                        return;
                    }
                    Timer_docMaVach.Enabled = true;
                    tssNhanVien.ForeColor = Color.Black;
                    try
                    {
                        ModuleKhaiBaoConst.StrConnectMain_mas = ModuleKhac.KetNoi(Dns.GetHostName() + str, "Master", userID, passID);
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        ProjectData.ClearProjectError();
                    }
                }
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
            LogHelper.GetLogger().Info("Xe vào vòng từ");
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
            LogHelper.GetLogger().Info("Nhận dạng biển số");
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
            LogHelper.GetLogger().Info("Xử lý xe");
            if (LenhNhanDangBienSo)
            {
                Controller.MoDenHongNgoai = false;
                LenhNhanDangBienSo = false;
                XeQuaTram xeQuaTram = new XeQuaTram();
                string soVeNull = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
                byte pLXeTruoc = 0;
                byte b = 0;
                string str = "";
                BienSo = Strings.Trim(BienSo);
                lbBienSoDuoiLanSet(BienSo);
                bool flag = false;
                if (Operators.CompareString(BienSo, "", false) != 0)
                {
                    if (!(FlagUuTienDoan | FlagUuTienLuot))
                    {
                        VideoData.TextOutDVR(DvrChanel, BienSo);
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
                        lbThongTinVeSet(str2);
                        lbGiaVeSet("NGÀY HẾT HẠN: " + str);
                    }
                    string text = "";
                    string text2 = "";
                    switch (CSDL.UuTienKhach(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref text2))
                    {
                        case CSDL.EUuTienKhach.HetHan:
                            lbThongTinVeSet("VÉ NỘI BỘ HẾT HẠN");
                            lbGiaVeSet(text2);
                            break;
                        case CSDL.EUuTienKhach.HopLe:
                            xeQuaTram = HangDoiXeVaoTram.Insert(ModuleKhaiBaoConst.EnumVe.VeNoiBo13Char, 0L, BienSo, false);
                            OpenBarrier(0, "VÉ NỘI BỘ: " + BienSo, "NGÀY HẾT HẠN: " + text2);
                            UcComPort.spLed_MoiXeQua_VeQuy = true;
                            VideoData.TextOutDVR(DvrChanel, xeQuaTram.BienSo, xeQuaTram.SoVe, xeQuaTram.PTTT, xeQuaTram.PLVe, xeQuaTram.MSNV, xeQuaTram.TTXeQua);
                            break;
                    }
                    string str3 = "";
                    if (CSDL.DanhSachDen(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref str3))
                    {
                        lbThongTinVeSet(str3);
                        Thread thread = new Thread(ChangeColor3);
                        thread.Start();
                    }
                    string text3 = default(string);
                    string text4 = default(string);
                    string text5 = default(string);
                    if (CSDL.ThongTinDangKiem(ModuleKhaiBaoConst.StrConnectMain, BienSo, ref text3, ref text4, ref text5))
                    {
                        lbBienSoXeCSDL.Text = BienSo;
                        lbPhuongTien.Text = text3;
                        lbSoNguoi.Text = text4;
                        lbTTHangHoa.Text = text5;
                        lbPhanLoaiiii.ForeColor = Color.White;
                        lbBienSoooo.ForeColor = Color.White;
                        lbSoNguoiiiii.ForeColor = Color.White;
                        lbTaiTrongHangHoaaa.ForeColor = Color.White;
                    }
                    HangDoiXeVaoTram.Insert(BienSo, pLXeTruoc);
                    pnStatusCar1SetColor(HangDoiXeVaoTram.CarFrontStatus);
                    pnStatusCar2SetColor(HangDoiXeVaoTram.CarRearStatus);
                }
                else if (!(FlagUuTienDoan | FlagUuTienLuot))
                {
                    VideoData.TextOutDVR(DvrChanel, "%%%%%%");
                }
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
            LogHelper.GetLogger().Info("Mở barrier");
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
            LogHelper.GetLogger().Info("Đọc mã vạch. Data receive");
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
            LogHelper.GetLogger().Info("Xử lý quét vé");
            XeQuaTram xeQuaTram = new XeQuaTram();
            try
            {
                int num = (int)VeXe.LoaiVe(SoVe13Char);
                int num2 = (int)VeXe.PhanLoaiVe(SoVe13Char);
                if (this.FlagUuTienDoan && num != 8)
                {
                    this.tslbThongTin.Text = "Đoàn xe ưu tiên đang qua trạm";
                }
                else
                {
                    if (num == 8)
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
                    else
                    {
                        if (num == 6)
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
                        else
                        {
                            if (!this.HangDoiXeVaoTram.CoXe)
                            {
                                this.TrangThaiPortVao = UcController.TrangThaiPortVao.KhongKetNoi;
                                this.FlagKiemTraVungTu = true;
                                this.Controller.KiemTraPortVao = true;
                                this.tslbThongTin.Text = "Không có xe vào trạm, đang tiến hành kiểm tra vùng từ";
                            }
                            else
                            {
                                if (this.HangDoiXeVaoTram.XeChuaRaKhoiVungTu)
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
                                                goto IL_84A;
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
                                                goto IL_84A;
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
                                                goto IL_84A;
                                            }

                                        case 4:
                                            {
                                                string bSXeThangQui = "";
                                                DateTime dateTime = DateTime.MinValue;
                                                DateTime dateTime2 = DateTime.MinValue;
                                                if (!CSDL.xeGiamGia(ModuleKhaiBaoConst.StrConnectMain, SoVe13Char, ref bSXeThangQui, ref dateTime, ref dateTime2))
                                                {
                                                    this.lbThongTinVeSet("VÉ KHÔNG HỢP LỆ");
                                                    return;
                                                }
                                                this.lbMaVeXeSet(SoVe13Char);
                                                xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, bSXeThangQui, false);
                                                this.HangDoiXeVaoTram.Send(false);
                                                this.lbPhanLoaiXeDuoiLanSet(Conversions.ToString(VeXe.PhanLoaiVe(SoVe13Char)));
                                                this.UcComPort.spLed_MoiXeQua_giamGia = true;
                                                this.OpenBarrier(num2, "VÉ GIẢM GIÁ ", "NGÀY HẾT HẠN: " + dateTime2.ToString("dd/MM/yyyy"));
                                                this.VeLuotPhanLoaiTruoc = "";
                                                goto IL_84A;
                                            }

                                        case 7:
                                            this.lbMaVeXeSet(SoVe13Char);
                                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                                            this.HangDoiXeVaoTram.Send(false);
                                            this.UcComPort.spLed_MoiXeQua_VeToanQuoc = true;
                                            this.OpenBarrier(0, "VÉ TOÀN QUỐC", "");
                                            goto IL_84A;

                                        case 9:
                                            this.lbMaVeXeSet(SoVe13Char);
                                            xeQuaTram = this.HangDoiXeVaoTram.Insert(SoVe13Char, 0L, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false);
                                            this.HangDoiXeVaoTram.Send(false);
                                            this.UcComPort.spLed_MoiXeQua = true;
                                            this.OpenBarrier(0, "VÉ CƯỠNG BỨC", "");
                                            this.VeLuotPhanLoaiTruoc = "";
                                            goto IL_84A;

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
                                            goto IL_84A;
                                    }
                                    this.tslbThongTin.Text = "Vui lòng quét vé lại!";
                                    return;
                                IL_84A:
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
                        }
                    }
                }
            }
            catch (Exception expr_8CF)
            {
                ProjectData.SetProjectError(expr_8CF);
                Exception ex = expr_8CF;
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
                this._ChupHinhXe.Capture();
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
        private bool CheckNetWork(string address)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(address);

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
