using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebApiBLL;
using WebApiSDK;
using WuZhouApi;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        private string token = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBLL login = new LoginBLL();
            token = login.Login();
            MessageBox.Show(token);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OrderBLL bll = new OrderBLL();
                var list = bll.List(1, new DateTime(2015, 8, 1), DateTime.Now.AddHours(-1), ref token);
                dataGridView1.DataSource = list.order_data[0].goods_info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                LogisticsBLL bll = new LogisticsBLL();
                var response = bll.WeightCallback(new WeightCallback
                {
                    inter_logistics_number = "CW543784919US-2",
                    operate_time = DateTime.Now.ToString(Common.DateTimeFormat),
                    package_weight = 10.5,
                    weight_unit = "kg",
                }, ref token);
                MessageBox.Show(response.operate_success.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                LogisticsBLL bll = new LogisticsBLL();
                var response = bll.StatusCallback(new LogisticsCallback { 
                    express_company = "abc",
                    higo_internal_logistics_number = "CW543784919US-2",
                    express_number = "11111",
                    operate_time = DateTime.Now.ToString(Common.DateTimeFormat),
                    logistics_type = 1002,
                }, ref token);
                MessageBox.Show(response.process_success.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                LogisticsBLL bll = new LogisticsBLL();
                var response = bll.ExpCallback(new LogisticsExpCallback
                {
                    higo_internal_logistics_number = "CW543784919US-2",
                    operate_time = DateTime.Now.ToString(Common.DateTimeFormat),
                    logistics_exp_type = 2002,
                    remark = "test",
                }, ref token);
                MessageBox.Show(response.process_success.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                LogisticsBLL bll = new LogisticsBLL();
                var response = bll.MaterialConsumedCallback(new MaterialConsumedCallback
                {
                    consumed_quantity = 12,
                    date = DateTime.Now.ToString("yyyy-MM-dd"),
                    material_fee = 6,
                    fee_unit = "CNY",
                    material_id = 1,
                    material_name = "test m",
                    material_weight = 12.2,
                }, ref token);
                MessageBox.Show(response.process_success.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                LogisticsBLL bll = new LogisticsBLL();
                var response = bll.ShippingFeeCallback(new ShippingFeeCallback
                {
                    fee_unit = "CNY",
                    clearance_date = DateTime.Now.ToString("yyyy-MM-dd"),
                    higo_internal_logistics_numbers = "CW543784919US-2",
                    inter_logistics_numbers = "CW543784919US - 2",
                    operate_time = DateTime.Now.ToString(Common.DateTimeFormat),
                    shipping_fee = 10.1,
                    total_weight = 100,
                }, ref token);
                MessageBox.Show(response.operate_success.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
