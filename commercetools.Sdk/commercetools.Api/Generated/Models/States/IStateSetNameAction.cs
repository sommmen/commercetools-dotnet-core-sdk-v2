using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.States
{
    public interface IStateSetNameAction : IStateUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
