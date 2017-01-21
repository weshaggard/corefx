// TODO[tinchou]: attribute https://github.com/mono/mono/blob/0bcbe39b148bb498742fc68416f8293ccd350fb6/mcs/class/System.Data/ReferenceSources/ResCategoryAttribute.cs

using System.ComponentModel;

namespace System.Data
{
    sealed class ResCategoryAttribute : CategoryAttribute
    {
        public ResCategoryAttribute(string category)
            : base(category)
        {
        }
    }
}