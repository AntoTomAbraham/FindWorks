using System;

namespace studentFreelance.Models
{
    public class Chat
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
