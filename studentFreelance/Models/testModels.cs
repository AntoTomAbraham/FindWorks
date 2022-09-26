using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class testModels
    {
        [Key]
        public Guid ID { get; set; }
        public int point { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string email { get; set; }
        public DateTime DateOfSubmission { get; set; }


    }
}
