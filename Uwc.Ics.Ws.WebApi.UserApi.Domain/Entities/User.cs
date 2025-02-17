using Uwc.Ics.Ws.WebApi.UserApi.Domain.Common;

namespace Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities
{
    public class User: BaseEntity
    { 
        //  public string user_principal_name { get; set; } = string.Empty;//used by AAD 
        public string display_name { get; set; } = string.Empty;
        public bool is_admin { get; set; }
       
    }
}

