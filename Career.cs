//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITcompany.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Career
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Career()
        {
            this.job_applications = new HashSet<job_applications>();
        }
    
        public int job_id { get; set; }
        public string job_title { get; set; }
        public string job_location { get; set; }
        public int experience { get; set; }
        public string minimum_qualification { get; set; }
        public string job_category { get; set; }
        public int total_vacancies { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<job_applications> job_applications { get; set; }
    }
}
