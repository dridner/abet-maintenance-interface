//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentLearningObjectives
    {
        public StudentLearningObjectives()
        {
            this.StudentLearningObjectivesRevisions = new HashSet<StudentLearningObjectivesRevisions>();
        }
    
        public int SLOId { get; set; }
    
        public virtual StudentLearningObjectivesRevisions CurrentRevision { get; set; }
        public virtual ICollection<StudentLearningObjectivesRevisions> StudentLearningObjectivesRevisions { get; set; }
    }
}
