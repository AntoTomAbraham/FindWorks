using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentFreelance.Models
{
    public class AddgigViewmodel
    {
        public string title { get; set; }
       
        public string desc { get; set; }
        
        public int amount { get; set; }
       
        public string email { get; set; }
    }
}
