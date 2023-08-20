using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSEIDON.Models
{
    public class Consumer
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }
        [Display(Name = "Extension Name")]
        public string? Extension { get; set; }
        [Display(Name = "Account Number")]
        public string? AccountNo { get; set; }
        [Display(Name = "Street Address")]
        public string? Address { get; set; }
        [Display(Name = "Contact Number")]
        public string? ContactNo { get; set; }
        [Display(Name = "Job Title")]
        public string? JobTitle { get; set; }
        public string? Company { get; set; }
        [Display(Name = "Stand Pipe")]
        public string? StandPipe { get; set; }
        [Display(Name = "Meter Serial No.")]
        public string? MeterNo { get; set; }
        [Display(Name = "Latest Reading")]
        public int? LatestReading { get; set; }
        [Display(Name = "Is Senior Citizen")]
        public string? isSenior { get; set; }
        [Display(Name = "Senior ID #")]
        public string? SeniorIDNo { get; set; }
        [Display(Name = "Connection Date")]
        public DateTime? ConnectionDate { get; set; }
        public int? ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Classification Classification { get; set; }
        public int? ClusterId { get; set; }
        [ForeignKey("ClusterId")]
        public Cluster Cluster { get; set; }
        public int BrgyId { get; set; }
        [ForeignKey("BrgyId")]
        public Barangay Barangay { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public ConsumerStatus ConsumerStatus { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }

    }
}
