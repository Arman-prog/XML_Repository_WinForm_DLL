using System;
using XML_Repository.Attributes;
using XML_Repository_DLL.Attributes;

namespace XML_Repository.Models
{
    public class Student
    {
        [Id]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        [Ignore]
        public string FullName => $"{FirstName} {Lastname}";
        [DateFormat]
        public DateTime BirthDate { get; set; }

        [AgeIgnore]
        public int Age
        {
            get
            {
                TimeSpan age = DateTime.Now - BirthDate;
                return age.Days / 365;
            }
        }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{Lastname}\t{Age}";
        }



    }
}
