using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyUnion.Models
{
    public class UnionAdmin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Location { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
