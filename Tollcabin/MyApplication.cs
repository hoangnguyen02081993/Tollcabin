using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Tollcabin.My;

namespace Tollcabin
{
    [GeneratedCode("MyTemplate", "8.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {

        public MyApplication() : base(AuthenticationMode.Windows)
        {
            this.IsSingleInstance = true;
            this.EnableVisualStyles = true;
            this.SaveMySettingsOnExit = true;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = MyProject.Forms.frmMain;
        }
    }
}
