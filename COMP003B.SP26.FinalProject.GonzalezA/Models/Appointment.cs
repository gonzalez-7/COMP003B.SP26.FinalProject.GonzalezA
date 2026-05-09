using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.GonzalezA.Models
{
	public class Appointment
	{
		public int AppointmentId { get; set; }

		public int CustomerId { get; set; }

		public int BarberId { get; set; }

		public int BarberServiceId { get; set; }


		[Required]
		[StringLength(20)]
		public string AppointmentDate { get; set; }

		[Required]
		[StringLength(20)]
		public string AppointmentTime { get; set; }

		public bool IsConfirmed { get; set; }

		public virtual Customer? Customer { get; set; }

		public virtual Barber? Barber { get; set; }

		public virtual BarberService? BarberService { get; set; }

		public virtual ICollection<Payment>? Payments { get; set; }

	}
}
