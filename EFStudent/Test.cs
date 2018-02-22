using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudent
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        [Required] [MaxLength(50)]
        public string TestName { get; set; }
        [Required]
        public decimal Score { get; set; }
        [Required]

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}
