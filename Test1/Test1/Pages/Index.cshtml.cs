using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Test1.DBContext; // Import the correct namespace
using System.Collections.Generic;
using System.Linq;

namespace Test1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CardProductsDBContext _context; // Add this

        public IndexModel(ILogger<IndexModel> logger, CardProductsDBContext context) // Add CardProductsDBContext to the constructor
        {
            _logger = logger;
            _context = context; // Store the context
        }

        public List<CardProducts> CardProducts { get; set; } // Add this property

        public void OnGet()
        {
            CardProducts = _context.CardContent.ToList(); // Retrieve card products from the database
        }
    }
}
