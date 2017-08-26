using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tollcabin
{
    public class VeXe
    {
        [DebuggerNonUserCode]
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
                    byte result = 9;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.QLLuot, false) == 0)
                {
                    byte result = 5;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.ToanQuoc, false) == 0)
                {
                    byte result = 7;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienDoan, false) == 0)
                {
                    byte result = 8;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienLuot, false) == 0)
                {
                    byte result = 6;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeLuot, false) == 0)
                {
                    byte result = 1;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeQui, false) == 0)
                {
                    byte result = 3;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeThang, false) == 0)
                {
                    byte result = 2;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.VeTruDan, false) == 0)
                {
                    byte result = 4;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.UuTienKhach, false) == 0)
                {
                    byte result = 11;
                    return result;
                }
                if (Operators.CompareString(left, ModuleKhaiBaoConst.EStrPTTT.ToanQuocCongAn, false) == 0)
                {
                    byte result = 12;
                    return result;
                }
            }
            catch (Exception expr_F0)
            {
                ProjectData.SetProjectError(expr_F0);
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static byte PhanLoaiVe(string SoVe13Char)
        {
            try
            {
                byte result;
                if (VeXe.LoaiVe(SoVe13Char) == 5)
                {
                    result = 2;
                    return result;
                }
                result = byte.Parse(SoVe13Char[1].ToString());
                return result;
            }
            catch (Exception expr_24)
            {
                ProjectData.SetProjectError(expr_24);
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
            catch (Exception expr_32)
            {
                ProjectData.SetProjectError(expr_32);
                ProjectData.ClearProjectError();
            }
            return 0;
        }

        public static DateTime NgayInMaVali(string MaVali)
        {
            try
            {
                string s = "01/01/20" + MaVali.Substring(0, 2);
                return checked(DateTime.Parse(s).AddMonths(int.Parse(MaVali.Substring(2, 2)) - 1).AddDays((double)(int.Parse(MaVali.Substring(4, 2)) - 1)));
            }
            catch (Exception expr_4D)
            {
                ProjectData.SetProjectError(expr_4D);
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
            catch (Exception expr_1C)
            {
                ProjectData.SetProjectError(expr_1C);
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
            catch (Exception expr_0B)
            {
                ProjectData.SetProjectError(expr_0B);
                ProjectData.ClearProjectError();
            }
            return "";
        }

        public static bool ChangeVe16To13(string strVe16Char, ref string strVe13Char)
        {
            try
            {
                bool result;
                if (strVe16Char.Length != 16)
                {
                    result = false;
                    return result;
                }
                string text;
                switch (int.Parse(strVe16Char.Substring(7, 1)))
                {
                    case 0:
                        switch (int.Parse(strVe16Char.Substring(8, 1)))
                        {
                            case 0:
                                text = "T";
                                goto IL_C9;
                            case 1:
                                text = "F";
                                goto IL_C9;
                            case 2:
                                text = "H";
                                goto IL_C9;
                            case 3:
                                text = "I";
                                goto IL_C9;
                            case 4:
                                text = "E";
                                goto IL_C9;
                            case 5:
                                text = "G";
                                goto IL_C9;
                            case 8:
                                text = "V";
                                goto IL_C9;
                            case 9:
                                text = "U";
                                goto IL_C9;
                        }
                        result = false;
                        return result;
                    IL_C9:
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
                        result = false;
                        return result;
                }
                text += strVe16Char.Substring(5, 2);
                text += "0";
                text += strVe16Char.Substring(4, 1);
                text += strVe16Char.Substring(9, 7);
                strVe13Char = text;
                result = true;
                return result;
            }
            catch (Exception expr_178)
            {
                ProjectData.SetProjectError(expr_178);
                ProjectData.ClearProjectError();
            }
            return false;
        }
    }
}
