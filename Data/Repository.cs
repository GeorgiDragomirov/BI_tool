using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITool16550.Data
{
    static class Repository
    {
        public static List<Student> Students { get; set; }
        static Repository()
        {
            Students = new List<Student>();

        }
    }
}
