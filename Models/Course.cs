namespace Emamzadeh.Models
{
    public class Course
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        protected Course()
        {

        }
        public Course(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
