using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentSetStatusInterfaceCodeAction : IPaymentUpdateAction
    {
        string InterfaceCode { get; set;}
    }
}
