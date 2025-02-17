using System;
using System.Collections.Generic;
using System.Text;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Common;

namespace Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual List<UserRole>? Users { get; set; } 
    }
}
