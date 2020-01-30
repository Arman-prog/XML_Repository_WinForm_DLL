using XML_Repository.Models;

namespace XML_Repository
{
    public class TeacherRepository : BaseRepository<Teacher>
    {
        public TeacherRepository(string filename):base(filename)
        {

        }
       
    }
}
