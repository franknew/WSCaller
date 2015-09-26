using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAFramework.Library.DAL;
using System.Data;

namespace BLL
{
    public class ApiBLL
    {
        IDBHelper helper = DBFactory.CreateDBHelper();

        public void AddCode(string code)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO CodeHistory (Code) VALUES(@Code);");
            List<Parameter> param = new List<Parameter> {
                new Parameter { Name = "@Code", Value = code }
            };
            helper.ExecNoneQueryWithSQL(sql.ToString(), param.ToArray());
        }

        public string GetCode()
        {
            string code = null;
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TOP 1 * FROM CodeHistory ORDER BY CreateTime DESC");
            DataTable table = helper.GetTableWithSQL(sql.ToString());
            if (table.Rows.Count > 0)
            {
                code = table.Rows[0]["Code"].ToString();
                int id = (int)table.Rows[0]["ID"];
                sql = new StringBuilder();
                sql.Append("DELETE FROM CodeHistory WHERE ID=@ID");
                List<Parameter> param = new List<Parameter> {
                    new Parameter { Name = "@ID", Value = id }
                };
                helper.ExecNoneQueryWithSQL(sql.ToString(), param.ToArray());
            }
            return code;
        }
    }
}
