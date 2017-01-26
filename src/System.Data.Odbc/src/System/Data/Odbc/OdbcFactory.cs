// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// TODO[tinchou]: check public override CodeAccessPermission CreatePermission(PermissionState state)

using System;
using System.Data;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Odbc
{
    public sealed class OdbcFactory : DbProviderFactory
    {
        public static readonly OdbcFactory Instance = new OdbcFactory();

        private OdbcFactory()
        {
        }

        public override DbCommand CreateCommand()
        {
            return new OdbcCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new OdbcCommandBuilder();
        }

        public override DbConnection CreateConnection()
        {
            return new OdbcConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new OdbcConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OdbcDataAdapter();
        }

        public override DbParameter CreateParameter()
        {
            return new OdbcParameter();
        }

        //public override CodeAccessPermission CreatePermission(PermissionState state) {
        //    return new OdbcPermission(state);
        //}
    }
}
