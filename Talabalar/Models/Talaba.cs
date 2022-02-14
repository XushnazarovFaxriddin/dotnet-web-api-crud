using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Talabalar.Models
{
    public class Talaba
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Range(typeof(int), "16", "70")]
        public int Age { get; set; }

        [Required]
        [MaxLength(90)]
        public string GropName { get; set; }

        [Range(typeof(int), "1", "6")]
        public int Course { get; set; }
    }
}
