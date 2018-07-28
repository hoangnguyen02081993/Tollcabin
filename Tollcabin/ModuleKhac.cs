using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

using System.Windows.Forms;
namespace Tollcabin
{
    [StandardModule]
    internal sealed class ModuleKhac
    {
        public static void SaveJpgAs(Image image, string FileName, string ServerFilePath, string LocalFilePath)
        {
            string str = FileName.Substring(2, 6);
            try
            {
                if (!Directory.Exists(ServerFilePath + str))
                {
                    Directory.CreateDirectory(ServerFilePath + str);
                }
                image.Save(ServerFilePath + str + "\\" + FileName, ImageFormat.Jpeg);
                return;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            try
            {
                if (!Directory.Exists(LocalFilePath + str))
                {
                    Directory.CreateDirectory(LocalFilePath + str);
                }
                image.Save(LocalFilePath + str + "\\" + FileName, ImageFormat.Jpeg);
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                SaveError(ex4.Message, "SaveJpgAs");
                ProjectData.ClearProjectError();
            }
        }

        public static void PingGiamSat(string strData)
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
                byte[] bytes = Encoding.ASCII.GetBytes(strData);
                socket.Send(bytes, bytes.Length, SocketFlags.None);
                ModuleKhaiBaoConst.StatusConnectGiamSatMain = true;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ModuleKhaiBaoConst.StatusConnectGiamSatMain = false;
                ProjectData.ClearProjectError();
            }
        }

        public static int CatrucHienTai()
        {
            string text = "";
            string right = "";
            string text2 = "";
            text2 = Strings.Format(DateAndTime.Now, "HH:mm:ss");
            int num = 1;
            do
            {
                if (CSDL.SelectThoiGianCatruc(ModuleKhaiBaoConst.StrConnectMain, Conversions.ToString(num), ref text, ref right))
                {
                    if (Operators.CompareString(text, right, false) < 0)
                    {
                        if (Operators.CompareString(text2, text, false) >= 0 & Operators.CompareString(text2, right, false) <= 0)
                        {
                            return num;
                        }
                    }
                    else if ((Operators.CompareString(text2, text, false) >= 0 & Operators.CompareString(text2, "23:59:59", false) <= 0) | (Operators.CompareString(text2, "00:00:00", false) >= 0 & Operators.CompareString(text2, right, false) <= 0))
                    {
                        return num;
                    }
                }
                num = checked(num + 1);
            }
            while (num <= 4);
            return 0;
        }

        public static bool KiemTraNhanVienDangTruc(ref string MaNV)
        {
            string text = "";
            string s = "";
            string strConnectMain = ModuleKhaiBaoConst.StrConnectMain;
            checked
            {
                int num = default(int);
                byte b = (byte)num;
                bool num2 = CSDL.SelectNhanVienDangTruc(strConnectMain, ref text, ref b, ref s);
                num = b;
                if (!num2)
                {
                    return false;
                }
                int num3;
                try
                {
                    num3 = (int)Math.Round((DateAndTime.Now - DateTime.Parse(s)).TotalMinutes);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    num3 = 1000;
                    ProjectData.ClearProjectError();
                }
                if (num3 < 600 && num == CatrucHienTai())
                {
                    MaNV = text;
                    return true;
                }
                return false;
            }
        }

