using DirectX.Capture;
using DShowNET;
using Infrastructure.intefaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tollcabin
{
    public class VideoCapture : IVideoCapture
    {
        private Capture capture;
        private Filters filters;
        public event Infrastructure.CaptureHandler CaptureComplete;
        public void Capture()
        {
            this.capture.GrapImg();
        }
        private void CaptureDone(Bitmap GetBmp)
        {
            if (GetBmp != null)
            {
                Bitmap imgs = new Bitmap(GetBmp);
                this.CaptureComplete?.Invoke(imgs);
            }
        }
        public void InitDevice(Control control, string cameraIp = "")
        {
            try
            {
                this.filters = new Filters();
                Filter audioDevice = null;
                Filter filter = this.filters.VideoInputDevices[0];
                if (filter != null)
                {
                    this.capture = new Capture(filter, audioDevice, false);
                    try
                    {
                        this.capture.AllowSampleGrabber = true;
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.VideoSource = this.capture.VideoSources[1];
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.dxUtils.VideoStandard = AnalogVideoStandard.PAL_B;
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.FrameRate = 29.97000002997;
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.FrameSize = new Size(720, 576);
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.PreviewFrameSize = new Size(720, 576);
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.capture.PreviewWindow = control;
                    }
                    catch
                    {
                    }
                    this.capture.FrameEvent2 += new Capture.HeFrame(this.CaptureDone);
                }
            }
            catch
            {
            }
        }
    }
}
