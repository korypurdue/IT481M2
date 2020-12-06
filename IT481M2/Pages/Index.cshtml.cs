using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using IT481M2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace IT481M2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IT481M2.Data.RazorPagesNorthwindContext _context;

        public IndexModel(IT481M2.Data.RazorPagesNorthwindContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public IEnumerable<string> CustomerLastNames { get; set; }

        public int Count { get; set; }



        public async Task<IActionResult> OnGetAsync(string? id)
        {

            Count = await _context.Customers.CountAsync();

            CustomerLastNames = await _context.Customers.Select(customer => customer.ContactName).ToListAsync();

            return Page();
        }
    }
}
