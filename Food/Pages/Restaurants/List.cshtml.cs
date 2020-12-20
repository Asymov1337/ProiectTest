using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeFood.Core;
using OdeFood.Data;

namespace Food.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestauratData restauratData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, 
                         IRestauratData restauratData)
        {
            this.config = config;
            this.restauratData = restauratData;
        }
        public void OnGet()
        {


            Message = config["Message"];
            Restaurants = restauratData.GetRestaurantsByName(SearchTerm);
        }
    }
}