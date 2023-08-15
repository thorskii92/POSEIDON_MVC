using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.Models
{
    public class Classification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Classification")]
        public string? Name { get; set; }
        [Display(Name = "Class Code")]
        public string? Code { get; set; }
        public bool isBulk { get; set; }
       
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        [ValidateNever]
        public District District { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }

    }
}
