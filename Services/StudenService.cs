using BITool16550.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITool16550.Services
{
    class StudenService
    {
        public void Save(Student student)
        {
            Repository.Students.Add(student);
        }

        public List<Student> Get()
        {
            return Repository.Students;
        }
    }
}
