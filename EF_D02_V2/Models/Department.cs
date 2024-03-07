using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_D02_V2.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string name { get; set; }
       

        public virtual ICollection<student> Students  { get;}
    }
}
