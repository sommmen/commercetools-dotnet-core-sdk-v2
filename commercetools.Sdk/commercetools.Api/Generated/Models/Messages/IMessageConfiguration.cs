using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IMessageConfiguration 
    {
        bool Enabled { get; set;}
        
        int DeleteDaysAfterCreation { get; set;}
    }
}
