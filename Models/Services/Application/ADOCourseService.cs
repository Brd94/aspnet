using System.Collections.Generic;
using System.Data;
using aspnet.Models.Services.Infrastructure;
using aspnet.Models.ViewModels;

namespace aspnet.Models.Services.Application
{
    public class ADOCourseService : ICourseService
    {
        private readonly IDataBaseAccessor idb;
        public ADOCourseService(IDataBaseAccessor idb)
        {
            this.idb = idb;

        }
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CourseViewModel> GetCourses()
        {
            string SQL = "SELECT * FROM COURSES";
            DataSet dataSet = idb.Query(SQL);
            throw new System.NotImplementedException();
        }
    }
}