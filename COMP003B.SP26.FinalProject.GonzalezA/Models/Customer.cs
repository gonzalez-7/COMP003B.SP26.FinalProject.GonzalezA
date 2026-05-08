using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP26.FinalProject.GonzalezA.Models
{
	public class Customer
	{
		public int CustomerId { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }


		[Required]
		[StringLength(20)]
		public string PhoneNumber {  get; set; }


		[Required]
		[StringLength(50)]
		public string Email { get; set; }

		[StringLength(150)]
		public string Notes { get; set; }

		public virtual ICollection<Appointment>? Appointments { get; set; }
	}
}
