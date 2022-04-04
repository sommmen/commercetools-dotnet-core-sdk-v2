using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetBillingAddressAction))]
    public partial interface IMyCartSetBillingAddressAction : IMyCartUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
