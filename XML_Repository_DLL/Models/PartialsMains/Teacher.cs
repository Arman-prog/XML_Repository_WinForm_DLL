using System;
using XML_Repository.Attributes;

namespace XML_Repository.Models
{
   public partial class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
      
        [DateFormat]
        public DateTime BirthDate { get; set; }
      
    }
}
