using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP___Project.Models
{
    class Student_Session
    {
        public int Id { get; set; }
        public int Session_Id { get; set; }
        public int Student_Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
    }
}
