//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookReviewMVC2018.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckinLog
    {
        public int CheckInLogKey { get; set; }
        public int ReviewerKey { get; set; }
        public System.DateTime CheckinDateTime { get; set; }
    
        public virtual Reviewer Reviewer { get; set; }
    }
}
