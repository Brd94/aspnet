using System.Collections.Generic;
using aspnet.Models.ViewModels;

namespace aspnet.Models.Services.Application
{
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();
        CourseDetailViewModel GetCourse(int id);
    }
}