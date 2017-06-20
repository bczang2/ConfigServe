using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServe.Entity.DBEntity
{
    public class ApplicationEntity
    {
        public long Id { get; set; }

        public string AppId { get; set; }

        public string AppName { get; set; }

        public string GroupId { get; set; }

        public string GroupName { get; set; }

        public string Owner { get; set; }

        public string OwnerMail { get; set; }

        public string Creator { get; set; }

        public string Modifier { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
