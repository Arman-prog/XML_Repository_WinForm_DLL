using XML_Repository.Attributes;

namespace XML_Repository.Models
{
   public partial class University
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }        
               
    }
}
