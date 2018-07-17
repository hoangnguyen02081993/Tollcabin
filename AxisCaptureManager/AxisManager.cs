using CaptureTollCabinLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxisCaptureManager
{
    public partial class AxisManager : Form
    {
        Mutex globalMutex = new Mutex(false, "Global\\{{2671848c-26d4-4ab1-942f-103f34a3fbbf}}");

        private AxisCapture axisCapture = null;
        private ConfigManager configManager = null;

        private bool IsClose { set; get; }

        private bool IsStart { set; get; } = false;
        private bool IsShow { set; get; } = true;

        public AxisManager()
        {
            InitializeComponent();
            this.Load += AxisManager_Load;
        }

        private void AxisManager_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.video.GetHicon());
            this.ntfIco.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.video.GetHicon());
            this.axisCapture = new AxisCapture(true);

            this.configManager = new ConfigManager();
            this.configManager.Load();

            this.TbIp.Text = this.configManager.CameraIp;
            this.ChbAutoRun.Checked = this.configManager.IsAutoRun;
            if(this.configManager.IsAutoRun)
            {
                if (this.CheckNetWork(this.TbIp.Text))
                {
                    this.StartCapture();
                    this.TStart.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Camera Ip không đúng. Vui lòng chọn lại", "Axis manager - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HideToTraceBar()
        {
            this.IsShow = false;
            this.Hide();
            this.ntfIco.Visible = true;
            this.ntfIco.ShowBalloonTip(3000);
        }
        private void ShowFormWithNotifyIco()
        {
            this.IsShow = true;
            this.Show();
            this.ntfIco.Visible = false;
        }
        private void StartCapture()
        {
            if (!this.IsStart)
            {
                try
                {
                    if (!globalMutex.WaitOne(2000, false))
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình khởi động.", "Axis manager - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //todo log
                    MessageBox.Show("Có lỗi xảy ra trong quá trình khởi động.", "Axis manager - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.BtnStartStop.Text = "Kết thúc";
                this.axisCapture.InitDevice(PicVideo, this.TbIp.Text);
                this.IsStart = true;
                this.TbIp.Enabled = false;
                this.ChbAutoRun.Enabled = false;
            }
        }
        private void StopCapture()
        {
            if (this.IsStart)
            {
                try
                {
                    globalMutex.ReleaseMutex();
                }
                catch (Exception ex)
                {
                    //todo log
                }

                this.BtnStartStop.Text = "Bắt đầu";
                this.IsStart = false;
                this.PicVideo.BackgroundImage = Properties.Resources.noplay;
                this.TbIp.Enabled = true;
                this.ChbAutoRun.Enabled = true;
            }
        }

        private void NtfIco_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowFormWithNotifyIco();
        }

        private void AxisManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!IsClose)
            {
                e.Cancel = true;
                this.HideToTraceBar();
            }
            try
            {
                globalMutex.ReleaseMutex();
            }
            catch (Exception ex)
            {
                //todo log
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            IsClose = true;
            this.Close();
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if(this.IsStart)
            {
                this.StopCapture();
            }
            else
            {
                if (this.CheckNetWork(this.TbIp.Text))
                {
                    this.StartCapture();
                }
                else
                {
                    MessageBox.Show("Camera Ip không đúng. Vui lòng chọn lại", "Axis manager - Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TStart_Tick(object sender, EventArgs e)
        {
            this.TStart.Enabled = false;
            this.HideToTraceBar();
        }

        private void TbIp_TextChanged(object sender, EventArgs e)
        {
            this.configManager.CameraIp = TbIp.Text;
            this.configManager.Save();
        }

        private void ChbAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            this.configManager.IsAutoRun = ChbAutoRun.Checked;
            this.configManager.Save();
        }

        private bool CheckNetWork(string address)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(address);

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void TCapture_Tick(object sender, EventArgs e)
        {
            try
            {
                if(!IsStart || !IsShow)
                {
                    return;
                }
                TCapture.Enabled = false;
                this.axisCapture.Capture();
            }
            catch(Exception ex)
            {
                //todo log
            }
            finally
            {
                TCapture.Enabled = true;
            }
        }
    }
}
