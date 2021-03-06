﻿using System.Diagnostics;
using NHibernate;
using NHibernate.SqlCommand;

namespace ProjectManagement.Dal.Nhb.Interceptors
{
    /// <summary>
    /// Interceptor used to trace the SQL statements generated by NHibernate
    /// </summary>
    /// <remarks>It should be used only if in Debug mode or inside a Test Harness</remarks>
    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override SqlString OnPrepareStatement(SqlString sql)
        {
            Trace.WriteLine(sql.ToString());
            return sql;
        }
    }
}