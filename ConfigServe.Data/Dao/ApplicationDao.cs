using ConfigServe.Data.Base;
using ConfigServe.Data.Conn;
using ConfigServe.Data.IDao;
using ConfigServe.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigServe.Entity.DBEntity;

namespace ConfigServe.Data.Dao
{
    public class ApplicationDao : BaseDao, IApplicationDao
    {

        public int Insert(ApplicationEntity entity)
        {
            int ret = 0;
            string sql = "insert into application values(@Id,@AppName,@AppId,@GroupName,@GroupId,@Owner,@OwnerMail,@Creator,@Modifier,@CreateTime,@UpdateTime)";
            using (var conn = DbConnHelp.GetDbConnection<MySqlConnection>(Constant.MysqlConn))
            {
                ret = conn.Execute(sql, entity) > 0 ? 1 : 0;
            }

            return ret;
        }
    }
}
