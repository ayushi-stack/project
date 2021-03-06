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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Employee_Events_Registration
    {
        public int Registration_ID { get; set; }
        public Nullable<int> Event_ID { get; set; }
        [Required(ErrorMessage ="Please fill the Employee ID")]
        public Nullable<int> Emp_ID { get; set; }
        [Required(ErrorMessage="Please Enter the mobile no.")]
           [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [MinLength(10,ErrorMessage ="Please Give Valid Mobile No.")]
        [MaxLength(10, ErrorMessage = "Please Give Valid Mobile No.")]
        [DataType(DataType.PhoneNumber)]
     
        public string Mobile_no { get; set; }
    
        public virtual Employee_Data Employee_Data { get; set; }
        public virtual Events_General_Online Events_General_Online { get; set; }
    }
}
