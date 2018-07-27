using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infrastructure.intefaces
{
    public interface IVideoCapture
    {
        event CaptureHandler CaptureComplete;
        void InitDevice(Control pn, string cameraIp = "");
        void Capture();
    }
}
