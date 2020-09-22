using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Emamzadeh.Models
{
    public class DBOperations
    {
        private readonly EMContext _emcontext;
        
        public DBOperations(EMContext eMContext)
        {
            _emcontext = eMContext;
        }
        public List<Testimonial> TestimonialList()
        {
            return _emcontext.Testimonials.Where(x=>x.IsVisible==true).ToList();
        }
        public List<Resume> ResumesList()
        {
            return _emcontext.Resumes.OrderBy(x=>x.Id).ToList();
        }
        public List<Course> CoursesList()
        {
            return _emcontext.Courses.OrderByDescending(x => x.Id).ToList();
        }
        public Professor GetProfessor()
        {
            return _emcontext.Professors.FirstOrDefault(x => x.Id == 1);
        }
        public List<File> FilesList(int typeid)
        {
            return _emcontext.Files.Where(x => x.FileTypeId == typeid).ToList();
            //return allfiles.Select(files => new File
            //{
            //    Id = files.Id,
            //    Title = files.Title,
            //    FileTypeId = files.FileTypeId,
            //    Description = files.Description,
            //    FileName = files.FileName,
            //    UploadDate = files.UploadDate
            //    var 
            //}).ToList();

            ////FileInfo fi = new FileInfo(fileName);

        }
        public File GetFileBy(int fileid)
        {
            return _emcontext.Files.FirstOrDefault(x => x.Id == fileid);
        }

        public void AddTestimonial(Testimonial testimonial)
        {
            var newtestimonial = new Testimonial(testimonial.StudentName, testimonial.StudentImg, testimonial.StudentEmail, testimonial.CourseName, testimonial.UniversityName, testimonial.EduYear, testimonial.Title, testimonial.Description);
            _emcontext.Testimonials.Add(newtestimonial);
            Save();
        }
        public void AddMessage(Message message)
        {
            var newmessage = new Message(message.Name, message.Email, message.Title, message.Description);
            _emcontext.Messages.Add(newmessage);
            Save();
        }
        public void Save()
        {
            _emcontext.SaveChanges();
        }
    }
}
