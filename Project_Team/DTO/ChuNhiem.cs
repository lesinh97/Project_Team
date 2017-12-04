using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class ChuNhiem
    {
        [Key]
        public string MaGiaoVien { get; set; }
        [Required]
        public string TenGiaoVien { get; set; }
        public virtual ICollection<Lop> Lops { get; set; }
        public ChuNhiem()
        {
            
        }
    }
}
