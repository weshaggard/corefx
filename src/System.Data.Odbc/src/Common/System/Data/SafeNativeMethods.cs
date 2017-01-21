// TODO[tinchou]: attribute https://github.com/mono/mono/blob/0bcbe39b148bb498742fc68416f8293ccd350fb6/mcs/class/System.Data/ReferenceSources/SafeNativeMethods.cs

using System.Text;

namespace System.Data.Common
{

    internal static class SafeNativeMethods
    {

        static internal int GetComputerNameEx(int nameType, StringBuilder nameBuffer, ref int bufferSize)
        {
            throw new NotImplementedException();
        }
    }
}