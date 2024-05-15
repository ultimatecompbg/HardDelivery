using HardDelivery.Models.enums;
using System.ComponentModel.DataAnnotations;

namespace HardDelivery.Models
{
	public class Delivery
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public Status Status { get; set; }
		[Required] 
		public Address? Address { get; set; }
		[Required]
		public int CourierId { get; set; }
		[Required]
		public int SenderId { get; set; }
		[Required]
		public int ReceiverId { get; set; }
		[Required]
		public int DeliveryPrice { get; set; }
		public User Courier { get; set; }
		public User Sender { get; set; }
		public User Receiver { get; set; }


	}
}
