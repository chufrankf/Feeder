using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FCClassLib;
using FCClassLib.Google;
using FeederAPI.Links;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace FeederAPI.Helpers
{
    public static class ReadLinkHelper
    {

        public static async Task<string> ReadNearbyRestaurants(Dictionary<string, string> prmts)
        {
            using (var client = new HttpClient())
            {
                //Getting Google Header information.
                GooglePlacesLink gLink = new GooglePlacesLink(Constants.GooglePlacesAPI.SearchExt.Nearby);
                string gString = await gLink.GetGoogleObject(client, parameters: prmts);

                GooglePlacesHeader gPlacesHeader = JsonConvert.DeserializeObject<GooglePlacesHeader>(gString);
                
                return "Complete";
            }
        }
    }
}