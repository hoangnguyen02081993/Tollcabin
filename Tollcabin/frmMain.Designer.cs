
namespace Tollcabin
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TimerNgayGio = new System.Windows.Forms.Timer(this.components);
            this.TimerKiemTraDuLieuCu = new System.Windows.Forms.Timer(this.components);
            this.Timer_ChupHinh = new System.Windows.Forms.Timer(this.components);
            this.Timer_docMaVach = new System.Windows.Forms.Timer(this.components);
            this.Timer_KhoiTaoLai = new System.Windows.Forms.Timer(this.components);
            this.lbMaVeXe = new System.Windows.Forms.Label();
            this.lbPhanLoaiDuoiLan = new System.Windows.Forms.Label();
            this.lbBienSoDuoiLan = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lbTenTramThuPhi = new System.Windows.Forms.Label();
            this.lbGiaVe = new System.Windows.Forms.Label();
            this.lbPhanLoaiiii = new System.Windows.Forms.Label();
            this.lbThongTinVe = new System.Windows.Forms.Label();
            this.lbBienSoXeCSDL = new System.Windows.Forms.Label();
            this.lbBienSoooo = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.lbPhuongTien = new System.Windows.Forms.Label();
            this.lbSoNguoi = new System.Windows.Forms.Label();
            this.lbSoNguoiiiii = new System.Windows.Forms.Label();
            this.lbTTHangHoa = new System.Windows.Forms.Label();
            this.lbTaiTrongHangHoaaa = new System.Windows.Forms.Label();
            this.Console = new Tollcabin.UcConsole();
            this.Controller = new Tollcabin.UcController();
            this.DocMaVach = new Tollcabin.UcDocMaVach();
            this.UcComPort = new Tollcabin.UcSerialPort();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbBarrer = new System.Windows.Forms.PictureBox();
            this.pbTrangThaiLan = new System.Windows.Forms.PictureBox();
            this.pbTrangThaiMang = new System.Windows.Forms.PictureBox();
            this.pbAnhXeVaoLan = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnStatusCarIn2 = new System.Windows.Forms.Panel();
            this.pnStatusCarIn1 = new System.Windows.Forms.Panel();
            this.pnVideo = new System.Windows.Forms.Panel();
            this.ssTime = new System.Windows.Forms.StatusStrip();
            this.tslbThongTin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCatruc = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCabin = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThaiLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThaiMang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhXeVaoLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.ssTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerNgayGio
            // 
            this.TimerNgayGio.Enabled = true;
            this.TimerNgayGio.Interval = 1000;
            // 
            // TimerKiemTraDuLieuCu
            // 
            this.TimerKiemTraDuLieuCu.Enabled = true;
            this.TimerKiemTraDuLieuCu.Interval = 120000;
            // 
            // Timer_ChupHinh
            // 
            this.Timer_ChupHinh.Enabled = true;
            this.Timer_ChupHinh.Interval = 200;
            // 
            // Timer_docMaVach
            // 
            this.Timer_docMaVach.Interval = 2000;
            // 
            // Timer_KhoiTaoLai
            // 
            this.Timer_KhoiTaoLai.Interval = 600000;
            // 
            // lbMaVeXe
            // 
            this.lbMaVeXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbMaVeXe.AutoSize = true;
            this.lbMaVeXe.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaVeXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbMaVeXe.Location = new System.Drawing.Point(251, 654);
            this.lbMaVeXe.Name = "lbMaVeXe";
            this.lbMaVeXe.Size = new System.Drawing.Size(343, 40);
            this.lbMaVeXe.TabIndex = 110;
            this.lbMaVeXe.Text = "K221107120000";
            this.lbMaVeXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPhanLoaiDuoiLan
            // 
            this.lbPhanLoaiDuoiLan.AutoSize = true;
            this.lbPhanLoaiDuoiLan.BackColor = System.Drawing.Color.Transparent;
            this.lbPhanLoaiDuoiLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPhanLoaiDuoiLan.ForeColor = System.Drawing.Color.Red;
            this.lbPhanLoaiDuoiLan.Location = new System.Drawing.Point(251, 587);
            this.lbPhanLoaiDuoiLan.Name = "lbPhanLoaiDuoiLan";
            this.lbPhanLoaiDuoiLan.Size = new System.Drawing.Size(245, 53);
            this.lbPhanLoaiDuoiLan.TabIndex = 109;
            this.lbPhanLoaiDuoiLan.Text = "3";
            this.lbPhanLoaiDuoiLan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBienSoDuoiLan
            // 
            this.lbBienSoDuoiLan.AutoSize = true;
            this.lbBienSoDuoiLan.BackColor = System.Drawing.Color.Transparent;
            this.lbBienSoDuoiLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBienSoDuoiLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienSoDuoiLan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbBienSoDuoiLan.Location = new System.Drawing.Point(251, 543);
            this.lbBienSoDuoiLan.Name = "lbBienSoDuoiLan";
            this.lbBienSoDuoiLan.Size = new System.Drawing.Size(229, 40);
            this.lbBienSoDuoiLan.TabIndex = 108;
            this.lbBienSoDuoiLan.Text = "54P4-8920";
            this.lbBienSoDuoiLan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(87, 599);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(144, 31);
            this.Label9.TabIndex = 106;
            this.Label9.Text = "Phân loại:";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(87, 655);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(139, 31);
            this.Label8.TabIndex = 105;
            this.Label8.Text = "Mã vé xe:";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(87, 543);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(158, 31);
            this.Label7.TabIndex = 104;
            this.Label7.Text = "Biển số xe:";
            // 
            // lbTenTramThuPhi
            // 
            this.lbTenTramThuPhi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenTramThuPhi.AutoSize = true;
            this.lbTenTramThuPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTramThuPhi.ForeColor = System.Drawing.Color.LightGreen;
            this.lbTenTramThuPhi.Location = new System.Drawing.Point(305, 24);
            this.lbTenTramThuPhi.Name = "lbTenTramThuPhi";
            this.lbTenTramThuPhi.Size = new System.Drawing.Size(757, 55);
            this.lbTenTramThuPhi.TabIndex = 112;
            this.lbTenTramThuPhi.Text = "TRẠM THU PHÍ ĐẠI YÊN - QL18";
            this.lbTenTramThuPhi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGiaVe
            // 
            this.lbGiaVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGiaVe.AutoSize = true;
            this.lbGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaVe.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbGiaVe.Location = new System.Drawing.Point(854, 681);
            this.lbGiaVe.MaximumSize = new System.Drawing.Size(253, 30);
            this.lbGiaVe.MinimumSize = new System.Drawing.Size(420, 40);
            this.lbGiaVe.Name = "lbGiaVe";
            this.lbGiaVe.Size = new System.Drawing.Size(420, 40);
            this.lbGiaVe.TabIndex = 129;
            this.lbGiaVe.Text = "NGÀY HẾT HẠN: 25/01/2009";
            this.lbGiaVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPhanLoaiiii
            // 
            this.lbPhanLoaiiii.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPhanLoaiiii.AutoSize = true;
            this.lbPhanLoaiiii.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanLoaiiii.ForeColor = System.Drawing.Color.White;
            this.lbPhanLoaiiii.Location = new System.Drawing.Point(728, 292);
            this.lbPhanLoaiiii.Name = "lbPhanLoaiiii";
            this.lbPhanLoaiiii.Size = new System.Drawing.Size(178, 31);
            this.lbPhanLoaiiii.TabIndex = 128;
            this.lbPhanLoaiiii.Text = "Phương tiện:";
            // 
            // lbThongTinVe
            // 
            this.lbThongTinVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThongTinVe.AutoSize = true;
            this.lbThongTinVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbThongTinVe.Location = new System.Drawing.Point(854, 646);
            this.lbThongTinVe.MaximumSize = new System.Drawing.Size(253, 30);
            this.lbThongTinVe.MinimumSize = new System.Drawing.Size(420, 40);
            this.lbThongTinVe.Name = "lbThongTinVe";
            this.lbThongTinVe.Size = new System.Drawing.Size(420, 40);
            this.lbThongTinVe.TabIndex = 126;
            this.lbThongTinVe.Text = "VÉ SAI PHÂN LOẠI";
            this.lbThongTinVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBienSoXeCSDL
            // 
            this.lbBienSoXeCSDL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbBienSoXeCSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienSoXeCSDL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbBienSoXeCSDL.Location = new System.Drawing.Point(913, 236);
            this.lbBienSoXeCSDL.Name = "lbBienSoXeCSDL";
            this.lbBienSoXeCSDL.Size = new System.Drawing.Size(229, 40);
            this.lbBienSoXeCSDL.TabIndex = 125;
            this.lbBienSoXeCSDL.Text = "54P4-8920";
            this.lbBienSoXeCSDL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBienSoooo
            // 
            this.lbBienSoooo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbBienSoooo.AutoSize = true;
            this.lbBienSoooo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienSoooo.ForeColor = System.Drawing.Color.White;
            this.lbBienSoooo.Location = new System.Drawing.Point(778, 243);
            this.lbBienSoooo.Name = "lbBienSoooo";
            this.lbBienSoooo.Size = new System.Drawing.Size(128, 31);
            this.lbBienSoooo.TabIndex = 124;
            this.lbBienSoooo.Text = "Biển số :";
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGio.ForeColor = System.Drawing.Color.Yellow;
            this.lbGio.Location = new System.Drawing.Point(3, 5);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(269, 29);
            this.lbGio.TabIndex = 145;
            this.lbGio.Text = "08/08/2012 -  09:09:09";
            // 
            // lbPhuongTien
            // 
            this.lbPhuongTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPhuongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPhuongTien.Location = new System.Drawing.Point(913, 286);
            this.lbPhuongTien.Name = "lbPhuongTien";
            this.lbPhuongTien.Size = new System.Drawing.Size(441, 40);
            this.lbPhuongTien.TabIndex = 148;
            this.lbPhuongTien.Text = "54P4-8920";
            this.lbPhuongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoNguoi
            // 
            this.lbSoNguoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbSoNguoi.Location = new System.Drawing.Point(913, 336);
            this.lbSoNguoi.Name = "lbSoNguoi";
            this.lbSoNguoi.Size = new System.Drawing.Size(229, 40);
            this.lbSoNguoi.TabIndex = 150;
            this.lbSoNguoi.Text = "54P4-8920";
            this.lbSoNguoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSoNguoiiiii
            // 
            this.lbSoNguoiiiii.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSoNguoiiiii.AutoSize = true;
            this.lbSoNguoiiiii.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoiiiii.ForeColor = System.Drawing.Color.White;
            this.lbSoNguoiiiii.Location = new System.Drawing.Point(767, 343);
            this.lbSoNguoiiiii.Name = "lbSoNguoiiiii";
            this.lbSoNguoiiiii.Size = new System.Drawing.Size(137, 31);
            this.lbSoNguoiiiii.TabIndex = 149;
            this.lbSoNguoiiiii.Text = "Số người:";
            // 
            // lbTTHangHoa
            // 
            this.lbTTHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTTHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTTHangHoa.Location = new System.Drawing.Point(913, 388);
            this.lbTTHangHoa.Name = "lbTTHangHoa";
            this.lbTTHangHoa.Size = new System.Drawing.Size(229, 40);
            this.lbTTHangHoa.TabIndex = 152;
            this.lbTTHangHoa.Text = "54P4-8920";
            this.lbTTHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTaiTrongHangHoaaa
            // 
            this.lbTaiTrongHangHoaaa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTaiTrongHangHoaaa.AutoSize = true;
            this.lbTaiTrongHangHoaaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiTrongHangHoaaa.ForeColor = System.Drawing.Color.White;
            this.lbTaiTrongHangHoaaa.Location = new System.Drawing.Point(719, 395);
            this.lbTaiTrongHangHoaaa.Name = "lbTaiTrongHangHoaaa";
            this.lbTaiTrongHangHoaaa.Size = new System.Drawing.Size(187, 31);
            this.lbTaiTrongHangHoaaa.TabIndex = 151;
            this.lbTaiTrongHangHoaaa.Text = "TT hàng hóa:";
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.White;
            this.Console.BaudRate = 0;
            this.Console.ComPortName = null;
            this.Console.Location = new System.Drawing.Point(203, 57);
            this.Console.MinimumSize = new System.Drawing.Size(87, 22);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(87, 22);
            this.Console.TabIndex = 138;
            this.Console.Visible = false;
            // 
            // Controller
            // 
            this.Controller.BackColor = System.Drawing.Color.Gainsboro;
            this.Controller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Controller.Location = new System.Drawing.Point(12, 85);
            this.Controller.Name = "Controller";
            this.Controller.Size = new System.Drawing.Size(59, 28);
            this.Controller.TabIndex = 137;
            this.Controller.Visible = false;
            // 
            // DocMaVach
            // 
            this.DocMaVach.CongComThat = true;
            this.DocMaVach.Location = new System.Drawing.Point(72, 37);
            this.DocMaVach.Name = "DocMaVach";
            this.DocMaVach.Size = new System.Drawing.Size(111, 21);
            this.DocMaVach.TabIndex = 139;
            this.DocMaVach.Visible = false;
            // 
            // UcComPort
            // 
            this.UcComPort.Location = new System.Drawing.Point(12, 128);
            this.UcComPort.MaximumSize = new System.Drawing.Size(82, 31);
            this.UcComPort.MinimumSize = new System.Drawing.Size(82, 31);
            this.UcComPort.Name = "UcComPort";
            this.UcComPort.Size = new System.Drawing.Size(82, 31);
            this.UcComPort.TabIndex = 4;
            this.UcComPort.Visible = false;
            // 
            // pbPhone
            // 
            this.pbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPhone.BackColor = System.Drawing.Color.Black;
            this.pbPhone.Location = new System.Drawing.Point(1106, 0);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(52, 48);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 146;
            this.pbPhone.TabStop = false;
            // 
            // pbBarrer
            // 
            this.pbBarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBarrer.BackgroundImage = global::Tollcabin.Properties.Resources.BarierRaDong;
            this.pbBarrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBarrer.Location = new System.Drawing.Point(1210, 0);
            this.pbBarrer.Name = "pbBarrer";
            this.pbBarrer.Size = new System.Drawing.Size(52, 48);
            this.pbBarrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarrer.TabIndex = 131;
            this.pbBarrer.TabStop = false;
            // 
            // pbTrangThaiLan
            // 
            this.pbTrangThaiLan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrangThaiLan.BackgroundImage = global::Tollcabin.Properties.Resources.LanDong;
            this.pbTrangThaiLan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTrangThaiLan.Location = new System.Drawing.Point(1158, 0);
            this.pbTrangThaiLan.Name = "pbTrangThaiLan";
            this.pbTrangThaiLan.Size = new System.Drawing.Size(52, 48);
            this.pbTrangThaiLan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrangThaiLan.TabIndex = 132;
            this.pbTrangThaiLan.TabStop = false;
            // 
            // pbTrangThaiMang
            // 
            this.pbTrangThaiMang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrangThaiMang.BackColor = System.Drawing.Color.White;
            this.pbTrangThaiMang.BackgroundImage = global::Tollcabin.Properties.Resources.ketnoimang;
            this.pbTrangThaiMang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTrangThaiMang.Location = new System.Drawing.Point(1262, 0);
            this.pbTrangThaiMang.Name = "pbTrangThaiMang";
            this.pbTrangThaiMang.Size = new System.Drawing.Size(52, 48);
            this.pbTrangThaiMang.TabIndex = 130;
            this.pbTrangThaiMang.TabStop = false;
            // 
            // pbAnhXeVaoLan
            // 
            this.pbAnhXeVaoLan.BackColor = System.Drawing.Color.Gainsboro;
            this.pbAnhXeVaoLan.Location = new System.Drawing.Point(93, 85);
            this.pbAnhXeVaoLan.Name = "pbAnhXeVaoLan";
            this.pbAnhXeVaoLan.Size = new System.Drawing.Size(576, 432);
            this.pbAnhXeVaoLan.TabIndex = 133;
            this.pbAnhXeVaoLan.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImage = global::Tollcabin.Properties.Resources.Close;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(1314, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(52, 48);
            this.pbClose.TabIndex = 102;
            this.pbClose.TabStop = false;
            // 
            // pnStatusCarIn2
            // 
            this.pnStatusCarIn2.Location = new System.Drawing.Point(8, 571);
            this.pnStatusCarIn2.Name = "pnStatusCarIn2";
            this.pnStatusCarIn2.Size = new System.Drawing.Size(70, 70);
            this.pnStatusCarIn2.TabIndex = 143;
            // 
            // pnStatusCarIn1
            // 
            this.pnStatusCarIn1.BackColor = System.Drawing.Color.Transparent;
            this.pnStatusCarIn1.Location = new System.Drawing.Point(8, 654);
            this.pnStatusCarIn1.Name = "pnStatusCarIn1";
            this.pnStatusCarIn1.Size = new System.Drawing.Size(70, 70);
            this.pnStatusCarIn1.TabIndex = 142;
            // 
            // pnVideo
            // 
            this.pnVideo.BackColor = System.Drawing.Color.Silver;
            this.pnVideo.Location = new System.Drawing.Point(93, 85);
            this.pnVideo.Name = "pnVideo";
            this.pnVideo.Size = new System.Drawing.Size(576, 432);
            this.pnVideo.TabIndex = 147;
            // 
            // ssTime
            // 
            this.ssTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbThongTin,
            this.tssNhanVien,
            this.tssCatruc,
            this.tssCabin,
            this.ToolStripStatusLabel1});
            this.ssTime.Location = new System.Drawing.Point(0, 736);
            this.ssTime.Name = "ssTime";
            this.ssTime.Size = new System.Drawing.Size(1366, 32);
            this.ssTime.TabIndex = 111;
            this.ssTime.Text = "StatusStrip1";
            // 
            // tslbThongTin
            // 
            this.tslbThongTin.AutoSize = false;
            this.tslbThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.tslbThongTin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tslbThongTin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbThongTin.ForeColor = System.Drawing.Color.Red;
            this.tslbThongTin.Name = "tslbThongTin";
            this.tslbThongTin.Size = new System.Drawing.Size(450, 27);
            this.tslbThongTin.Text = "Đưa thẻ nhân viên vào máy đọc thẻ";
            this.tslbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssNhanVien
            // 
            this.tssNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.tssNhanVien.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tssNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssNhanVien.ForeColor = System.Drawing.Color.Black;
            this.tssNhanVien.Image = global::Tollcabin.Properties.Resources.Employee;
            this.tssNhanVien.Name = "tssNhanVien";
            this.tssNhanVien.Size = new System.Drawing.Size(631, 27);
            this.tssNhanVien.Spring = true;
            this.tssNhanVien.Text = "( chưa đăng nhập)";
            // 
            // tssCatruc
            // 
            this.tssCatruc.AutoSize = false;
            this.tssCatruc.BackColor = System.Drawing.SystemColors.Control;
            this.tssCatruc.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tssCatruc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssCatruc.ForeColor = System.Drawing.Color.Black;
            this.tssCatruc.Name = "tssCatruc";
            this.tssCatruc.Size = new System.Drawing.Size(100, 27);
            this.tssCatruc.Text = "Ca trực: ";
            // 
            // tssCabin
            // 
            this.tssCabin.AutoSize = false;
            this.tssCabin.BackColor = System.Drawing.SystemColors.Control;
            this.tssCabin.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.tssCabin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssCabin.ForeColor = System.Drawing.Color.Black;
            this.tssCabin.Name = "tssCabin";
            this.tssCabin.Size = new System.Drawing.Size(80, 27);
            this.tssCabin.Text = "Làn: ";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.AutoSize = false;
            this.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel1.Image = global::Tollcabin.Properties.Resources.test;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(90, 27);
            this.ToolStripStatusLabel1.Text = "161114VD";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TollCabin";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThaiLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrangThaiMang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhXeVaoLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ssTime.ResumeLayout(false);
            this.ssTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerNgayGio;
        private System.Windows.Forms.Timer TimerKiemTraDuLieuCu;
        private System.Windows.Forms.Timer Timer_ChupHinh;
        private System.Windows.Forms.Timer Timer_docMaVach;
        private System.Windows.Forms.Timer Timer_KhoiTaoLai;
        private System.Windows.Forms.Label lbMaVeXe;
        private System.Windows.Forms.Label lbPhanLoaiDuoiLan;
        private System.Windows.Forms.Label lbBienSoDuoiLan;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label lbTenTramThuPhi;
        private System.Windows.Forms.Label lbGiaVe;
        private System.Windows.Forms.Label lbPhanLoaiiii;
        private System.Windows.Forms.Label lbThongTinVe;
        private System.Windows.Forms.Label lbBienSoXeCSDL;
        private System.Windows.Forms.Label lbBienSoooo;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbPhuongTien;
        private System.Windows.Forms.Label lbSoNguoi;
        private System.Windows.Forms.Label lbSoNguoiiiii;
        private System.Windows.Forms.Label lbTTHangHoa;
        private System.Windows.Forms.Label lbTaiTrongHangHoaaa;
        private UcConsole Console;
        private UcController Controller;
        private UcDocMaVach DocMaVach;
        private UcSerialPort UcComPort;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbBarrer;
        private System.Windows.Forms.PictureBox pbTrangThaiLan;
        private System.Windows.Forms.PictureBox pbTrangThaiMang;
        private System.Windows.Forms.PictureBox pbAnhXeVaoLan;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel pnStatusCarIn2;
        private System.Windows.Forms.Panel pnStatusCarIn1;
        private System.Windows.Forms.Panel pnVideo;
        private System.Windows.Forms.StatusStrip ssTime;
        private System.Windows.Forms.ToolStripStatusLabel tslbThongTin;
        private System.Windows.Forms.ToolStripStatusLabel tssNhanVien;
        private System.Windows.Forms.ToolStripStatusLabel tssCatruc;
        private System.Windows.Forms.ToolStripStatusLabel tssCabin;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    }
}