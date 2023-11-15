using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    [RoutePrefix("api/User")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{ID=1, CountryName="Australia",Capital="Canberra"},
            new Country{ID=2, CountryName="Italy",Capital="Rome"},
            new Country{ID=3, CountryName="China",Capital="Beijing"},
            new Country{ID=4, CountryName="America",Capital="Washington D.C"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Country> Get()
        {
            return countrylist;
        }

        //getting country details using httpresponsemessage
        [HttpGet]
        [Route("byhttp")]
        public HttpResponseMessage GetAllCountries()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, countrylist);
            return response;
        }

        [HttpGet]
        [Route("ByID")]
        public IHttpActionResult GetByID(int cid)
        {
            var country = countrylist.Find(c => c.ID == cid);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpGet]
        [Route("GetName")]
        public IHttpActionResult GetCountryByName(int cid)
        {
            string cname = countrylist.Where(c => c.ID == cid).SingleOrDefault()?.CountryName;
            if (cname == null)
            {
                return NotFound();
            }
            return Ok(cname);
        }

        //Post 1
        [HttpPost]
        [Route("justpost")]
        public Country Post([FromBody] Country c)
        {
            countrylist.Add(c);
            return c;
        }

        //post 2
        [HttpPost]
        [Route("AllPost")]
        public List<Country> PostAll([FromBody] Country country)
        {
            countrylist.Add(country);
            return countrylist;
        }

        [HttpPost]
        [Route("countrypost")]
        public void CountryPost([FromUri] int Id, string name, string capital)
        {
            Country country = new Country();
            country.ID = Id;
            country.CountryName = name;
            country.Capital = capital;
            countrylist.Add(country);
        }

        //Put
        [HttpPut]
        [Route("updcountry")]
        public void Put(int id, [FromUri] Country c)
        {
            countrylist[id - 1] = c;
        }

        //delete
        [Route("del")]
        public void Delete(int id)
        {
            countrylist.RemoveAt(id - 1);
        }
    }
}