using System;
using System.Collections.Generic;
using System.Text;
using WebApiSDK;

namespace WuZhouApi
{
    public class TokenGetResponse : BaseResponse
    {
        public string code { get; set; }
    }
}
