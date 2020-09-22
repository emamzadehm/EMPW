

namespace Emamzadeh.Models
{
    public class Resume
    {
        public int Id { get; private set; }
        public string FromYear { get; private set; }
        public string ToYear { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        protected Resume()
        {

        }
        public Resume(string fromYear, string toYear, string title, string description)
        {
            FromYear = fromYear;
            ToYear = toYear;
            Title = title;
            Description = description;
        }
    }
}
