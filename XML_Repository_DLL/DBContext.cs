using System.Collections.Generic;
using XML_Repository.Models;

namespace XML_Repository_DLL
{
    public class DBContext
    {
        public Dictionary<int, Student> Students { get; set; }
        public Dictionary<int, Teacher> Teachers { get; set; }
        public Dictionary<int, University> Universities { get; set; }
    }
}
