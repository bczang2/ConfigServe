using ConfigServe.Data.DbFactory;
using ConfigServe.Entity.DBEntity;
using ConfigServe.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServe.Core.Portal
{
    public class PortalCore
    {

        public string GeneratAppid()
        {
            string appid = Constant.SAppid;
            if (RedisHelper.KeyExists(Constant.RedisClusterConn, Constant.AppidIncKey))
            {
                appid = RedisHelper.Inc(Constant.RedisClusterConn, Constant.AppidIncKey).ToString();
            }
            else
            {
                RedisHelper.Item_SetString(Constant.RedisClusterConn, Constant.AppidIncKey, appid);
            }

            return appid;
        }

        public bool AddApplicationInfo(ApplicationEntity entity)
        {
            bool ret = false;
            ret = ConfigDBFactory.ApplicationDao.Insert(entity) > 0;

            return ret;
        }
    }
}
