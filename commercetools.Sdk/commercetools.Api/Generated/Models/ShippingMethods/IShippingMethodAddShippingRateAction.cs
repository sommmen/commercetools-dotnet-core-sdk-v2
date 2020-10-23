using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShippingMethods
{
    public interface IShippingMethodAddShippingRateAction : IShippingMethodUpdateAction
    {
        IZoneResourceIdentifier Zone { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
    }
}
