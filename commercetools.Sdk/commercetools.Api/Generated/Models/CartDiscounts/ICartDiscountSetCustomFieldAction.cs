using commercetools.Api.Generated.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.CartDiscounts
{
    public interface ICartDiscountSetCustomFieldAction : ICartDiscountUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
