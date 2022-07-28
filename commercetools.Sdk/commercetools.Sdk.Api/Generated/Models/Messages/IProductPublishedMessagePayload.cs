using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPublishedMessagePayload))]
    public partial interface IProductPublishedMessagePayload : IMessagePayload
    {
        List<string> RemovedImageUrls { get; set; }

        IProductProjection ProductProjection { get; set; }

        IProductPublishScope Scope { get; set; }

    }
}
