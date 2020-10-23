using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IInvalidFieldError : IErrorObject
    {
        string Field { get; set;}
        
        Object InvalidValue { get; set;}
        
        List<Object> AllowedValues { get; set;}
    }
}
