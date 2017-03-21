using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FCClassLib;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FeederAPI.Links
{
    public class GooglePlacesLink
    {
        FCUriHelper uriHelper;

        public GooglePlacesLink(string searchExt)
        {
            this.BuildGooglePlacesUri(searchExt, Constants.GooglePlacesAPI.OutputType.Json);
        }

        #region Methods
        public async Task<string> GetGoogleObject(HttpClient client, Dictionary<string, string> parameters = null, Dictionary<string, string> headers = null)
        {
            uriHelper.SetParameters(parameters);
            return await FCHttpHelper.GetTaskAsync(client, uriHelper.Uri.ToString(), headers);
        }

        public void BuildGooglePlacesUri(string searchExt, string outputType)
        {
            //Set the uri to google specifications
            uriHelper = new FCUriHelper(($"{Constants.GooglePlacesAPI.BaseUri}/{searchExt}/{outputType}?"));

            //Remove the any port number
            uriHelper.Port = -1;
        }
        #endregion
    }
}