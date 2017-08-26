using AForge.Video.FFMPEG;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tollcabin
{
    public class ClassTaoVideo
    {
        private const int SoHinhLonNhat = 25;

        private const int ChieuDai = 720;

        private const int ChieuCao = 576;

        private const int SoKhungHinh = 5;

        private bool _FlagLuuVideo;

        private int _SoKhungHinhHienTai;

        private string _DuongDanLuuVideo;

        private Bitmap[] _Hinh;

        public bool FlagLuuVideo
        {
            get
            {
                return this._FlagLuuVideo;
            }
            set
            {
                this._FlagLuuVideo = value;
            }
        }

        public int SoKhungHinhHienTai
        {
            get
            {
                return this._SoKhungHinhHienTai;
            }
        }

        public bool MaxFrame
        {
            get
            {
                return this.SoKhungHinhHienTai < 25;
            }
        }

        public string DuongDanLuuVideo
        {
            get
            {
                return this._DuongDanLuuVideo;
            }
            set
            {
                this._DuongDanLuuVideo = value;
            }
        }

        private Bitmap Hinh
        {
            get
            {
                if (_SoKhungHinhHienTai > 25)
                {
                    return new Bitmap(720, 576);
                }
                return this._Hinh[_SoKhungHinhHienTai];
            }
        }

        public void ThemHinh(Bitmap img)
        {
            checked
            {
                if (this._SoKhungHinhHienTai < 25)
                {
                    this._SoKhungHinhHienTai++;
                    this._Hinh[this._SoKhungHinhHienTai - 1] = img;
                }
                else if (img != null)
                {
                    img.Dispose();
                }
            }
        }

        public bool TaoVideo()
        {
            checked
            {
                bool result = false;
                try
                {
                    if (this._FlagLuuVideo)
                    {
                        this._FlagLuuVideo = false;
                        if (this._SoKhungHinhHienTai <= 0)
                        {
                            result = false;
                        }
                        else
                        {
                            VideoFileWriter videoFileWriter = new VideoFileWriter();
                            videoFileWriter.Open(this.DuongDanLuuVideo, 720, 576, 5);
                            int arg_4A_0 = 0;
                            int num = this._SoKhungHinhHienTai - 1;
                            for (int i = arg_4A_0; i <= num; i++)
                            {
                                if (this._Hinh[i] != null)
                                {
                                    try
                                    {
                                        videoFileWriter.WriteVideoFrame(this._Hinh[i]);
                                    }
                                    catch (Exception expr_67)
                                    {
                                        ProjectData.SetProjectError(expr_67);
                                        ProjectData.ClearProjectError();
                                    }
                                }
                            }
                            this._SoKhungHinhHienTai = 0;
                            this._Hinh = null;
                            videoFileWriter.Close();
                            GC.Collect();
                            result = true;
                        }
                    }
                }
                catch (Exception expr_9D)
                {
                    ProjectData.SetProjectError(expr_9D);
                    Exception ex = expr_9D;
                    ModuleKhac.SaveError(ex.Message, "LuuVideo");
                    ProjectData.ClearProjectError();
                }
                return result;
            }
        }

        public ClassTaoVideo()
        {
            this._Hinh = new Bitmap[321];
            this._SoKhungHinhHienTai = 0;
            this._FlagLuuVideo = true;
        }
    }
}
