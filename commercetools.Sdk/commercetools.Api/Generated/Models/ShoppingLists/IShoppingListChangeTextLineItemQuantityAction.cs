using commercetools.Api.Generated.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListChangeTextLineItemQuantityAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        long Quantity { get; set;}
    }
}
