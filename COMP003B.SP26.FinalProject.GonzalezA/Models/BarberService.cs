using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.GonzalezA.Models
{
	public class BarberService
	{
		public int BarberServiceId { get; set; }

		[Required]
		[StringLength (30)]
		public string ServiceName { get; set; }

		[Required]
		[StringLength(100)]
		public string Description { get; set; }


		[Range(1, 150)]
		public int Price { get; set; }


		[Range(10, 120)]
		public int EstimatedMinutes { get; set; }

		public virtual ICollection<Appointment>? Appointments { get; set; }

	}
}
