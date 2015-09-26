using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ApiServer.Controllers
{
    public class HigoController_temp : System.Web.Http.ApiController
    {
        ApiBLL bll = new ApiBLL();
        // GET api/values
        public string Get()
        {
            string result = "";
            bool valid = false;
            try
            {
                if (HttpContext.Current.Request.QueryString.AllKeys.Contains("code"))
                {
                    string code = HttpContext.Current.Request.QueryString["code"];
                    bll.AddCode(code);
                    valid = true;
                }
                result = valid.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
