namespace AxisCaptureManager
{
    partial class AxisManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PicVideo = new System.Windows.Forms.PictureBox();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.ntfIco = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnExit = new System.Windows.Forms.Button();
            this.TStart = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TbIp = new System.Windows.Forms.TextBox();
            this.ChbAutoRun = new System.Windows.Forms.CheckBox();
            this.TCapture = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicVideo
            // 
            this.PicVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicVideo.Location = new System.Drawing.Point(12, 12);
            this.PicVideo.MaximumSize = new System.Drawing.Size(421, 238);
            this.PicVideo.MinimumSize = new System.Drawing.Size(421, 238);
            this.PicVideo.Name = "PicVideo";
            this.PicVideo.Size = new System.Drawing.Size(421, 238);
            this.PicVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVideo.TabIndex = 0;
            this.PicVideo.TabStop = false;
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(266, 256);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(81, 40);
            this.BtnStartStop.TabIndex = 1;
            this.BtnStartStop.Text = "Start";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // ntfIco
            // 
            this.ntfIco.BalloonTipText = "Chương trình đang chạy trong nền...";
            this.ntfIco.BalloonTipTitle = "Thông báo";
            this.ntfIco.Text = "Axis capture manager";
            this.ntfIco.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NtfIco_MouseDoubleClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(353, 256);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(81, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TStart
            // 
            this.TStart.Tick += new System.EventHandler(this.TStart_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera IP:";
            // 
            // TbIp
            // 
            this.TbIp.Location = new System.Drawing.Point(93, 259);
            this.TbIp.Name = "TbIp";
            this.TbIp.Size = new System.Drawing.Size(155, 20);
            this.TbIp.TabIndex = 3;
            this.TbIp.TextChanged += new System.EventHandler(this.TbIp_TextChanged);
            // 
            // ChbAutoRun
            // 
            this.ChbAutoRun.AutoSize = true;
            this.ChbAutoRun.Location = new System.Drawing.Point(93, 281);
            this.ChbAutoRun.Name = "ChbAutoRun";
            this.ChbAutoRun.Size = new System.Drawing.Size(161, 17);
            this.ChbAutoRun.TabIndex = 4;
            this.ChbAutoRun.Text = "Tự động chạy khi khởi động";
            this.ChbAutoRun.UseVisualStyleBackColor = true;
            this.ChbAutoRun.CheckedChanged += new System.EventHandler(this.ChbAutoRun_CheckedChanged);
            // 
            // TCapture
            // 
            this.TCapture.Enabled = true;
            this.TCapture.Interval = 33;
            this.TCapture.Tick += new System.EventHandler(this.TCapture_Tick);
            // 
            // AxisManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 308);
            this.Controls.Add(this.ChbAutoRun);
            this.Controls.Add(this.TbIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.PicVideo);
            this.Name = "AxisManager";
            this.Text = "AxisManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AxisManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PicVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicVideo;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.NotifyIcon ntfIco;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer TStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIp;
        private System.Windows.Forms.CheckBox ChbAutoRun;
        private System.Windows.Forms.Timer TCapture;
    }
}