using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderSetParcelItemsAction : IOrderUpdateAction
    {
        string ParcelId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
    }
}
