using commercetools.Api.Generated.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IAttributeLocalizedEnumType : IAttributeType
    {
        List<IAttributeLocalizedEnumValue> Values { get; set;}
    }
}
