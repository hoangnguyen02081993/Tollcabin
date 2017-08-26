using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tollcabin
{
    public class DVR
    {
        private string _DVRIPAdress;

        private const int DVRPort = 10000;

        public string DVRIP
        {
            get
            {
                return this._DVRIPAdress;
            }
            set
            {
                this._DVRIPAdress = value;
            }
        }

        public DVR()
        {
            this._DVRIPAdress = "192.168.1.33";
        }

        public void TextOutDVR(int channel, string bienso)
        {
            if (channel <= 0)
            {
                return;
            }
            int length = bienso.Length;
            checked
            {
                string text;
                if (length >= 15)
                {
                    text = bienso.Substring(0, 15);
                }
                else
                {
                    text = bienso + Strings.Space(15 - length);
                }
                string text2 = Strings.Space(15);
                int num = 0;
                do
                {
                    if ((unchecked((long)channel) & (long)Math.Round(Math.Pow(2.0, (double)num))) > 0L)
                    {
                        string textOut = string.Concat(new string[]
                        {
                            "U",
                            Conversions.ToString(Strings.Chr(num + 1)),
                            text,
                            text2,
                            Conversions.ToString(Strings.Chr(170))
                        });
                        this.SendDVR(textOut);
                    }
                    num++;
                }
                while (num <= 15);
            }
        }

        public void TextOutDVR(int channel, string bienso, string Sove, byte Pttt, byte Loaixe, string msnv, byte TTXequa)
        {
            if (channel <= 0)
            {
                return;
            }
            bool flag = false;
            checked
            {
                string str;
                if (Strings.Len(bienso) <= 8)
                {
                    str = bienso + Strings.Space(8 - Strings.Len(bienso));
                }
                else
                {
                    str = bienso.Substring(0, 8);
                }
                string str2;
                if (Strings.Len(Sove) >= 6)
                {
                    str2 = Sove.Substring(Sove.Length - 6, 6);
                }
                else
                {
                    str2 = Sove + Strings.Space(6 - Strings.Len(Sove));
                }
                string str3;
                if (Strings.Len(msnv) >= 4)
                {
                    str3 = msnv.Substring(msnv.Length - 4, 4);
                }
                else
                {
                    str3 = msnv + Strings.Space(4 - Strings.Len(msnv));
                }
                string text = str + " " + str2;
                string text2;
                switch (Pttt)
                {
                    case 1:
                        text2 = "PL" + ((int)(Loaixe % 10)).ToString();
                        if (TTXequa == 3)
                        {
                            flag = true;
                        }
                        if (flag)
                        {
                            text2 += "VIPHAM";
                        }
                        else
                        {
                            text2 += "HOPLE ";
                        }
                        text2 = text2 + "  " + str3;
                        goto IL_281;
                    case 2:
                        text2 = "PL" + ((int)(Loaixe % 10)).ToString();
                        text2 += "VETHANG";
                        text2 = text2 + " " + str3;
                        goto IL_281;
                    case 3:
                        text2 = "PL" + Strings.Format(Loaixe, "0");
                        text2 += "VEQUI";
                        text2 = text2 + "   " + str3;
                        goto IL_281;
                    case 5:
                        text2 = "PL" + Strings.Format(Loaixe, "0");
                        text2 += "VEQLL";
                        text2 = text2 + "   " + str3;
                        goto IL_281;
                    case 6:
                        text2 = "UUTIENLUOT";
                        text2 = text2 + " " + str3;
                        goto IL_281;
                    case 7:
                        text2 = "TOANQUOC";
                        text2 = text2 + "   " + str3;
                        goto IL_281;
                    case 8:
                        text2 = "UUTIENDOAN";
                        text2 = text2 + " " + str3;
                        goto IL_281;
                    case 9:
                        text2 = "CUONGBUC";
                        text2 = text2 + "   " + str3;
                        goto IL_281;
                    case 10:
                        text2 = "PL" + ((int)(Loaixe % 10)).ToString();
                        text2 += "THUHOI";
                        text2 = text2 + "  " + str3;
                        goto IL_281;
                    case 11:
                        text2 = "NOIBO ";
                        text2 = text2 + "     " + str3;
                        goto IL_281;
                }
                text2 = Strings.Space(15);
            IL_281:
                int num = 0;
                do
                {
                    if ((unchecked((long)channel) & (long)Math.Round(Math.Pow(2.0, (double)num))) > 0L)
                    {
                        string textOut = string.Concat(new string[]
                        {
                            "U",
                            Conversions.ToString(Strings.Chr(num + 1)),
                            text,
                            text2,
                            Conversions.ToString(Strings.Chr(170))
                        });
                        this.SendDVR(textOut);
                    }
                    num++;
                }
                while (num <= 15);
            }
        }

        public void ClearDVR(int channel)
        {
            if (channel <= 0)
            {
                return;
            }
            int num = 0;
            checked
            {
                do
                {
                    if ((unchecked((long)channel) & (long)Math.Round(Math.Pow(2.0, (double)num))) > 0L)
                    {
                        string text = Strings.Space(15);
                        string text2 = Strings.Space(15);
                        string textOut = string.Concat(new string[]
                        {
                            "U",
                            Conversions.ToString(Strings.Chr(num + 1)),
                            text,
                            text2,
                            Conversions.ToString(Strings.Chr(170))
                        });
                        this.SendDVR(textOut);
                    }
                    num++;
                }
                while (num <= 15);
            }
        }

        private void SendDVR(string TextOut)
        {
        }
    }
}
