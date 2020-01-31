using System;
using XML_Repository;
using XML_Repository.Models;

namespace Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //StudentRepository strep = new StudentRepository(@"Data\Student.xml");
            //var stlist = strep.AsEnumerable().ToList();
            //Console.WriteLine("students");
            //foreach (var st in stlist)
            //{
            //    Console.WriteLine(st);
            //}
            //strep.RemoveAT(2);
            StudentRepository repository = new StudentRepository(@"Data\Student.xml");

            //List<Student> stlist2 = new List<Student>
            //{
            //    new Student{BirthDate=DateTime.Now.AddYears(-18),FirstName="Simon",Lastname="Gevorgyan"},
            //    new Student{BirthDate=DateTime.Now.AddYears(-19),FirstName="Arshak",Lastname="Vardanyan"},
            //    new Student{BirthDate=DateTime.Now.AddYears(-20),FirstName="Anna",Lastname="Kirakosyan"},
            //};

            //repository.AddRange(stlist2);
            repository.Add(new Student
            {
                BirthDate = DateTime.Now.AddYears(-18),
                FirstName = "Nunufar",
                Lastname = "Gevorgyan"               
            });
            repository.Add(new Student
            {
                BirthDate = DateTime.Now.AddYears(-19),
                FirstName = "Artavazd",
                Lastname = "Vardanyan"
            });
            repository.Add(new Student
            {
                BirthDate = DateTime.Now.AddYears(-20),
                FirstName = "Vladimir",
                Lastname = "Kirakosyan"              
            });
            repository.RemoveAT(1);
        }
    }
}
