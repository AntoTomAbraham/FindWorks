using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Payment
    {
        public string from { get; set; }
        public string to { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string amount { get; set; }

        public Guid prID { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string paymentMethod { get; set; }




    }
}
