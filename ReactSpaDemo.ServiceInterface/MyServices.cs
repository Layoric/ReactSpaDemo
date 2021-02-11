using System;
using ServiceStack;
using ReactSpaDemo.ServiceModel;

namespace ReactSpaDemo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
