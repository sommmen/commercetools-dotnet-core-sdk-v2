using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductRemovePriceAction : IProductRemovePriceAction
    {
        public string Action { get; set;}
        
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemovePriceAction()
        { 
           this.Action = "removePrice";
        }
    }
}
