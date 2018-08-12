using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyTrips.Resources;

namespace MyTrips.Pages
{
    public class TripsModel : PageModel
    {
        public class Trip
        {
            [Required(
                ErrorMessageResourceName = nameof(MyDataAnnotations.Required),
                ErrorMessageResourceType = typeof(MyDataAnnotations))]
            [StringLength(maximumLength: 100, MinimumLength = 3,
                ErrorMessageResourceName = nameof(MyDataAnnotations.StringLength),
                ErrorMessageResourceType = typeof(MyDataAnnotations))]
            [Display(
                Name = nameof(MyDataAnnotations.Destination), 
                ResourceType = typeof(MyDataAnnotations))]
            public string Destination { get; set; }

            [Required(
                ErrorMessageResourceName = nameof(MyDataAnnotations.Required),
                ErrorMessageResourceType = typeof(MyDataAnnotations))]
            [Display(
                Name = nameof(MyDataAnnotations.TravelDate),
                ResourceType = typeof(MyDataAnnotations))]
            public DateTime? TravelDate { get; set; }

            [Required(
                ErrorMessageResourceName = nameof(MyDataAnnotations.Required),
                ErrorMessageResourceType = typeof(MyDataAnnotations))]
            [Range(10.00, 10000.00,
                ErrorMessageResourceName = nameof(MyDataAnnotations.Range),
                ErrorMessageResourceType = typeof(MyDataAnnotations))]
            [Display(
                Name = nameof(MyDataAnnotations.TicketPrice),
                ResourceType = typeof(MyDataAnnotations))]
            public decimal? TicketPrice { get; set; }
        }

        [BindProperty]
        public Trip MyTrip { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}