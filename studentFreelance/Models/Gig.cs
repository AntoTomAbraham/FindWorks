using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Gig
    {
        [Key]
        public int gidId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string title { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string desc { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public int amount { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string email { get; set; }

    }
}
