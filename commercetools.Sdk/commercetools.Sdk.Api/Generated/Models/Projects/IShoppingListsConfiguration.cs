using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.ShoppingListsConfiguration))]
    public partial interface IShoppingListsConfiguration
    {
        long? DeleteDaysAfterLastModification { get; set; }
    }
}
