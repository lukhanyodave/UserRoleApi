using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult)
        {
            //foreach (var error in validationResult.ErrorMessage.)
            //{
                Errors.Add(validationResult.ErrorMessage??"");
           // }
        }
    }
}
