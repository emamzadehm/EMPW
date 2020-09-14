namespace Emamzadeh.Models
{
    public class FileType
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Img { get; private set; }

        public FileType(string title, string img)
        {
            Title = title;
            Img = img;
        }
    }
}
