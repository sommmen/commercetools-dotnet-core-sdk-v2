using commercetools.Api.Models.Products;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductTransitionStateAction : IProductTransitionStateAction
    {
        public string Action { get; set;}
        
        public IStateResourceIdentifier State { get; set;}
        
        public bool Force { get; set;}
        public ProductTransitionStateAction()
        { 
           this.Action = "transitionState";
        }
    }
}
