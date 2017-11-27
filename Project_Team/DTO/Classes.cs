using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Classes
    {
        [Key]
        public int Class_ID { get; set; }
        [Required]
        public int Major_ID { get; set; }
        [Required]
        public string Class_name { get; set; }
        public virtual ICollection<Alumnus> Alumni { get; set; }
        [ForeignKey("Major_ID")]
        public virtual Major Major { get; set; }

        public Classes()
        {
            
        }
    }
}
