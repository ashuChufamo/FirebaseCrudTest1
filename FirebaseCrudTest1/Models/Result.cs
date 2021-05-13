using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseCrudTest1.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public int Assessment { get; set; }
        public int Test { get; set; }
        public int Final { get; set; }
        public int Total { get; set; }
    }
}
