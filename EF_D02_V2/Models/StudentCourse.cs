using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_D02_V2.Models
{
    internal class StudentCourse
    {
        public int StdId { get; set; }
        public int CourseId { get; set;}

        public virtual student Std { get; set; }
        public virtual Course Course { get; set; }
    }
}
