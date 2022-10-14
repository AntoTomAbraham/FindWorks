using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Bids
    {
        [Key]
        public Guid bid { get; set; }
        public Guid prID { get; set; }

        public string FRemail { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public int deadline { get; set; }

        [Column(TypeName = "nvarchar(200)")]

        public int amount { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string desc { get; set; }
    }
}
