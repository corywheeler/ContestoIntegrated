using System;
using System.Collections.Generic;

namespace ContestoIntegrated.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
