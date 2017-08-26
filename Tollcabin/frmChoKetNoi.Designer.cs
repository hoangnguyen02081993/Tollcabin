using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Tollcabin
{
    partial class frmChoKetNoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.components != null)
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmChoKetNoi));
            this.Timer1 = new Timer(this.components);
            this.Label1 = new Label();
            this.SuspendLayout();
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += Timer1_Tick;
            this.Label1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
            this.Label1.ForeColor = Color.Yellow;
            this.Label1.Click += Label1_Click;
            this.Label1.Location = new Point(300, 293);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0, 33);
            this.Label1.TabIndex = 0;
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            this.ClientSize = new Size(945, 619);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.ico.GetHicon());
            this.Name = "frmChoKetNoi";
            this.Text = "frmChoKetNoi";
            this.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        Timer Timer1;
        private Label Label1;
        #endregion
    }
}