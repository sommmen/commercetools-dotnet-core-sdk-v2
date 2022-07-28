using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantDeletedMessage))]
    public partial interface IProductVariantDeletedMessage : IMessage
    {
        IProductVariant Variant { get; set; }

        List<string> RemovedImageUrls { get; set; }

    }
}
