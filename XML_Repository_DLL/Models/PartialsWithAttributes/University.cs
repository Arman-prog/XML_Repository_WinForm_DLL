

namespace XML_Repository.Models
{
   public partial class University
    {
        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Address}";
        }
    }
}
