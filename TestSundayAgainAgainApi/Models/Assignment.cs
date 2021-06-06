using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSundayAgainAgainApi.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        //FK
        public virtual Developer Developer { get; set; }
        public int DevloperId { get; set; }

        public virtual Project Project { get; set; }
        public int ProjectId { get; set; }

        public Assignment() { }

    }
}
