//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Student_Course = new HashSet<Student_Course>();
        }
    
        public int CID { get; set; }
        public string CName { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
        public Nullable<int> TID { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Course> Student_Course { get; set; }
    }
}
