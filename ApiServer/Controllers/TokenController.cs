using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ApiServer.Controllers
{
    public class TokenController : System.Web.Http.ApiController
    {
        ApiBLL bll = new ApiBLL();

        
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            StringBuilder json = new StringBuilder();
            try
            {
                string code = bll.GetCode();

                json.Append("{\"code\":\"").Append(code).Append("\"}");
            }
            catch (Exception ex)
            {
                json.Append(ex.Message);
            }

            return new HttpResponseMessage { Content = new StringContent(json.ToString(), System.Text.Encoding.UTF8, "application/json") };
        }
        
    }
}