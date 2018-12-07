using ServiceStack;
using LoopeiWebService.ServiceModel;

namespace LoopeiWebService.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}