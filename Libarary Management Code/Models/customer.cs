//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libarary_Management_Code.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class customer
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Nullable<int> Duration { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? EnrollDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime? LastPaymentDate { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Nullable<int> Fees { get; set; }
        [Required]
        public Nullable<int> PaymentDone { get; set; }
        public Nullable<int> DueAmount { get; set; }
    }
}
