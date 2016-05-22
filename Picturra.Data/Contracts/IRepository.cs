﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Data.Contracts
{
    public interface IRepository<TEntity, TId>
    {
        SqlConnection SqlConnection { get; set; }
        TId Set(TEntity entity);
        TEntity Get(TId id);
    }
}