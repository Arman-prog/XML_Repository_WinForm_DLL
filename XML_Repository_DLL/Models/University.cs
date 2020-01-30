using XML_Repository.Attributes;

namespace XML_Repository.Models
{
   public class University
    {
        [Id]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }        

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Address}";
        }
    }
}
