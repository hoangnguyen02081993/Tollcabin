using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Tollcabin
{
    public class VeXe
    {
        public VeXe()
        {
        }

        public static byte LoaiVe(string SoVe13Char)
        {
            try
            {
                string text = SoVe13Char.Substring(0, 1);
                string left = text;
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.CuongBuc, false) == 0)
                {
                    return 9;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.QLLuot, false) == 0)
                {
                    return 5;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.ToanQuoc, false) == 0)
                {
                    return 7;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienDoan, false) == 0)
                {
                    return 8;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienLuot, false) == 0)
                {
                    return 6;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeLuot, false) == 0)
                {
                    return 1;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeQui, false) == 0)
                {
                    return 3;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeThang, false) == 0)
                {
                    return 2;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeTruDan, false) == 0)
                {
                    return 4;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienKhach, false) == 0)
                {
                    return 11;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.ToanQuocCongAn, false) == 0)
                {
                    return 12;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static byte PhanLoaiVe(string SoVe13Char)
        {
            try
            {
                if (LoaiVe(SoVe13Char) == 5)
                {
                    return 2;
                }
                return byte.Parse(SoVe13Char[1].ToString());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static byte CabinInMaVali(string MaVali)
        {
            string s = MaVali[8].ToString() + MaVali[9].ToString();
            try
            {
                return byte.Parse(s);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static DateTime NgayInMaVali(string MaVali)
        {
            try
            {
                string s = "01/01/20" + MaVali.Substring(0, 2);
                DateTime result = DateTime.Parse(s);
                result = result.AddMonths(checked(int.Parse(MaVali.Substring(2, 2)) - 1));
                result = result.AddDays((double)checked(int.Parse(MaVali.Substring(4, 2)) - 1));
                return result;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return DateAndTime.Now.AddDays(-2.0);
        }

        public static byte CatrucInMaVali(string MaVali)
        {
            string s = MaVali[7].ToString();
            try
            {
                return byte.Parse(s);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static string NgayInMaValiString(string MaVali)
        {
            try
            {
                return MaVali.Substring(0, 6);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return "";
        }

        public static bool ChangeVe16To13(string strVe16Char, ref string strVe13Char)
        {
            string text = "";
            try
            {
                if (strVe16Char.Length != 16)
                {
                    return false;
                }
                switch (int.Parse(strVe16Char.Substring(7, 1)))
                {
                    case 0:
                        switch (int.Parse(strVe16Char.Substring(8, 1)))
                        {
                            case 0:
                                text = "T";
                                break;
                            case 1:
                                text = "F";
                                break;
                            case 2:
                                text = "H";
                                break;
                            case 3:
                                text = "I";
                                break;
                            case 4:
                                text = "E";
                                break;
                            case 5:
                                text = "G";
                                break;
                            case 9:
                                text = "U";
                                break;
                            case 8:
                                text = "V";
                                break;
                            default:
                                return false;
                        }
                        text += "0";
                        break;
                    case 1:
                        text = "A";
                        text += strVe16Char.Substring(8, 1);
                        break;
                    case 2:
                        text = "B";
                        text += strVe16Char.Substring(8, 1);
                        break;
                    case 3:
                        text = "C";
                        text += strVe16Char.Substring(8, 1);
                        break;
                    case 4:
                        text = "D";
                        text += strVe16Char.Substring(8, 1);
                        break;
                    default:
                        return false;
                }
                text += strVe16Char.Substring(5, 2);
                text += "0";
                text += strVe16Char.Substring(4, 1);
                text = (strVe13Char = text + strVe16Char.Substring(9, 7));
                return true;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            return false;
        }
    }
}
