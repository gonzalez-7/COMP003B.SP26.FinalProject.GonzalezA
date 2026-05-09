using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.GonzalezA.Models
{
	public class Barber
	{
		public int BarberId { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }


		[Required]
		[StringLength(20)]
		public string PhoneNumber { get; set; }


		[Required]
		[StringLength(30)]
		public string Specialty { get; set; }

		[Range(0, 40)]
		public int YearsExperience { get; set; }

		public virtual ICollection<Appointment>? Appointments { get; set; }
	}
}
