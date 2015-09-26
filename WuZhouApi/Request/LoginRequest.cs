using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginRequest : WuZhouGetRequest<WuZhouResponse>
    {
        public override string GetInterface()
        {
            return "oauth2/login";
        }

        public string client_id { get; set; }

        public string state { get; set; }
    }
}
