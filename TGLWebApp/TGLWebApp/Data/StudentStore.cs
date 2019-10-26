using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGLWebApp.Models;

namespace TGLWebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();
        public StudentStore()
        {
            Students.Add(new Student
            {
                
                Age = 17,
                Name = "Juan Pablo",
                LastName = "Hincapie",
                Nit = "1039472642",
            });

            Students.Add(new Student
            {
                
                Age = 17,
                Name = "Jacobo",
                LastName = "Lopera",
                Nit = "xxx",
            });

            Students.Add(new Student
            {
                
                Age = 17,
                Name = "Manuela",
                LastName = "Rojas",
                Nit = "xxx",
            });
            
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }
    }
}
