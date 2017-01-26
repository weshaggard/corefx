// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Data.OleDb
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Text;

    internal static class ODB
    {
        // used by OleDbConnection to create and verify OLE DB Services
        internal const string DataLinks_CLSID = "CLSID\\{2206CDB2-19C1-11D1-89E0-00C04FD7A829}\\InprocServer32";

        static internal InvalidOperationException MDACNotAvailable(Exception inner)
        {
            return ADP.DataAdapter(Res.GetString(Res.OleDb_MDACNotAvailable), inner);
        }
    }
}
