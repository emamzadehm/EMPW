using System.Collections.Generic;
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
            return _emcontext.Files.Where(x => x.TypeID == typeid).ToList();
        }
    }
}
