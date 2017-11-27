using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Pass { get; set; }

        public Users()
        {
            
        }
    }
}
