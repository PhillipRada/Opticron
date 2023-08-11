using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Test1.Pages
{
    public class AdminCMSModel : PageModel
    {
        [BindProperty]
        public string ImagePath { get; set; }

        [BindProperty]
        public string TextContent { get; set; }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
          
            return RedirectToPage("/AdminCMS");
        }
    }
}
