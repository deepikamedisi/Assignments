using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
    {
        new Country { id = 1, Countryname = "India", Capital = "Delhi" },
        new Country { id = 2, Countryname = "Thailand", Capital = "Bangkok" },
        new Country { id = 3, Countryname = "SouthKorea", Capital = "Seoul" }
    };

        // GET: api/Country
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        // GET: api/Country/1
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST: api/Country
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.id = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
        }

        // PUT: api/Country/1
        public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }

            country.Countryname = updatedCountry.Countryname;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }

        // DELETE: api/Country/1
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }

            countries.Remove(country);

            return Ok(country);
        }
    }

}

