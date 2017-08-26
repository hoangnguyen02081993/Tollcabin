using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tollcabin.My;

namespace Tollcabin
{
    [DesignerGenerated]
    public partial class Form1 : Form
    {

        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = new EventHandler(this.Button1_Click);
                if (this._Button1 != null)
                {
                    this._Button1.Click -= value2;
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += value2;
                }
            }
        }

        [DebuggerNonUserCode]
        public Form1()
        {
            base.Load += new EventHandler(this.Form1_Load);
            this.InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string userID = "";
            string passID = "";
            string initialCatalog = "";
            string str = "";
            string arg_79_0 = MyProject.Application.Info.DirectoryPath + "\\TollcabinConfig.xml";
            int lanXeMain = (int)ModuleKhaiBaoConst.LanXeMain;
            bool arg_86_0 = ModuleKhac.ReadConfig(arg_79_0, ref initialCatalog, ref userID, ref passID, ref lanXeMain, ref ModuleKhaiBaoConst.IPMayGiamSatMain, ref ModuleKhaiBaoConst.IPMayNhanDangMain, ref ModuleKhaiBaoConst.LocalImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathMain, ref ModuleKhaiBaoConst.ServerImagesPathBSMain, ref ModuleKhaiBaoConst.PortDuLieuChinhMain, ref ModuleKhaiBaoConst.PortDuLieuCuMain, ref ModuleKhaiBaoConst.PortGiupDoMain, ref ModuleKhaiBaoConst.PortMayNhanDangMain, ref ModuleKhaiBaoConst.TramIdMain, ref ModuleKhaiBaoConst.StatusMain, ref str);
            ModuleKhaiBaoConst.LanXeMain = checked((byte)lanXeMain);
            if (!arg_86_0)
            {
                Interaction.MsgBox("Không đọc được file TollcabinConfig.xml", MsgBoxStyle.OkOnly, null);
                ProjectData.EndApp();
            }
            ModuleKhaiBaoConst.StrConnectMain = ModuleKhac.KetNoi(Dns.GetHostName() + str, initialCatalog, userID, passID);
            if (Operators.CompareString(ModuleKhaiBaoConst.StrConnectMain, null, false) == 0)
            {
                ModuleKhaiBaoConst.StrConnectMain = ModuleKhac.KetNoi(Dns.GetHostName() + str, initialCatalog, userID, passID);
                if (Operators.CompareString(ModuleKhaiBaoConst.StrConnectMain, null, false) == 0)
                {
                    //using (frmChoKetNoi formcho = new frmChoKetNoi())
                    {
                        //formcho.ShowDialog();
                        Interaction.MsgBox("Không kết nối được cơ sở dữ liệu", MsgBoxStyle.OkOnly, null);
                        Application.Exit();
                        return;
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