        public static void PingNhanDang(PictureBox pb)
        {
            try
            {
                int num = 0;
                byte[] array = new byte[1025];
                string s = "PING";
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayNhanDangMain);
                IPAddress[] addressList = hostEntry.AddressList;
                IPAddress[] array2 = addressList;
                IPAddress address = default(IPAddress);
                foreach (IPAddress iPAddress in array2)
                {
                    if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        address = iPAddress;
                        break;
                    }
                }
                IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortMayNhanDangMain);
                socket.Connect(remoteEP);
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                socket.Send(bytes, bytes.Length, SocketFlags.None);
                socket.ReceiveTimeout = 2000;
                num = socket.Receive(array, array.Length, SocketFlags.None);
                s = "";
                s = Encoding.ASCII.GetString(array, 0, array.Length).Substring(0, num);
                if (Operators.CompareString(s.ToUpper(), "OK", false) == 0)
                {
                    //pb.Image = Resources.Network11;
                    pb.BackColor = Color.White;
                    return;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            //pb.Image = Resources.Network21;
            pb.BackColor = Color.Black;
        }

        public static void SaveError(string ThongTin, string TenFile)
        {
            try
            {
                DateTime now = DateAndTime.Now;
                string text = "ErrorLog\\" + now.ToString("yyyyMMdd");
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                string[] array = new string[6]
                {
                text,
                "\\",
                TenFile,
                "-",
                null,
                null
                };
                string[] array2 = array;
                now = DateAndTime.Now;
                array2[4] = now.ToString("HHmmssfff");
                array[5] = ".xml";
                FileStream fileStream = new FileStream(string.Concat(array), FileMode.Create, FileAccess.ReadWrite);
                DataTable dataTable = new DataTable("save");
                dataTable.Columns.Add("ThongTin", Type.GetType("System.String"));
                DataRow dataRow = dataTable.NewRow();
                dataRow["ThongTin"] = ThongTin;
                dataTable.Rows.Add(dataRow);
                dataTable.WriteXml(fileStream);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public static bool ReadConfig(string FilePath, ref string Database, ref string UserName, ref string PassWord, ref int Cabin, ref string IPMayGiamSat, ref string IPMayNhanDang, ref string LocalImagesPath, ref string ServerImagesPath, ref string ServerImagesPathBS, ref int PortDuLieuChinh, ref int PortDuLieuCu, ref int PortTroGiup, ref int PortMayNhanDangBienSo, ref int IdTram, ref int Status_, ref string Instance_)
        {
            try
            {
                ProcessXML processXML = new ProcessXML(FilePath);
                Database = processXML.XmlNodeValue("Catalog", "Database", "");
                UserName = processXML.XmlNodeValue("Login", "Database", "");
                PassWord = processXML.XmlNodeValue("Password", "Database", "");
                Encryption.Encryption.Decode("ITVVA", ref UserName, UserName);
                Encryption.Encryption.Decode("ITVVA", ref PassWord, PassWord);
                IPMayGiamSat = processXML.XmlNodeValue("MayGiamSat", "Connect", "");
                IPMayNhanDang = processXML.XmlNodeValue("NhanDangBienSo", "Connect", "");
                LocalImagesPath = processXML.XmlNodeValue("LocalImagesPath", "Connect", "");
                ServerImagesPath = processXML.XmlNodeValue("ServerImagesPath", "Connect", "");
                ServerImagesPathBS = processXML.XmlNodeValue("ServerImagesPathBS", "Connect", "");
                PortDuLieuChinh = int.Parse(processXML.XmlNodeValue("PortDuLieuChinh", "Connect", ""));
                PortDuLieuCu = int.Parse(processXML.XmlNodeValue("PortDuLieuCu", "Connect", ""));
                PortTroGiup = int.Parse(processXML.XmlNodeValue("PortTroGiup", "Connect", ""));
                PortMayNhanDangBienSo = int.Parse(processXML.XmlNodeValue("PortMayNhanDangBienSo", "Connect", ""));
                Cabin = int.Parse(processXML.XmlNodeValue("CabinID", "General", ""));
                IdTram = int.Parse(processXML.XmlNodeValue("TramId", "General", ""));
                Status_ = int.Parse(processXML.XmlNodeValue("Status", "General", ""));
                Instance_ = processXML.XmlNodeValue("Instance", "Database", "");
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

        public static string KetNoi(string DataSource, string InitialCatalog, string UserID, string PassID)
        {
            string str = "Data Source = " + DataSource;
            str = str + "; Initial Catalog = " + InitialCatalog;
            str = str + "; User ID = " + UserID;
            str = str + "; PWD = " + PassID;
            str += "; Integrated Security =False";
            str += "; Connect Timeout = 2";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = str;
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                return str;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                string result = null;
                ProjectData.ClearProjectError();
                return result;
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo[] directories;
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
                directories = directoryInfo.GetDirectories();
                if (directoryInfo.Exists)
                {
                    if (!Directory.Exists(destDirName))
                    {
                        Directory.CreateDirectory(destDirName);
                    }
                    FileInfo[] files = directoryInfo.GetFiles();
                    FileInfo[] array = files;
                    foreach (FileInfo fileInfo in array)
                    {
                        try
                        {
                            string text = Path.Combine(destDirName, fileInfo.Name);
                            if (!File.Exists(text))
                            {
                                fileInfo.CopyTo(text, false);
                            }
                            File.Delete(fileInfo.FullName);
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            Exception ex2 = ex;
                            ProjectData.ClearProjectError();
                        }
                    }
                    goto end_IL_0000;
                }
                return;
                end_IL_0000:;
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                ProjectData.ClearProjectError();
                return;
            }
            if (copySubDirs)
            {
                DirectoryInfo[] array2 = directories;
                foreach (DirectoryInfo directoryInfo2 in array2)
                {
                    string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
                    DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
                    FileInfo[] files2 = new DirectoryInfo(directoryInfo2.FullName).GetFiles();
                    if (files2.Length == 0)
                    {
                        DirectoryInfo[] directories2 = new DirectoryInfo(directoryInfo2.FullName).GetDirectories();
                        if (directories2.Length == 0)
                        {
                            try
                            {
                                Directory.Delete(directoryInfo2.FullName);
                            }
                            catch (Exception ex5)
                            {
                                ProjectData.SetProjectError(ex5);
                                Exception ex6 = ex5;
                                ProjectData.ClearProjectError();
                            }
                        }
                    }
                }
            }
        }

        private static void DirectoryCopyVideo(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo[] directories;
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
                directories = directoryInfo.GetDirectories();
                if (directoryInfo.Exists)
                {
                    if (!Directory.Exists(destDirName))
                    {
                        Directory.CreateDirectory(destDirName);
                    }
                    FileInfo[] files = directoryInfo.GetFiles();
                    try
                    {
                        FileInfo[] array = files;
                        foreach (FileInfo fileInfo in array)
                        {
                            string text = Path.Combine(destDirName, fileInfo.Name);
                            try
                            {
                                if (!File.Exists(text))
                                {
                                    fileInfo.CopyTo(text, false);
                                }
                                File.Delete(fileInfo.FullName);
                            }
                            catch (Exception ex)
                            {
                                ProjectData.SetProjectError(ex);
                                Exception ex2 = ex;
                                ProjectData.ClearProjectError();
                            }
                        }
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        ProjectData.ClearProjectError();
                    }
                    goto end_IL_0000;
                }
                return;
                end_IL_0000:;
            }
            catch (Exception ex5)
            {
                ProjectData.SetProjectError(ex5);
                Exception ex6 = ex5;
                ProjectData.ClearProjectError();
                return;
            }
            if (copySubDirs)
            {
                try
                {
                    DirectoryInfo[] array2 = directories;
                    foreach (DirectoryInfo directoryInfo2 in array2)
                    {
                        string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
                        DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
                        FileInfo[] files2 = new DirectoryInfo(directoryInfo2.FullName).GetFiles();
                        if (files2.Length == 0)
                        {
                            DirectoryInfo[] directories2 = new DirectoryInfo(directoryInfo2.FullName).GetDirectories();
                        }
                    }
                }
                catch (Exception ex7)
                {
                    ProjectData.SetProjectError(ex7);
                    Exception ex8 = ex7;
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static void CoppyHinhAnhLenServer()
        {
            DirectoryCopy(ModuleKhaiBaoConst.LocalImagesPathMain, ModuleKhaiBaoConst.ServerImagesPathMain, true);
        }

        public static void CoppyVideoLenServer()
        {
            DirectoryCopyVideo("VIDEO\\", "Z:\\", true);
        }

        public static void SendOldData()
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
                IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortDuLieuCuMain);
                DataTable dataTable = new DataTable();
                dataTable = CSDL.SelectXeQuaTram(ModuleKhaiBaoConst.StrConnectMain);
                socket.Connect(remoteEP);
                socket.ReceiveTimeout = 5000;
                IEnumerator enumerator = default(IEnumerator);
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        XeQuaTram xeQuaTram = new XeQuaTram();
                        xeQuaTram.BienSo = Conversions.ToString(dataRow["BienSo"]);
                        xeQuaTram.CaTruc = RuntimeHelpers.GetObjectValue(dataRow["CaTruc"]);
                        xeQuaTram.GioQuaTram = Conversions.ToString(dataRow["GioQuaTram"]);
                        xeQuaTram.LanXe = Conversions.ToByte(dataRow["LanXe"]);
                        xeQuaTram.MSNV = Conversions.ToString(dataRow["MSNV"]);
                        xeQuaTram.NgayQuaTram = Conversions.ToString(dataRow["NgayQuaTram"]);
                        xeQuaTram.Phi = Conversions.ToLong(dataRow["Phi"]);
                        xeQuaTram.PLVe = Conversions.ToByte(dataRow["PLVe"]);
                        xeQuaTram.PLXeSau = Conversions.ToByte(dataRow["PLXeSau"]);
                        xeQuaTram.PLXeTruoc = Conversions.ToByte(dataRow["PLXeTruoc"]);
                        xeQuaTram.PTTT = Conversions.ToByte(dataRow["PTTT"]);
                        xeQuaTram.SoVe = Conversions.ToString(dataRow["SoVe"]);
                        xeQuaTram.TenHinhXe = Conversions.ToString(dataRow["TenHinhXe"]);
                        xeQuaTram.BSXeThangQui = Conversions.ToString(dataRow["BSXeThangQui"]);
                        if (xeQuaTram.LanXe <= 0)
                        {
                            CSDL.DeleteXeQuaTram(ModuleKhaiBaoConst.StrConnectMain, xeQuaTram.TenHinhXe);
                        }
                        else
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes(xeQuaTram.ToString());
                            socket.Send(bytes, bytes.Length, SocketFlags.None);
                            byte[] array2 = new byte[31];
                            int num = 0;
                            num = socket.Receive(array2, array2.Length, SocketFlags.None);
                            string @string = Encoding.ASCII.GetString(array2, 0, num);
                            CSDL.DeleteXeQuaTram(ModuleKhaiBaoConst.StrConnectMain, @string);
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
                goto end_IL_0000;
                IL_028c:
                end_IL_0000:;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public static void SendOldData_TienPhong()
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
                IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortDuLieuCuMain);
                string text = "";
                long phi = 0L;
                long num = 0L;
                long num2 = 0L;
                string bSXeThangQui = "";
                string text2 = "";
                DataTable dataTable = new DataTable();
                dataTable = CSDL.SelectXeQuaTram_TienPhong(ModuleKhaiBaoConst.StrConnectMain);
                socket.Connect(remoteEP);
                socket.ReceiveTimeout = 5000;
                IEnumerator enumerator = default(IEnumerator);
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator.Current;
                        XeQuaTram xeQuaTram = new XeQuaTram();
                        xeQuaTram.BienSo = Conversions.ToString(dataRow["BienSo"]);
                        xeQuaTram.CaTruc = RuntimeHelpers.GetObjectValue(dataRow["CaTruc"]);
                        xeQuaTram.GioQuaTram = Conversions.ToString(dataRow["GioQuaTram"]);
                        xeQuaTram.LanXe = Conversions.ToByte(dataRow["LanXe"]);
                        xeQuaTram.MSNV = Conversions.ToString(dataRow["MSNV"]);
                        xeQuaTram.NgayQuaTram = Conversions.ToString(dataRow["NgayQuaTram"]);
                        xeQuaTram.PLXeSau = 0;
                        xeQuaTram.PLXeTruoc = 0;
                        xeQuaTram.TenHinhXe = Conversions.ToString(dataRow["TenHinhXe"]);
                        text = (xeQuaTram.SoVe = Conversions.ToString(dataRow["SoVe"]));
                        int num3 = VeXe.LoaiVe(text);
                        int num4 = VeXe.PhanLoaiVe(text);
                        checked
                        {
                            xeQuaTram.PLVe = (byte)num4;
                            xeQuaTram.PTTT = (byte)num3;
                            switch (num3)
                            {
                                case 1:
                                    CSDL.SelectMenhGiaVe(ModuleKhaiBaoConst.StrConnectMain, Conversions.ToString(num4), ref phi, ref num, ref num2);
                                    xeQuaTram.Phi = phi;
                                    xeQuaTram.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
                                    break;
                                case 2:
                                    CSDL.TimBienSoTuVeThang(ModuleKhaiBaoConst.StrConnectMain, text, ref bSXeThangQui, ref text2);
                                    xeQuaTram.BSXeThangQui = bSXeThangQui;
                                    xeQuaTram.Phi = 0L;
                                    break;
                                case 11:
                                    xeQuaTram.Phi = 0L;
                                    xeQuaTram.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
                                    break;
                                default:
                                    xeQuaTram.Phi = 0L;
                                    xeQuaTram.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
                                    break;
                            }
                            byte[] bytes = Encoding.ASCII.GetBytes(xeQuaTram.ToString());
                            socket.Send(bytes, bytes.Length, SocketFlags.None);
                            byte[] array2 = new byte[31];
                            int num5 = 0;
                            num5 = socket.Receive(array2, array2.Length, SocketFlags.None);
                            string @string = Encoding.ASCII.GetString(array2, 0, num5);
                            CSDL.DeleteXeQuaTram_TienPhong(ModuleKhaiBaoConst.StrConnectMain, @string);
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
                goto end_IL_0000;
                IL_02f1:
                end_IL_0000:;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public static void SendTroGiup()
        {
            string text = "";
            string s = ModuleKhaiBaoConst.LanXeMain.ToString();
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
                IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortMayGiamSatMain);
                socket.Connect(remoteEP);
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                socket.Send(bytes, bytes.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }
    }
}
