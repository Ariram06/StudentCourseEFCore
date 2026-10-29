namespace CourseSystem.Models
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string Title { get; set; } 
        public decimal Fee { get; set; }
        public int MaxSeats { get; set; }
        public bool IsAvailable { get; set; }


        public Course(string a, string b, decimal c, int d, bool e)
        {
            CourseCode = a;
            Title = b;
            Fee = c;
            MaxSeats = d;
            IsAvailable = e;
        }
    }
}