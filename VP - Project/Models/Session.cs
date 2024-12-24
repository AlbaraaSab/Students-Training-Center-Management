using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP___Project.Models
{
    class Session
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int Status { get; set; }
        public int Staff_Id { get; set; }
        public int Course_Id { get; set; }
    }
}
