using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyUnion.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Player Name")]
        public string PlayerName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Ground")]
        public string BirthDate { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Height { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("FoundedYear")]
        public string Weight { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Region")]
        public string PlaceofBirth { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CreateTime { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string IsActive { get; set; }
    }
}
