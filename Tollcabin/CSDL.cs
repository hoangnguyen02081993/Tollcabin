using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tollcabin
{
    [StandardModule]
    internal sealed class CSDL
    {
        public enum EUuTienKhach
        {
            HopLe,
            HetHan,
            KhongHopLe,
            KhongDungBienSo
        }

        public static bool Ve_Test(string strCon, string Sove_)
        {
            string cmdText = " select *  from tbl_Ve_test  where Sove ='" + Sove_ + "'";
            SqlConnection sqlConnection = new SqlConnection(strCon);
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(cmdText, sqlConnection)
                {
                    CommandType = CommandType.Text
                });
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable.Rows.Count > 0;
            }
            catch (Exception expr_5E)
            {
                ProjectData.SetProjectError(expr_5E);
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool KiemTraVeLanCungChieu(string strCon, int LanXe, string SoVe)
        {
            string cmdText = "select MsVali,SoveBD,SoveKT from tbl_Vali_DataBackup where convert(int, substring(MsVali,9,2)) =  " + Conversions.ToString(LanXe);
            SqlConnection sqlConnection = new SqlConnection(strCon);
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(cmdText, sqlConnection)
                {
                    CommandType = CommandType.Text
                });
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        string maVali = Conversions.ToString(dataRow["MSVali"]);
                        string right = Conversions.ToString(dataRow["SoveBD"]);
                        string right2 = Conversions.ToString(dataRow["SoveKT"]);
                        if (Operators.CompareString(SoVe, right, false) >= 0 & Operators.CompareString(SoVe, right2, false) <= 0)
                        {
                            string text = "";
                            string text2 = "";
                            DateTime t = VeXe.NgayInMaVali(maVali);
                            if (CSDL.SelectThoiGianCatruc(ModuleKhaiBaoConst.StrConnectMain, Conversions.ToString(VeXe.CatrucInMaVali(maVali)), ref text, ref text2))
                            {
                                t = t.AddHours(Conversions.ToDouble(text2.Substring(0, 2))).AddMinutes(Conversions.ToDouble(text2.Substring(3, 2))).AddHours(24.0);
                                if (DateTime.Compare(DateAndTime.Now, t) <= 0)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_18A)
            {
                ProjectData.SetProjectError(expr_18A);
                Exception ex = expr_18A;
                ModuleKhac.SaveError(ex.Message, "KiemTraVeLanCungChieu");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        private static bool KiemTraVeThangQui(int LoaiVe, int Nam, int ThangQui, ref string NgayHetHanVe)
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dateTime2 = DateTime.MinValue;
            CSDL.TinhThoiHanVe(LoaiVe, ThangQui, Nam, ref dateTime, ref dateTime2);
            DateTime t = DateTime.Parse(Strings.Format(DateAndTime.Now, "MM/dd/yyyy"));
            dateTime = DateTime.Parse(Strings.Format(dateTime, "MM/dd/yyyy"));
            dateTime2 = DateTime.Parse(Strings.Format(dateTime2, "MM/dd/yyyy"));
            if (DateTime.Compare(t, dateTime) >= 0 & DateTime.Compare(t, dateTime2) <= 0)
            {
                NgayHetHanVe = Strings.Format(dateTime2, "dd/MM/yyyy");
                return true;
            }
            return false;
        }

        private static void TinhThoiHanVe(int LoaiVe, int ThangQui, int Nam, ref DateTime NgayApDung, ref DateTime NgayHetHan)
        {
            checked
            {
                if (LoaiVe == 2)
                {
                    string value = "01/01/" + Conversions.ToString(Nam);
                    DateTime dateTime = Conversions.ToDate(value);
                    dateTime = DateAndTime.DateAdd("m", (double)(ThangQui - 1), dateTime);
                    NgayApDung = dateTime;
                    dateTime = DateAndTime.DateAdd("m", 1.0, dateTime);
                    dateTime = DateAndTime.DateAdd("d", -1.0, dateTime);
                    NgayHetHan = dateTime;
                }
                else if (LoaiVe == 3)
                {
                    string value = "01/01/" + Conversions.ToString(Nam);
                    DateTime dateTime = Conversions.ToDate(value);
                    int num = (ThangQui - 1) * 3;
                    dateTime = DateAndTime.DateAdd("m", (double)num, dateTime);
                    NgayApDung = dateTime;
                    dateTime = DateAndTime.DateAdd("m", 3.0, dateTime);
                    dateTime = DateAndTime.DateAdd("d", -1.0, dateTime);
                    NgayHetHan = dateTime;
                }
            }
        }

        private static DataTable TruyXuatCSDLByProcedure(string strCon, string ProcedureName, string[] ParameterNames, string[] ParameterValues, int SoParameter)
        {
            SqlConnection sqlConnection = new SqlConnection(strCon);
            DataTable dataTable = new DataTable();
            checked
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(ProcedureName, sqlConnection);
                    int arg_23_0 = 0;
                    int num = SoParameter - 1;
                    for (int i = arg_23_0; i <= num; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(ParameterNames[i], ParameterValues[i]);
                    }
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                }
                catch (Exception expr_68)
                {
                    ProjectData.SetProjectError(expr_68);
                    Exception ex = expr_68;
                    ModuleKhac.SaveError(ex.Message, "TruyXuatCSDLByProcedure");
                    ProjectData.ClearProjectError();
                }
                return dataTable;
            }
        }

        private static void InCSDLByProcedure(string strCon, string ProcedureName, string[] ParameterNames, string[] ParameterValues, int SoParameter)
        {
            SqlConnection sqlConnection = new SqlConnection(strCon);
            checked
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(ProcedureName, sqlConnection);
                    int arg_1C_0 = 0;
                    int num = SoParameter - 1;
                    for (int i = arg_1C_0; i <= num; i++)
                    {
                        sqlCommand.Parameters.AddWithValue(ParameterNames[i], ParameterValues[i]);
                    }
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception expr_50)
                {
                    ProjectData.SetProjectError(expr_50);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static bool TimVeThangTuBienSo(string strCon, string BienSo, ref string SoVe, ref string NgayHetHan)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@BienSo"
            };
            string[] parameterValues = new string[]
            {
                BienSo
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeVeThangTuBienSo", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        byte loaiVe = Conversions.ToByte(dataRow["LoaiVe"]);
                        int thangQui = Conversions.ToInteger(dataRow["ThangQui"]);
                        int nam = Conversions.ToInteger(dataRow["Nam"]);
                        if (CSDL.KiemTraVeThangQui((int)loaiVe, nam, thangQui, ref NgayHetHan))
                        {
                            SoVe = Conversions.ToString(dataRow["SoVe"]);
                            return true;
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_D7)
            {
                ProjectData.SetProjectError(expr_D7);
                Exception ex = expr_D7;
                ModuleKhac.SaveError(ex.Message, "TimVeThangTuBienSo");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool TimBienSoTuVeThang(string strCon, string SoVe, ref string BienSo, ref string NgayHetHan)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@SoVe"
            };
            string[] parameterValues = new string[]
            {
                SoVe
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeVeBienSoTuSoVe", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        byte loaiVe = Conversions.ToByte(dataRow["LoaiVe"]);
                        int thangQui = Conversions.ToInteger(dataRow["ThangQui"]);
                        int nam = Conversions.ToInteger(dataRow["Nam"]);
                        if (CSDL.KiemTraVeThangQui((int)loaiVe, nam, thangQui, ref NgayHetHan))
                        {
                            BienSo = Conversions.ToString(dataRow["BienSo"]);
                            return true;
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_D7)
            {
                ProjectData.SetProjectError(expr_D7);
                Exception ex = expr_D7;
                ModuleKhac.SaveError(ex.Message, "TimBienSoTuVeThang");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool TimDLXeMauTuBienSo(string strCon, string BienSo, ref byte PLTruoc, ref bool XeUuTien)
        {
            DataTable dataTable = new DataTable();
            DateTime t = DateTime.Parse(Strings.Format(DateAndTime.Now, "MM/dd/yyyy"));
            string[] parameterNames = new string[]
            {
                "@BienSo"
            };
            string[] parameterValues = new string[]
            {
                BienSo
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeDLXeMau", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        PLTruoc = Conversions.ToByte(dataRow["PLXe"]);
                        XeUuTien = false;
                        try
                        {
                            int num = Conversions.ToInteger(dataRow["TinhTrangMuaVe"]);
                            if (num == 5)
                            {
                                DateTime t2 = DateTime.Parse(Conversions.ToString(dataRow["NgayApDung"]));
                                DateTime t3 = DateTime.Parse(Conversions.ToString(dataRow["NgayHetHan"]));
                                if (DateTime.Compare(t, t2) >= 0 & DateTime.Compare(t, t3) <= 0)
                                {
                                    XeUuTien = true;
                                }
                            }
                        }
                        catch (Exception expr_FA)
                        {
                            ProjectData.SetProjectError(expr_FA);
                            XeUuTien = false;
                            ProjectData.ClearProjectError();
                        }
                        return true;
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_137)
            {
                ProjectData.SetProjectError(expr_137);
                Exception ex = expr_137;
                ModuleKhac.SaveError(ex.Message, "TimDLXeMauTuBienSo");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool ThongTinDangKiem(string strCon, string BienSo, ref string PhuongTien, ref string SoNguoi, ref string TaiTrongHangHoa)
        {
            string cmdText = string.Concat(new string[]
            {
                "SELECT * FROM tblDangkiem where bienso = '",
                BienSo,
                "t' or bienso = '",
                BienSo,
                "x' or bienso = '",
                BienSo,
                "'"
            });
            SqlConnection sqlConnection = new SqlConnection(strCon);
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(cmdText, sqlConnection)
                {
                    CommandType = CommandType.Text
                });
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    PhuongTien = Conversions.ToString(dataTable.Rows[0]["LoaiPT_String"]);
                    SoNguoi = Conversions.ToString(dataTable.Rows[0]["SoCho"]);
                    TaiTrongHangHoa = Conversions.ToString(dataTable.Rows[0]["TaiTrongGT"]);
                    return true;
                }
            }
            catch (Exception expr_EB)
            {
                ProjectData.SetProjectError(expr_EB);
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static void InsertNhanVienDangTruc(string strCon, string MSNV, byte Catruc, string ThoiGianLuu)
        {
            string[] parameterNames = new string[]
            {
                "@MSNV",
                "@CaTruc",
                "@ThoiGianLuu"
            };
            string[] parameterValues = new string[]
            {
                MSNV,
                Catruc.ToString(),
                ThoiGianLuu
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "InNhanVienDangTruc", parameterNames, parameterValues, 3);
            }
            catch (Exception expr_4C)
            {
                ProjectData.SetProjectError(expr_4C);
                Exception ex = expr_4C;
                ModuleKhac.SaveError(ex.Message, "InNhanVienDangTruc");
                ProjectData.ClearProjectError();
            }
        }

        public static bool SelectNhanVienDangTruc(string strCon, ref string MSNV, ref byte Catruc, ref string ThoiGianLuu)
        {
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            DataTable dataTable = new DataTable();
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeNhanVienDangTruc", parameterNames, parameterValues, 0);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        MSNV = Conversions.ToString(dataRow["MSNV"]);
                        Catruc = Conversions.ToByte(dataRow["CaTruc"]);
                        ThoiGianLuu = Conversions.ToString(dataRow["ThoiGianLuu"]);
                        return true;
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_BA)
            {
                ProjectData.SetProjectError(expr_BA);
                Exception ex = expr_BA;
                ModuleKhac.SaveError(ex.Message, "SelectNhanVienDangTruc");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static void DeleteNhanVienDangTruc(string strCon)
        {
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "DeNhanVienDangTruc", parameterNames, parameterValues, 0);
            }
            catch (Exception expr_32)
            {
                ProjectData.SetProjectError(expr_32);
                Exception ex = expr_32;
                ModuleKhac.SaveError(ex.Message, "DeleteNhanVienDangTruc");
                ProjectData.ClearProjectError();
            }
        }

        public static void InsertVeSuDung(string strCon, string SoVe)
        {
            string[] parameterNames = new string[]
            {
                "@SoVe"
            };
            string[] parameterValues = new string[]
            {
                SoVe
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "InVeSuDung", parameterNames, parameterValues, 1);
            }
            catch (Exception expr_2E)
            {
                ProjectData.SetProjectError(expr_2E);
                Exception ex = expr_2E;
                ModuleKhac.SaveError(ex.Message, "InsertVeSuDung");
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteVeSuDung(string strCon)
        {
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "DeVeSuDung", parameterNames, parameterValues, 0);
            }
            catch (Exception expr_32)
            {
                ProjectData.SetProjectError(expr_32);
                Exception ex = expr_32;
                ModuleKhac.SaveError(ex.Message, "DeleteVeSuDung");
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteValiDataBackup(string strCon)
        {
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            CSDL.InCSDLByProcedure(strCon, "DeValiBackup", parameterNames, parameterValues, 0);
        }

        public static void InsertValiDataBackup(string strCon)
        {
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            CSDL.InCSDLByProcedure(strCon, "InValiBackup", parameterNames, parameterValues, 0);
        }

        public static bool SelectVali(string strCon, string MSNV, string SoVe, int LanXe, int TramId)
        {
            if (CSDL.Ve_Test(strCon, SoVe))
            {
                return true;
            }
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@MSNV"
            };
            string[] parameterValues = new string[]
            {
                MSNV
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeValiData", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        string maVali = Conversions.ToString(dataRow["MSVali"]);
                        string right = Conversions.ToString(dataRow["SoVeBD"]);
                        string right2 = Conversions.ToString(dataRow["SoVeKT"]);
                        if (Operators.CompareString(SoVe, right, false) >= 0 & Operators.CompareString(SoVe, right2, false) <= 0 & (int)VeXe.CabinInMaVali(maVali) == LanXe)
                        {
                            string left = Strings.Format(DateAndTime.Now, "yyMMdd");
                            string left2 = Strings.Format(DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.Now), "yyMMdd");
                            string left3 = Strings.Format(DateAndTime.Now, "HH");
                            string right3 = "12";
                            switch (ModuleKhaiBaoConst.CaTrucMain)
                            {
                                case 1:
                                case 2:
                                    if ((int)VeXe.CatrucInMaVali(maVali) == ModuleKhaiBaoConst.CaTrucMain & Operators.CompareString(left, VeXe.NgayInMaValiString(maVali), false) == 0)
                                    {
                                        bool result = true;
                                        return result;
                                    }
                                    break;
                                case 3:
                                    if ((int)VeXe.CatrucInMaVali(maVali) == ModuleKhaiBaoConst.CaTrucMain & ((Operators.CompareString(left, VeXe.NgayInMaValiString(maVali), false) == 0 & Operators.CompareString(left3, right3, false) > 0) | (Operators.CompareString(left2, VeXe.NgayInMaValiString(maVali), false) == 0 & Operators.CompareString(left3, right3, false) < 0)))
                                    {
                                        bool result = true;
                                        return result;
                                    }
                                    break;
                            }
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_1F4)
            {
                ProjectData.SetProjectError(expr_1F4);
                Exception ex = expr_1F4;
                ModuleKhac.SaveError(ex.Message, "SelectVali");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool SelectVeInVeSuDung(string strCon, string SoVe)
        {
            string cmdText = "SELECT *  from tbl_VeSuDung where sove = '" + SoVe + "'";
            SqlConnection sqlConnection = new SqlConnection(strCon);
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand(cmdText, sqlConnection)
                {
                    CommandType = CommandType.Text
                });
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable.Rows.Count > 0;
            }
            catch (Exception expr_5E)
            {
                ProjectData.SetProjectError(expr_5E);
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool SelectNhanVien(string strCon, string MSNV, ref string HoTen)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@MSNV"
            };
            string[] parameterValues = new string[]
            {
                MSNV
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeNhanVien", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        HoTen = Conversions.ToString(dataRow["HoTen"]);
                        return true;
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_90)
            {
                ProjectData.SetProjectError(expr_90);
                Exception ex = expr_90;
                ModuleKhac.SaveError(ex.Message, "SelectNhanVien");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static void InsertXeQuaTram(string strCon, XeQuaTram Xe)
        {
            string[] parameterNames = new string[]
            {
                "@BienSo",
                "@TTXeQua",
                "@SoVe",
                "@PLXeTruoc",
                "@PLVe",
                "@PLXeSau",
                "@PTTT",
                "@Phi",
                "@LanXe",
                "@NgayQuaTram",
                "@GioQuaTram",
                "@CaTruc",
                "@MSNV",
                "@TenHinhXe",
                "@BSXeThangQui"
            };
            string[] parameterValues = new string[]
            {
                Xe.BienSo,
                Conversions.ToString(Xe.TTXeQua),
                Xe.SoVe,
                Conversions.ToString(Xe.PLXeTruoc),
                Conversions.ToString(Xe.PLVe),
                Conversions.ToString(Xe.PLXeSau),
                Conversions.ToString(Xe.PTTT),
                Conversions.ToString(Xe.Phi),
                Conversions.ToString(Xe.LanXe),
                Xe.NgayQuaTram,
                Xe.GioQuaTram,
                Conversions.ToString(Xe.CaTruc),
                Xe.MSNV,
                Xe.TenHinhXe,
                Xe.BSXeThangQui
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "InXeQuaTram", parameterNames, parameterValues, 15);
            }
            catch (Exception expr_158)
            {
                ProjectData.SetProjectError(expr_158);
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteXeQuaTram(string strCon, string TenHinhXe)
        {
            string[] parameterNames = new string[]
            {
                "@TenHinhXe"
            };
            string[] parameterValues = new string[]
            {
                TenHinhXe
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "DeXeQuaTram", parameterNames, parameterValues, 1);
            }
            catch (Exception expr_2E)
            {
                ProjectData.SetProjectError(expr_2E);
                Exception ex = expr_2E;
                ModuleKhac.SaveError(ex.Message, "DeleteXeQuaTram");
                ProjectData.ClearProjectError();
            }
        }

        public static void DeleteXeQuaTram_TienPhong(string strCon, string TenHinhXe)
        {
            string[] parameterNames = new string[]
            {
                "@TenHinhXe"
            };
            string[] parameterValues = new string[]
            {
                TenHinhXe
            };
            try
            {
                CSDL.InCSDLByProcedure(strCon, "DeXeQuaTramTienPhong", parameterNames, parameterValues, 1);
            }
            catch (Exception expr_2E)
            {
                ProjectData.SetProjectError(expr_2E);
                Exception ex = expr_2E;
                ModuleKhac.SaveError(ex.Message, "DeleteXeQuaTramTienPhong");
                ProjectData.ClearProjectError();
            }
        }

        public static bool SelectThoiGianCatruc(string strCon, string CaTruc, ref string GioBD, ref string GioKT)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@CaTruc"
            };
            string[] parameterValues = new string[]
            {
                CaTruc
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SeCaTruc", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        GioBD = Conversions.ToString(dataRow["GioBD"]);
                        GioKT = Conversions.ToString(dataRow["GioKT"]);
                        return true;
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_A3)
            {
                ProjectData.SetProjectError(expr_A3);
                Exception ex = expr_A3;
                ModuleKhac.SaveError(ex.Message, "SelectThoiGianCaTRuc");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static bool SelectMenhGiaVe(string strCon, string LoaiXe, ref long Phi, ref long PhiThang, ref long PhiQui)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                "@LoaiXe"
            };
            string[] parameterValues = new string[]
            {
                LoaiXe
            };
            dataTable = CSDL.TruyXuatCSDLByProcedure(strCon, "SePhi", parameterNames, parameterValues, 1);
            try
            {
                IEnumerator enumerator = null;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        Phi = Conversions.ToLong(dataRow["Phi"]);
                        PhiThang = Conversions.ToLong(dataRow["PhiThang"]);
                        PhiQui = Conversions.ToLong(dataRow["PhiQui"]);
                        return true;
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
            }
            catch (Exception expr_B7)
            {
                ProjectData.SetProjectError(expr_B7);
                Exception ex = expr_B7;
                ModuleKhac.SaveError(ex.Message, "SelectMenhGiaVe");
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static DataTable SelectXeQuaTram(string strCon)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            return CSDL.TruyXuatCSDLByProcedure(strCon, "SeXeQuaTram", parameterNames, parameterValues, 0);
        }

        public static DataTable SelectXeQuaTram_TienPhong(string strCon)
        {
            DataTable dataTable = new DataTable();
            string[] parameterNames = new string[]
            {
                ""
            };
            string[] parameterValues = new string[]
            {
                ""
            };
            return CSDL.TruyXuatCSDLByProcedure(strCon, "SeXeQuaTramTienPhong", parameterNames, parameterValues, 0);
        }

        public static void UpXeQuaTram(string strCon, string TenHinhXe, byte PLXeSau)
        {
            string[] parameterNames = new string[]
            {
                "@TenHinhXe",
                "@PLXeSau"
            };
            string[] parameterValues = new string[]
            {
                TenHinhXe,
                Conversions.ToString(PLXeSau)
            };
            CSDL.InCSDLByProcedure(strCon, "UpxeQuaTram", parameterNames, parameterValues, 2);
        }

        public static CSDL.EUuTienKhach UuTienKhach(string ConnString, string BienSo, ref string NgayHetHan)
        {
            string text = " select bienso,convert(varchar(8),ngayapdung,112) as  'ngayapdung',convert(varchar(8),ngayhethan,112) as  'ngayhethan', convert(varchar(10),ngayhethan,103) as 'ngay'   from tbl_xeuutien ";
            text = text + " where BienSo = '" + BienSo + "' ";
            DataTable dataTable = new DataTable("Result");
            string left = Strings.Format(DateAndTime.Now, "yyyyMMdd");
            SqlConnection sqlConnection = new SqlConnection(ConnString);
            try
            {
                sqlConnection.Open();
                SqlCommand selectCommand = new SqlCommand(text, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    string right = Conversions.ToString(dataTable.Rows[0]["ngayapdung"]);
                    string right2 = Conversions.ToString(dataTable.Rows[0]["ngayhethan"]);
                    CSDL.EUuTienKhach result;
                    if (Operators.CompareString(left, right, false) >= 0 & Operators.CompareString(left, right2, false) <= 0)
                    {
                        NgayHetHan = Conversions.ToString(dataTable.Rows[0]["ngay"]);
                        result = CSDL.EUuTienKhach.HopLe;
                        return result;
                    }
                    NgayHetHan = Conversions.ToString(dataTable.Rows[0]["ngay"]);
                    result = CSDL.EUuTienKhach.HetHan;
                    return result;
                }
                else
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception arg_127_0)
            {
                ProjectData.SetProjectError(arg_127_0);
                ProjectData.ClearProjectError();
            }
            return CSDL.EUuTienKhach.KhongHopLe;
        }

        public static bool DanhSachDen(string ConnString, string BienSo, ref string GhiChu)
        {
            string text = " select * from tbl_XeCanhBao ";
            text = text + " where BienSo = '" + BienSo + "' ";
            DataTable dataTable = new DataTable("Result");
            SqlConnection sqlConnection = new SqlConnection(ConnString);
            try
            {
                sqlConnection.Open();
                SqlCommand selectCommand = new SqlCommand(text, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    GhiChu = Conversions.ToString(dataTable.Rows[0]["GhiChu"]);
                    return true;
                }
            }
            catch (Exception arg_82_0)
            {
                ProjectData.SetProjectError(arg_82_0);
                ProjectData.ClearProjectError();
            }
            return false;
        }
    }
}
