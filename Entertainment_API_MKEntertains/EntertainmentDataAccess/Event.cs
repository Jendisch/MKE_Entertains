//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntertainmentDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int Id { get; set; }
        public Nullable<int> LocationId { get; set; }
        public System.DateTime Date { get; set; }
        public string EventDescription { get; set; }
        public string TimeConstraint { get; set; }
    
        public virtual Location Location { get; set; }
    }
}