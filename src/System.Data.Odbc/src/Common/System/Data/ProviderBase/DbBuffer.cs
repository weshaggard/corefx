//------------------------------------------------------------------------------
// <copyright file="DbBuffer.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <owner current="true" primary="true">[....]</owner>
//------------------------------------------------------------------------------

namespace System.Data.ProviderBase
{
    // DbBuffer is abstract to require derived class to exist
    // so that when debugging, we can tell the difference between one DbBuffer and another
    internal abstract class DbBuffer {

        internal const int LMEM_FIXED = 0x0000;
    }
}
