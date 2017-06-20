using ConfigServe.Entity.DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServe.Data.IDao
{
    public interface IApplicationDao
    {
        int Insert(ApplicationEntity entity);
    }
}
