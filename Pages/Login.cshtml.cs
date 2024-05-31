using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.Pages
{
    public class LoginModel : PageModel
    {
        public string? Message { get; set; }
        [BindProperty] public string? user_id { get; set; }
        [BindProperty] public string? password { get; set; }
        public string ReturnUrl { get; set; }
        public LoginModel()
        {
        }

        public void OnGet()
        {

        }
    }
}
