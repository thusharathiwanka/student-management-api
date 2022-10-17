using System;
using student_management.Models.Interfaces;

namespace student_management.Models
{
    public class StudentStoreDatabaseSettings: IStudentStoreDatabaseSettings
    {
        public StudentStoreDatabaseSettings() {}

        public string StudentCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}

