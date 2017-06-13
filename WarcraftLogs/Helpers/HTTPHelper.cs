using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WarcraftLogs.Helpers
{
    class HTTPHelper
    {
        public T Get<T>(Uri url, Dictionary<string, string> parameters)
        {
            try
            {
                StringBuilder parameterString = new StringBuilder();

                if (parameters == null || parameters.Count <= 0)
                {
                    parameterString.Clear();
                }
                else
                {
                    parameterString.Append("?");
                    foreach (KeyValuePair<string, string> parameter in parameters)
                    {
                        parameterString.Append(parameter.Key + "=" + parameter.Value + "&");
                    }
                }

                url = new Uri(url + parameterString.ToString().TrimEnd(new char[] { '&' }));

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";
                request.KeepAlive = false;
                request.ContentType = "application/json";
                request.ContentLength = 0;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(response.StatusDescription);
                    }

                    string value;
                    using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        value = reader.ReadToEnd();
                    }
                    return JsonConvert.DeserializeObject<T>(value);
                }
            }
            catch (Exception ex)
            {
                //no need to log here - should be handled by global and redirected accordingly
                throw ex;
            }
        }
    }
}
