using ConfigServe.Data.Dao;
using ConfigServe.Data.IDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServe.Data.DbFactory
{
    public class ConfigDBFactory
    {
        private static IApplicationDao _ApplicationDao = new ApplicationDao();

        public static IApplicationDao ApplicationDao
        {
            get { return _ApplicationDao; }
        }
    }
}
