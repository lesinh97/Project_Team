using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Major
    {
        [Key]
        public int Major_ID { get; set; }
        [Required]
        public string Major_name { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ICollection<Lecturers> Lecturers { get; set; }

        public Major()
        {
            
        }
    }
}
