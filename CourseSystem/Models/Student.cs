using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSystem.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public string StdId { get; set; }
        public int Age { get; set; }
        public string PhoneNo { get; set; }

       public  Student(string a,string b,int c,string d)
        {
            Name = a;StdId = b;Age = c;PhoneNo = d;
        }

    }
}
