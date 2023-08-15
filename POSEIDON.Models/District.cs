using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.Models
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="City/Municipality")]
        public string? Name { get; set; }
        public int ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        [ValidateNever]
        public Province? Province { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? deleted_at { get; set; }
    }
}
