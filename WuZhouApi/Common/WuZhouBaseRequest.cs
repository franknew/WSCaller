using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebApiSDK;

namespace WuZhouApi
{
    public class WuZhouBaseRequest<T> : IRequest<T> where T : WuZhouResponse
    {
        public string GetUrl()
        {
            string host = "";
            StringBuilder url = new StringBuilder();
            if (!string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["HigoHost"].ConnectionString))
            {
                host = ConfigurationManager.ConnectionStrings["HigoHost"].ConnectionString;
            }
            else
            {
                throw new Exception("没有配置HigoHost！");
            }
            url.AppendFormat("{0}/{1}", host.TrimEnd('/'), GetInterface());
            return url.ToString();
        }

        public virtual string Method()
        {
            throw new NotImplementedException();
        }

        public virtual string GetInterface()
        {
            throw new NotImplementedException();
        }
    }
}
