using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyTrips.Pages
{
    public class TripsModel : PageModel
    {

        [BindProperty]
        public Trip MyTrip { get; set; }

        public class Trip
        {
            [Required(ErrorMessage = "Please enter value for {0}")]
            [StringLength(
                maximumLength: 100, MinimumLength = 3,
                ErrorMessage = "'{0}' must be at least {1} and maximum {2} characters")]
            [Display(Name = "Destination")]
            public string Destination { get; set; }

            [Required(ErrorMessage = "Please enter value for {0}")]
            [Display(Name = "Travel date")]
            public DateTime? TravelDate { get; set; }

            [Required(ErrorMessage = "Please enter value for {0}")]
            [Range(
                10.00, 10000.00, 
                ErrorMessage = "'{0}' must be between [{1} - {2}]")]
            [Display(Name = "Ticket price")]
            public decimal? TicketPrice { get; set; }
        }

        public void OnGet()
        {

        }

    }
}