using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;


namespace studentFreelance.Models
{
    public class Project
    {
        [Key]
        public Guid prID { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string title { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public string desc { get; set; }

        [Column(TypeName = "nvarchar(200)")]

        public int amount { get; set; }
        [Column(TypeName = "nvarchar(200)")]

        public int deadline { get; set; }

        [Column(TypeName = "nvarchar(20)")]

        public string status { get; set; }

        public string email { get; set; }

    }
}
