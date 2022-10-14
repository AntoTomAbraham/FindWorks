using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Allocate
    {
        [Key]
        public Guid allId { get; set; }
        public Guid prID { get; set; }

        public string FRemail { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public int deadline { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public string status { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public DateTime dealDate { get; set; }
        public int amount { get; set; }
    }
}
