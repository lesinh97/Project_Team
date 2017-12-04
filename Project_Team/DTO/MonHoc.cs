using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class MonHoc
    {
        [Key]
        public string MaMonHoc { get; set; }
        [Required]
        public string TenMonHoc { get; set; }
        [Required]
        public int TinChi { get; set; }
        public MonHoc()
        {
            
        }
    }
}
