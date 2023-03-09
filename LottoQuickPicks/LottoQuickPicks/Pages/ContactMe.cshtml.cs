using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace LottoQuickPicks.Pages
{
    public class ContactMeModel : PageModel
    {
        [BindProperty]
        public string? ContactName { get; set; }
        [BindProperty]
        public string? ContactEmail { get; set; }
        [BindProperty]
        public string? ContactComments { get; set; }
        [BindProperty]
        public bool? SubscribeToMail { get; set; }

        
        public string InfoMessage { get; private set; }

        public string ErrorMessage { get; private set; }

        public void OnPostMessage()
        {
            string subscribeToMail = (SubscribeToMail is null) ? "Yes" : "No";
            InfoMessage = $"Name: {ContactName} <br />" + $"Email: {ContactEmail} <br />" + $"Comments: {ContactComments}" + $"Subscribe to mail: {subscribeToMail}";
        }
        public IActionResult OnPostClear()
        {

            return RedirectToPage();
        }
        public void OnGet()
        {
        }
    }
}
