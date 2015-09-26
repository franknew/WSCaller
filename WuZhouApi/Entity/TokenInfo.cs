using System;
using System.Collections.Generic;
using System.Text;

namespace WuZhouApi
{
    public class TokenInfo
    {
        public string access_token { get; set; }

        public long expires_in { get; set; }

        public string token_type { get; set; }

        public string scope { get; set; }

        public string refresh_token { get; set; }
    }
}
