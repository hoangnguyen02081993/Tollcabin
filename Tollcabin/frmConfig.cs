using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using CaptureOcx;
using Encryption;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tollcabin
{
    [DesignerGenerated]
    public partial class frmConfig : Form
    {

        [AccessedThroughProperty("Cap")]
        private VideoCap _Cap;

        private const int MuoiMotSoNhiPhan = 2047;

        private string LocalUserName;

        private string LocalPassWord;

        private string LocalDatabase;

        private string InstanceName;

        private string IPMayGiamSat;

        private string IPMayNhanDang;

        private string LocalImagesPath;

        private string ServerImagesPath;

        private string ServerImagesPathBS;

        private string PortDuLieuChinh;

        private string PortDuLieuCu;

        private string PortTroGiup;

        private string PortMayNhanDangBienSo;

        private string Cabin;

        private int IdTram;

        private int Status;

        private string Instance;

        private string IPDauGhiHinh;

        private string ServerName;

        private string ServerSqlPassword;

        private string ServerDatabase;

        private string ServerSqlUser;

        private string ServerPublication;

        private string ComPortBangDien;

        private string ComPortDauDoc;

        private string ComPortDieuKhien;

        private string ComPortBanPhim;

        private int DVRchanel;

        private string TenTram;

        private bool TinhNangThoai;

        private int DauDocMaVach;

        private ProcessXML Config;


        internal virtual VideoCap Cap
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Cap;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Cap = value;
            }
        }


        public frmConfig()
        {
            base.Load += new EventHandler(this.frmConfig_Load);
            this.LocalUserName = "";
            this.LocalPassWord = "";
            this.LocalDatabase = "";
            this.InstanceName = "";
            this.IPMayGiamSat = "";
            this.IPMayNhanDang = "";
            this.LocalImagesPath = "";
            this.ServerImagesPath = "";
            this.ServerImagesPathBS = "";
            this.PortDuLieuChinh = "";
            this.PortDuLieuCu = "";
            this.PortTroGiup = "";
            this.PortMayNhanDangBienSo = "";
            this.Cabin = "";
            this.IdTram = 0;
            this.Status = 0;
            this.Instance = "";
            this.IPDauGhiHinh = "";
            this.ServerName = "";
            this.ServerSqlPassword = "";
            this.ServerDatabase = "";
            this.ServerSqlUser = "";
            this.ComPortBangDien = "";
            this.ComPortDauDoc = "";
            this.ComPortDieuKhien = "";
            this.ComPortBanPhim = "";
            this.DVRchanel = -1;
            this.TenTram = "";
            this.TinhNangThoai = false;
            this.InitializeComponent();
            this.Cap = new VideoCap();
            this.Cap.BackColor = SystemColors.ButtonShadow;
            this.Cap.Location = new Point(736, 333);
            this.Cap.Size = new Size(203, 207);
            this.Cap.Name = "Cap";
            this.Cap.TabIndex = 145;
            this.Controls.Add(this.Cap);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                this.LocalDatabase = this.tbLocalDatabase.Text;
                this.LocalUserName = this.tbLocalSqlUser.Text;
                this.LocalPassWord = this.tbLocalSqlPassword.Text;
                this.IPMayGiamSat = this.tbComputerWatch.Text;
                this.IPMayNhanDang = this.tbComputerRecognize.Text;
                this.ServerImagesPath = this.tbServerFolderImage.Text;
                this.ServerImagesPathBS = this.tbServerFolderPlateImage.Text;
                this.PortDuLieuChinh = this.tbPortMain.Text;
                this.PortDuLieuCu = this.tbPortSub.Text;
                this.PortMayNhanDangBienSo = this.tbPortRecognize.Text;
                this.Cabin = this.tbLane.Text;
                this.IdTram = Conversions.ToInteger(this.cbbCodeTram.Text);
                this.Instance = this.tbLocalInstance.Text;
                this.Status = this.cbbPropertyLane.SelectedIndex;
                this.LocalImagesPath = this.tbLocalFolderlImage.Text;
                this.ServerName = this.tbServerName.Text;
                this.ServerSqlUser = this.tbServerSqlUser.Text;
                this.ServerSqlPassword = this.tbServerSqlPassword.Text;
                this.ServerDatabase = this.tbServerDatabaseName.Text;
                this.ServerPublication = this.tbPublicationName.Text;
                this.ComPortBangDien = this.cbbbangDien.Text;
                this.ComPortBanPhim = this.cbbComportNameKeyboard.Text;
                this.ComPortDieuKhien = this.cbbComportNameController.Text;
                this.ComPortDauDoc = this.cbbComportNameTicket.Text;
                this.IPDauGhiHinh = this.tbIpDauGhi.Text;
                this.DVRchanel = 0;
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb0.Checked, 1.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb1.Checked, 2.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb2.Checked, 4.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb3.Checked, 8.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb4.Checked, 16.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb5.Checked, 32.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb6.Checked, 64.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb7.Checked, 128.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb8.Checked, 256.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb9.Checked, 512.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb10.Checked, 1024.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb11.Checked, 2048.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb12.Checked, 4096.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb13.Checked, 8192.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb14.Checked, 16384.0, 0)));
                this.DVRchanel = Conversions.ToInteger(Operators.AddObject(this.DVRchanel, Interaction.IIf(this.cb15.Checked, 32768.0, 0)));
                this.TinhNangThoai = this.cbTinhNangThoai.Checked;
                this.DauDocMaVach = this.cbbDauDoc.SelectedIndex;
                Encryption.Encryption.Encode("ITVVA", this.LocalUserName, ref this.LocalUserName);
                Encryption.Encryption.Encode("ITVVA", this.LocalPassWord, ref this.LocalPassWord);
                this.Config.WriteNode("Catalog", "Database", this.LocalDatabase);
                this.Config.WriteNode("Login", "Database", this.LocalUserName);
                this.Config.WriteNode("Password", "Database", this.LocalPassWord);
                this.Config.WriteNode("MayGiamSat", "Connect", this.IPMayGiamSat);
                this.Config.WriteNode("NhanDangBienSo", "Connect", this.IPMayNhanDang);
                this.Config.WriteNode("LocalImagesPath", "Connect", this.LocalImagesPath);
                this.Config.WriteNode("ServerImagesPath", "Connect", this.ServerImagesPath);
                this.Config.WriteNode("ServerImagesPathBS", "Connect", this.ServerImagesPathBS);
                this.Config.WriteNode("PortDuLieuChinh", "Connect", this.PortDuLieuChinh);
                this.Config.WriteNode("PortDuLieuCu", "Connect", this.PortDuLieuCu);
                this.Config.WriteNode("PortTroGiup", "Connect", this.PortTroGiup);
                this.Config.WriteNode("PortMayNhanDangBienSo", "Connect", this.PortMayNhanDangBienSo);
                this.Config.WriteNode("CabinID", "General", this.Cabin);
                this.Config.WriteNode("TramId", "General", Conversions.ToString(this.IdTram));
                this.Config.WriteNode("Status", "General", Conversions.ToString(this.Status));
                this.Config.WriteNode("Instance", "Database", this.Instance);
                this.Config.WriteNode("DatabaseServer", "SQLReplication", this.ServerDatabase);
                this.Config.WriteNode("Server", "SQLReplication", this.ServerName);
                Encryption.Encryption.Encode("ITVVA", this.ServerSqlUser, ref this.ServerSqlUser);
                this.Config.XmlNodeValue("UserServer", "SQLReplication", this.ServerSqlUser);
                Encryption.Encryption.Encode("ITVVA", this.ServerSqlPassword, ref this.ServerSqlPassword);
                this.Config.WriteNode("PasswordServer", "SQLReplication", this.ServerSqlPassword);
                this.Config.WriteNode("Publication", "SQLReplication", this.ServerPublication);
                this.Config.WriteNode("TenDauDoc", "NewInfo", Conversions.ToString(this.DauDocMaVach));
                this.Config.WriteNode("ComPortBangDien", "NewInfo", this.ComPortBangDien);
                this.Config.WriteNode("ComPortBanPhim", "NewInfo", this.ComPortBanPhim);
                this.Config.WriteNode("ComPortDieuKhien", "NewInfo", this.ComPortDieuKhien);
                this.Config.WriteNode("ComPortDauDoc", "NewInfo", this.ComPortDauDoc);
                this.Config.WriteNode("DVRChanel", "NewInfo", Conversions.ToString(this.DVRchanel));
                if (this.TinhNangThoai)
                {
                    this.Config.WriteNode("TinhNangThoai", "NewInfo", "1");
                }
                else
                {
                    this.Config.WriteNode("TinhNangThoai", "NewInfo", "0");
                }
                this.Config.WriteNode("videoCard", "NewInfo", this.IPDauGhiHinh);
            }
            catch (Exception expr_96C)
            {
                ProjectData.SetProjectError(expr_96C);
                Interaction.MsgBox("err", MsgBoxStyle.OkOnly, null);
                ProjectData.ClearProjectError();
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.Config = new ProcessXML("TollcabinConfig.xml");
            try
            {
                this.LocalDatabase = this.Config.XmlNodeValue("Catalog", "Database", "");
                this.LocalUserName = this.Config.XmlNodeValue("Login", "Database", "");
                this.LocalPassWord = this.Config.XmlNodeValue("Password", "Database", "");
                Encryption.Encryption.Decode("ITVVA", ref this.LocalUserName, this.LocalUserName);
                Encryption.Encryption.Decode("ITVVA", ref this.LocalPassWord, this.LocalPassWord);
                this.IPMayGiamSat = this.Config.XmlNodeValue("MayGiamSat", "Connect", "");
                this.IPMayNhanDang = this.Config.XmlNodeValue("NhanDangBienSo", "Connect", "");
                this.LocalImagesPath = this.Config.XmlNodeValue("LocalImagesPath", "Connect", "");
                this.ServerImagesPath = this.Config.XmlNodeValue("ServerImagesPath", "Connect", "");
                this.ServerImagesPathBS = this.Config.XmlNodeValue("ServerImagesPathBS", "Connect", "");
                this.PortDuLieuChinh = Conversions.ToString(int.Parse(this.Config.XmlNodeValue("PortDuLieuChinh", "Connect", "")));
                this.PortDuLieuCu = Conversions.ToString(int.Parse(this.Config.XmlNodeValue("PortDuLieuCu", "Connect", "")));
                this.PortTroGiup = Conversions.ToString(int.Parse(this.Config.XmlNodeValue("PortTroGiup", "Connect", "")));
                this.PortMayNhanDangBienSo = Conversions.ToString(int.Parse(this.Config.XmlNodeValue("PortMayNhanDangBienSo", "Connect", "")));
                this.Cabin = Conversions.ToString(int.Parse(this.Config.XmlNodeValue("CabinID", "General", "")));
                this.IdTram = int.Parse(this.Config.XmlNodeValue("TramId", "General", ""));
                this.Status = int.Parse(this.Config.XmlNodeValue("Status", "General", ""));
                this.Instance = this.Config.XmlNodeValue("Instance", "Database", "");
                this.ServerDatabase = this.Config.XmlNodeValue("DatabaseServer", "SQLReplication", "");
                this.ServerName = this.Config.XmlNodeValue("Server", "SQLReplication", "");
                this.ServerSqlUser = this.Config.XmlNodeValue("UserServer", "SQLReplication", "");
                Encryption.Encryption.Decode("ITVVA", ref this.ServerSqlUser, this.ServerSqlUser);
                this.ServerSqlPassword = this.Config.XmlNodeValue("PasswordServer", "SQLReplication", "");
                Encryption.Encryption.Decode("ITVVA", ref this.ServerSqlPassword, this.ServerSqlPassword);
                this.ServerPublication = this.Config.XmlNodeValue("Publication", "SQLReplication", "");
                this.ComPortBangDien = this.Config.XmlNodeValue("ComPortBangDien", "NewInfo", "");
                this.ComPortBanPhim = this.Config.XmlNodeValue("ComPortBanPhim", "NewInfo", "");
                this.ComPortDieuKhien = this.Config.XmlNodeValue("ComPortDieuKhien", "NewInfo", "");
                this.ComPortDauDoc = this.Config.XmlNodeValue("ComPortDauDoc", "NewInfo", "");
                this.DVRchanel = Conversions.ToInteger(this.Config.XmlNodeValue("DVRChanel", "NewInfo", ""));
                this.IPDauGhiHinh = this.Config.XmlNodeValue("videoCard", "NewInfo", "");
                this.DauDocMaVach = Conversions.ToInteger(this.Config.XmlNodeValue("TenDauDoc", "NewInfo", "0"));
                if (Operators.CompareString(this.Config.XmlNodeValue("TinhNangThoai", "NewInfo", "0"), "0", false) != 0)
                {
                    this.cbTinhNangThoai.Checked = true;
                }
                else
                {
                    this.cbTinhNangThoai.Checked = false;
                }
                this.cbbbangDien.Text = this.ComPortBangDien;
                this.cbbComportNameKeyboard.Text = this.ComPortBanPhim;
                this.cbbComportNameController.Text = this.ComPortDieuKhien;
                this.cbbComportNameTicket.Text = this.ComPortDauDoc;
                this.tbServerName.Text = this.ServerName;
                this.tbServerSqlUser.Text = this.ServerSqlUser;
                this.tbServerSqlPassword.Text = this.ServerSqlPassword;
                this.tbServerDatabaseName.Text = this.ServerDatabase;
                this.tbPublicationName.Text = this.ServerPublication;
                this.tbLocalDatabase.Text = this.LocalDatabase;
                this.tbLocalSqlUser.Text = this.LocalUserName;
                this.tbLocalSqlPassword.Text = this.LocalPassWord;
                this.tbComputerWatch.Text = this.IPMayGiamSat;
                this.tbComputerRecognize.Text = this.IPMayNhanDang;
                this.tbServerFolderImage.Text = this.ServerImagesPath;
                this.tbServerFolderPlateImage.Text = this.ServerImagesPathBS;
                this.tbPortMain.Text = this.PortDuLieuChinh;
                this.tbPortSub.Text = this.PortDuLieuCu;
                this.tbPortRecognize.Text = this.PortMayNhanDangBienSo;
                this.tbLane.Text = this.Cabin;
                this.cbbCodeTram.Text = Conversions.ToString(this.IdTram);
                this.tbLocalInstance.Text = this.Instance;
                this.cbbPropertyLane.SelectedIndex = this.Status;
                this.tbLocalFolderlImage.Text = this.LocalImagesPath;
                this.cbbDauDoc.SelectedIndex = this.DauDocMaVach;
                this.tbIpDauGhi.Text = this.IPDauGhiHinh;
                if (this.DVRchanel >= 0)
                {
                    this.cb0.Checked = (((long)this.DVRchanel & 1L) != 0L);
                    this.cb1.Checked = (((long)this.DVRchanel & 2L) != 0L);
                    this.cb2.Checked = (((long)this.DVRchanel & 4L) != 0L);
                    this.cb3.Checked = (((long)this.DVRchanel & 8L) != 0L);
                    this.cb4.Checked = (((long)this.DVRchanel & 16L) != 0L);
                    this.cb5.Checked = (((long)this.DVRchanel & 32L) != 0L);
                    this.cb6.Checked = (((long)this.DVRchanel & 64L) != 0L);
                    this.cb7.Checked = (((long)this.DVRchanel & 128L) != 0L);
                    this.cb8.Checked = (((long)this.DVRchanel & 256L) != 0L);
                    this.cb9.Checked = (((long)this.DVRchanel & 512L) != 0L);
                    this.cb10.Checked = (((long)this.DVRchanel & 1024L) != 0L);
                    this.cb11.Checked = (((long)this.DVRchanel & 2048L) != 0L);
                    this.cb12.Checked = (((long)this.DVRchanel & 4096L) != 0L);
                    this.cb13.Checked = (((long)this.DVRchanel & 8192L) != 0L);
                    this.cb14.Checked = (((long)this.DVRchanel & 16384L) != 0L);
                    this.cb15.Checked = (((long)this.DVRchanel & 32768L) != 0L);
                }
            }
            catch (Exception expr_7F8)
            {
                ProjectData.SetProjectError(expr_7F8);
                MessageBox.Show("Có lỗi trong quá trình đọc thông tin cấu hình", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.frmConfig_Load(RuntimeHelpers.GetObjectValue(new object()), new EventArgs());
        }

        private void cbTinhNangThoai_CheckedChanged(object sender, EventArgs e)
        {
            this.TinhNangThoai = this.cbTinhNangThoai.Checked;
        }
    }
}
