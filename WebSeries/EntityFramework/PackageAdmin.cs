//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSeries.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PackageAdmin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PackageAdmin()
        {
            this.Customers = new HashSet<Customer>();
            this.Packages = new HashSet<Package>();
        }
    
        public int PAId { get; set; }

        [Required(ErrorMessage = "Please enter  Nmae")]
        [MaxLength(10, ErrorMessage = "maximum 9 characters")]
        [RegularExpression("^[a-zA-Z- ]+$", ErrorMessage = "Enter Only Alphabate")]
        public string PAName { get; set; }

        [Required(ErrorMessage = "Please enter  Password")]
        [MaxLength(8, ErrorMessage = "maximum 8 characters")]
        public string PAPassword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
    }
}
