using commercetools.Api.Generated.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Projects
{
    public interface IProjectChangeCountryTaxRateFallbackEnabledAction : IProjectUpdateAction
    {
        bool CountryTaxRateFallbackEnabled { get; set;}
    }
}
