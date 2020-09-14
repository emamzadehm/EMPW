using System;

namespace Emamzadeh.Models
{
    public class History
    {
        public int Id { get; private set; }
        public string StudentName { get; private set; }
        public string StudentImg { get; private set; }
        public string CourseName { get; private set; }
        public string UniversityName { get; private set; }
        public int EduYear { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsVisible { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public History(string studentName, string studentImg, string courseName, string universityName, int eduYear, string title, string description)
        {
            StudentName = studentName;
            StudentImg = studentImg;
            CourseName = courseName;
            UniversityName = universityName;
            EduYear = eduYear;
            Title = title;
            Description = description;
            CreatedDate = DateTime.Now;
            IsVisible = false;
        }
    }
}
