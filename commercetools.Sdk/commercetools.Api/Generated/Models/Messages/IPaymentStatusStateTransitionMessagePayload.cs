using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IPaymentStatusStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set;}
        
        bool Force { get; set;}
    }
}
