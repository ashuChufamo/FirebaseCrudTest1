using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseCrudTest1.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public int SectionId { get; set; }
        public int ClassRoomId { get; set; }
        public string Username { get; set; }
    }
}
