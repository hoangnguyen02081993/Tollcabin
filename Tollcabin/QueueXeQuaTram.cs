using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tollcabin
{
    public class QueueXeQuaTram
    {
        private const int MaxSize = 2;

        private byte front;

        private byte rear;

        private byte size;

        private XeQuaTram[] Car;

        private XeQuaTram CarOutVungTuCuoi;

        public Color CarFrontStatus
        {
            get
            {
                if (this.size <= 0)
                {
                    return Color.Black;
                }
                if (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0)
                {
                    return Color.Red;
                }
                return Color.White;
            }
        }

        public Color CarRearStatus
        {
            get
            {
                if (this.size <= 1)
                {
                    return Color.Black;
                }
                if (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0)
                {
                    return Color.Red;
                }
                return Color.White;
            }
        }

        public bool CoXe
        {
            get
            {
                return this.size > 0;
            }
        }

        public bool XeChuaRaKhoiVungTu
        {
            get
            {
                return this.size > 0 && Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0;
            }
        }

        public bool XeSauHopLe
        {
            get
            {
                return this.size >= 2 && Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0;
            }
        }

        public bool CoXeHopLe
        {
            get
            {
                return this.size > 0 && (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0 | Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0);
            }
        }

        public int PhanLoaiXeTruoc
        {
            get
            {
                if (this.size <= 0)
                {
                    return 0;
                }
                int num = -1;
                if (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    num = (int)this.front;
                }
                else if (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    num = (int)this.rear;
                }
                return (int)this.Car[num].PLXeTruoc;
            }
        }

        public bool CoXeKhongHopLe
        {
            get
            {
                return this.size > 0 && (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0 | Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0);
            }
        }

        public QueueXeQuaTram()
        {
            this.Car = new XeQuaTram[3];
            this.front = 1;
            this.rear = 0;
            this.size = 0;
            this.CarOutVungTuCuoi = new XeQuaTram();
        }

        public void EnQueue(string Ngay, string Gio, string MaNhanVien, byte Catruc, byte LanXe, string HinhAnh)
        {
            if (this.size == 2)
            {
                this.DeQueue();
            }
            checked
            {
                this.rear = (byte)((this.rear + 1) % 2);
                this.Car[(int)this.rear] = new XeQuaTram();
                this.Car[(int)this.rear].NgayQuaTram = Ngay;
                this.Car[(int)this.rear].GioQuaTram = Gio;
                this.Car[(int)this.rear].TenHinhXe = HinhAnh;
                this.Car[(int)this.rear].MSNV = MaNhanVien;
                this.Car[(int)this.rear].CaTruc = Catruc;
                this.Car[(int)this.rear].LanXe = LanXe;
                this.Car[(int)this.rear].DataSend = true;
                this.size += 1;
            }
        }

        public void EditQueue(string Gio, string MaNhanVien, byte Catruc)
        {
            if (this.size <= 0)
            {
                return;
            }
            if (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                this.Car[(int)this.rear].GioQuaTram = Gio;
                this.Car[(int)this.rear].MSNV = MaNhanVien;
                this.Car[(int)this.rear].CaTruc = Catruc;
            }
            if (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                this.Car[(int)this.front].GioQuaTram = Gio;
                this.Car[(int)this.front].MSNV = MaNhanVien;
                this.Car[(int)this.front].CaTruc = Catruc;
            }
        }

        public void DeQueue()
        {
            if (this.size <= 0)
            {
                return;
            }
            this.Car[(int)this.front].Reset();
            checked
            {
                this.front = (byte)((this.front + 1) % 2);
                this.size -= 1;
            }
        }

        public void Insert(string BienSo, int PLXeTruoc)
        {
            if (this.size <= 0)
            {
                return;
            }
            this.Car[(int)this.rear].BienSo = BienSo;
            this.Car[(int)this.rear].PLXeTruoc = checked((byte)PLXeTruoc);
        }

        public void InsertBienSoFront(string BienSo, int PLXeTruoc)
        {
            if (this.size <= 0)
            {
                return;
            }
            this.Car[(int)this.front].BienSo = BienSo;
            this.Car[(int)this.front].PLXeTruoc = checked((byte)PLXeTruoc);
        }

        public void Insert(int PhanLoaiXe)
        {
            if (this.size <= 0)
            {
                return;
            }
            int num = -1;
            if (this.Car[(int)this.front].PTTT != 1 & this.Car[(int)this.front].PTTT != 2 & this.Car[(int)this.front].PTTT != 3 & this.Car[(int)this.front].PLVe == 0)
            {
                num = (int)this.front;
            }
            else if (this.Car[(int)this.rear].PTTT != 1 & this.Car[(int)this.rear].PTTT != 2 & this.Car[(int)this.rear].PTTT != 3 & this.Car[(int)this.rear].PLVe == 0)
            {
                num = (int)this.rear;
            }
            if (num == -1)
            {
                return;
            }
            this.Car[num].PLVe = checked((byte)PhanLoaiXe);
        }

        public XeQuaTram Insert(string SoVe, long Phi, string BSXeThangQui, bool FlagThuHoi)
        {
            XeQuaTram result = new XeQuaTram();
            if (this.size <= 0)
            {
                return result;
            }
            int num = -1;
            if (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = (int)this.front;
            }
            else if (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = (int)this.rear;
            }
            if (num == -1)
            {
                return result;
            }
            this.Car[num].SoVe = SoVe;
            this.Car[num].PTTT = VeXe.LoaiVe(SoVe);
            this.Car[num].PLVe = VeXe.PhanLoaiVe(SoVe);
            this.Car[num].Phi = Phi;
            this.Car[num].BSXeThangQui = BSXeThangQui;
            return this.Car[num].Paste();
        }

        public string BienSoFront()
        {
            if (this.size <= 0)
            {
                return "";
            }
            int num = -1;
            if (Operators.CompareString(this.Car[(int)this.front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = (int)this.front;
            }
            else if (Operators.CompareString(this.Car[(int)this.rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = (int)this.rear;
            }
            return this.Car[num].BienSo;
        }

        public void Send(int PLSau)
        {
            if (this.CarOutVungTuCuoi.Null)
            {
                return;
            }
            XeQuaTram xeQuaTram = new XeQuaTram();
            xeQuaTram = this.CarOutVungTuCuoi.Paste();
            this.CarOutVungTuCuoi.Reset();
            xeQuaTram.PLXeSau = checked((byte)PLSau);
            Thread thread = new Thread(delegate (object a0)
            {
                QueueXeQuaTram.ConnectServerUpData((XeQuaTram)a0);
            });
            thread.Start(xeQuaTram);
        }

        public void Send(bool CoHuyDuLieu)
        {
            if (this.size <= 0)
            {
                return;
            }
            XeQuaTram parameter = new XeQuaTram();
            if (this.Car[(int)this.front].DataSend)
            {
                parameter = this.Car[(int)this.front].Paste();
                this.CarOutVungTuCuoi = new XeQuaTram();
                this.CarOutVungTuCuoi = this.Car[(int)this.front].Paste();
                Thread thread = new Thread(delegate (object a0)
                {
                    QueueXeQuaTram.ConnectServer((XeQuaTram)a0);
                });
                thread.Start(parameter);
                this.Car[(int)this.front].DataSend = false;
            }
            if (CoHuyDuLieu)
            {
                this.DeQueue();
            }
        }

        public static void ConnectServer(XeQuaTram Xe)
        {
            checked
            {
                try
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayGiamSatMain);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array = addressList;
                    IPAddress address = null;
                    for (int i = 0; i < array.Length; i++)
                    {
                        IPAddress iPAddress = array[i];
                        if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            address = iPAddress;
                            break;
                        }
                    }
                    IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortDuLieuChinhMain);
                    socket.Connect(remoteEP);
                    byte[] bytes = Encoding.ASCII.GetBytes(Xe.ToString());
                    socket.Send(bytes, bytes.Length, SocketFlags.None);
                }
                catch (Exception expr_7D)
                {
                    ProjectData.SetProjectError(expr_7D);
                    ProjectData.ClearProjectError();
                }
                CSDL.InsertXeQuaTram(ModuleKhaiBaoConst.StrConnectMain, Xe);
            }
        }

        public void ResetFront()
        {
            if (this.size <= 0)
            {
                return;
            }
            this.DeQueue();
        }

        public static void ConnectServerUpData(XeQuaTram Xe)
        {
            CSDL.UpXeQuaTram(ModuleKhaiBaoConst.StrConnectMain, Xe.TenHinhXe, Xe.PLXeSau);
        }
    }
}
