

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Flat  
    {
        [Key]
        public int FlatId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public string FlatOwnerName { get; set; }
        public string FlatNo { get; set; }
        public string FlatType { get; set; }
        public string FlatLocation { get; set; } //bulunduğu kat
        public string BlockNo { get; set; }
        public bool Status { get; set; }
    }
}
