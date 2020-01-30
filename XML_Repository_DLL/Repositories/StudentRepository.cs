using XML_Repository.Models;

namespace XML_Repository
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(string filename):base(filename)
        {

        }

       

    }
}
