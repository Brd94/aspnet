using System;
using System.Collections.Generic;
using aspnet.Models.ViewModels;

namespace aspnet.Models.Services.Application
{
    public class CourseService : ICourseService
    {
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseViewModel> GetCourses()
        {
            var clist = new List<CourseViewModel>();

            for(int i=0;i<20;i++){
                CourseViewModel c = new CourseViewModel();
                c.Id = i;
                c.Tipo = "DTL " + i;    
                c.Img = "/VCP.png";    
                clist.Add(c);        
            }

            return clist;
        }

      
    }
}