using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Types
{
    public interface ITypeAddLocalizedEnumValueAction : ITypeUpdateAction
    {
        string FieldName { get; set;}
        
        ICustomFieldLocalizedEnumValue Value { get; set;}
    }
}
