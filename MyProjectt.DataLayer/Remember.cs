//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProjectt.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Remember
    {
        public int RememberID { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime RememberDate { get; set; }
        public byte IsRead { get; set; }
        public int UserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
