//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ramen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ramen()
        {
            this.details = new HashSet<detail>();
        }
    
        public int ramenId { get; set; }
        public int meatId { get; set; }
        public string ramenName { get; set; }
        public string ramenBorth { get; set; }
        public string ramenPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail> details { get; set; }
        public virtual meat meat { get; set; }
    }
}
