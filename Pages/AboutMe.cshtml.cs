using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebsite.Pages
{
    public class AboutMeModel : PageModel
    {
        public void OnGet()
        {
            // Date and time shamelessly stolen from this website: https://abundantcode.com/c-program-how-to-calculate-age-based-on-datetime/
            var birthday = new DateTime(1998, 09, 09); // Store my birthday in YYYY MM DD
            var todayDate = DateTime.Today.Year - birthday.Year; // Subtract today's date from my birthday
            if (birthday.Date > DateTime.Today.AddYears(-todayDate)) todayDate--; // uhhhh magic??

            ViewData["CallumDOB"] = todayDate; // Store todayDate in CallumDOB for use in HTML
        }
    }
}
