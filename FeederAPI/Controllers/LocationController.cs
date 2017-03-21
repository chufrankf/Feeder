using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FeederAPI.Helpers;
using FCClassLib;
using System.Threading.Tasks;

namespace FeederAPI.Controllers
{
    public class LocationController : ApiController
    {
        // GET: api/Location
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Location/5
        public async Task<string> Get(int id)
        {
            // NOTE: The following few lines are temporary so that I can test the
            //       get with the following parameters
            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
                {"location", "45.4868580,-122.6371730" }
                ,{"key","AIzaSyDWia1aT60nJIwxDje1yU4T0ICahRK8B7A"}
                ,{"radius","50000"}
                ,{"keyword","chinese" }
            };

            var value = await ReadLinkHelper.ReadNearbyRestaurants(parameters);

            return value.ToString();
        }

        // POST: api/Location
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Location/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Location/5
        public void Delete(int id)
        {
        }
    }
}
