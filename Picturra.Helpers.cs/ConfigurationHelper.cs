using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Helpers.cs
{
    public static class ConfigurationHelper
    {
        public static string GetPicturraConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PicturraConnection"].ConnectionString;
        }
    }
}
