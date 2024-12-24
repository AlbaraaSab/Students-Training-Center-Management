using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP___Project.models
{
    //Model for manager/employee/teacher
    class Staff
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Position { get; set; }

    }
}
