using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.TaxCategories
{
    public interface ITaxCategoryReplaceTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set;}
        
        ITaxRateDraft TaxRate { get; set;}
    }
}
