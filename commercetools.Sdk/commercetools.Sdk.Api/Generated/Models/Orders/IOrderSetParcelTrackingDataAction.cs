using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetParcelTrackingDataAction))]
    public partial interface IOrderSetParcelTrackingDataAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }

    }
}
