﻿using System;
using System.Collections.Generic;

namespace Web_11.Models
{
    public partial class Loaihinhanh
    {
        public Loaihinhanh()
        {
            Hinhanh = new HashSet<Hinhanh>();
            Taitro = new HashSet<Taitro>();
        }

        public string IdLoaiHinhAnh { get; set; }
        public string TenLoaiHinhAnh { get; set; }

        public virtual ICollection<Hinhanh> Hinhanh { get; set; }
        public virtual ICollection<Taitro> Taitro { get; set; }
    }
}
