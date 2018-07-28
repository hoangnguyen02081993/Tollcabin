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
                if (size > 0)
                {
                    if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0)
                    {
                        return Color.Red;
                    }
                    return Color.White;
                }
                return Color.Black;
            }
        }

        public Color CarRearStatus
        {
            get
            {
                if (size > 1)
                {
                    if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0)
                    {
                        return Color.Red;
                    }
                    return Color.White;
                }
                return Color.Black;
            }
        }

        public bool CoXe => size > 0;

        public bool XeChuaRaKhoiVungTu
        {
            get
            {
                if (size <= 0)
                {
                    return false;
                }
                return Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0;
            }
        }

        public bool XeSauHopLe
        {
            get
            {
                if (size < 2)
                {
                    return false;
                }
                return Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0;
            }
        }

        public bool CoXeHopLe
        {
            get
            {
                if (size <= 0)
                {
                    return false;
                }
                if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0 | Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) != 0)
                {
                    return true;
                }
                return false;
            }
        }

        public int PhanLoaiXeTruoc
        {
            get
            {
                if (size <= 0)
                {
                    return 0;
                }
                int num = -1;
                if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    num = front;
                }
                else if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    num = rear;
                }
                return Car[num].PLXeTruoc;
            }
        }

        public bool CoXeKhongHopLe
        {
            get
            {
                if (size <= 0)
                {
                    return false;
                }
                if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0 | Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public QueueXeQuaTram()
        {
            Car = new XeQuaTram[3];
            front = 1;
            rear = 0;
            size = 0;
            CarOutVungTuCuoi = new XeQuaTram();
        }

        public void EnQueue(string Ngay, string Gio, string MaNhanVien, byte Catruc, byte LanXe, string HinhAnh)
        {
            if (size == 2)
            {
                DeQueue();
            }
            checked
            {
                rear = (byte)unchecked(checked(unchecked((int)rear) + 1) % 2);
                Car[rear] = new XeQuaTram();
                Car[rear].NgayQuaTram = Ngay;
                Car[rear].GioQuaTram = Gio;
                Car[rear].TenHinhXe = HinhAnh;
                Car[rear].MSNV = MaNhanVien;
                Car[rear].CaTruc = Catruc;
                Car[rear].LanXe = LanXe;
                Car[rear].DataSend = true;
                size = (byte)(unchecked((int)size) + 1);
            }
        }

        public void EditQueue(string Gio, string MaNhanVien, byte Catruc)
        {
            if (size > 0)
            {
                if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    Car[rear].GioQuaTram = Gio;
                    Car[rear].MSNV = MaNhanVien;
                    Car[rear].CaTruc = Catruc;
                }
                if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
                {
                    Car[front].GioQuaTram = Gio;
                    Car[front].MSNV = MaNhanVien;
                    Car[front].CaTruc = Catruc;
                }
            }
        }

        public void DeQueue()
        {
            checked
            {
                if (size > 0)
                {
                    Car[front].Reset();
                    front = (byte)unchecked(checked(unchecked((int)front) + 1) % 2);
                    size = (byte)(unchecked((int)size) - 1);
                }
            }
        }

        public void Insert(string BienSo, int PLXeTruoc)
        {
            if (size > 0)
            {
                Car[rear].BienSo = BienSo;
                Car[rear].PLXeTruoc = checked((byte)PLXeTruoc);
            }
        }

        public void InsertBienSoFront(string BienSo, int PLXeTruoc)
        {
            if (size > 0)
            {
                Car[front].BienSo = BienSo;
                Car[front].PLXeTruoc = checked((byte)PLXeTruoc);
            }
        }

        public void Insert(int PhanLoaiXe)
        {
            if (size > 0)
            {
                int num = -1;
                if (Car[front].PTTT != 1 & Car[front].PTTT != 2 & Car[front].PTTT != 3 & Car[front].PLVe == 0)
                {
                    num = front;
                }
                else if (Car[rear].PTTT != 1 & Car[rear].PTTT != 2 & Car[rear].PTTT != 3 & Car[rear].PLVe == 0)
                {
                    num = rear;
                }
                if (num != -1)
                {
                    Car[num].PLVe = checked((byte)PhanLoaiXe);
                }
            }
        }

        public XeQuaTram Insert(string SoVe, long Phi, string BSXeThangQui, bool FlagThuHoi)
        {
            XeQuaTram result = new XeQuaTram();
            if (size <= 0)
            {
                return result;
            }
            int num = -1;
            if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = front;
            }
            else if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = rear;
            }
            if (num == -1)
            {
                return result;
            }
            Car[num].SoVe = SoVe;
            Car[num].PTTT = VeXe.LoaiVe(SoVe);
            Car[num].PLVe = VeXe.PhanLoaiVe(SoVe);
            Car[num].Phi = Phi;
            Car[num].BSXeThangQui = BSXeThangQui;
            return Car[num].Paste();
        }

        public string BienSoFront()
        {
            if (size <= 0)
            {
                return "";
            }
            int num = -1;
            if (Operators.CompareString(Car[front].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = front;
            }
            else if (Operators.CompareString(Car[rear].SoVe, ModuleKhaiBaoConst.EnumStrNull.SoVeNull, false) == 0)
            {
                num = rear;
            }
            return Car[num].BienSo;
        }

        public void Send(int PLSau)
        {
            if (!CarOutVungTuCuoi.Null)
            {
                XeQuaTram xeQuaTram = new XeQuaTram();
                xeQuaTram = CarOutVungTuCuoi.Paste();
                CarOutVungTuCuoi.Reset();
                xeQuaTram.PLXeSau = checked((byte)PLSau);
                Thread thread = new Thread(delegate (object a0)
                {
                    ConnectServerUpData((XeQuaTram)a0);
                });
                thread.Start(xeQuaTram);
            }
        }

        public void Send(bool CoHuyDuLieu)
        {
            if (size > 0)
            {
                XeQuaTram xeQuaTram = new XeQuaTram();
                if (Car[front].DataSend)
                {
                    xeQuaTram = Car[front].Paste();
                    CarOutVungTuCuoi = new XeQuaTram();
                    CarOutVungTuCuoi = Car[front].Paste();
                    Thread thread = new Thread(delegate (object a0)
                    {
                        ConnectServer((XeQuaTram)a0);
                    });
                    thread.Start(xeQuaTram);
                    Car[front].DataSend = false;
                }
                if (CoHuyDuLieu)
                {
                    DeQueue();
                }
            }
        }

        public static void ConnectServer(XeQuaTram Xe)
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayGiamSatMain);
                IPAddress[] addressList = hostEntry.AddressList;
                IPAddress[] array = addressList;
                IPAddress address = default(IPAddress);
                foreach (IPAddress iPAddress in array)
                {
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
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            CSDL.InsertXeQuaTram(ModuleKhaiBaoConst.StrConnectMain, Xe);
            try
            {
                CSDL.InsertXeQuaTram(ModuleKhaiBaoConst.StrConnectMain_mas, Xe);
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                ProjectData.ClearProjectError();
            }
        }

        public void ResetFront()
        {
            if (size > 0)
            {
                DeQueue();
            }
        }

        public static void ConnectServerUpData(XeQuaTram Xe)
        {
        }
    }
}
