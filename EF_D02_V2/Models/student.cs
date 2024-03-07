using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_D02_V2.Models
{
    internal class student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public int age { get; set; }

        [ForeignKey("dept")]
        public int D_Id { get; set; }

        public virtual Department dept { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
