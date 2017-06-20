using ConfigServe.Core.Portal;
using ConfigServe.Entity.Api;
using ConfigServe.Entity.DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalApi.Controllers
{
    public class PortalController : ApiController
    {
        [HttpGet]
        [HttpPost]
        public InterfaceResponse<string> GeneratAppid()
        {
            InterfaceResponse<string> ret = new InterfaceResponse<string>();
            PortalCore core = new PortalCore();
            ret.Data = core.GeneratAppid();

            return ret;
        }

        [HttpGet]
        [HttpPost]
        public InterfaceResponse<bool> AddApplication()
        {
            InterfaceResponse<bool> ret = new InterfaceResponse<bool>();
            ApplicationEntity entity = new ApplicationEntity()
            {
                AppId = "1111",
                AppName = "1344",
                Owner = "zbc",
                OwnerMail = "234@ww.com",
                Creator = "333",
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now
            };

            PortalCore core = new PortalCore();
            ret.Data = core.AddApplicationInfo(entity);

            return ret;
        }
    }
}
