using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP___Project.models
{
    class Course_Student
    {
        public int Id { get; set; }
        public int Course_Id { get; set; }
        public int Student_Id { get; set; }
        public int Student_Mark { get; set; }
        public int Student_Attendance { get; set; }
        public int Teacher_Id { get; set; }
    }
}
