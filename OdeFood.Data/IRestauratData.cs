using OdeFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeFood.Data
{
    public interface IRestauratData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestauratData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData ()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Michele", Locatie = "Targu Ocna", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 2, Name = "Tratoria", Locatie = "Onesti", Cuisine = CuisineType.Italian},
                new Restaurant{Id = 3, Name = "Snobish", Locatie = "Bacau", Cuisine = CuisineType.Mexican}
            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetRestaurantsByName( string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

    }
}
