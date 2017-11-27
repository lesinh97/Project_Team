using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Alumnus
    {
        [Key]
        public int Student_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Hometown { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public int Class_ID { get; set; }
        [Required]
        public string Year_Grad { get; set; }
        
        public string Image { get; set; }
        [ForeignKey("Class_ID")]
        public virtual Classes Classes { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }

        public Alumnus()
        {
            
        }


    }
}
