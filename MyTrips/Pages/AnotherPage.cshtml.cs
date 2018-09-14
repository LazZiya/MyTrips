using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace MyTrips.Pages
{
    public class AnotherPageModel : PageModel
    {
        public AnotherPageModel()
        {
        }

        [BindProperty]
        [Display(Name ="Sample title")]
        [Required(ErrorMessage = "Don't miss this one!")]
        public string SampleTitle { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            
        }
    }
}