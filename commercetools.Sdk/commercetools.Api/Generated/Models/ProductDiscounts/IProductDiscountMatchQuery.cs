using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductDiscounts
{
    public interface IProductDiscountMatchQuery 
    {
        string ProductId { get; set;}
        
        int VariantId { get; set;}
        
        bool Staged { get; set;}
        
        IQueryPrice Price { get; set;}
    }
}
