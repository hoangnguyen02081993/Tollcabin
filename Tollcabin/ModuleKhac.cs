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
using System.Threading.Tasks;
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
            catch (Exception expr_3E)
            {
                ProjectData.SetProjectError(expr_3E);
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
            catch (Exception expr_81)
            {
                ProjectData.SetProjectError(expr_81);
                Exception ex = expr_81;
                ModuleKhac.SaveError(ex.Message, "SaveJpgAs");
                ProjectData.ClearProjectError();
            }
        }

        public static void PingGiamSat(string strData)
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
                    byte[] bytes = Encoding.ASCII.GetBytes(strData);
                    socket.Send(bytes, bytes.Length, SocketFlags.None);
                    ModuleKhaiBaoConst.StatusConnectGiamSatMain = true;
                }
                catch (Exception expr_7E)
                {
                    ProjectData.SetProjectError(expr_7E);
                    ModuleKhaiBaoConst.StatusConnectGiamSatMain = false;
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static int CatrucHienTai()
        {
            string text = "";
            string right = "";
            string left = Strings.Format(DateAndTime.Now, "HH:mm:ss");
            int num = 1;
            checked
            {
                while (true)
                {
                    if (CSDL.SelectThoiGianCatruc(ModuleKhaiBaoConst.StrConnectMain, Conversions.ToString(num), ref text, ref right))
                    {
                        if (Operators.CompareString(text, right, false) < 0)
                        {
                            if (Operators.CompareString(left, text, false) >= 0 & Operators.CompareString(left, right, false) <= 0)
                            {
                                break;
                            }
                        }
                        else if ((Operators.CompareString(left, text, false) >= 0 & Operators.CompareString(left, "23:59:59", false) <= 0) | (Operators.CompareString(left, "00:00:00", false) >= 0 & Operators.CompareString(left, right, false) <= 0))
                        {
                            return num;
                        }
                    }
                    num++;
                    if (num > 4)
                    {
                        return 0;
                    }
                }
                return num;
            }
        }

        public static bool KiemTraNhanVienDangTruc(ref string MaNV)
        {
            string text = "";
            string s = "";
            string arg_1C_0 = ModuleKhaiBaoConst.StrConnectMain;
            checked
            {
                int num = 0;
                byte b = (byte)num;
                bool arg_24_0 = CSDL.SelectNhanVienDangTruc(arg_1C_0, ref text, ref b, ref s);
                num = (int)b;
                if (!arg_24_0)
                {
                    return false;
                }
                int num2;
                try
                {
                    num2 = (int)Math.Round((DateAndTime.Now - DateTime.Parse(s)).TotalMinutes);
                }
                catch (Exception expr_4B)
                {
                    ProjectData.SetProjectError(expr_4B);
                    num2 = 1000;
                    ProjectData.ClearProjectError();
                }
                if (num2 < 600 && num == ModuleKhac.CatrucHienTai())
                {
                    MaNV = text;
                    return true;
                }
                return false;
            }
        }

        public static void PingNhanDang(PictureBox pb)
        {
            checked
            {
                try
                {
                    byte[] array = new byte[1025];
                    string text = "PING";
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayNhanDangMain);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array2 = addressList;
                    IPAddress address = null;
                    for (int i = 0; i < array2.Length; i++)
                    {
                        IPAddress iPAddress = array2[i];
                        if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            address = iPAddress;
                            break;
                        }
                    }
                    IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortMayNhanDangMain);
                    socket.Connect(remoteEP);
                    byte[] bytes = Encoding.ASCII.GetBytes(text);
                    socket.Send(bytes, bytes.Length, SocketFlags.None);
                    socket.ReceiveTimeout = 2000;
                    int length = socket.Receive(array, array.Length, SocketFlags.None);
                    text = Encoding.ASCII.GetString(array, 0, array.Length).Substring(0, length);
                    if (Operators.CompareString(text.ToUpper(), "OK", false) == 0)
                    {
                        // Hoang comment pb.Image = Resources.Network11;
                        pb.BackColor = Color.White;
                        return;
                    }
                }
                catch (Exception expr_F7)
                {
                    ProjectData.SetProjectError(expr_F7);
                    ProjectData.ClearProjectError();
                }
                // Hoang comment pb.Image = Resources.Network21;
                pb.BackColor = Color.Black;
            }
        }

        public static void SaveError(string ThongTin, string TenFile)
        {
            try
            {
                string text = "ErrorLog\\" + DateAndTime.Now.ToString("yyyyMMdd");
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                FileStream fileStream = new FileStream(string.Concat(new string[]
                {
                    text,
                    "\\",
                    TenFile,
                    "-",
                    DateAndTime.Now.ToString("HHmmssfff"),
                    ".xml"
                }), FileMode.Create, FileAccess.ReadWrite);
                DataTable dataTable = new DataTable("save");
                dataTable.Columns.Add("ThongTin", Type.GetType("System.String"));
                DataRow dataRow = dataTable.NewRow();
                dataRow["ThongTin"] = ThongTin;
                dataTable.Rows.Add(dataRow);
                dataTable.WriteXml(fileStream);
                fileStream.Close();
            }
            catch (Exception expr_D4)
            {
                ProjectData.SetProjectError(expr_D4);
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
            catch (Exception expr_1C7)
            {
                ProjectData.SetProjectError(expr_1C7);
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public static string KetNoi(string DataSource, string InitialCatalog, string UserID, string PassID)
        {
            string text = "Data Source = " + DataSource;
            text = text + "; Initial Catalog = " + InitialCatalog;
            text = text + "; User ID = " + UserID;
            text = text + "; PWD = " + PassID;
            text += "; Integrated Security =False";
            text += "; Connect Timeout = 2";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = text;
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception expr_66)
            {
                ProjectData.SetProjectError(expr_66);
                string result = null;
                ProjectData.ClearProjectError();
                return result;
            }
            return text;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            checked
            {
                DirectoryInfo[] directories;
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
                    directories = directoryInfo.GetDirectories();
                    if (!directoryInfo.Exists)
                    {
                        return;
                    }
                    if (!Directory.Exists(destDirName))
                    {
                        Directory.CreateDirectory(destDirName);
                    }
                    FileInfo[] files = directoryInfo.GetFiles();
                    FileInfo[] array = files;
                    for (int i = 0; i < array.Length; i++)
                    {
                        FileInfo fileInfo = array[i];
                        try
                        {
                            string text = Path.Combine(destDirName, fileInfo.Name);
                            if (!File.Exists(text))
                            {
                                fileInfo.CopyTo(text, false);
                            }
                            File.Delete(fileInfo.FullName);
                        }
                        catch (Exception expr_6D)
                        {
                            ProjectData.SetProjectError(expr_6D);
                            ProjectData.ClearProjectError();
                        }
                    }
                }
                catch (Exception expr_8C)
                {
                    ProjectData.SetProjectError(expr_8C);
                    ProjectData.ClearProjectError();
                    return;
                }
                if (copySubDirs)
                {
                    DirectoryInfo[] array2 = directories;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        DirectoryInfo directoryInfo2 = array2[j];
                        string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
                        ModuleKhac.DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
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
                                catch (Exception expr_113)
                                {
                                    ProjectData.SetProjectError(expr_113);
                                    ProjectData.ClearProjectError();
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void DirectoryCopyVideo(string sourceDirName, string destDirName, bool copySubDirs)
        {
            checked
            {
                DirectoryInfo[] directories;
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
                    directories = directoryInfo.GetDirectories();
                    if (!directoryInfo.Exists)
                    {
                        return;
                    }
                    if (!Directory.Exists(destDirName))
                    {
                        Directory.CreateDirectory(destDirName);
                    }
                    FileInfo[] files = directoryInfo.GetFiles();
                    try
                    {
                        FileInfo[] array = files;
                        for (int i = 0; i < array.Length; i++)
                        {
                            FileInfo fileInfo = array[i];
                            string text = Path.Combine(destDirName, fileInfo.Name);
                            try
                            {
                                if (!File.Exists(text))
                                {
                                    fileInfo.CopyTo(text, false);
                                }
                                File.Delete(fileInfo.FullName);
                            }
                            catch (Exception expr_6D)
                            {
                                ProjectData.SetProjectError(expr_6D);
                                ProjectData.ClearProjectError();
                            }
                        }
                    }
                    catch (Exception expr_8C)
                    {
                        ProjectData.SetProjectError(expr_8C);
                        ProjectData.ClearProjectError();
                    }
                }
                catch (Exception expr_9B)
                {
                    ProjectData.SetProjectError(expr_9B);
                    ProjectData.ClearProjectError();
                    return;
                }
                if (copySubDirs)
                {
                    try
                    {
                        DirectoryInfo[] array2 = directories;
                        for (int j = 0; j < array2.Length; j++)
                        {
                            DirectoryInfo directoryInfo2 = array2[j];
                            string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
                            ModuleKhac.DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
                            FileInfo[] files2 = new DirectoryInfo(directoryInfo2.FullName).GetFiles();
                            if (files2.Length == 0)
                            {
                                DirectoryInfo[] directories2 = new DirectoryInfo(directoryInfo2.FullName).GetDirectories();
                            }
                        }
                    }
                    catch (Exception expr_117)
                    {
                        ProjectData.SetProjectError(expr_117);
                        ProjectData.ClearProjectError();
                    }
                }
            }
        }

        public static void CoppyHinhAnhLenServer()
        {
            ModuleKhac.DirectoryCopy(ModuleKhaiBaoConst.LocalImagesPathMain, ModuleKhaiBaoConst.ServerImagesPathMain, true);
        }

        public static void CoppyVideoLenServer()
        {
            ModuleKhac.DirectoryCopyVideo("VIDEO\\", "Z:\\", true);
        }

        public static void SendOldData()
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
                    IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortDuLieuCuMain);
                    DataTable dataTable = new DataTable();
                    dataTable = CSDL.SelectXeQuaTram(ModuleKhaiBaoConst.StrConnectMain);
                    socket.Connect(remoteEP);
                    socket.ReceiveTimeout = 5000;
                    IEnumerator enumerator = null;
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
                                int count = socket.Receive(array2, array2.Length, SocketFlags.None);
                                string @string = Encoding.ASCII.GetString(array2, 0, count);
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
                }
                catch (Exception expr_28E)
                {
                    ProjectData.SetProjectError(expr_28E);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static void SendOldData_TienPhong()
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
                    IPEndPoint remoteEP = new IPEndPoint(address, ModuleKhaiBaoConst.PortDuLieuCuMain);
                    long phi = 0L;
                    long num = 0L;
                    long num2 = 0L;
                    string bSXeThangQui = "";
                    string text = "";
                    DataTable dataTable = new DataTable();
                    dataTable = CSDL.SelectXeQuaTram_TienPhong(ModuleKhaiBaoConst.StrConnectMain);
                    socket.Connect(remoteEP);
                    socket.ReceiveTimeout = 5000;
                    IEnumerator enumerator = null;
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
                            string text2 = Conversions.ToString(dataRow["SoVe"]);
                            xeQuaTram.SoVe = text2;
                            int num3 = (int)VeXe.LoaiVe(text2);
                            int num4 = (int)VeXe.PhanLoaiVe(text2);
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
                                    CSDL.TimBienSoTuVeThang(ModuleKhaiBaoConst.StrConnectMain, text2, ref bSXeThangQui, ref text);
                                    xeQuaTram.BSXeThangQui = bSXeThangQui;
                                    xeQuaTram.Phi = 0L;
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:
                                case 9:
                                case 10:
                                    goto IL_25F;
                                case 11:
                                    xeQuaTram.Phi = 0L;
                                    xeQuaTram.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
                                    break;
                                default:
                                    goto IL_25F;
                            }
                        IL_274:
                            byte[] bytes = Encoding.ASCII.GetBytes(xeQuaTram.ToString());
                            socket.Send(bytes, bytes.Length, SocketFlags.None);
                            byte[] array2 = new byte[31];
                            int count = socket.Receive(array2, array2.Length, SocketFlags.None);
                            string @string = Encoding.ASCII.GetString(array2, 0, count);
                            CSDL.DeleteXeQuaTram_TienPhong(ModuleKhaiBaoConst.StrConnectMain, @string);
                            continue;
                        IL_25F:
                            xeQuaTram.Phi = 0L;
                            xeQuaTram.BSXeThangQui = ModuleKhaiBaoConst.EnumStrNull.BienSoNull;
                            goto IL_274;
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
                catch (Exception expr_2F3)
                {
                    ProjectData.SetProjectError(expr_2F3);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public static void SendTroGiup()
        {
            string s = ModuleKhaiBaoConst.LanXeMain.ToString();
            checked
            {
                try
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPHostEntry hostEntry = Dns.GetHostEntry(ModuleKhaiBaoConst.IPMayGiamSatMain);
                    IPAddress[] addressList = hostEntry.AddressList;
                    IPAddress[] array = addressList;
                    IPAddress address = null ;
                    for (int i = 0; i < array.Length; i++)
                    {
                        IPAddress iPAddress = array[i];
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
                catch (Exception expr_8E)
                {
                    ProjectData.SetProjectError(expr_8E);
                    ProjectData.ClearProjectError();
                }
            }
        }
    }
}
