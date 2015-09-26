using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class TransferTokenRequest : WuZhouPostRequest<CommonResponse<TokenInfo>>
    {
        public string grant_type { get; set; }

        public string code { get; set; }

        public string refresh_token { get; set; }

        public override string GetInterface()
        {
            return "oauth2/token";
        }
    }
}
