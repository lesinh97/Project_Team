using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Lecturers
    {
        [Key]
        public int Lecturers_ID { get; set; }
        [Required]
        public string Lecturer_name { get; set; }
        [Required]
        public int Major_ID { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        [ForeignKey("Major_ID")]
        public virtual Major Major { get; set; }

        public Lecturers()
        {
            
        }
    }
}
