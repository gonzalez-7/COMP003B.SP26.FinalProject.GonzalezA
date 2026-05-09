using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.GonzalezA.Models
{
	public class Payment
	{
		public int PaymentId { get; set; }

		public int AppointmentId { get; set; }


		[Range(1, 200)]
		public int Amount { get; set; }

		[Required]
		[StringLength(15)]
		public string PaymentMethod { get; set; }

		[Required]
		[StringLength(25)]
		public string PaymentStatus { get; set; }

		public bool IsPaid { get; set; }

		public virtual Appointment? Appointment { get; set; }
	}
}
