using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserRoleDTO
{
    public class UserRoleListDto:BaseDto
    {
        public DateTimeOffset? CommencementDate { get; set; }
        public DateTimeOffset? TerminationDate { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
