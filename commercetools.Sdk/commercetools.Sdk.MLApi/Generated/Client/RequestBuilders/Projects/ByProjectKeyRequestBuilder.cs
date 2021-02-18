using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.MLApi.Client.RequestBuilders.Projects
{
    public class ByProjectKeyRequestBuilder
    {
        private IClient ApiHttpClient { get; }
       
        private ISerializerService SerializerService { get; }
       
        private string ProjectKey { get; }
   
        public ByProjectKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }
    }
}