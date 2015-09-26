using System;
using System.Collections.Generic;
using System.Text;
using WebApiSDK;
using WuZhouApi;

namespace WebApiBLL
{
    public class OrderBLL
    {
        public OrderList List(long pageIndex, DateTime send_start, DateTime send_end, ref string token)
        {
            QueryOrderRequest request = new QueryOrderRequest();
            request.access_token = token;
            request.page_curr = pageIndex;
            request.send_time_start = send_start.ToString(Common.DateTimeFormat);
            request.send_time_end = send_end.ToString(Common.DateTimeFormat);
            var response = SDKFactory.Executor.Execute(request);
            response = Common.CheckResponseError<OrderList, CommonResponse<OrderList>>(request, response, ref token);
            return response.data;
        }
    }
}
