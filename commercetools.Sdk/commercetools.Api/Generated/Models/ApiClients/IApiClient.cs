using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ApiClients
{
    public interface IApiClient 
    {
        string Id { get; set;}
        
        string Name { get; set;}
        
        string Scope { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastUsedAt { get; set;}
        
        DateTime DeleteAt { get; set;}
        
        string Secret { get; set;}
    }
}
