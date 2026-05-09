using COMP003B.SP26.FinalProject.GonzalezA.Data;
using COMP003B.SP26.FinalProject.GonzalezA.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.SP26.FinalProject.GonzalezA.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BarberServicesApiController : Controller
	{
		private readonly ApplicationDbContext _context;

		public BarberServicesApiController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<List<BarberService>> GetBarberServices()
		{
			return Ok(_context.BarberServices.ToList());
		}

		[HttpGet("{id:int}")]
		public ActionResult<BarberService> GetBarberService([FromRoute] int id)
		{
			var barberService = _context.BarberServices.FirstOrDefault(s => s.BarberServiceId == id);

			if (barberService == null)
			{
				return NotFound();
			}

			return Ok(barberService);
		}

		[HttpPost]
		public ActionResult<BarberService> CreateBarberService([FromForm] BarberService barberService)
		{
			_context.BarberServices.Add(barberService);
			_context.SaveChanges();

			return CreatedAtAction(nameof(GetBarberService), new { id = barberService.BarberServiceId }, barberService);
		}

		[HttpPut("{id:int}")]
		public ActionResult UpdateBarberService([FromRoute] int id, BarberService barberService)
		{
			var existingService = _context.BarberServices.FirstOrDefault(s => s.BarberServiceId == id);

			if (existingService == null)
			{
				return NotFound();
			}

			existingService.ServiceName = barberService.ServiceName;
			existingService.Description = barberService.Description;
			existingService.Price = barberService.Price;
			existingService.EstimatedMinutes = barberService.EstimatedMinutes;

			_context.SaveChanges();

			return NoContent();
		}


		[HttpDelete("{id:int}")]
		public IActionResult DeleteBarberService([FromRoute] int id)
		{
			var barberService = _context.BarberServices.FirstOrDefault(s => s.BarberServiceId == id);


			if (barberService == null)
			{
				return NotFound();
			}

			_context.BarberServices.Remove(barberService);
			_context.SaveChanges();

			return NoContent();
		}
	}
}
