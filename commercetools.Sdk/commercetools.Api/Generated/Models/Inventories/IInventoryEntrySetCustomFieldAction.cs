using commercetools.Api.Generated.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Inventories
{
    public interface IInventoryEntrySetCustomFieldAction : IInventoryEntryUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
