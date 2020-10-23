using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Zones
{
    public interface IZoneReference : IReference
    {
        IZone Obj { get; set;}
    }
}
