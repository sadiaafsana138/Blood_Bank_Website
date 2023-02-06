//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBank.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PatientTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientTbl()
        {
            this.TrasferTbls = new HashSet<TrasferTbl>();
        }
        [Display(Name = "Serial Number of Patients")]
        public int PNum { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string PName { get; set; }
        [Required]
        [Display(Name = "Age")]
        public int PAge { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PPhone { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Sex")]
        public string PGender { get; set; }
        [Required]
        [Display(Name = "Blood Group")]
        public string PBGroup { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string PAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrasferTbl> TrasferTbls { get; set; }
    }
}
