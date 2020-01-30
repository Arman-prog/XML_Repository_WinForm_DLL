using System.Collections.Generic;
using XML_Repository.Models;

namespace XML_Repository_DLL
{
    public class DbContext
    {
        private Dictionary<int, Student> Students { get; set; }
        private Dictionary<int, Teacher> Teachers { get; set; }
        private Dictionary<int, University> Universities { get; set; }
    }
}
