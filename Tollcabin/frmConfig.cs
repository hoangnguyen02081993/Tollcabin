using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;

        [AccessedThroughProperty("tbLocalSqlPassword")]
        private TextBox _tbLocalSqlPassword;

        [AccessedThroughProperty("Label9")]
        private Label _Label9;

        [AccessedThroughProperty("tbLocalDatabase")]
        private TextBox _tbLocalDatabase;

        [AccessedThroughProperty("Label10")]
        private Label _Label10;

        [AccessedThroughProperty("tbLocalSqlUser")]
        private TextBox _tbLocalSqlUser;

        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        [AccessedThroughProperty("tbLocalInstance")]
        private TextBox _tbLocalInstance;

        [AccessedThroughProperty("Label8")]
        private Label _Label8;

        [AccessedThroughProperty("Label13")]
        private Label _Label13;

        [AccessedThroughProperty("ttbTenTram")]
        private TextBox _ttbTenTram;

        [AccessedThroughProperty("Label14")]
        private Label _Label14;

        [AccessedThroughProperty("Label11")]
        private Label _Label11;

        [AccessedThroughProperty("tbLane")]
        private TextBox _tbLane;

        [AccessedThroughProperty("Label12")]
        private Label _Label12;

        [AccessedThroughProperty("GroupBox2")]
        private GroupBox _GroupBox2;

        [AccessedThroughProperty("tbPublicationName")]
        private TextBox _tbPublicationName;

        [AccessedThroughProperty("Label18")]
        private Label _Label18;

        [AccessedThroughProperty("tbServerSqlPassword")]
        private TextBox _tbServerSqlPassword;

        [AccessedThroughProperty("Label19")]
        private Label _Label19;

        [AccessedThroughProperty("tbServerDatabaseName")]
        private TextBox _tbServerDatabaseName;

        [AccessedThroughProperty("Label20")]
        private Label _Label20;

        [AccessedThroughProperty("tbServerSqlUser")]
        private TextBox _tbServerSqlUser;

        [AccessedThroughProperty("Label21")]
        private Label _Label21;

        [AccessedThroughProperty("tbServerName")]
        private TextBox _tbServerName;

        [AccessedThroughProperty("Label22")]
        private Label _Label22;

        [AccessedThroughProperty("GroupBox3")]
        private GroupBox _GroupBox3;

        [AccessedThroughProperty("tbPortRecognize")]
        private TextBox _tbPortRecognize;

        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        [AccessedThroughProperty("tbPortSub")]
        private TextBox _tbPortSub;

        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        [AccessedThroughProperty("tbPortMain")]
        private TextBox _tbPortMain;

        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        [AccessedThroughProperty("tbComputerRecognize")]
        private TextBox _tbComputerRecognize;

        [AccessedThroughProperty("Label15")]
        private Label _Label15;

        [AccessedThroughProperty("tbComputerWatch")]
        private TextBox _tbComputerWatch;

        [AccessedThroughProperty("Label16")]
        private Label _Label16;

        [AccessedThroughProperty("Label23")]
        private Label _Label23;

        [AccessedThroughProperty("tbLocalFolderlImage")]
        private TextBox _tbLocalFolderlImage;

        [AccessedThroughProperty("Label24")]
        private Label _Label24;

        [AccessedThroughProperty("tbServerFolderPlateImage")]
        private TextBox _tbServerFolderPlateImage;

        [AccessedThroughProperty("Label17")]
        private Label _Label17;

        [AccessedThroughProperty("tbServerFolderImage")]
        private TextBox _tbServerFolderImage;

        [AccessedThroughProperty("Label27")]
        private Label _Label27;

        [AccessedThroughProperty("Label26")]
        private Label _Label26;

        [AccessedThroughProperty("Label25")]
        private Label _Label25;

        [AccessedThroughProperty("cbbComportNameKeyboard")]
        private ComboBox _cbbComportNameKeyboard;

        [AccessedThroughProperty("cbbbangDien")]
        private ComboBox _cbbbangDien;

        [AccessedThroughProperty("cbbComportNameController")]
        private ComboBox _cbbComportNameController;

        [AccessedThroughProperty("cbbComportNameTicket")]
        private ComboBox _cbbComportNameTicket;

        [AccessedThroughProperty("Label28")]
        private Label _Label28;

        [AccessedThroughProperty("btLuu")]
        private Button _btLuu;

        [AccessedThroughProperty("btThoat")]
        private Button _btThoat;

        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        [AccessedThroughProperty("cbbDVRchanel")]
        private ComboBox _cbbDVRchanel;

        [AccessedThroughProperty("cbbPropertyLane")]
        private ComboBox _cbbPropertyLane;

        [AccessedThroughProperty("cbbCodeTram")]
        private ComboBox _cbbCodeTram;

        [AccessedThroughProperty("Cap")]
        private VideoCap _Cap;

        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        [AccessedThroughProperty("cbTinhNangThoai")]
        private CheckBox _cbTinhNangThoai;

        [AccessedThroughProperty("Label35")]
        private Label _Label35;

        [AccessedThroughProperty("cbbDauDoc")]
        private ComboBox _cbbDauDoc;

        [AccessedThroughProperty("cb15")]
        private CheckBox _cb15;

        [AccessedThroughProperty("cb14")]
        private CheckBox _cb14;

        [AccessedThroughProperty("cb13")]
        private CheckBox _cb13;

        [AccessedThroughProperty("cb12")]
        private CheckBox _cb12;

        [AccessedThroughProperty("cb11")]
        private CheckBox _cb11;

        [AccessedThroughProperty("cb10")]
        private CheckBox _cb10;

        [AccessedThroughProperty("cb9")]
        private CheckBox _cb9;

        [AccessedThroughProperty("cb8")]
        private CheckBox _cb8;

        [AccessedThroughProperty("cb7")]
        private CheckBox _cb7;

        [AccessedThroughProperty("cb6")]
        private CheckBox _cb6;

        [AccessedThroughProperty("cb5")]
        private CheckBox _cb5;

        [AccessedThroughProperty("cb4")]
        private CheckBox _cb4;

        [AccessedThroughProperty("cb3")]
        private CheckBox _cb3;

        [AccessedThroughProperty("cb2")]
        private CheckBox _cb2;

        [AccessedThroughProperty("cb1")]
        private CheckBox _cb1;

        [AccessedThroughProperty("cb0")]
        private CheckBox _cb0;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("tbIpDauGhi")]
        private TextBox _tbIpDauGhi;

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

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox1 = value;
            }
        }

        internal virtual TextBox tbLocalSqlPassword
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLocalSqlPassword;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLocalSqlPassword = value;
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

        internal virtual TextBox tbLocalDatabase
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLocalDatabase;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLocalDatabase = value;
            }
        }

        internal virtual Label Label10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label10;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label10 = value;
            }
        }

        internal virtual TextBox tbLocalSqlUser
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLocalSqlUser;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLocalSqlUser = value;
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

        internal virtual TextBox tbLocalInstance
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLocalInstance;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLocalInstance = value;
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

        internal virtual Label Label13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label13;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label13 = value;
            }
        }

        internal virtual TextBox ttbTenTram
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ttbTenTram;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ttbTenTram = value;
            }
        }

        internal virtual Label Label14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label14;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label14 = value;
            }
        }

        internal virtual Label Label11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label11;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label11 = value;
            }
        }

        internal virtual TextBox tbLane
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLane;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLane = value;
            }
        }

        internal virtual Label Label12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label12;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label12 = value;
            }
        }

        internal virtual GroupBox GroupBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox2;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox2 = value;
            }
        }

        internal virtual TextBox tbPublicationName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbPublicationName;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbPublicationName = value;
            }
        }

        internal virtual Label Label18
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label18;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label18 = value;
            }
        }

        internal virtual TextBox tbServerSqlPassword
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerSqlPassword;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerSqlPassword = value;
            }
        }

        internal virtual Label Label19
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label19;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label19 = value;
            }
        }

        internal virtual TextBox tbServerDatabaseName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerDatabaseName;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerDatabaseName = value;
            }
        }

        internal virtual Label Label20
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label20;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label20 = value;
            }
        }

        internal virtual TextBox tbServerSqlUser
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerSqlUser;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerSqlUser = value;
            }
        }

        internal virtual Label Label21
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label21;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label21 = value;
            }
        }

        internal virtual TextBox tbServerName
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerName;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerName = value;
            }
        }

        internal virtual Label Label22
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label22;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label22 = value;
            }
        }

        internal virtual GroupBox GroupBox3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GroupBox3;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GroupBox3 = value;
            }
        }

        internal virtual TextBox tbPortRecognize
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbPortRecognize;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbPortRecognize = value;
            }
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual TextBox tbPortSub
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbPortSub;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbPortSub = value;
            }
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual TextBox tbPortMain
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbPortMain;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbPortMain = value;
            }
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label6;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual TextBox tbComputerRecognize
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbComputerRecognize;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbComputerRecognize = value;
            }
        }

        internal virtual Label Label15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label15;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label15 = value;
            }
        }

        internal virtual TextBox tbComputerWatch
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbComputerWatch;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbComputerWatch = value;
            }
        }

        internal virtual Label Label16
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label16;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label16 = value;
            }
        }

        internal virtual Label Label23
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label23;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label23 = value;
            }
        }

        internal virtual TextBox tbLocalFolderlImage
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbLocalFolderlImage;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbLocalFolderlImage = value;
            }
        }

        internal virtual Label Label24
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label24;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label24 = value;
            }
        }

        internal virtual TextBox tbServerFolderPlateImage
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerFolderPlateImage;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerFolderPlateImage = value;
            }
        }

        internal virtual Label Label17
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label17;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label17 = value;
            }
        }

        internal virtual TextBox tbServerFolderImage
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbServerFolderImage;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbServerFolderImage = value;
            }
        }

        internal virtual Label Label27
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label27;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label27 = value;
            }
        }

        internal virtual Label Label26
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label26;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label26 = value;
            }
        }

        internal virtual Label Label25
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label25;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label25 = value;
            }
        }

        internal virtual ComboBox cbbComportNameKeyboard
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbComportNameKeyboard;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbComportNameKeyboard = value;
            }
        }

        internal virtual ComboBox cbbbangDien
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbbangDien;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbbangDien = value;
            }
        }

        internal virtual ComboBox cbbComportNameController
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbComportNameController;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbComportNameController = value;
            }
        }

        internal virtual ComboBox cbbComportNameTicket
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbComportNameTicket;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbComportNameTicket = value;
            }
        }

        internal virtual Label Label28
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label28;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label28 = value;
            }
        }

        internal virtual Button btLuu
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btLuu;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btLuu_Click);
                if (this._btLuu != null)
                {
                    this._btLuu.Click -= value2;
                }
                this._btLuu = value;
                if (this._btLuu != null)
                {
                    this._btLuu.Click += value2;
                }
            }
        }

        internal virtual Button btThoat
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btThoat;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.btThoat_Click);
                if (this._btThoat != null)
                {
                    this._btThoat.Click -= value2;
                }
                this._btThoat = value;
                if (this._btThoat != null)
                {
                    this._btThoat.Click += value2;
                }
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual ComboBox cbbDVRchanel
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbDVRchanel;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbDVRchanel = value;
            }
        }

        internal virtual ComboBox cbbPropertyLane
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbPropertyLane;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbPropertyLane = value;
            }
        }

        internal virtual ComboBox cbbCodeTram
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbCodeTram;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbCodeTram = value;
            }
        }

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

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button1_Click_1);
                if (this._Button1 != null)
                {
                    this._Button1.Click -= value2;
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += value2;
                }
            }
        }

        internal virtual CheckBox cbTinhNangThoai
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbTinhNangThoai;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.cbTinhNangThoai_CheckedChanged);
                if (this._cbTinhNangThoai != null)
                {
                    this._cbTinhNangThoai.CheckedChanged -= value2;
                }
                this._cbTinhNangThoai = value;
                if (this._cbTinhNangThoai != null)
                {
                    this._cbTinhNangThoai.CheckedChanged += value2;
                }
            }
        }

        internal virtual Label Label35
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label35;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label35 = value;
            }
        }

        internal virtual ComboBox cbbDauDoc
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cbbDauDoc;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbbDauDoc = value;
            }
        }

        internal virtual CheckBox cb15
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb15;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb15 = value;
            }
        }

        internal virtual CheckBox cb14
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb14;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb14 = value;
            }
        }

        internal virtual CheckBox cb13
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb13;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb13 = value;
            }
        }

        internal virtual CheckBox cb12
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb12;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb12 = value;
            }
        }

        internal virtual CheckBox cb11
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb11;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb11 = value;
            }
        }

        internal virtual CheckBox cb10
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb10;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb10 = value;
            }
        }

        internal virtual CheckBox cb9
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb9;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb9 = value;
            }
        }

        internal virtual CheckBox cb8
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb8;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb8 = value;
            }
        }

        internal virtual CheckBox cb7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb7;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb7 = value;
            }
        }

        internal virtual CheckBox cb6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb6;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb6 = value;
            }
        }

        internal virtual CheckBox cb5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb5;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb5 = value;
            }
        }

        internal virtual CheckBox cb4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb4;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb4 = value;
            }
        }

        internal virtual CheckBox cb3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb3;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb3 = value;
            }
        }

        internal virtual CheckBox cb2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb2;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb2 = value;
            }
        }

        internal virtual CheckBox cb1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb1 = value;
            }
        }

        internal virtual CheckBox cb0
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cb0;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cb0 = value;
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

        internal virtual TextBox tbIpDauGhi
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tbIpDauGhi;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbIpDauGhi = value;
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
        }

        private void InitializeComponent()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmConfig));
            this.GroupBox1 = new GroupBox();
            this.tbIpDauGhi = new TextBox();
            this.cbbDauDoc = new ComboBox();
            this.Label35 = new Label();
            this.cbbPropertyLane = new ComboBox();
            this.cbbDVRchanel = new ComboBox();
            this.Label3 = new Label();
            this.cbbComportNameKeyboard = new ComboBox();
            this.cbbbangDien = new ComboBox();
            this.cbbComportNameController = new ComboBox();
            this.cbbComportNameTicket = new ComboBox();
            this.Label28 = new Label();
            this.Label11 = new Label();
            this.Label27 = new Label();
            this.Label26 = new Label();
            this.Label25 = new Label();
            this.Label23 = new Label();
            this.tbLocalFolderlImage = new TextBox();
            this.ttbTenTram = new TextBox();
            this.Label14 = new Label();
            this.tbLane = new TextBox();
            this.Label12 = new Label();
            this.tbLocalSqlPassword = new TextBox();
            this.Label9 = new Label();
            this.tbLocalDatabase = new TextBox();
            this.Label10 = new Label();
            this.tbLocalSqlUser = new TextBox();
            this.Label7 = new Label();
            this.tbLocalInstance = new TextBox();
            this.Label8 = new Label();
            this.cbbCodeTram = new ComboBox();
            this.Label13 = new Label();
            this.GroupBox2 = new GroupBox();
            this.Label24 = new Label();
            this.tbServerFolderPlateImage = new TextBox();
            this.Label17 = new Label();
            this.tbPublicationName = new TextBox();
            this.tbServerFolderImage = new TextBox();
            this.Label18 = new Label();
            this.tbServerSqlPassword = new TextBox();
            this.Label19 = new Label();
            this.tbServerDatabaseName = new TextBox();
            this.Label20 = new Label();
            this.tbServerSqlUser = new TextBox();
            this.Label21 = new Label();
            this.tbServerName = new TextBox();
            this.Label22 = new Label();
            this.GroupBox3 = new GroupBox();
            this.cb15 = new CheckBox();
            this.cb14 = new CheckBox();
            this.cb13 = new CheckBox();
            this.cb12 = new CheckBox();
            this.cb11 = new CheckBox();
            this.cb10 = new CheckBox();
            this.cb9 = new CheckBox();
            this.cb8 = new CheckBox();
            this.cb7 = new CheckBox();
            this.cb6 = new CheckBox();
            this.cb5 = new CheckBox();
            this.cb4 = new CheckBox();
            this.cb3 = new CheckBox();
            this.cb2 = new CheckBox();
            this.cb1 = new CheckBox();
            this.cb0 = new CheckBox();
            this.Label1 = new Label();
            this.cbTinhNangThoai = new CheckBox();
            this.tbPortRecognize = new TextBox();
            this.Label4 = new Label();
            this.tbPortSub = new TextBox();
            this.Label5 = new Label();
            this.tbPortMain = new TextBox();
            this.Label6 = new Label();
            this.tbComputerRecognize = new TextBox();
            this.Label15 = new Label();
            this.tbComputerWatch = new TextBox();
            this.Label16 = new Label();
            this.btLuu = new Button();
            this.btThoat = new Button();
            this.Cap = new VideoCap();
            this.Button1 = new Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            this.GroupBox1.Controls.Add(this.tbIpDauGhi);
            this.GroupBox1.Controls.Add(this.cbbDauDoc);
            this.GroupBox1.Controls.Add(this.Label35);
            this.GroupBox1.Controls.Add(this.cbbPropertyLane);
            this.GroupBox1.Controls.Add(this.cbbDVRchanel);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbbComportNameKeyboard);
            this.GroupBox1.Controls.Add(this.cbbbangDien);
            this.GroupBox1.Controls.Add(this.cbbComportNameController);
            this.GroupBox1.Controls.Add(this.cbbComportNameTicket);
            this.GroupBox1.Controls.Add(this.Label28);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label27);
            this.GroupBox1.Controls.Add(this.Label26);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Label23);
            this.GroupBox1.Controls.Add(this.tbLocalFolderlImage);
            this.GroupBox1.Controls.Add(this.ttbTenTram);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.tbLane);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.tbLocalSqlPassword);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.tbLocalDatabase);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.tbLocalSqlUser);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.tbLocalInstance);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.GroupBox1.ForeColor = Color.Navy;
            Control arg_667_0 = this.GroupBox1;
            Point location = new Point(12, 0);
            arg_667_0.Location = location;
            this.GroupBox1.Name = "GroupBox1";
            Control arg_694_0 = this.GroupBox1;
            Size size = new Size(690, 212);
            arg_694_0.Size = size;
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Máy trạm";
            this.tbIpDauGhi.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbIpDauGhi.ForeColor = Color.Black;
            Control arg_708_0 = this.tbIpDauGhi;
            location = new Point(493, 126);
            arg_708_0.Location = location;
            this.tbIpDauGhi.Name = "tbIpDauGhi";
            Control arg_732_0 = this.tbIpDauGhi;
            size = new Size(166, 22);
            arg_732_0.Size = size;
            this.tbIpDauGhi.TabIndex = 149;
            this.cbbDauDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbDauDoc.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbDauDoc.ForeColor = Color.Black;
            this.cbbDauDoc.FormattingEnabled = true;
            this.cbbDauDoc.Items.AddRange(new object[]
            {
                "Cổng COM thật",
                "Cổng COM ảo"
            });
            Control arg_7D0_0 = this.cbbDauDoc;
            location = new Point(493, 152);
            arg_7D0_0.Location = location;
            this.cbbDauDoc.Name = "cbbDauDoc";
            Control arg_7FA_0 = this.cbbDauDoc;
            size = new Size(166, 23);
            arg_7FA_0.Size = size;
            this.cbbDauDoc.TabIndex = 148;
            this.Label35.AutoSize = true;
            this.Label35.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label35.ForeColor = Color.Black;
            Control arg_864_0 = this.Label35;
            location = new Point(419, 161);
            arg_864_0.Location = location;
            this.Label35.Name = "Label35";
            Control arg_88B_0 = this.Label35;
            size = new Size(61, 16);
            arg_88B_0.Size = size;
            this.Label35.TabIndex = 147;
            this.Label35.Text = "Đầu đọc ";
            this.cbbPropertyLane.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbPropertyLane.Enabled = false;
            this.cbbPropertyLane.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbPropertyLane.ForeColor = Color.Black;
            this.cbbPropertyLane.FormattingEnabled = true;
            this.cbbPropertyLane.Items.AddRange(new object[]
            {
                "Làn xe đơn",
                "Làn xe đôi chính",
                "Làn xe đôi phụ"
            });
            Control arg_94D_0 = this.cbbPropertyLane;
            location = new Point(493, 179);
            arg_94D_0.Location = location;
            this.cbbPropertyLane.Name = "cbbPropertyLane";
            Control arg_977_0 = this.cbbPropertyLane;
            size = new Size(166, 23);
            arg_977_0.Size = size;
            this.cbbPropertyLane.TabIndex = 42;
            this.cbbDVRchanel.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbDVRchanel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbDVRchanel.ForeColor = Color.Black;
            this.cbbDVRchanel.FormattingEnabled = true;
            this.cbbDVRchanel.Items.AddRange(new object[]
            {
                "-1",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16"
            });
            Control arg_A99_0 = this.cbbDVRchanel;
            location = new Point(343, 42);
            arg_A99_0.Location = location;
            this.cbbDVRchanel.Name = "cbbDVRchanel";
            Control arg_AC0_0 = this.cbbDVRchanel;
            size = new Size(32, 23);
            arg_AC0_0.Size = size;
            this.cbbDVRchanel.TabIndex = 41;
            this.cbbDVRchanel.Visible = false;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label3.ForeColor = Color.Black;
            Control arg_B33_0 = this.Label3;
            location = new Point(386, 133);
            arg_B33_0.Location = location;
            this.Label3.Name = "Label3";
            Control arg_B5A_0 = this.Label3;
            size = new Size(94, 16);
            arg_B5A_0.Size = size;
            this.Label3.TabIndex = 40;
            this.Label3.Text = "IP đầu ghi hình";
            this.cbbComportNameKeyboard.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbComportNameKeyboard.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbComportNameKeyboard.ForeColor = Color.Black;
            this.cbbComportNameKeyboard.FormattingEnabled = true;
            this.cbbComportNameKeyboard.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20"
            });
            Control arg_CA1_0 = this.cbbComportNameKeyboard;
            location = new Point(130, 182);
            arg_CA1_0.Location = location;
            this.cbbComportNameKeyboard.Name = "cbbComportNameKeyboard";
            Control arg_CCB_0 = this.cbbComportNameKeyboard;
            size = new Size(166, 23);
            arg_CCB_0.Size = size;
            this.cbbComportNameKeyboard.TabIndex = 39;
            this.cbbbangDien.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbbangDien.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbbangDien.ForeColor = Color.Black;
            this.cbbbangDien.FormattingEnabled = true;
            this.cbbbangDien.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20"
            });
            Control arg_E02_0 = this.cbbbangDien;
            location = new Point(130, 154);
            arg_E02_0.Location = location;
            this.cbbbangDien.Name = "cbbbangDien";
            Control arg_E2C_0 = this.cbbbangDien;
            size = new Size(166, 23);
            arg_E2C_0.Size = size;
            this.cbbbangDien.TabIndex = 38;
            this.cbbComportNameController.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbComportNameController.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbComportNameController.ForeColor = Color.Black;
            this.cbbComportNameController.FormattingEnabled = true;
            this.cbbComportNameController.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20"
            });
            Control arg_F60_0 = this.cbbComportNameController;
            location = new Point(493, 99);
            arg_F60_0.Location = location;
            this.cbbComportNameController.Name = "cbbComportNameController";
            Control arg_F8A_0 = this.cbbComportNameController;
            size = new Size(166, 23);
            arg_F8A_0.Size = size;
            this.cbbComportNameController.TabIndex = 37;
            this.cbbComportNameTicket.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbComportNameTicket.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbComportNameTicket.ForeColor = Color.Black;
            this.cbbComportNameTicket.FormattingEnabled = true;
            this.cbbComportNameTicket.Items.AddRange(new object[]
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
                "COM5",
                "COM6",
                "COM7",
                "COM8",
                "COM9",
                "COM10",
                "COM11",
                "COM12",
                "COM13",
                "COM14",
                "COM15",
                "COM16",
                "COM17",
                "COM18",
                "COM19",
                "COM20"
            });
            Control arg_10BE_0 = this.cbbComportNameTicket;
            location = new Point(493, 72);
            arg_10BE_0.Location = location;
            this.cbbComportNameTicket.Name = "cbbComportNameTicket";
            Control arg_10E8_0 = this.cbbComportNameTicket;
            size = new Size(166, 23);
            arg_10E8_0.Size = size;
            this.cbbComportNameTicket.TabIndex = 36;
            this.Label28.AutoSize = true;
            this.Label28.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label28.ForeColor = Color.Black;
            Control arg_114C_0 = this.Label28;
            location = new Point(376, 107);
            arg_114C_0.Location = location;
            this.Label28.Name = "Label28";
            Control arg_1173_0 = this.Label28;
            size = new Size(104, 16);
            arg_1173_0.Size = size;
            this.Label28.TabIndex = 31;
            this.Label28.Text = "Cổng điều khiển";
            this.Label11.AutoSize = true;
            this.Label11.Enabled = false;
            this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label11.ForeColor = Color.Black;
            Control arg_11F6_0 = this.Label11;
            location = new Point(380, 185);
            arg_11F6_0.Location = location;
            this.Label11.Name = "Label11";
            Control arg_121D_0 = this.Label11;
            size = new Size(100, 16);
            arg_121D_0.Size = size;
            this.Label11.TabIndex = 18;
            this.Label11.Text = "Tính chất làn xe";
            this.Label27.AutoSize = true;
            this.Label27.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label27.ForeColor = Color.Black;
            Control arg_1291_0 = this.Label27;
            location = new Point(23, 184);
            arg_1291_0.Location = location;
            this.Label27.Name = "Label27";
            Control arg_12B8_0 = this.Label27;
            size = new Size(98, 16);
            arg_12B8_0.Size = size;
            this.Label27.TabIndex = 30;
            this.Label27.Text = "Cổng bàn phím";
            this.Label26.AutoSize = true;
            this.Label26.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label26.ForeColor = Color.Black;
            Control arg_132C_0 = this.Label26;
            location = new Point(18, 157);
            arg_132C_0.Location = location;
            this.Label26.Name = "Label26";
            Control arg_1353_0 = this.Label26;
            size = new Size(103, 16);
            arg_1353_0.Size = size;
            this.Label26.TabIndex = 29;
            this.Label26.Text = "Cổng bảng điện";
            this.Label25.AutoSize = true;
            this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label25.ForeColor = Color.Black;
            Control arg_13C7_0 = this.Label25;
            location = new Point(388, 80);
            arg_13C7_0.Location = location;
            this.Label25.Name = "Label25";
            Control arg_13EE_0 = this.Label25;
            size = new Size(92, 16);
            arg_13EE_0.Size = size;
            this.Label25.TabIndex = 28;
            this.Label25.Text = "Cổng đầu đọc";
            this.Label23.AutoSize = true;
            this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label23.ForeColor = Color.Black;
            Control arg_1462_0 = this.Label23;
            location = new Point(20, 130);
            arg_1462_0.Location = location;
            this.Label23.Name = "Label23";
            Control arg_1489_0 = this.Label23;
            size = new Size(101, 16);
            arg_1489_0.Size = size;
            this.Label23.TabIndex = 27;
            this.Label23.Text = "Thư mục ảnh xe";
            this.tbLocalFolderlImage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLocalFolderlImage.ForeColor = Color.Black;
            Control arg_14F1_0 = this.tbLocalFolderlImage;
            location = new Point(130, 127);
            arg_14F1_0.Location = location;
            this.tbLocalFolderlImage.Name = "tbLocalFolderlImage";
            Control arg_151B_0 = this.tbLocalFolderlImage;
            size = new Size(166, 22);
            arg_151B_0.Size = size;
            this.tbLocalFolderlImage.TabIndex = 24;
            this.ttbTenTram.Enabled = false;
            this.ttbTenTram.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.ttbTenTram.ForeColor = Color.Black;
            Control arg_157F_0 = this.ttbTenTram;
            location = new Point(130, 100);
            arg_157F_0.Location = location;
            this.ttbTenTram.Name = "ttbTenTram";
            Control arg_15A9_0 = this.ttbTenTram;
            size = new Size(166, 22);
            arg_15A9_0.Size = size;
            this.ttbTenTram.TabIndex = 21;
            this.Label14.AutoSize = true;
            this.Label14.Enabled = false;
            this.Label14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label14.ForeColor = Color.Black;
            Control arg_1616_0 = this.Label14;
            location = new Point(19, 103);
            arg_1616_0.Location = location;
            this.Label14.Name = "Label14";
            Control arg_163D_0 = this.Label14;
            size = new Size(102, 16);
            arg_163D_0.Size = size;
            this.Label14.TabIndex = 20;
            this.Label14.Text = "Tên trạm thu phí";
            this.tbLane.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLane.ForeColor = Color.Black;
            Control arg_16A5_0 = this.tbLane;
            location = new Point(130, 73);
            arg_16A5_0.Location = location;
            this.tbLane.Name = "tbLane";
            Control arg_16CF_0 = this.tbLane;
            size = new Size(166, 22);
            arg_16CF_0.Size = size;
            this.tbLane.TabIndex = 17;
            this.Label12.AutoSize = true;
            this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label12.ForeColor = Color.Black;
            Control arg_1730_0 = this.Label12;
            location = new Point(74, 76);
            arg_1730_0.Location = location;
            this.Label12.Name = "Label12";
            Control arg_1757_0 = this.Label12;
            size = new Size(47, 16);
            arg_1757_0.Size = size;
            this.Label12.TabIndex = 16;
            this.Label12.Text = "Làn xe";
            this.tbLocalSqlPassword.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLocalSqlPassword.ForeColor = Color.Black;
            Control arg_17BF_0 = this.tbLocalSqlPassword;
            location = new Point(493, 46);
            arg_17BF_0.Location = location;
            this.tbLocalSqlPassword.Name = "tbLocalSqlPassword";
            Control arg_17E9_0 = this.tbLocalSqlPassword;
            size = new Size(166, 22);
            arg_17E9_0.Size = size;
            this.tbLocalSqlPassword.TabIndex = 15;
            this.tbLocalSqlPassword.UseSystemPasswordChar = true;
            this.Label9.AutoSize = true;
            this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label9.ForeColor = Color.Black;
            Control arg_1859_0 = this.Label9;
            location = new Point(381, 22);
            arg_1859_0.Location = location;
            this.Label9.Name = "Label9";
            Control arg_1880_0 = this.Label9;
            size = new Size(99, 16);
            arg_1880_0.Size = size;
            this.Label9.TabIndex = 14;
            this.Label9.Text = "Tên đăng nhập";
            this.tbLocalDatabase.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLocalDatabase.ForeColor = Color.Black;
            Control arg_18E8_0 = this.tbLocalDatabase;
            location = new Point(130, 46);
            arg_18E8_0.Location = location;
            this.tbLocalDatabase.Name = "tbLocalDatabase";
            Control arg_1912_0 = this.tbLocalDatabase;
            size = new Size(166, 22);
            arg_1912_0.Size = size;
            this.tbLocalDatabase.TabIndex = 13;
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label10.ForeColor = Color.Black;
            Control arg_1973_0 = this.Label10;
            location = new Point(31, 22);
            arg_1973_0.Location = location;
            this.Label10.Name = "Label10";
            Control arg_199A_0 = this.Label10;
            size = new Size(90, 16);
            arg_199A_0.Size = size;
            this.Label10.TabIndex = 12;
            this.Label10.Text = "Tên máy trạm";
            this.tbLocalSqlUser.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLocalSqlUser.ForeColor = Color.Black;
            Control arg_1A02_0 = this.tbLocalSqlUser;
            location = new Point(493, 20);
            arg_1A02_0.Location = location;
            this.tbLocalSqlUser.Name = "tbLocalSqlUser";
            Control arg_1A2C_0 = this.tbLocalSqlUser;
            size = new Size(166, 22);
            arg_1A2C_0.Size = size;
            this.tbLocalSqlUser.TabIndex = 11;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label7.ForeColor = Color.Black;
            Control arg_1A90_0 = this.Label7;
            location = new Point(418, 49);
            arg_1A90_0.Location = location;
            this.Label7.Name = "Label7";
            Control arg_1AB7_0 = this.Label7;
            size = new Size(62, 16);
            arg_1AB7_0.Size = size;
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Mật khẩu";
            this.tbLocalInstance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbLocalInstance.ForeColor = Color.Black;
            Control arg_1B1F_0 = this.tbLocalInstance;
            location = new Point(130, 19);
            arg_1B1F_0.Location = location;
            this.tbLocalInstance.Name = "tbLocalInstance";
            Control arg_1B49_0 = this.tbLocalInstance;
            size = new Size(166, 22);
            arg_1B49_0.Size = size;
            this.tbLocalInstance.TabIndex = 9;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label8.ForeColor = Color.Black;
            Control arg_1BAA_0 = this.Label8;
            location = new Point(36, 49);
            arg_1BAA_0.Location = location;
            this.Label8.Name = "Label8";
            Control arg_1BD1_0 = this.Label8;
            size = new Size(85, 16);
            arg_1BD1_0.Size = size;
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Cơ sở dữ liệu";
            this.cbbCodeTram.AutoCompleteCustomSource.AddRange(new string[]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7"
            });
            this.cbbCodeTram.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbbCodeTram.Enabled = false;
            this.cbbCodeTram.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.cbbCodeTram.ForeColor = Color.Black;
            this.cbbCodeTram.FormattingEnabled = true;
            this.cbbCodeTram.Items.AddRange(new object[]
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6"
            });
            Control arg_1D05_0 = this.cbbCodeTram;
            location = new Point(814, 74);
            arg_1D05_0.Location = location;
            this.cbbCodeTram.Name = "cbbCodeTram";
            Control arg_1D2F_0 = this.cbbCodeTram;
            size = new Size(166, 23);
            arg_1D2F_0.Size = size;
            this.cbbCodeTram.TabIndex = 43;
            this.Label13.AutoSize = true;
            this.Label13.Enabled = false;
            this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label13.ForeColor = Color.Black;
            Control arg_1D9F_0 = this.Label13;
            location = new Point(759, 100);
            arg_1D9F_0.Location = location;
            this.Label13.Name = "Label13";
            Control arg_1DC6_0 = this.Label13;
            size = new Size(97, 16);
            arg_1DC6_0.Size = size;
            this.Label13.TabIndex = 22;
            this.Label13.Text = "Mã trạm thu phí";
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.tbServerFolderPlateImage);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.tbPublicationName);
            this.GroupBox2.Controls.Add(this.tbServerFolderImage);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.tbServerSqlPassword);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.tbServerDatabaseName);
            this.GroupBox2.Controls.Add(this.Label20);
            this.GroupBox2.Controls.Add(this.tbServerSqlUser);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.tbServerName);
            this.GroupBox2.Controls.Add(this.Label22);
            this.GroupBox2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.GroupBox2.ForeColor = Color.FromArgb(0, 0, 192);
            Control arg_1F69_0 = this.GroupBox2;
            location = new Point(12, 212);
            arg_1F69_0.Location = location;
            this.GroupBox2.Name = "GroupBox2";
            Control arg_1F93_0 = this.GroupBox2;
            size = new Size(690, 126);
            arg_1F93_0.Size = size;
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Máy chủ";
            this.Label24.AutoSize = true;
            this.Label24.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label24.ForeColor = Color.Black;
            Control arg_2013_0 = this.Label24;
            location = new Point(331, 81);
            arg_2013_0.Location = location;
            this.Label24.Name = "Label24";
            Control arg_203D_0 = this.Label24;
            size = new Size(150, 16);
            arg_203D_0.Size = size;
            this.Label24.TabIndex = 31;
            this.Label24.Text = "Thư mục ảnh nhận dạng";
            this.tbServerFolderPlateImage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerFolderPlateImage.ForeColor = Color.Black;
            Control arg_20A5_0 = this.tbServerFolderPlateImage;
            location = new Point(493, 77);
            arg_20A5_0.Location = location;
            this.tbServerFolderPlateImage.Name = "tbServerFolderPlateImage";
            Control arg_20CF_0 = this.tbServerFolderPlateImage;
            size = new Size(166, 22);
            arg_20CF_0.Size = size;
            this.tbServerFolderPlateImage.TabIndex = 30;
            this.Label17.AutoSize = true;
            this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label17.ForeColor = Color.Black;
            Control arg_2130_0 = this.Label17;
            location = new Point(14, 99);
            arg_2130_0.Location = location;
            this.Label17.Name = "Label17";
            Control arg_2157_0 = this.Label17;
            size = new Size(101, 16);
            arg_2157_0.Size = size;
            this.Label17.TabIndex = 29;
            this.Label17.Text = "Thư mục ảnh xe";
            this.tbPublicationName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbPublicationName.ForeColor = Color.Black;
            Control arg_21BF_0 = this.tbPublicationName;
            location = new Point(130, 69);
            arg_21BF_0.Location = location;
            this.tbPublicationName.Name = "tbPublicationName";
            Control arg_21E9_0 = this.tbPublicationName;
            size = new Size(166, 22);
            arg_21E9_0.Size = size;
            this.tbPublicationName.TabIndex = 17;
            this.tbServerFolderImage.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerFolderImage.ForeColor = Color.Black;
            Control arg_2241_0 = this.tbServerFolderImage;
            location = new Point(130, 96);
            arg_2241_0.Location = location;
            this.tbServerFolderImage.Name = "tbServerFolderImage";
            Control arg_226B_0 = this.tbServerFolderImage;
            size = new Size(166, 22);
            arg_226B_0.Size = size;
            this.tbServerFolderImage.TabIndex = 28;
            this.Label18.AutoSize = true;
            this.Label18.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label18.ForeColor = Color.Black;
            Control arg_22CB_0 = this.Label18;
            location = new Point(-1, 72);
            arg_22CB_0.Location = location;
            this.Label18.Name = "Label18";
            Control arg_22F2_0 = this.Label18;
            size = new Size(116, 16);
            arg_22F2_0.Size = size;
            this.Label18.TabIndex = 16;
            this.Label18.Text = "Thông tin đồng bộ";
            this.tbServerSqlPassword.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerSqlPassword.ForeColor = Color.Black;
            Control arg_235A_0 = this.tbServerSqlPassword;
            location = new Point(493, 48);
            arg_235A_0.Location = location;
            this.tbServerSqlPassword.Name = "tbServerSqlPassword";
            Control arg_2384_0 = this.tbServerSqlPassword;
            size = new Size(166, 22);
            arg_2384_0.Size = size;
            this.tbServerSqlPassword.TabIndex = 15;
            this.tbServerSqlPassword.UseSystemPasswordChar = true;
            this.Label19.AutoSize = true;
            this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label19.ForeColor = Color.Black;
            Control arg_23F4_0 = this.Label19;
            location = new Point(382, 21);
            arg_23F4_0.Location = location;
            this.Label19.Name = "Label19";
            Control arg_241B_0 = this.Label19;
            size = new Size(99, 16);
            arg_241B_0.Size = size;
            this.Label19.TabIndex = 14;
            this.Label19.Text = "Tên đăng nhập";
            this.tbServerDatabaseName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerDatabaseName.ForeColor = Color.Black;
            Control arg_2483_0 = this.tbServerDatabaseName;
            location = new Point(130, 42);
            arg_2483_0.Location = location;
            this.tbServerDatabaseName.Name = "tbServerDatabaseName";
            Control arg_24AD_0 = this.tbServerDatabaseName;
            size = new Size(166, 22);
            arg_24AD_0.Size = size;
            this.tbServerDatabaseName.TabIndex = 13;
            this.Label20.AutoSize = true;
            this.Label20.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label20.ForeColor = Color.Black;
            Control arg_250E_0 = this.Label20;
            location = new Point(30, 18);
            arg_250E_0.Location = location;
            this.Label20.Name = "Label20";
            Control arg_2535_0 = this.Label20;
            size = new Size(85, 16);
            arg_2535_0.Size = size;
            this.Label20.TabIndex = 12;
            this.Label20.Text = "Tên máy chủ";
            this.tbServerSqlUser.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerSqlUser.ForeColor = Color.Black;
            Control arg_259D_0 = this.tbServerSqlUser;
            location = new Point(493, 19);
            arg_259D_0.Location = location;
            this.tbServerSqlUser.Name = "tbServerSqlUser";
            Control arg_25C7_0 = this.tbServerSqlUser;
            size = new Size(166, 22);
            arg_25C7_0.Size = size;
            this.tbServerSqlUser.TabIndex = 11;
            this.Label21.AutoSize = true;
            this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label21.ForeColor = Color.Black;
            Control arg_262B_0 = this.Label21;
            location = new Point(419, 51);
            arg_262B_0.Location = location;
            this.Label21.Name = "Label21";
            Control arg_2652_0 = this.Label21;
            size = new Size(62, 16);
            arg_2652_0.Size = size;
            this.Label21.TabIndex = 10;
            this.Label21.Text = "Mật khẩu";
            this.tbServerName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbServerName.ForeColor = Color.Black;
            Control arg_26BA_0 = this.tbServerName;
            location = new Point(130, 15);
            arg_26BA_0.Location = location;
            this.tbServerName.Name = "tbServerName";
            Control arg_26E4_0 = this.tbServerName;
            size = new Size(166, 22);
            arg_26E4_0.Size = size;
            this.tbServerName.TabIndex = 9;
            this.Label22.AutoSize = true;
            this.Label22.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label22.ForeColor = Color.Black;
            Control arg_2745_0 = this.Label22;
            location = new Point(30, 45);
            arg_2745_0.Location = location;
            this.Label22.Name = "Label22";
            Control arg_276C_0 = this.Label22;
            size = new Size(85, 16);
            arg_276C_0.Size = size;
            this.Label22.TabIndex = 8;
            this.Label22.Text = "Cơ sở dữ liệu";
            this.GroupBox3.Controls.Add(this.cb15);
            this.GroupBox3.Controls.Add(this.cb14);
            this.GroupBox3.Controls.Add(this.cb13);
            this.GroupBox3.Controls.Add(this.cb12);
            this.GroupBox3.Controls.Add(this.cb11);
            this.GroupBox3.Controls.Add(this.cb10);
            this.GroupBox3.Controls.Add(this.cb9);
            this.GroupBox3.Controls.Add(this.cb8);
            this.GroupBox3.Controls.Add(this.cb7);
            this.GroupBox3.Controls.Add(this.cb6);
            this.GroupBox3.Controls.Add(this.cb5);
            this.GroupBox3.Controls.Add(this.cb4);
            this.GroupBox3.Controls.Add(this.cb3);
            this.GroupBox3.Controls.Add(this.cb2);
            this.GroupBox3.Controls.Add(this.cb1);
            this.GroupBox3.Controls.Add(this.cb0);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.cbTinhNangThoai);
            this.GroupBox3.Controls.Add(this.tbPortRecognize);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.tbPortSub);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.tbPortMain);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.tbComputerRecognize);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.tbComputerWatch);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.GroupBox3.ForeColor = Color.FromArgb(0, 0, 192);
            Control arg_2A42_0 = this.GroupBox3;
            location = new Point(12, 341);
            arg_2A42_0.Location = location;
            this.GroupBox3.Name = "GroupBox3";
            Control arg_2A6F_0 = this.GroupBox3;
            size = new Size(690, 163);
            arg_2A6F_0.Size = size;
            this.GroupBox3.TabIndex = 18;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Thông tin kết nối";
            this.cb15.AutoSize = true;
            this.cb15.ForeColor = Color.Black;
            Control arg_2AD1_0 = this.cb15;
            location = new Point(550, 135);
            arg_2AD1_0.Location = location;
            this.cb15.Name = "cb15";
            Control arg_2AF8_0 = this.cb15;
            size = new Size(43, 22);
            arg_2AF8_0.Size = size;
            this.cb15.TabIndex = 59;
            this.cb15.Text = "15";
            this.cb15.UseVisualStyleBackColor = true;
            this.cb14.AutoSize = true;
            this.cb14.ForeColor = Color.Black;
            Control arg_2B5A_0 = this.cb14;
            location = new Point(490, 135);
            arg_2B5A_0.Location = location;
            this.cb14.Name = "cb14";
            Control arg_2B81_0 = this.cb14;
            size = new Size(43, 22);
            arg_2B81_0.Size = size;
            this.cb14.TabIndex = 58;
            this.cb14.Text = "14";
            this.cb14.UseVisualStyleBackColor = true;
            this.cb13.AutoSize = true;
            this.cb13.ForeColor = Color.Black;
            Control arg_2BE3_0 = this.cb13;
            location = new Point(430, 135);
            arg_2BE3_0.Location = location;
            this.cb13.Name = "cb13";
            Control arg_2C0A_0 = this.cb13;
            size = new Size(43, 22);
            arg_2C0A_0.Size = size;
            this.cb13.TabIndex = 57;
            this.cb13.Text = "13";
            this.cb13.UseVisualStyleBackColor = true;
            this.cb12.AutoSize = true;
            this.cb12.ForeColor = Color.Black;
            Control arg_2C6C_0 = this.cb12;
            location = new Point(370, 135);
            arg_2C6C_0.Location = location;
            this.cb12.Name = "cb12";
            Control arg_2C93_0 = this.cb12;
            size = new Size(43, 22);
            arg_2C93_0.Size = size;
            this.cb12.TabIndex = 56;
            this.cb12.Text = "12";
            this.cb12.UseVisualStyleBackColor = true;
            this.cb11.AutoSize = true;
            this.cb11.ForeColor = Color.Black;
            Control arg_2CF5_0 = this.cb11;
            location = new Point(310, 135);
            arg_2CF5_0.Location = location;
            this.cb11.Name = "cb11";
            Control arg_2D1C_0 = this.cb11;
            size = new Size(43, 22);
            arg_2D1C_0.Size = size;
            this.cb11.TabIndex = 55;
            this.cb11.Text = "11";
            this.cb11.UseVisualStyleBackColor = true;
            this.cb10.AutoSize = true;
            this.cb10.ForeColor = Color.Black;
            Control arg_2D7E_0 = this.cb10;
            location = new Point(250, 135);
            arg_2D7E_0.Location = location;
            this.cb10.Name = "cb10";
            Control arg_2DA5_0 = this.cb10;
            size = new Size(43, 22);
            arg_2DA5_0.Size = size;
            this.cb10.TabIndex = 54;
            this.cb10.Text = "10";
            this.cb10.UseVisualStyleBackColor = true;
            this.cb9.AutoSize = true;
            this.cb9.ForeColor = Color.Black;
            Control arg_2E07_0 = this.cb9;
            location = new Point(190, 135);
            arg_2E07_0.Location = location;
            this.cb9.Name = "cb9";
            Control arg_2E2E_0 = this.cb9;
            size = new Size(35, 22);
            arg_2E2E_0.Size = size;
            this.cb9.TabIndex = 53;
            this.cb9.Text = "9";
            this.cb9.UseVisualStyleBackColor = true;
            this.cb8.AutoSize = true;
            this.cb8.ForeColor = Color.Black;
            Control arg_2E90_0 = this.cb8;
            location = new Point(130, 135);
            arg_2E90_0.Location = location;
            this.cb8.Name = "cb8";
            Control arg_2EB7_0 = this.cb8;
            size = new Size(35, 22);
            arg_2EB7_0.Size = size;
            this.cb8.TabIndex = 52;
            this.cb8.Text = "8";
            this.cb8.UseVisualStyleBackColor = true;
            this.cb7.AutoSize = true;
            this.cb7.ForeColor = Color.Black;
            Control arg_2F16_0 = this.cb7;
            location = new Point(550, 108);
            arg_2F16_0.Location = location;
            this.cb7.Name = "cb7";
            Control arg_2F3D_0 = this.cb7;
            size = new Size(35, 22);
            arg_2F3D_0.Size = size;
            this.cb7.TabIndex = 51;
            this.cb7.Text = "7";
            this.cb7.UseVisualStyleBackColor = true;
            this.cb6.AutoSize = true;
            this.cb6.ForeColor = Color.Black;
            Control arg_2F9C_0 = this.cb6;
            location = new Point(490, 108);
            arg_2F9C_0.Location = location;
            this.cb6.Name = "cb6";
            Control arg_2FC3_0 = this.cb6;
            size = new Size(35, 22);
            arg_2FC3_0.Size = size;
            this.cb6.TabIndex = 50;
            this.cb6.Text = "6";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb5.AutoSize = true;
            this.cb5.ForeColor = Color.Black;
            Control arg_3022_0 = this.cb5;
            location = new Point(430, 108);
            arg_3022_0.Location = location;
            this.cb5.Name = "cb5";
            Control arg_3049_0 = this.cb5;
            size = new Size(35, 22);
            arg_3049_0.Size = size;
            this.cb5.TabIndex = 49;
            this.cb5.Text = "5";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb4.AutoSize = true;
            this.cb4.ForeColor = Color.Black;
            Control arg_30A8_0 = this.cb4;
            location = new Point(370, 108);
            arg_30A8_0.Location = location;
            this.cb4.Name = "cb4";
            Control arg_30CF_0 = this.cb4;
            size = new Size(35, 22);
            arg_30CF_0.Size = size;
            this.cb4.TabIndex = 48;
            this.cb4.Text = "4";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb3.AutoSize = true;
            this.cb3.ForeColor = Color.Black;
            Control arg_312E_0 = this.cb3;
            location = new Point(310, 108);
            arg_312E_0.Location = location;
            this.cb3.Name = "cb3";
            Control arg_3155_0 = this.cb3;
            size = new Size(35, 22);
            arg_3155_0.Size = size;
            this.cb3.TabIndex = 47;
            this.cb3.Text = "3";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb2.AutoSize = true;
            this.cb2.ForeColor = Color.Black;
            Control arg_31B4_0 = this.cb2;
            location = new Point(250, 108);
            arg_31B4_0.Location = location;
            this.cb2.Name = "cb2";
            Control arg_31DB_0 = this.cb2;
            size = new Size(35, 22);
            arg_31DB_0.Size = size;
            this.cb2.TabIndex = 46;
            this.cb2.Text = "2";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb1.AutoSize = true;
            this.cb1.ForeColor = Color.Black;
            Control arg_323A_0 = this.cb1;
            location = new Point(190, 108);
            arg_323A_0.Location = location;
            this.cb1.Name = "cb1";
            Control arg_3261_0 = this.cb1;
            size = new Size(35, 22);
            arg_3261_0.Size = size;
            this.cb1.TabIndex = 45;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb0.AutoSize = true;
            this.cb0.ForeColor = Color.Black;
            Control arg_32C0_0 = this.cb0;
            location = new Point(130, 108);
            arg_32C0_0.Location = location;
            this.cb0.Name = "cb0";
            Control arg_32E7_0 = this.cb0;
            size = new Size(35, 22);
            arg_32E7_0.Size = size;
            this.cb0.TabIndex = 44;
            this.cb0.Text = "0";
            this.cb0.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label1.ForeColor = Color.Black;
            Control arg_3364_0 = this.Label1;
            location = new Point(37, 111);
            arg_3364_0.Location = location;
            this.Label1.Name = "Label1";
            Control arg_338B_0 = this.Label1;
            size = new Size(75, 16);
            arg_338B_0.Size = size;
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Kênh video";
            this.cbTinhNangThoai.AutoSize = true;
            this.cbTinhNangThoai.ForeColor = Color.Black;
            Control arg_33DE_0 = this.cbTinhNangThoai;
            location = new Point(493, 78);
            arg_33DE_0.Location = location;
            this.cbTinhNangThoai.Name = "cbTinhNangThoai";
            Control arg_3405_0 = this.cbTinhNangThoai;
            size = new Size(127, 22);
            arg_3405_0.Size = size;
            this.cbTinhNangThoai.TabIndex = 42;
            this.cbTinhNangThoai.Text = "Tính năng thoại";
            this.cbTinhNangThoai.UseVisualStyleBackColor = true;
            this.tbPortRecognize.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbPortRecognize.ForeColor = Color.Black;
            Control arg_3479_0 = this.tbPortRecognize;
            location = new Point(133, 77);
            arg_3479_0.Location = location;
            this.tbPortRecognize.Name = "tbPortRecognize";
            Control arg_34A3_0 = this.tbPortRecognize;
            size = new Size(166, 22);
            arg_34A3_0.Size = size;
            this.tbPortRecognize.TabIndex = 17;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label4.ForeColor = Color.Black;
            Control arg_3504_0 = this.Label4;
            location = new Point(11, 78);
            arg_3504_0.Location = location;
            this.Label4.Name = "Label4";
            Control arg_352B_0 = this.Label4;
            size = new Size(109, 16);
            arg_352B_0.Size = size;
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Cổng nhận dạng ";
            this.tbPortSub.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbPortSub.ForeColor = Color.Black;
            Control arg_3593_0 = this.tbPortSub;
            location = new Point(493, 48);
            arg_3593_0.Location = location;
            this.tbPortSub.Name = "tbPortSub";
            Control arg_35BD_0 = this.tbPortSub;
            size = new Size(166, 22);
            arg_35BD_0.Size = size;
            this.tbPortSub.TabIndex = 15;
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label5.ForeColor = Color.Black;
            Control arg_3621_0 = this.Label5;
            location = new Point(380, 22);
            arg_3621_0.Location = location;
            this.Label5.Name = "Label5";
            Control arg_3648_0 = this.Label5;
            size = new Size(100, 16);
            arg_3648_0.Size = size;
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Máy nhận dạng";
            this.tbPortMain.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbPortMain.ForeColor = Color.Black;
            Control arg_36B0_0 = this.tbPortMain;
            location = new Point(133, 48);
            arg_36B0_0.Location = location;
            this.tbPortMain.Name = "tbPortMain";
            Control arg_36DA_0 = this.tbPortMain;
            size = new Size(166, 22);
            arg_36DA_0.Size = size;
            this.tbPortMain.TabIndex = 13;
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label6.ForeColor = Color.Black;
            Control arg_373B_0 = this.Label6;
            location = new Point(32, 26);
            arg_373B_0.Location = location;
            this.Label6.Name = "Label6";
            Control arg_3762_0 = this.Label6;
            size = new Size(88, 16);
            arg_3762_0.Size = size;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Máy giám sát";
            this.tbComputerRecognize.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbComputerRecognize.ForeColor = Color.Black;
            Control arg_37CA_0 = this.tbComputerRecognize;
            location = new Point(493, 19);
            arg_37CA_0.Location = location;
            this.tbComputerRecognize.Name = "tbComputerRecognize";
            Control arg_37F4_0 = this.tbComputerRecognize;
            size = new Size(166, 22);
            arg_37F4_0.Size = size;
            this.tbComputerRecognize.TabIndex = 11;
            this.Label15.AutoSize = true;
            this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label15.ForeColor = Color.Black;
            Control arg_3858_0 = this.Label15;
            location = new Point(373, 49);
            arg_3858_0.Location = location;
            this.Label15.Name = "Label15";
            Control arg_387F_0 = this.Label15;
            size = new Size(107, 16);
            arg_387F_0.Size = size;
            this.Label15.TabIndex = 10;
            this.Label15.Text = "Cổng dữ liệu phụ";
            this.tbComputerWatch.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.tbComputerWatch.ForeColor = Color.Black;
            Control arg_38E7_0 = this.tbComputerWatch;
            location = new Point(133, 19);
            arg_38E7_0.Location = location;
            this.tbComputerWatch.Name = "tbComputerWatch";
            Control arg_3911_0 = this.tbComputerWatch;
            size = new Size(166, 22);
            arg_3911_0.Size = size;
            this.tbComputerWatch.TabIndex = 9;
            this.Label16.AutoSize = true;
            this.Label16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.Label16.ForeColor = Color.Black;
            Control arg_3971_0 = this.Label16;
            location = new Point(4, 52);
            arg_3971_0.Location = location;
            this.Label16.Name = "Label16";
            Control arg_3998_0 = this.Label16;
            size = new Size(116, 16);
            arg_3998_0.Size = size;
            this.Label16.TabIndex = 8;
            this.Label16.Text = "Cổng dữ liệu chính";
            this.btLuu.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.btLuu.ForeColor = Color.Blue;
            Control arg_3A02_0 = this.btLuu;
            location = new Point(449, 510);
            arg_3A02_0.Location = location;
            this.btLuu.Name = "btLuu";
            Control arg_3A29_0 = this.btLuu;
            size = new Size(99, 32);
            arg_3A29_0.Size = size;
            this.btLuu.TabIndex = 25;
            this.btLuu.Text = "Lưu ";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btThoat.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 163);
            this.btThoat.ForeColor = Color.Blue;
            Control arg_3AA0_0 = this.btThoat;
            location = new Point(584, 513);
            arg_3AA0_0.Location = location;
            this.btThoat.Name = "btThoat";
            Control arg_3AC7_0 = this.btThoat;
            size = new Size(99, 32);
            arg_3AC7_0.Size = size;
            this.btThoat.TabIndex = 26;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.Cap.BackColor = SystemColors.ButtonShadow;
            Control arg_3B1D_0 = this.Cap;
            location = new Point(736, 333);
            arg_3B1D_0.Location = location;
            this.Cap.Name = "Cap";
            Control arg_3B4A_0 = this.Cap;
            size = new Size(203, 207);
            arg_3B4A_0.Size = size;
            this.Cap.TabIndex = 145;
            Control arg_3B77_0 = this.Button1;
            location = new Point(257, 516);
            arg_3B77_0.Location = location;
            this.Button1.Name = "Button1";
            Control arg_3B9E_0 = this.Button1;
            size = new Size(75, 23);
            arg_3B9E_0.Size = size;
            this.Button1.TabIndex = 146;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Visible = false;
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(708, 549);
            this.ClientSize = size;
            this.Controls.Add(this.cbbCodeTram);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Cap);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label13);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Cấu hình";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
