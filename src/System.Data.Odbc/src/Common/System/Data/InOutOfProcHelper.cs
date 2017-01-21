// TODO[tinchou]: attribute https://raw.githubusercontent.com/mono/mono/0bcbe39b148bb498742fc68416f8293ccd350fb6/mcs/class/System.Data/ReferenceSources/InOutOfProcHelper.cs

namespace System.Data.SqlClient
{

    static class InOutOfProcHelper
    {

        internal static bool InProc
        {
            get
            {
                return false;
            }
        }
    }
}