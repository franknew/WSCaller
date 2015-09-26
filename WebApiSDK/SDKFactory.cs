using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiSDK
{
    public class SDKFactory
    {
        public static readonly IExecutor Executor = new JsonExecutor();
    }
}
