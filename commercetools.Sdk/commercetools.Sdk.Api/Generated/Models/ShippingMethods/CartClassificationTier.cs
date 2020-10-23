using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public  partial class CartClassificationTier : ICartClassificationTier
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public ShippingRateTierType TypeAsEnum => this.Type.GetEnum<ShippingRateTierType>();
        
        public string Value { get; set;}
        
        public IMoney Price { get; set;}
        
        public bool IsMatching { get; set;}
        public CartClassificationTier()
        { 
           this.Type = "CartClassification";
        }
    }
}
