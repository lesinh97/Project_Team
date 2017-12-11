using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class KetQua
    {
        [Column(Order = 0), Key]
        public string MaMonHoc { get; set; }
        [ForeignKey("MaMonHoc")]
        public virtual MonHoc MonHoc { get; set; }
        [Column(Order = 1), Key]
        public int MaSinhVien { get; set; }
        [ForeignKey("MaSinhVien")]
        public virtual SinhVien SinhVien { get; set; }
        public double DiemTrungBinh { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKi { get; set; }
        public double DiemCuoiKi { get; set; }
        public string DiemChu { get; set; }
    }
}
