using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace Tollcabin
{
    public class XeQuaTram
    {
        private string BienSo_;

        private string SoVe_;

        private byte PLXeTruoc_;

        private byte PLXeSau_;

        private byte PLVe_;

        private byte PTTT_;

        private long Phi_;

        private byte LanXe_;

        private string NgayQuaTram_;

        private string GioQuaTram_;

        private byte CaTruc_;

        private string MSNV_;

        private string TenHinhXe_;

        private string BSXeThangQui_;

        private bool DataSend_;

        public bool DataSend
        {
            get
            {
                return DataSend_;
            }
            set
            {
                DataSend_ = value;
            }
        }

        public string BienSo
        {
            get
            {
                return BienSo_;
            }
            set
            {
                BienSo_ = value;
            }
        }

        public byte TTXeQua
        {
            get
            {
                switch (PTTT)
                {
                    case 7:
                    case 12:
                        return 0;
                    case 6:
                    case 8:
                        return 12;
                    case 2:
                    case 3:
                        if (Operators.CompareString(BienSo, BSXeThangQui, false) != 0)
                        {
                            return 5;
                        }
                        if (PLXeTruoc == 0)
                        {
                            return 1;
                        }
                        if (PLXeTruoc != PLVe)
                        {
                            return 3;
                        }
                        return 0;
                    case 4:
                        if (Operators.CompareString(BienSo, BSXeThangQui, false) != 0)
                        {
                            return 14;
                        }
                        return 0;
                    case 1:
                    case 5:
                        if (PLXeTruoc == 0)
                        {
                            if (Operators.CompareString(BienSo, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false) == 0)
                            {
                                return 2;
                            }
                            return 1;
                        }
                        if (PLVe != PLXeTruoc)
                        {
                            return 3;
                        }
                        if ((uint)PLVe < (uint)PLXeSau)
                        {
                            return 4;
                        }
                        return 0;
                    case 0:
                        return 8;
                    case 9:
                        return 9;
                    case 11:
                        return 0;
                    default:
                        {
                            byte result = default(byte);
                            return result;
                        }
                }
            }
        }

        public string SoVe
        {
            get
            {
                return SoVe_;
            }
            set
            {
                SoVe_ = value;
            }
        }

        public byte PLXeTruoc
        {
            get
            {
                return PLXeTruoc_;
            }
            set
            {
                PLXeTruoc_ = value;
            }
        }

        public byte PLXeSau
        {
            get
            {
                return PLXeSau_;
            }
            set
            {
                PLXeSau_ = value;
            }
        }

        public byte PLVe
        {
            get
            {
                return PLVe_;
            }
            set
            {
                PLVe_ = value;
            }
        }

        public byte PTTT
        {
            get
            {
                return PTTT_;
            }
            set
            {
                PTTT_ = value;
            }
        }

        public long Phi
        {
            get
            {
                return Phi_;
            }
            set
            {
                Phi_ = value;
            }
        }

        public byte LanXe
        {
            get
            {
                return LanXe_;
            }
            set
            {
                LanXe_ = value;
            }
        }

        public string NgayQuaTram
        {
            get
            {
                return NgayQuaTram_;
            }
            set
            {
                NgayQuaTram_ = value;
            }
        }

        public string GioQuaTram
        {
            get
            {
                return GioQuaTram_;
            }
            set
            {
                GioQuaTram_ = value;
            }
        }

        public object CaTruc
        {
            get
            {
                return CaTruc_;
            }
            set
            {
                CaTruc_ = Conversions.ToByte(value);
            }
        }

        public string MSNV
        {
            get
            {
                return MSNV_;
            }
            set
            {
                MSNV_ = value;
            }
        }

        public string TenHinhXe
        {
            get
            {
                return TenHinhXe_;
            }
            set
            {
                TenHinhXe_ = value;
            }
        }

        public string BSXeThangQui
        {
            get
            {
                return BSXeThangQui_;
            }
            set
            {
                BSXeThangQui_ = value;
            }
        }

        public bool Null => Operators.CompareString(TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) == 0;

        public XeQuaTram()
        {
            DataSend_ = true;
            BienSo = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            SoVe = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
            PLXeTruoc = 0;
            PLXeSau = 0;
            PLVe = 0;
            PTTT = 0;
            Phi = 0L;
            LanXe = 0;
            NgayQuaTram = ModuleKhaiBaoConst.EnumStrNull.NgayQuaTramNull;
            GioQuaTram = ModuleKhaiBaoConst.EnumStrNull.GioQuaTramNull;
            CaTruc = ModuleKhaiBaoConst.EnumNull.PhiNull;
            MSNV = ModuleKhaiBaoConst.EnumStrNull.MSNVNull;
            TenHinhXe = ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull;
            BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            DataSend = true;
        }

        public void Reset()
        {
            BienSo = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            SoVe = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
            PLXeTruoc = 0;
            PLXeSau = 0;
            PLVe = 0;
            PTTT = 0;
            Phi = 0L;
            LanXe = 0;
            NgayQuaTram = ModuleKhaiBaoConst.EnumStrNull.NgayQuaTramNull;
            GioQuaTram = ModuleKhaiBaoConst.EnumStrNull.GioQuaTramNull;
            CaTruc = ModuleKhaiBaoConst.EnumNull.PhiNull;
            MSNV = ModuleKhaiBaoConst.EnumStrNull.MSNVNull;
            TenHinhXe = ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull;
            BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            DataSend = true;
        }

        public XeQuaTram Paste()
        {
            XeQuaTram xeQuaTram = new XeQuaTram();
            xeQuaTram.BienSo = BienSo;
            xeQuaTram.CaTruc = RuntimeHelpers.GetObjectValue(CaTruc);
            xeQuaTram.GioQuaTram = GioQuaTram;
            xeQuaTram.LanXe = LanXe;
            xeQuaTram.MSNV = MSNV;
            xeQuaTram.NgayQuaTram = NgayQuaTram;
            xeQuaTram.Phi = Phi;
            xeQuaTram.PLVe = PLVe;
            xeQuaTram.PLXeSau = PLXeSau;
            xeQuaTram.PLXeTruoc = PLXeTruoc;
            xeQuaTram.PTTT = PTTT;
            xeQuaTram.SoVe = SoVe;
            xeQuaTram.TenHinhXe = TenHinhXe;
            xeQuaTram.BSXeThangQui = BSXeThangQui;
            xeQuaTram.DataSend = DataSend;
            return xeQuaTram;
        }

        public void Coppy(XeQuaTram Car)
        {
            BienSo = Car.BienSo;
            CaTruc = RuntimeHelpers.GetObjectValue(Car.CaTruc);
            GioQuaTram = Car.GioQuaTram;
            LanXe = Car.LanXe;
            MSNV = Car.MSNV;
            NgayQuaTram = Car.NgayQuaTram;
            Phi = Car.Phi;
            PLVe = Car.PLVe;
            PLXeSau = Car.PLXeSau;
            PLXeTruoc = Car.PLXeTruoc;
            PTTT = Car.PTTT;
            SoVe = Car.SoVe;
            TenHinhXe = Car.TenHinhXe;
            BSXeThangQui = Car.BSXeThangQui;
            DataSend = Car.DataSend;
        }

        public override string ToString()
        {
            string text = "";
            return text + BienSo + "#" + CaTruc.ToString() + "#" + GioQuaTram + "#" + LanXe.ToString() + "#" + MSNV + "#" + NgayQuaTram + "#" + Phi.ToString() + "#" + PLVe.ToString() + "#" + PLXeSau.ToString() + "#" + PLXeTruoc.ToString() + "#" + PTTT.ToString() + "#" + SoVe.ToString() + "#" + TenHinhXe.ToString() + "#" + TTXeQua.ToString();
        }
    }
}
