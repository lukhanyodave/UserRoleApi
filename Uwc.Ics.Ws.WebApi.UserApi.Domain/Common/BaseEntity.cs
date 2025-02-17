using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string? UpdatedBy { get; set; }
        //public DateTimeOffset? DateDeleted { get; set; }
        //public string? DeletedBy { get; set; }
    }
}

   

