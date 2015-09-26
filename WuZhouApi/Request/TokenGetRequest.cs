using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebApiSDK;

namespace WuZhouApi
{
    public class TokenGetRequest : IRequest<TokenGetResponse>
    {
        public string GetUrl()
        {
            string host = "";
            StringBuilder url = new StringBuilder();
            if (!string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["HigoHost"].ConnectionString))
            {
                host = ConfigurationManager.ConnectionStrings["HigoHost"].ConnectionString;
            }
            url.AppendFormat("{0}/{1}", host.TrimEnd('/'), "api/token");
            return url.ToString();
        }

        public string Method()
        {
            return "get";
        }
    }
}
