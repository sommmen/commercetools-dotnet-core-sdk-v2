using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.ImageDimensions))]
    public interface IImageDimensions 
    {
        int W { get; set;}
        
        int H { get; set;}
    }
}
