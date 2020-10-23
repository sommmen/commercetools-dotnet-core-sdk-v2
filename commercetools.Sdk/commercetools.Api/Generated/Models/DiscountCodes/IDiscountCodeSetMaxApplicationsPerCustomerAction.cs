using commercetools.Api.Generated.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.DiscountCodes
{
    public interface IDiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeUpdateAction
    {
        long MaxApplicationsPerCustomer { get; set;}
    }
}
