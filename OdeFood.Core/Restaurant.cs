using System;
using System.Collections.Generic;
using System.Text;

namespace OdeFood.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Locatie { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
