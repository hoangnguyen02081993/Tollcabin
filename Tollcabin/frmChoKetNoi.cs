using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tollcabin
{
    public partial class frmChoKetNoi : Form
    {

        public int TimeChoKetNoi;

        public frmChoKetNoi()
        {
            this.TimeChoKetNoi = 60;
            this.InitializeComponent();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.TimeChoKetNoi <= 0)
            {
                this.Close();
            }
            this.Label1.Text = "CHỜ KẾT NỐI DỮ LIỆU TRONG " + Conversions.ToString(this.TimeChoKetNoi) + " GIÂY";
            Control arg_88_0 = this.Label1;
            checked
            {
                Point location = new Point((int)Math.Round((double)(this.Width - this.Label1.Width) / 2.0), (int)Math.Round((double)(this.Height - this.Label1.Height) / 2.0));
                arg_88_0.Location = location;
                this.TimeChoKetNoi--;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
