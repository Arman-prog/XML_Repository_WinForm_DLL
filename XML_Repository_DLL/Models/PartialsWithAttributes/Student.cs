using System;
using XML_Repository.Attributes;

namespace XML_Repository.Models
{
    public partial class Student
    {
        [Ignore]
        public string FullName => $"{FirstName} {Lastname}";
        [Ignore]
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
