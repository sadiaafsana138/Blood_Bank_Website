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
    
    public partial class TrasferTbl
    {
        public int TNum { get; set; }
        public int PNum { get; set; }
        public string BGroup { get; set; }
    
        public virtual BloodTbl BloodTbl { get; set; }
        public virtual PatientTbl PatientTbl { get; set; }
    }
}
