using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Plant Name")]
        public string? Name { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        [ValidateNever]
        public District District { get; set; }
        [Required]
        public string? Status { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
    }
}
