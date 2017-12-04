using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Lop
    {
        [Key]
        public string MaLop { get; set; }
        [Required]
        public string TenLop { get; set; }
        [Required]
        public string MaKhoa { get; set; }
        [Required]
        public string MaGiaoVien { get; set; }
        [ForeignKey("MaKhoa")]
        public virtual Khoa Khoa { get; set; }
        [ForeignKey("MaGiaoVien")]
        public virtual ChuNhiem ChuNhiem { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }

        public Lop()
        {
            
        }
    }
}
