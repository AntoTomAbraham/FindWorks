using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class freelancer
    {
        [Key]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string skill { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string phno { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string balance { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string college { get; set; }
    }
}