using System;


namespace Emamzadeh.Models
{
    public class Message
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public Message(string name, string email, string title, string description)
        {
            Name = name;
            Email = email;
            Title = title;
            Description = description;
            CreatedDate = DateTime.Now;
        }
    }
}
