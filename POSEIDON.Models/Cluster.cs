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
    public class Cluster
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Cluster Name")]
        public string? Name { get; set; }
        public int BarangayId { get; set; }
        [ForeignKey("BarangayId")]
        [ValidateNever]
        public Barangay Barangay { get; set; }
        public string? Code { get; set; }
        public string? Status { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
    }
}
