using System.ComponentModel.DataAnnotations;

namespace HardDelivery.Models
{
	public class Payment
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public User Receiver { get; set; }
		[Required]
		public User Sender { get; set; }
		[Required]
		public int Sum { get; set; }
	}
}
