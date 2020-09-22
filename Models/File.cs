using System;
using System.IO;

namespace Emamzadeh.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public long FileLenght { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
        public int FileTypeId { get; set; }

        public File()
        {

        }

        public File(string title, string fileName, string description, int fileTypeId)
        {
            Title = title;
            FileName = new FileInfo(fileName).Name;
            FileExtention = new FileInfo(fileName).Extension;
            FileLenght = new FileInfo(fileName).Length;
            Description = description;
            FileTypeId = fileTypeId;
            UploadDate = DateTime.Now;
        }

    }
}
