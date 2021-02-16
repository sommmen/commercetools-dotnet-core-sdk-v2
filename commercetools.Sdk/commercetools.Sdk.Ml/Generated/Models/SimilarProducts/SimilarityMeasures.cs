using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    public partial class SimilarityMeasures : ISimilarityMeasures
    {
        public long? Name { get; set;}
        
        public long? Description { get; set;}
        
        public long? Attribute { get; set;}
        
        public long? VariantCount { get; set;}
        
        public long? Price { get; set;}
    }
}
