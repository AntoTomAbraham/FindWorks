using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Communication
    {
        [Key]
        public Guid chatId { get; set; }

        public string sendemail { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public string receiveemail { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public DateTime sendDate { get; set; }

        public string message { get; set; }
    }
}
