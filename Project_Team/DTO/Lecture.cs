using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Lecture
    {
        [Key]
        public int Lecture_ID { get; set; }
        [Required]
        public string Lecture_name { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public int Student_ID { get; set; }
        [Required]
        public int Lecturers_ID { get; set; }
        [Required]
        public float Exe_mark { get; set; }
        [Required]
        public float Mid_mark { get; set; }
        [Required]
        public float End_mark { get; set; }
        [Required]
        public float Avg_mark { get; set; }
        [ForeignKey("Student_ID")]
        public virtual Alumnus Alumnus { get; set; }
        [ForeignKey("Lecturers_ID")]
        public virtual Lecturers Lecturer { get; set; }

        public Lecture()
        {
            
        }
    }
}
