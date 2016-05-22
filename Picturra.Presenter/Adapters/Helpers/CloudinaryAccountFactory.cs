using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using System.Configuration;

namespace Picturra.Presenter.Adapters.Helpers
{
    public static class CloudinaryAccountFactory
    {
        public static Account Create()
        {
            return new Account
            {
                ApiKey = ConfigurationManager.AppSettings["CloudinaryApiKey"],
                ApiSecret = ConfigurationManager.AppSettings["CloudinaryApiSecret"],
                Cloud = ConfigurationManager.AppSettings["CloudinaryCloudName"]
            };
        }
    }
}
