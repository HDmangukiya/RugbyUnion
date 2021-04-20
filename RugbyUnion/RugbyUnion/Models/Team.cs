﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RugbyUnion.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Team Name")]
        public string TeamName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Ground")]
        public string Ground { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Coach { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("FoundedYear")]
        public string FoundedYear { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Region")]
        public string Region { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CreateTime { get; set; }
    }
}
