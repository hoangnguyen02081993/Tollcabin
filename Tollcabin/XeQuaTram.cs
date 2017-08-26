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
                return this.DataSend_;
            }
            set
            {
                this.DataSend_ = value;
            }
        }

        public string BienSo
        {
            get
            {
                return this.BienSo_;
            }
            set
            {
                this.BienSo_ = value;
            }
        }

        public byte TTXeQua
        {
            get
            {
                switch (this.PTTT)
                {
                    case 0:
                        return 8;
                    case 1:
                    case 5:
                        if (this.PLXeTruoc == 0)
                        {
                            if (Operators.CompareString(this.BienSo, ModuleKhaiBaoConst.EnumStrNull.BienSoNull, false) == 0)
                            {
                                return 2;
                            }
                            return 1;
                        }
                        else
                        {
                            if (this.PLVe != this.PLXeTruoc)
                            {
                                return 3;
                            }
                            if (this.PLVe < this.PLXeSau)
                            {
                                return 4;
                            }
                            return 0;
                        }
                        break;
                    case 2:
                    case 3:
                        if (Operators.CompareString(this.BienSo, this.BSXeThangQui, false) != 0)
                        {
                            return 5;
                        }
                        if (this.PLXeTruoc == 0)
                        {
                            return 1;
                        }
                        if (this.PLXeTruoc != this.PLVe)
                        {
                            return 3;
                        }
                        return 0;
                    case 4:
                        return 0;
                    case 6:
                    case 8:
                        return 12;
                    case 7:
                    case 12:
                        return 0;
                    case 9:
                        return 9;
                    case 11:
                        return 0;
                }
                byte result = 0;
                return result;
            }
        }

        public string SoVe
        {
            get
            {
                return this.SoVe_;
            }
            set
            {
                this.SoVe_ = value;
            }
        }

        public byte PLXeTruoc
        {
            get
            {
                return this.PLXeTruoc_;
            }
            set
            {
                this.PLXeTruoc_ = value;
            }
        }

        public byte PLXeSau
        {
            get
            {
                return this.PLXeSau_;
            }
            set
            {
                this.PLXeSau_ = value;
            }
        }

        public byte PLVe
        {
            get
            {
                return this.PLVe_;
            }
            set
            {
                this.PLVe_ = value;
            }
        }

        public byte PTTT
        {
            get
            {
                return this.PTTT_;
            }
            set
            {
                this.PTTT_ = value;
            }
        }

        public long Phi
        {
            get
            {
                return this.Phi_;
            }
            set
            {
                this.Phi_ = value;
            }
        }

        public byte LanXe
        {
            get
            {
                return this.LanXe_;
            }
            set
            {
                this.LanXe_ = value;
            }
        }

        public string NgayQuaTram
        {
            get
            {
                return this.NgayQuaTram_;
            }
            set
            {
                this.NgayQuaTram_ = value;
            }
        }

        public string GioQuaTram
        {
            get
            {
                return this.GioQuaTram_;
            }
            set
            {
                this.GioQuaTram_ = value;
            }
        }

        public object CaTruc
        {
            get
            {
                return this.CaTruc_;
            }
            set
            {
                this.CaTruc_ = Conversions.ToByte(value);
            }
        }

        public string MSNV
        {
            get
            {
                return this.MSNV_;
            }
            set
            {
                this.MSNV_ = value;
            }
        }

        public string TenHinhXe
        {
            get
            {
                return this.TenHinhXe_;
            }
            set
            {
                this.TenHinhXe_ = value;
            }
        }

        public string BSXeThangQui
        {
            get
            {
                return this.BSXeThangQui_;
            }
            set
            {
                this.BSXeThangQui_ = value;
            }
        }

        public bool Null
        {
            get
            {
                return Operators.CompareString(this.TenHinhXe, ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull, false) == 0;
            }
        }

        public XeQuaTram()
        {
            this.DataSend_ = true;
            this.BienSo = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            this.SoVe = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
            this.PLXeTruoc = 0;
            this.PLXeSau = 0;
            this.PLVe = 0;
            this.PTTT = 0;
            this.Phi = 0L;
            this.LanXe = 0;
            this.NgayQuaTram = ModuleKhaiBaoConst.EnumStrNull.NgayQuaTramNull;
            this.GioQuaTram = ModuleKhaiBaoConst.EnumStrNull.GioQuaTramNull;
            this.CaTruc = ModuleKhaiBaoConst.EnumNull.PhiNull;
            this.MSNV = ModuleKhaiBaoConst.EnumStrNull.MSNVNull;
            this.TenHinhXe = ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull;
            this.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            this.DataSend = true;
        }

        public void Reset()
        {
            this.BienSo = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            this.SoVe = ModuleKhaiBaoConst.EnumStrNull.SoVeNull;
            this.PLXeTruoc = 0;
            this.PLXeSau = 0;
            this.PLVe = 0;
            this.PTTT = 0;
            this.Phi = 0L;
            this.LanXe = 0;
            this.NgayQuaTram = ModuleKhaiBaoConst.EnumStrNull.NgayQuaTramNull;
            this.GioQuaTram = ModuleKhaiBaoConst.EnumStrNull.GioQuaTramNull;
            this.CaTruc = ModuleKhaiBaoConst.EnumNull.PhiNull;
            this.MSNV = ModuleKhaiBaoConst.EnumStrNull.MSNVNull;
            this.TenHinhXe = ModuleKhaiBaoConst.EnumStrNull.TenHinhXeNull;
            this.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
            this.DataSend = true;
        }

        public XeQuaTram Paste()
        {
            return new XeQuaTram
            {
                BienSo = this.BienSo,
                CaTruc = RuntimeHelpers.GetObjectValue(this.CaTruc),
                GioQuaTram = this.GioQuaTram,
                LanXe = this.LanXe,
                MSNV = this.MSNV,
                NgayQuaTram = this.NgayQuaTram,
                Phi = this.Phi,
                PLVe = this.PLVe,
                PLXeSau = this.PLXeSau,
                PLXeTruoc = this.PLXeTruoc,
                PTTT = this.PTTT,
                SoVe = this.SoVe,
                TenHinhXe = this.TenHinhXe,
                BSXeThangQui = this.BSXeThangQui,
                DataSend = this.DataSend
            };
        }

        public void Coppy(XeQuaTram Car)
        {
            this.BienSo = Car.BienSo;
            this.CaTruc = RuntimeHelpers.GetObjectValue(Car.CaTruc);
            this.GioQuaTram = Car.GioQuaTram;
            this.LanXe = Car.LanXe;
            this.MSNV = Car.MSNV;
            this.NgayQuaTram = Car.NgayQuaTram;
            this.Phi = Car.Phi;
            this.PLVe = Car.PLVe;
            this.PLXeSau = Car.PLXeSau;
            this.PLXeTruoc = Car.PLXeTruoc;
            this.PTTT = Car.PTTT;
            this.SoVe = Car.SoVe;
            this.TenHinhXe = Car.TenHinhXe;
            this.BSXeThangQui = Car.BSXeThangQui;
            this.DataSend = Car.DataSend;
        }

        public override string ToString()
        {
            string text = "";
            return string.Concat(new string[]
            {
                text,
                this.BienSo,
                "#",
                this.CaTruc.ToString(),
                "#",
                this.GioQuaTram,
                "#",
                this.LanXe.ToString(),
                "#",
                this.MSNV,
                "#",
                this.NgayQuaTram,
                "#",
                this.Phi.ToString(),
                "#",
                this.PLVe.ToString(),
                "#",
                this.PLXeSau.ToString(),
                "#",
                this.PLXeTruoc.ToString(),
                "#",
                this.PTTT.ToString(),
                "#",
                this.SoVe.ToString(),
                "#",
                this.TenHinhXe.ToString(),
                "#",
                this.TTXeQua.ToString()
            });
        }
    }
}
