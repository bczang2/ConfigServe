using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServe.Util
{
    public class Constant
    {
        /// <summary>
        /// conn
        /// </summary>
        public static string RedisClusterConn = ConfigUtils.GetConfig("RedisClusterConn", "127.0.0.1:6379");

        public const string AppidIncKey = "config_serve_appid_inc";

        public const string SAppid = "10000";

        public static readonly string MysqlConn = ConfigUtils.GetConfig("MysqlConn", "server=localhost;User Id=root;password=zangbc;Database=configdb");
    }
}
