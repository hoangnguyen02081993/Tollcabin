using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Tollcabin
{
    [StandardModule]
    internal sealed class ModuleKhaiBaoConst
    {
        public enum ETinhTrangMuaVe
        {
            UuTien = 5
        }

        public enum EPhanLoaiXe
        {
            QuocLoLuot = 2
        }

        public enum EDauDocMaVach
        {
            ComThat,
            ComAo
        }

        public enum EnumTTXeQuaTram
        {
            XeHopLe,
            XeQuaLanDau,
            XeKhongBienSo,
            XeViPhamPhanLoaiTruoc,
            XeViPhamPhanLoaiSau,
            XeThangQuiKhongDungBS,
            XeVuotTram = 8,
            XeMoCuongBuc,
            VeThuHoi,
            VeThuHoiViPhamPLTruoc,
            XeUuTien
        }

        public enum TrangThaiDauVao
        {
            KhongTrangThai,
            DauVao,
            DauRa
        }

        public enum EnumPTTToan
        {
            VuotTram,
            VeLuot,
            VeThang,
            VeQui,
            VetruDan,
            ToanQuoc = 7,
            UuTienLuot = 6,
            QuocLoLuot = 5,
            UuTienDoan = 8,
            CuongBuc,
            UuTienKhach = 11,
            ToanQuocCongAn
        }

        public class MTTheCung
        {
            public static string NhanDangLai
            {
                get
                {
                    return "212239328001";
                }
            }

            public static string MoLan
            {
                get
                {
                    return "212239328002";
                }
            }

            public static string DongLan
            {
                get
                {
                    return "212239328003";
                }
            }

            public static string Reset
            {
                get
                {
                    return "212239328004";
                }
            }

            public static string KetNoiGiamSat
            {
                get
                {
                    return "212239328005";
                }
            }

            [DebuggerNonUserCode]
            public MTTheCung()
            {
            }
        }

        public class EStrPTTT
        {
            public static string TheNV
            {
                get
                {
                    return "T";
                }
            }

            public static string VeLuot
            {
                get
                {
                    return "A";
                }
            }

            public static string VeThang
            {
                get
                {
                    return "B";
                }
            }

            public static string VeQui
            {
                get
                {
                    return "C";
                }
            }

            public static string VeTruDan
            {
                get
                {
                    return "D";
                }
            }

            public static string QLLuot
            {
                get
                {
                    return "E";
                }
            }

            public static string UuTienLuot
            {
                get
                {
                    return "F";
                }
            }

            public static string ToanQuoc
            {
                get
                {
                    return "G";
                }
            }

            public static string UuTienDoan
            {
                get
                {
                    return "H";
                }
            }

            public static string CuongBuc
            {
                get
                {
                    return "I";
                }
            }

            public static string UuTienKhach
            {
                get
                {
                    return "U";
                }
            }

            public static string ToanQuocCongAn
            {
                get
                {
                    return "V";
                }
            }

            [DebuggerNonUserCode]
            public EStrPTTT()
            {
            }
        }

        public enum EnumNull
        {
            PhiNull,
            PLTruocNull = 0,
            PLSauNull = 0,
            PLVeNull = 0,
            CaTrucNull = 0,
            LanXeNull = 0
        }

        public class EnumVe
        {
            public static string VeNoiBo13Char
            {
                get
                {
                    return "U011010000000";
                }
            }

            public static string CuongBuc
            {
                get
                {
                    return "2282109030000000";
                }
            }

            public static string QuocLoLuot
            {
                get
                {
                    return "228209040000000";
                }
            }

            public static string ToanQuoc
            {
                get
                {
                    return "2282109050000000";
                }
            }

            public static string UuTien
            {
                get
                {
                    return "2282109010000000";
                }
            }

            public static string ToanQuocCongAn
            {
                get
                {
                    return "2282109080000000";
                }
            }

            public static string UuTienDoan
            {
                get
                {
                    return "2282109020000000";
                }
            }

            [DebuggerNonUserCode]
            public EnumVe()
            {
            }
        }

        public class EnumStrNull
        {
            public static string SoVeNull
            {
                get
                {
                    return "%%%%%%%%%%%%%";
                }
            }

            public static string BienSoNull
            {
                get
                {
                    return "%%%%%%";
                }
            }

            public static string NgayQuaTramNull
            {
                get
                {
                    return "";
                }
            }

            public static string GioQuaTramNull
            {
                get
                {
                    return "";
                }
            }

            public static string MSNVNull
            {
                get
                {
                    return "";
                }
            }

            public static string TenHinhXeNull
            {
                get
                {
                    return "";
                }
            }

            [DebuggerNonUserCode]
            public EnumStrNull()
            {
            }
        }

        public static string IPMayGiamSatMain;

        public static int PortMayGiamSatMain;

        public static int PortDuLieuChinhMain;

        public static int PortDuLieuCuMain;

        public static int PortGiupDoMain;

        public static string IPMayNhanDangMain;

        public static int PortMayNhanDangMain;

        public static string StrConnectMain;

        public static byte LanXeMain;

        public static string MaNhanVienMain = "";

        public static int CaTrucMain;

        public static string ServerImagesPathMain;

        public static string LocalImagesPathMain;

        public const string _VideoPathMain = "VIDEO";

        public static string ServerImagesPathBSMain = "";

        public static int TramIdMain = 1;

        public static int StatusMain = -1;

        public static readonly string IDMaTram = "2282";

        public static readonly string IDMaTram2 = "2282";

        public static bool StatusConnectGiamSatMain = false;

        public const int SOLANXEMAIN = 2;

        public static bool ConsoleMain = false;
    }
}
