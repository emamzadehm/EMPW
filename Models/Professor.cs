

namespace Emamzadeh.Models
{
    public class Professor
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Family { get; private set; }
        public string Level { get; private set; }
        public string ImgAddress { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public string LinkedInURL { get; private set; }

        public Professor(string name, string family, string level, string imgAddress, string tel, string email, string address, string linkedInURL)
        {
            Name = name;
            Family = family;
            Level = level;
            ImgAddress = imgAddress;
            Tel = tel;
            Email = email;
            Address = address;
            LinkedInURL = linkedInURL;
        }
    }
}
