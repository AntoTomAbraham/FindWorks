using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Client
    {
        [Key]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string phno { get; set; }
    }
}
