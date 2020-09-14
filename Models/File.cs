using System;

namespace Emamzadeh.Models
{
    public class File
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string FileName { get; private set; }
        public string FileAddress { get; private set; }
        public string Description { get; private set; }
        public DateTime UploadDate { get; private set; }
        public int TypeID { get; private set; }
        public FileType FileTypes { get; private set; }

        public File(string title, string fileName, string fileAddress, string description, int typeID)
        {
            Title = title;
            FileName = fileName;
            FileAddress = fileAddress;
            Description = description;
            TypeID = typeID;
            UploadDate = DateTime.Now;
        }
    }
}
