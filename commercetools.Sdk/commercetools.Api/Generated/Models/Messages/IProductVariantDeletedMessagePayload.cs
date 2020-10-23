using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IProductVariantDeletedMessagePayload : IMessagePayload
    {
        IProductVariant Variant { get; set;}
        
        List<string> RemovedImageUrls { get; set;}
    }
}
