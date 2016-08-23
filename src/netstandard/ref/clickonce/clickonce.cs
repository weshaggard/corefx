/* Broken APIs
AppDomain:
//CLICKONCE public System.ActivationContext ActivationContext { get { throw null; } }
//CLICKONCE public System.ApplicationIdentity ApplicationIdentity { get { throw null; } }

AppDomainSetup
//CLICKONCE public AppDomainSetup(System.ActivationContext activationContext) { }
*/

namespace System
{
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ActivationContext : System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        internal ActivationContext() { }
        public System.ActivationContext.ContextForm Form { get { throw null; } }
        public System.ApplicationIdentity Identity { get { throw null; } }
        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity identity) { throw null; }
        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity identity, string[] manifestPaths) { throw null; }
        public void Dispose() { }
        ~ActivationContext() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public enum ContextForm
        {
            Loose = 0,
            StoreBounded = 1,
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationId
    {
        public ApplicationId(byte[] publicKeyToken, string name, System.Version version, string processorArchitecture, string culture) { }
        public string Culture { get { throw null; } }
        public string Name { get { throw null; } }
        public string ProcessorArchitecture { get { throw null; } }
        public byte[] PublicKeyToken { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public System.ApplicationId Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationIdentity : System.Runtime.Serialization.ISerializable
    {
        public ApplicationIdentity(string applicationIdentityFullName) { }
        public string CodeBase { get { throw null; } }
        public string FullName { get { throw null; } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
}
namespace System.Deployment.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class InternalActivationContextHelper
    {
        public static object GetActivationContextData(System.ActivationContext appInfo) { throw null; }
        public static object GetApplicationComponentManifest(System.ActivationContext appInfo) { throw null; }
        public static byte[] GetApplicationManifestBytes(System.ActivationContext appInfo) { throw null; }
        public static object GetDeploymentComponentManifest(System.ActivationContext appInfo) { throw null; }
        public static byte[] GetDeploymentManifestBytes(System.ActivationContext appInfo) { throw null; }
        public static bool IsFirstRun(System.ActivationContext appInfo) { throw null; }
        public static void PrepareForExecution(System.ActivationContext appInfo) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class InternalApplicationIdentityHelper
    {
        public static object GetInternalAppId(System.ApplicationIdentity id) { throw null; }
    }
}