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
    
    public partial class Events_Reg_General_Online
    {
        public int RegistrationId { get; set; }
        public Nullable<int> EventId { get; set; }
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter the mobile no.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Please Give Valid Mobile No.")]
        [DataType(DataType.PhoneNumber)]

        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage ="Email is incorrect")]
        public string Email { get; set; }
    
        public virtual Events_General_Online Events_General_Online { get; set; }
    }
}
