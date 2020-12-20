using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeFood.Core;
using OdeFood.Data;

namespace Food.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestauratData restauratData;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestauratData restauratData)
        {
            this.restauratData = restauratData;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restauratData.GetById(restaurantId);
            if(Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}