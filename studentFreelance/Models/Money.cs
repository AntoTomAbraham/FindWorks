using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace studentFreelance.Models
{
    public class Money
    {
        [Key]
        public Guid payid { get; set; }
        public String frID { get; set; }
        public String cliID { get; set; }
        public DateTime date { get; set; }
        public String companyTransffered { get; set; }
    }
}
