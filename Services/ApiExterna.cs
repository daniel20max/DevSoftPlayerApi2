using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DevSoftPlayerApi2.Services
{
    public class ApiExterna
    {
        public double ReturnGet()
        {
            var requestWeb = WebRequest.CreateHttp("https://localhost:44344/Index/TaxaJuros");
            requestWeb.Method = "GET";
            requestWeb.UserAgent = "RequestWeb";
            var returnGet = requestWeb.GetResponse();
            var streamDados = returnGet.GetResponseStream();
            StreamReader streamReader = new StreamReader(streamDados);
            object objectResponse = streamReader.ReadToEnd();
            double post = JsonConvert.DeserializeObject<double>(objectResponse.ToString());
            return post;
        }
    }
}
