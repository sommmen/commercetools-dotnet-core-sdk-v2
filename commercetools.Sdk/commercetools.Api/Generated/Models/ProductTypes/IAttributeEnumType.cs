using commercetools.Api.Generated.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IAttributeEnumType : IAttributeType
    {
        List<IAttributePlainEnumValue> Values { get; set;}
    }
}
