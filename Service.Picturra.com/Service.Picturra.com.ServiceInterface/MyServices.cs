using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using Service.Picturra.com.ServiceModel;

namespace Service.Picturra.com.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, {0}!".Fmt(request.Name) };
        }
    }
}