using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Infrastructure;
using Infrastructure.intefaces;

namespace CaptureTollCabinLib
{
    public class AxisCapture : IVideoCapture
    {

        private Control controlPanel;
        private string cameraIp { set; get; }
        
        private Mutex lockMute = new Mutex();

        public event CaptureHandler CaptureComplete;

        private bool IsManager { set; get; }

        public AxisCapture(bool isManager = false)
        {
            this.IsManager = isManager;
        }

        private void CaptureDone(Bitmap GetBmp)
        {
            if (GetBmp != null)
            {
                controlPanel.Invoke((Action) delegate {
                    controlPanel.BackgroundImage = GetBmp;
                });

                Bitmap imgs = new Bitmap(GetBmp);
                this.CaptureComplete?.Invoke(imgs);
            }
        }
        public void Capture()
        {
            DownloadImageFromUrl();
        }
        public void InitDevice(Control layoutControl,string cameraIp = "")
        {
            this.controlPanel = layoutControl;
            this.cameraIp = cameraIp;
        }


        private void DownloadImageFromUrl()
        {
            if (!this.IsManager)
            {
                using (var globalMutex = new Mutex(false, "Global\\{{2671848c-26d4-4ab1-942f-103f34a3fbbf}}"))
                {
                    try
                    {
                        if (Monitor.TryEnter(globalMutex))
                        {
                            Monitor.Exit(lockMute);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        //todo log
                    }
                }
            }

            if (!Monitor.TryEnter(lockMute))
            {
                return;
            }

            Image imagesDowload = null;
            HttpWebRequest ImageWebRequest;
            HttpWebResponse ImageWebResponse = null;
            Stream responseStream = null;
            try
            {
                //ImageWebRequest = (HttpWebRequest)WebRequest.Create("http://192.0.2.3/scapture");
                string strURLCaptureImage = "http://" + cameraIp + "/scapture";
                ImageWebRequest = (HttpWebRequest)WebRequest.Create(strURLCaptureImage);

                ImageWebRequest.AllowWriteStreamBuffering = true;
                ImageWebRequest.Timeout = 2000;

                ImageWebResponse = (HttpWebResponse)ImageWebRequest.GetResponse();
                responseStream = ImageWebResponse.GetResponseStream();

                imagesDowload = Image.FromStream(responseStream);

                ImageWebResponse.Close();


                CaptureDone((Bitmap)imagesDowload);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close connections

                //Release objects
                ImageWebRequest = null;
                ImageWebResponse = null;
                responseStream = null;

                Monitor.Exit(lockMute);
            }
        }
    }
}
