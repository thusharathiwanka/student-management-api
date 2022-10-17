using System;
using student_management.Models;

namespace student_management.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Delete(string id);
    }


}

