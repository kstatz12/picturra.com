using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace Picturra.Data.Contracts
{
    public interface IRepository
    {
        OrmLiteConnectionFactory DbFactory { get; set; }
    }
}
