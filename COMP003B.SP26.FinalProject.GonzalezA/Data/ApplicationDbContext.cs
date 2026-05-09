using COMP003B.SP26.FinalProject.GonzalezA.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.SP26.FinalProject.GonzalezA.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Barber> Barbers { get; set; }

		public DbSet<BarberService> BarberServices { get; set; }

		public DbSet<Appointment> Appointments { get; set; }

		public DbSet<Payment> Payments { get; set; }
	}
}
