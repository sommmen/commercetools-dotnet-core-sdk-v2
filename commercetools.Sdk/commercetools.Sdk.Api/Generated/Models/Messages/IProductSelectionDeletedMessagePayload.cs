using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionDeletedMessagePayload))]
    public partial interface IProductSelectionDeletedMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }
    }
}
