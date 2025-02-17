using System;
using System.Collections.Generic;
using System.Text;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Common;

namespace Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public string Name { get; set; }= String.Empty;
        public virtual Role Roles { get; set; }
        public virtual User Users { get; set; }
    }
}
