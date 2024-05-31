using Demo.Models;
using Demo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository _repository;

        [BindProperty]
        public int DriverId { get; set; }

        [BindProperty]
        public double Latitude { get; set; }

        [BindProperty]
        public double Longitude { get; set; }

        public Store[] test { get; set; }
        
        public int Total {  get; set; }
        public long ExecutionTime { get; set; }
        public IndexModel(IRepository repository)
        {
            _repository=repository;


        }

        public async Task OnGetAsync()
        {
            await Stores();
            var stopwatch = Stopwatch.StartNew();
            await getTotal();
            stopwatch.Stop();
            ExecutionTime = stopwatch.ElapsedMilliseconds;

        }
        public async Task Stores()
        {
            test = await _repository.getStore();
        }

        public async Task getTotal()
        {
            Total = await _repository.GetSaleDtlCountAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //var driver = await _context.Drivers.FindAsync(DriverId);
            //if (driver == null)
            //{
            //    return NotFound();
            //}

            //driver.Latitude = Latitude;
            //driver.Longitude = Longitude;
            //_context.Drivers.Update(driver);
            //await _context.SaveChangesAsync();

            return Page();
        }
    }
}
