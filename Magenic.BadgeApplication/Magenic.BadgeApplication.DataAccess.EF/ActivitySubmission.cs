//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivitySubmission
    {
        public int ActivitySubmissionId { get; set; }
        public int ActivityId { get; set; }
        public string EmployeeADName { get; set; }
        public string SubmissionDescription { get; set; }
        public string SubmissionApprovedADName { get; set; }
        public System.DateTime SubmissionDate { get; set; }
        public int SubmissionStatusId { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ItemStatu ItemStatu { get; set; }
    }
}
