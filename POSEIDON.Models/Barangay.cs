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
    public class Barangay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Barangay")]
        public string? Name { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        [ValidateNever]
        public District District { get; set; }
        public int PlantId { get; set; }
        [ForeignKey("PlantId")]
        [ValidateNever]
        public Plant Plant { get; set; }
        public string? BarangayCode { get; set; }
        public string? LocationType { get; set; }
        public string? Status { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
    }
}
