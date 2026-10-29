
using System;

namespace StudentCourseSystem.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }

        public int StudentId { get; set; }

        public string CourseCode { get; set; }

        public DateTime RegistrationDate { get; set; }

        public decimal FeeAtRegistration { get; set; }

        public string Status { get; set; } = "Active";

        public Registration(int a,int b,string c,DateTime d,decimal e,string f)
        {
            RegistrationId = a;
            StudentId = b;
            CourseCode = c;
            RegistrationDate = d;
            FeeAtRegistration = e;
            Status = f;
        }
    }
}
