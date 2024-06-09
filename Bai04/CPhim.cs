using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04

{
    internal class CPhim
    {
        public struct CPhong
        {
            public string TenPhong { get; set; }
            public string[] suat { get; set; }
            public CPhong(string tenPhong, string[] suat)
            {
                TenPhong = tenPhong;
                this.suat = suat;
            }
            public CPhong()
            {
                TenPhong = "";
                suat = new[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
            }
            public string ImageUrl { get; set; }
        }


        public string TenPhim { get; set; }
        public List<CPhong> Phong { get; set; }
        public long GiaVe { get; set; }
        public long TongTien { get; set; }
        public int Rank { get; set; }
        public string ImageUrl { get; set; }
        public CPhim()
        {
            TenPhim = string.Empty;
            Phong = new List<CPhong>();
            GiaVe = 0;
            TongTien = 0;
            Rank = -1;
            ImageUrl = string.Empty;
        }
        ~CPhim()
        {

        }
    }
}
