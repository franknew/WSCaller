using System;
using System.Collections.Generic;
using System.Text;
using WebApiSDK;
using WuZhouApi;

namespace WebApiBLL
{
    public class LogisticsBLL
    {
        /// <summary>
        /// 物流状态回传
        /// </summary>
        /// <param name="token"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public LogisticsCallback StatusCallback(LogisticsCallback entity, ref string token)
        {
            LogisticsCallbackRequest request = new LogisticsCallbackRequest();
            request.access_token = token;
            request.express_company = entity.express_company;
            request.express_number = entity.express_number;
            request.higo_internal_logistics_number = entity.higo_internal_logistics_number;
            request.logistics_type = entity.logistics_type;
            request.operate_time = entity.operate_time;

            var response = SDKFactory.Executor.Execute(request);
            response = Common.CheckResponseError<LogisticsCallback, CommonResponse<LogisticsCallback>>(request, response, ref token);
            return response.data;
        }

        /// <summary>
        /// 异常状态回传
        /// </summary>
        /// <param name="token"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public LogisticsExpCallback ExpCallback(LogisticsExpCallback entity, ref string token)
        {
            LogisticsExpCallbackRequest request = new LogisticsExpCallbackRequest();
            request.access_token = token;
            request.higo_internal_logistics_number = entity.higo_internal_logistics_number;
            request.logistics_exp_type = entity.logistics_exp_type;
            request.operate_time = entity.operate_time;
            request.remark = entity.remark;
            var response = SDKFactory.Executor.Execute(request);
            response = Common.CheckResponseError<LogisticsExpCallback, CommonResponse<LogisticsExpCallback>>(request, response, ref token);
            return response.data;
        }

        /// <summary>
        /// 称重回传
        /// </summary>
        /// <param name="token"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public WeightCallback WeightCallback(WeightCallback entity, ref string token)
        {
            WeightCallbackRequest request = new WeightCallbackRequest();
            request.access_token = token;
            request.inter_logistics_number = entity.inter_logistics_number;
            request.operate_time = entity.operate_time;
            request.package_weight = entity.package_weight;
            request.weight_unit = entity.weight_unit;
            var response = SDKFactory.Executor.Execute(request);

            response = Common.CheckResponseError<WeightCallback, CommonResponse<WeightCallback>>(request, response, ref token);
            return response.data;
        }

        /// <summary>
        /// 运费回传
        /// </summary>
        /// <param name="token"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ShippingFeeCallback ShippingFeeCallback(ShippingFeeCallback entity, ref string token)
        {
            ShippingFeeCallbackRequest request = new ShippingFeeCallbackRequest();
            request.access_token = token;
            request.clearance_date = entity.clearance_date;
            request.fee_unit = entity.fee_unit;
            request.higo_internal_logistics_numbers = entity.higo_internal_logistics_numbers;
            request.inter_logistics_numbers = entity.inter_logistics_numbers;
            request.operate_time = entity.operate_time;
            request.shipping_fee = entity.shipping_fee;
            request.total_weight = entity.total_weight;
            request.weight_unit = entity.weight_unit;
            var response = SDKFactory.Executor.Execute(request);
            response = Common.CheckResponseError<ShippingFeeCallback, CommonResponse<ShippingFeeCallback>>(request, response, ref token);
            return response.data;
        }

        /// <summary>
        /// 耗材回传
        /// </summary>
        /// <param name="token"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public MaterialConsumedCallback MaterialConsumedCallback(MaterialConsumedCallback entity, ref string token)
        {
            MaterialConsumedCallbackRequest request = new MaterialConsumedCallbackRequest();
            request.access_token = token;
            request.consumed_quantity = entity.consumed_quantity;
            request.date = entity.date;
            request.fee_unit = entity.fee_unit;
            request.material_fee = entity.material_fee;
            request.material_id = entity.material_id;
            request.material_name = entity.material_name;
            request.material_weight = entity.material_weight;
            request.weight_unit = entity.weight_unit;
            var response = SDKFactory.Executor.Execute(request);
            response = Common.CheckResponseError<MaterialConsumedCallback, CommonResponse<MaterialConsumedCallback>>(request, response, ref token);
            return response.data;
        }
    }
}
