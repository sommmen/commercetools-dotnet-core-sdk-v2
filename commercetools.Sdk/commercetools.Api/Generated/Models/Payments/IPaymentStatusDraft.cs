using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPaymentStatusDraft 
    {
        string InterfaceCode { get; set;}
        
        string InterfaceText { get; set;}
        
        IStateResourceIdentifier State { get; set;}
    }
}
