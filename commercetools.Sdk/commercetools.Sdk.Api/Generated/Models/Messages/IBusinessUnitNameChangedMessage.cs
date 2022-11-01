using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitNameChangedMessage))]
    public partial interface IBusinessUnitNameChangedMessage : IMessage
    {
        string Name { get; set; }

    }
}
