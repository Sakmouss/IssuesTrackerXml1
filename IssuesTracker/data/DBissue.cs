//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssuesTracker.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBissue
    {
        public int issueId { get; set; }
        public string issueSumup { get; set; }
        public string issueDescription { get; set; }
        public Nullable<System.DateTime> identifiedDate { get; set; }
        public int relatedProjectId { get; set; }
        public string assignedPerson { get; set; }
        public Nullable<System.DateTime> resolutionTargetDate { get; set; }
        public string issueProgression { get; set; }
        public Nullable<System.DateTime> actualResolutionDate { get; set; }
        public string resolutionSumup { get; set; }
    
        public virtual DBproject DBproject { get; set; }
    }
}