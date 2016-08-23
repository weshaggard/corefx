// Broken APIs
/*
AppDomain:
//CAS     public System.Security.Policy.Evidence Evidence { get { throw null; } }
//CAS     public System.Security.PermissionSet PermissionSet { get { throw null; } }
//CAS     public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo) { throw null; }
//CAS     public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup info) { throw null; }
//CAS     public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) { throw null; }
//CAS     public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, System.AppDomainInitializer adInit, string[] adInitArgs) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
//CAS     public System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute("AppDomain policy levels are obsolete")]
//CAS     [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
//CAS     public void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) { }
//CAS     public void SetData(string name, object data, System.Security.IPermission permission) { }
//CAS     public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) { }

AppDomainManager:
//CAS     public virtual System.Security.HostSecurityManager HostSecurityManager { get { throw null; } }
//CAS     public virtual bool CheckSecuritySettings(System.Security.SecurityState state) { throw null; }
//CAS     public virtual System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup appDomainInfo) { throw null; }
//CAS     protected static System.AppDomain CreateDomainHelper(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup appDomainInfo) { throw null; }

AppDomainSetup:
//CAS     public System.Security.Policy.ApplicationTrust ApplicationTrust { get { throw null; } set { } }

IsolatedStorage:
//CAS     protected abstract System.Security.Permissions.IsolatedStoragePermission GetPermission(System.Security.PermissionSet ps);

IsolatedStorageFile:
//CAS     protected override System.Security.Permissions.IsolatedStoragePermission GetPermission(System.Security.PermissionSet ps) { throw null; }
//CAS     public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Security.Policy.Evidence domainEvidence, System.Type domainEvidenceType, System.Security.Policy.Evidence assemblyEvidence, System.Type assemblyEvidenceType) { throw null; }

Assembly:
//CAS     public virtual System.Security.Policy.Evidence Evidence { get { throw null; } }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS     public static System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.SecurityContextSource securityContextSource) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly LoadFile(string path, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
//CAS     [System.ObsoleteAttribute]
//CAS     public static System.Reflection.Assembly LoadWithPartialName(string partialName, System.Security.Policy.Evidence securityEvidence) { throw null; }

XmlSerializer:
//CAS     public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) { }
//CAS     public static System.Xml.Serialization.XmlSerializer[] FromMappings(System.Xml.Serialization.XmlMapping[] mappings, System.Security.Policy.Evidence evidence) { throw null; }

XmlSerializerFactory:
//CAS     public System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) { throw null; }

XslTransform:
//CAS     public void Load(System.Xml.XmlReader stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
//CAS     public void Load(System.Xml.XPath.IXPathNavigable stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
//CAS     public void Load(System.Xml.XPath.XPathNavigator stylesheet, System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }

*/
namespace System.Net
{
    public sealed partial class SocketPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public const int AllPorts = -1;
        public SocketPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
        public SocketPermission(System.Security.Permissions.PermissionState state) { }
        public System.Collections.IEnumerator AcceptList { get { throw null; } }
        public System.Collections.IEnumerator ConnectList { get { throw null; } }
        public void AddPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    public sealed partial class SocketPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SocketPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Access { get { throw null; } set { } }
        public string Host { get { throw null; } set { } }
        public string Port { get { throw null; } set { } }
        public string Transport { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public sealed partial class WebPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public WebPermission() { }
        public WebPermission(System.Net.NetworkAccess access, string uriString) { }
        public WebPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public WebPermission(System.Security.Permissions.PermissionState state) { }
        public System.Collections.IEnumerator AcceptList { get { throw null; } }
        public System.Collections.IEnumerator ConnectList { get { throw null; } }
        public void AddPermission(System.Net.NetworkAccess access, string uriString) { }
        public void AddPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    public sealed partial class WebPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public WebPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Accept { get { throw null; } set { } }
        public string AcceptPattern { get { throw null; } set { } }
        public string Connect { get { throw null; } set { } }
        public string ConnectPattern { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
}
namespace System.Security
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CodeAccessPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk
    {
        protected CodeAccessPermission() { }
        public void Assert() { }
        public abstract System.Security.IPermission Copy();
        public void Demand() { }
        public void Deny() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public abstract void FromXml(System.Security.SecurityElement elem);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public abstract System.Security.IPermission Intersect(System.Security.IPermission target);
        public abstract bool IsSubsetOf(System.Security.IPermission target);
        public void PermitOnly() { }
        public static void RevertAll() { }
        public static void RevertAssert() { }
        public static void RevertDeny() { }
        public static void RevertPermitOnly() { }
        public override string ToString() { throw null; }
        public abstract System.Security.SecurityElement ToXml();
        public virtual System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HostProtectionException : System.SystemException
    {
        public HostProtectionException() { }
        protected HostProtectionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public HostProtectionException(string message) { }
        public HostProtectionException(string message, System.Exception e) { }
        public HostProtectionException(string message, System.Security.Permissions.HostProtectionResource protectedResources, System.Security.Permissions.HostProtectionResource demandedResources) { }
        public System.Security.Permissions.HostProtectionResource DemandedResources { get { throw null; } }
        public System.Security.Permissions.HostProtectionResource ProtectedResources { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum HostSecurityManagerOptions
    {
        AllFlags = 31,
        HostAppDomainEvidence = 1,
        HostAssemblyEvidence = 4,
        HostDetermineApplicationTrust = 8,
        HostPolicyLevel = 2,
        HostResolvePolicy = 16,
        None = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HostSecurityManager
    {
        public HostSecurityManager() { }
        public virtual System.Security.Policy.PolicyLevel DomainPolicy { get { throw null; } }
        public virtual System.Security.HostSecurityManagerOptions Flags { get { throw null; } }
        public virtual System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence applicationEvidence, System.Security.Policy.Evidence activatorEvidence, System.Security.Policy.TrustManagerContext context) { throw null; }
        public virtual System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence inputEvidence) { throw null; }
        public virtual System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly loadedAssembly, System.Security.Policy.Evidence inputEvidence) { throw null; }
        public virtual System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IEvidenceFactory
    {
        System.Security.Policy.Evidence Evidence { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IPermission : System.Security.ISecurityEncodable
    {
        System.Security.IPermission Copy();
        void Demand();
        System.Security.IPermission Intersect(System.Security.IPermission target);
        bool IsSubsetOf(System.Security.IPermission target);
        System.Security.IPermission Union(System.Security.IPermission target);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISecurityEncodable
    {
        void FromXml(System.Security.SecurityElement e);
        System.Security.SecurityElement ToXml();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISecurityPolicyEncodable
    {
        void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level);
        System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IStackWalk
    {
        void Assert();
        void Demand();
        void Deny();
        void PermitOnly();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class NamedPermissionSet : System.Security.PermissionSet
    {
        public NamedPermissionSet(System.Security.NamedPermissionSet permSet) : base (default(System.Security.Permissions.PermissionState)) { }
        public NamedPermissionSet(string name) : base (default(System.Security.Permissions.PermissionState)) { }
        public NamedPermissionSet(string name, System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
        public NamedPermissionSet(string name, System.Security.PermissionSet permSet) : base (default(System.Security.Permissions.PermissionState)) { }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public override System.Security.PermissionSet Copy() { throw null; }
        public System.Security.NamedPermissionSet Copy(string name) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public override void FromXml(System.Security.SecurityElement et) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PermissionSet : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Security.ISecurityEncodable, System.Security.IStackWalk
    {
        public PermissionSet(System.Security.Permissions.PermissionState state) { }
        public PermissionSet(System.Security.PermissionSet permSet) { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public System.Security.IPermission AddPermission(System.Security.IPermission perm) { throw null; }
        public void Assert() { }
        public bool ContainsNonCodeAccessPermissions() { throw null; }
        public virtual System.Security.PermissionSet Copy() { throw null; }
        public virtual void CopyTo(System.Array array, int index) { }
        public void Demand() { }
        public void Deny() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public virtual void FromXml(System.Security.SecurityElement et) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public System.Security.IPermission GetPermission(System.Type permClass) { throw null; }
        public System.Security.PermissionSet Intersect(System.Security.PermissionSet other) { throw null; }
        public bool IsEmpty() { throw null; }
        public bool IsSubsetOf(System.Security.PermissionSet target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public void PermitOnly() { }
        public System.Security.IPermission RemovePermission(System.Type permClass) { throw null; }
        public static void RevertAssert() { }
        public System.Security.IPermission SetPermission(System.Security.IPermission perm) { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        public override string ToString() { throw null; }
        public virtual System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.PermissionSet Union(System.Security.PermissionSet other) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PolicyLevelType
    {
        AppDomain = 3,
        Enterprise = 2,
        Machine = 1,
        User = 0,
    }
    public sealed partial class SecurityContext : System.IDisposable
    {
        internal SecurityContext() { }
        public static System.Security.SecurityContext Capture() { throw null; }
        public System.Security.SecurityContext CreateCopy() { throw null; }
        public void Dispose() { }
        public static bool IsFlowSuppressed() { throw null; }
        public static bool IsWindowsIdentityFlowSuppressed() { throw null; }
        public static void RestoreFlow() { }
        public static void Run(System.Security.SecurityContext securityContext, System.Threading.ContextCallback callback, object state) { }
        public static System.Threading.AsyncFlowControl SuppressFlow() { throw null; }
        public static System.Threading.AsyncFlowControl SuppressFlowWindowsIdentity() { throw null; }
    }
    public enum SecurityContextSource
    {
        CurrentAppDomain = 0,
        CurrentAssembly = 1,
    }
    [System.ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
    public enum SecurityCriticalScope
    {
        Everything = 1,
        Explicit = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class SecurityManager
    {
        [System.ObsoleteAttribute]
        public static bool CheckExecutionRights { get { throw null; } set { } }
        [System.ObsoleteAttribute("The security manager cannot be turned off on MS runtime")]
        public static bool SecurityEnabled { get { throw null; } set { } }
        public static bool CurrentThreadRequiresSecurityContextCapture() { throw null; }
        public static System.Security.PermissionSet GetStandardSandbox(System.Security.Policy.Evidence evidence) { throw null; }
        [System.Security.Permissions.StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, PublicKey="0x00000000000000000400000000000000")]
        public static void GetZoneAndOrigin(out System.Collections.ArrayList zone, out System.Collections.ArrayList origin) { zone = default(System.Collections.ArrayList); origin = default(System.Collections.ArrayList); }
        [System.ObsoleteAttribute]
        public static bool IsGranted(System.Security.IPermission perm) { throw null; }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromFile(string path, System.Security.PolicyLevelType type) { throw null; }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromString(string str, System.Security.PolicyLevelType type) { throw null; }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Collections.IEnumerator PolicyHierarchy() { throw null; }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) { throw null; }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence, System.Security.PermissionSet reqdPset, System.Security.PermissionSet optPset, System.Security.PermissionSet denyPset, out System.Security.PermissionSet denied) { denied = default(System.Security.PermissionSet); throw null; }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence[] evidences) { throw null; }
        [System.ObsoleteAttribute]
        public static System.Collections.IEnumerator ResolvePolicyGroups(System.Security.Policy.Evidence evidence) { throw null; }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolveSystemPolicy(System.Security.Policy.Evidence evidence) { throw null; }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static void SavePolicy() { }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static void SavePolicyLevel(System.Security.Policy.PolicyLevel level) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityZone
    {
        Internet = 3,
        Intranet = 1,
        MyComputer = 0,
        NoZone = -1,
        Trusted = 2,
        Untrusted = 4,
    }
}
namespace System.Security.Permissions
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CodeAccessSecurityAttribute : System.Security.Permissions.SecurityAttribute
    {
        protected CodeAccessSecurityAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class EnvironmentPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public EnvironmentPermission(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
        public EnvironmentPermission(System.Security.Permissions.PermissionState state) { }
        public void AddPathList(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public string GetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag) { throw null; }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public void SetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum EnvironmentPermissionAccess
    {
        AllAccess = 3,
        NoAccess = 0,
        Read = 1,
        Write = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class EnvironmentPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string All { get { throw null; } set { } }
        public string Read { get { throw null; } set { } }
        public string Write { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileDialogPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public FileDialogPermission(System.Security.Permissions.FileDialogPermissionAccess access) { }
        public FileDialogPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.FileDialogPermissionAccess Access { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FileDialogPermissionAccess
    {
        None = 0,
        Open = 1,
        OpenSave = 3,
        Save = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileDialogPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public FileDialogPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool Open { get { throw null; } set { } }
        public bool Save { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileIOPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string path) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string[] pathList) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public FileIOPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { throw null; } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { throw null; } set { } }
        public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public override System.Security.IPermission Copy() { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FileIOPermissionAccess
    {
        AllAccess = 15,
        Append = 4,
        NoAccess = 0,
        PathDiscovery = 8,
        Read = 1,
        Write = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileIOPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public FileIOPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        [System.ObsoleteAttribute("use newer properties")]
        public string All { get { throw null; } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { throw null; } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { throw null; } set { } }
        public string Append { get { throw null; } set { } }
        public string ChangeAccessControl { get { throw null; } set { } }
        public string PathDiscovery { get { throw null; } set { } }
        public string Read { get { throw null; } set { } }
        public string ViewAccessControl { get { throw null; } set { } }
        public string ViewAndModify { get { throw null; } set { } }
        public string Write { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacIdentityPermission : System.Security.CodeAccessPermission
    {
        public GacIdentityPermission() { }
        public GacIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public GacIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4205), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class HostProtectionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public HostProtectionAttribute() : base (default(System.Security.Permissions.SecurityAction)) { }
        public HostProtectionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool ExternalProcessMgmt { get { throw null; } set { } }
        public bool ExternalThreading { get { throw null; } set { } }
        public bool MayLeakOnAbort { get { throw null; } set { } }
        public System.Security.Permissions.HostProtectionResource Resources { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool SecurityInfrastructure { get { throw null; } set { } }
        public bool SelfAffectingProcessMgmt { get { throw null; } set { } }
        public bool SelfAffectingThreading { get { throw null; } set { } }
        public bool SharedState { get { throw null; } set { } }
        public bool Synchronization { get { throw null; } set { } }
        public bool UI { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum HostProtectionResource
    {
        All = 511,
        ExternalProcessMgmt = 4,
        ExternalThreading = 16,
        MayLeakOnAbort = 256,
        None = 0,
        SecurityInfrastructure = 64,
        SelfAffectingProcessMgmt = 8,
        SelfAffectingThreading = 32,
        SharedState = 2,
        Synchronization = 1,
        UI = 128,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum IsolatedStorageContainment
    {
        AdministerIsolatedStorageByUser = 112,
        ApplicationIsolationByMachine = 69,
        ApplicationIsolationByRoamingUser = 101,
        ApplicationIsolationByUser = 21,
        AssemblyIsolationByMachine = 64,
        AssemblyIsolationByRoamingUser = 96,
        AssemblyIsolationByUser = 32,
        DomainIsolationByMachine = 48,
        DomainIsolationByRoamingUser = 80,
        DomainIsolationByUser = 16,
        None = 0,
        UnrestrictedIsolatedStorage = 240,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFilePermission : System.Security.Permissions.IsolatedStoragePermission
    {
        public IsolatedStorageFilePermission(System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFilePermissionAttribute : System.Security.Permissions.IsolatedStoragePermissionAttribute
    {
        public IsolatedStorageFilePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        protected IsolatedStoragePermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { throw null; } set { } }
        public long UserQuota { get { throw null; } set { } }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        protected IsolatedStoragePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { throw null; } set { } }
        public long UserQuota { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IUnrestrictedPermission
    {
        bool IsUnrestricted();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public KeyContainerPermission(System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public KeyContainerPermission(System.Security.Permissions.KeyContainerPermissionFlags flags, System.Security.Permissions.KeyContainerPermissionAccessEntry[] accessList) { }
        public KeyContainerPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.KeyContainerPermissionAccessEntryCollection AccessEntries { get { throw null; } }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { throw null; } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntry
    {
        public KeyContainerPermissionAccessEntry(System.Security.Cryptography.CspParameters parameters, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public KeyContainerPermissionAccessEntry(string keyContainerName, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { throw null; } set { } }
        public string KeyContainerName { get { throw null; } set { } }
        public int KeySpec { get { throw null; } set { } }
        public string KeyStore { get { throw null; } set { } }
        public string ProviderName { get { throw null; } set { } }
        public int ProviderType { get { throw null; } set { } }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntryCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal KeyContainerPermissionAccessEntryCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Permissions.KeyContainerPermissionAccessEntry this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { throw null; }
        public void Clear() { }
        public void CopyTo(System.Security.Permissions.KeyContainerPermissionAccessEntry[] array, int index) { }
        public System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { throw null; }
        public void Remove(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntryEnumerator : System.Collections.IEnumerator
    {
        internal KeyContainerPermissionAccessEntryEnumerator() { }
        public System.Security.Permissions.KeyContainerPermissionAccessEntry Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public KeyContainerPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { throw null; } set { } }
        public string KeyContainerName { get { throw null; } set { } }
        public int KeySpec { get { throw null; } set { } }
        public string KeyStore { get { throw null; } set { } }
        public string ProviderName { get { throw null; } set { } }
        public int ProviderType { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum KeyContainerPermissionFlags
    {
        AllFlags = 13111,
        ChangeAcl = 8192,
        Create = 1,
        Decrypt = 512,
        Delete = 4,
        Export = 32,
        Import = 16,
        NoFlags = 0,
        Open = 2,
        Sign = 256,
        ViewAcl = 4096,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PermissionSetAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PermissionSetAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string File { get { throw null; } set { } }
        public string Hex { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public bool UnicodeEncoded { get { throw null; } set { } }
        public string XML { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
        public System.Security.PermissionSet CreatePermissionSet() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PermissionState
    {
        None = 0,
        Unrestricted = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PrincipalPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.Permissions.IUnrestrictedPermission
    {
        public PrincipalPermission(System.Security.Permissions.PermissionState state) { }
        public PrincipalPermission(string name, string role) { }
        public PrincipalPermission(string name, string role, bool isAuthenticated) { }
        public System.Security.IPermission Copy() { throw null; }
        public void Demand() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public void FromXml(System.Security.SecurityElement elem) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PrincipalPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PrincipalPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool Authenticated { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Role { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherIdentityPermission : System.Security.CodeAccessPermission
    {
        public PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public PublisherIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PublisherIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string CertFile { get { throw null; } set { } }
        public string SignedFile { get { throw null; } set { } }
        public string X509Certificate { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ReflectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public ReflectionPermission(System.Security.Permissions.PermissionState state) { }
        public ReflectionPermission(System.Security.Permissions.ReflectionPermissionFlag flag) { }
        public System.Security.Permissions.ReflectionPermissionFlag Flags { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ReflectionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.ReflectionPermissionFlag Flags { get { throw null; } set { } }
        public bool MemberAccess { get { throw null; } set { } }
        [System.ObsoleteAttribute]
        public bool ReflectionEmit { get { throw null; } set { } }
        public bool RestrictedMemberAccess { get { throw null; } set { } }
        [System.ObsoleteAttribute("not enforced in 2.0+")]
        public bool TypeInformation { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ReflectionPermissionFlag
    {
        [System.ObsoleteAttribute]
        AllFlags = 7,
        MemberAccess = 2,
        NoFlags = 0,
        [System.ObsoleteAttribute]
        ReflectionEmit = 4,
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        RestrictedMemberAccess = 8,
        [System.ObsoleteAttribute("not used anymore")]
        TypeInformation = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class RegistryPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public RegistryPermission(System.Security.Permissions.PermissionState state) { }
        public RegistryPermission(System.Security.Permissions.RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) { }
        public RegistryPermission(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
        public void AddPathList(System.Security.Permissions.RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) { }
        public void AddPathList(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public string GetPathList(System.Security.Permissions.RegistryPermissionAccess access) { throw null; }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public void SetPathList(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission other) { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum RegistryPermissionAccess
    {
        AllAccess = 7,
        Create = 4,
        NoAccess = 0,
        Read = 1,
        Write = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class RegistryPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public RegistryPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        [System.ObsoleteAttribute("use newer properties")]
        public string All { get { throw null; } set { } }
        public string ChangeAccessControl { get { throw null; } set { } }
        public string Create { get { throw null; } set { } }
        public string Read { get { throw null; } set { } }
        public string ViewAccessControl { get { throw null; } set { } }
        public string ViewAndModify { get { throw null; } set { } }
        public string Write { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityAction
    {
        Assert = 3,
        Demand = 2,
        [System.ObsoleteAttribute("This requests should not be used")]
        Deny = 4,
        InheritanceDemand = 7,
        LinkDemand = 6,
        PermitOnly = 5,
        [System.ObsoleteAttribute("This requests should not be used")]
        RequestMinimum = 8,
        [System.ObsoleteAttribute("This requests should not be used")]
        RequestOptional = 9,
        [System.ObsoleteAttribute("This requests should not be used")]
        RequestRefuse = 10,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class SecurityAttribute : System.Attribute
    {
        protected SecurityAttribute(System.Security.Permissions.SecurityAction action) { }
        public System.Security.Permissions.SecurityAction Action { get { throw null; } set { } }
        public bool Unrestricted { get { throw null; } set { } }
        public abstract System.Security.IPermission CreatePermission();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public SecurityPermission(System.Security.Permissions.PermissionState state) { }
        public SecurityPermission(System.Security.Permissions.SecurityPermissionFlag flag) { }
        public System.Security.Permissions.SecurityPermissionFlag Flags { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SecurityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool Assertion { get { throw null; } set { } }
        public bool BindingRedirects { get { throw null; } set { } }
        public bool ControlAppDomain { get { throw null; } set { } }
        public bool ControlDomainPolicy { get { throw null; } set { } }
        public bool ControlEvidence { get { throw null; } set { } }
        public bool ControlPolicy { get { throw null; } set { } }
        public bool ControlPrincipal { get { throw null; } set { } }
        public bool ControlThread { get { throw null; } set { } }
        public bool Execution { get { throw null; } set { } }
        public System.Security.Permissions.SecurityPermissionFlag Flags { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool Infrastructure { get { throw null; } set { } }
        public bool RemotingConfiguration { get { throw null; } set { } }
        public bool SerializationFormatter { get { throw null; } set { } }
        public bool SkipVerification { get { throw null; } set { } }
        public bool UnmanagedCode { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityPermissionFlag
    {
        AllFlags = 16383,
        Assertion = 1,
        BindingRedirects = 8192,
        ControlAppDomain = 1024,
        ControlDomainPolicy = 256,
        ControlEvidence = 32,
        ControlPolicy = 64,
        ControlPrincipal = 512,
        ControlThread = 16,
        Execution = 8,
        Infrastructure = 4096,
        NoFlags = 0,
        RemotingConfiguration = 2048,
        SerializationFormatter = 128,
        SkipVerification = 4,
        UnmanagedCode = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SiteIdentityPermission : System.Security.CodeAccessPermission
    {
        public SiteIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public SiteIdentityPermission(string site) { }
        public string Site { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SiteIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SiteIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Site { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameIdentityPermission : System.Security.CodeAccessPermission
    {
        public StrongNameIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public StrongNameIdentityPermission(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { throw null; } set { } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { throw null; } set { } }
        public System.Version Version { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement e) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Name { get { throw null; } set { } }
        public string PublicKey { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNamePublicKeyBlob
    {
        public StrongNamePublicKeyBlob(byte[] publicKey) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class TypeDescriptorPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public TypeDescriptorPermission(System.Security.Permissions.PermissionState state) { }
        public TypeDescriptorPermission(System.Security.Permissions.TypeDescriptorPermissionFlags flag) { }
        public System.Security.Permissions.TypeDescriptorPermissionFlags Flags { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.FlagsAttribute]
    public enum TypeDescriptorPermissionFlags
    {
        NoFlags = 0,
        RestrictedRegistrationAccess = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UIPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public UIPermission(System.Security.Permissions.PermissionState state) { }
        public UIPermission(System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
        public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag) { }
        public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag, System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
        public System.Security.Permissions.UIPermissionClipboard Clipboard { get { throw null; } set { } }
        public System.Security.Permissions.UIPermissionWindow Window { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UIPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public UIPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.UIPermissionClipboard Clipboard { get { throw null; } set { } }
        public System.Security.Permissions.UIPermissionWindow Window { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UIPermissionClipboard
    {
        AllClipboard = 2,
        NoClipboard = 0,
        OwnClipboard = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UIPermissionWindow
    {
        AllWindows = 3,
        NoWindows = 0,
        SafeSubWindows = 1,
        SafeTopLevelWindows = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlIdentityPermission : System.Security.CodeAccessPermission
    {
        public UrlIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public UrlIdentityPermission(string site) { }
        public string Url { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public UrlIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Url { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneIdentityPermission : System.Security.CodeAccessPermission
    {
        public ZoneIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public ZoneIdentityPermission(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ZoneIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.SecurityZone Zone { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
}
namespace System.Security.Policy
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AllMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public AllMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationDirectory : System.Security.Policy.EvidenceBase
    {
        public ApplicationDirectory(string name) { }
        public string Directory { get { throw null; } }
        public object Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationDirectoryMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public ApplicationDirectoryMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationSecurityInfo
    {
        public ApplicationSecurityInfo(System.ActivationContext activationContext) { }
        public System.Security.Policy.Evidence ApplicationEvidence { get { throw null; } set { } }
        public System.ApplicationId ApplicationId { get { throw null; } set { } }
        public System.Security.PermissionSet DefaultRequestSet { get { throw null; } set { } }
        public System.ApplicationId DeploymentId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class ApplicationSecurityManager
    {
        public static System.Security.Policy.IApplicationTrustManager ApplicationTrustManager { get { throw null; } }
        public static System.Security.Policy.ApplicationTrustCollection UserApplicationTrusts { get { throw null; } }
        public static bool DetermineApplicationTrust(System.ActivationContext activationContext, System.Security.Policy.TrustManagerContext context) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrust : System.Security.Policy.EvidenceBase, System.Security.ISecurityEncodable
    {
        public ApplicationTrust() { }
        public ApplicationTrust(System.ApplicationIdentity applicationIdentity) { }
        public ApplicationTrust(System.Security.PermissionSet defaultGrantSet, System.Collections.Generic.IEnumerable<System.Security.Policy.StrongName> fullTrustAssemblies) { }
        public System.ApplicationIdentity ApplicationIdentity { get { throw null; } set { } }
        public System.Security.Policy.PolicyStatement DefaultGrantSet { get { throw null; } set { } }
        public object ExtraInfo { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.Security.Policy.StrongName> FullTrustAssemblies { get { throw null; } }
        public bool IsApplicationTrustedToRun { get { throw null; } set { } }
        public bool Persist { get { throw null; } set { } }
        public void FromXml(System.Security.SecurityElement element) { }
        public System.Security.SecurityElement ToXml() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrustCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal ApplicationTrustCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Policy.ApplicationTrust this[int index] { get { throw null; } }
        public System.Security.Policy.ApplicationTrust this[string appFullName] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Policy.ApplicationTrust trust) { throw null; }
        public void AddRange(System.Security.Policy.ApplicationTrust[] trusts) { }
        public void AddRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
        public void Clear() { }
        public void CopyTo(System.Security.Policy.ApplicationTrust[] array, int index) { }
        public System.Security.Policy.ApplicationTrustCollection Find(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { throw null; }
        public System.Security.Policy.ApplicationTrustEnumerator GetEnumerator() { throw null; }
        public void Remove(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { }
        public void Remove(System.Security.Policy.ApplicationTrust trust) { }
        public void RemoveRange(System.Security.Policy.ApplicationTrust[] trusts) { }
        public void RemoveRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrustEnumerator : System.Collections.IEnumerator
    {
        internal ApplicationTrustEnumerator() { }
        public System.Security.Policy.ApplicationTrust Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ApplicationVersionMatch
    {
        MatchAllVersions = 1,
        MatchExactVersion = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CodeConnectAccess
    {
        public static readonly string AnyScheme;
        public static readonly int DefaultPort;
        public static readonly int OriginPort;
        public static readonly string OriginScheme;
        public CodeConnectAccess(string allowScheme, int allowPort) { }
        public int Port { get { throw null; } }
        public string Scheme { get { throw null; } }
        public static System.Security.Policy.CodeConnectAccess CreateAnySchemeAccess(int allowPort) { throw null; }
        public static System.Security.Policy.CodeConnectAccess CreateOriginSchemeAccess(int allowPort) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CodeGroup
    {
        protected CodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) { }
        public virtual string AttributeString { get { throw null; } }
        public System.Collections.IList Children { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Security.Policy.IMembershipCondition MembershipCondition { get { throw null; } set { } }
        public abstract string MergeLogic { get; }
        public string Name { get { throw null; } set { } }
        public virtual string PermissionSetName { get { throw null; } }
        public System.Security.Policy.PolicyStatement PolicyStatement { get { throw null; } set { } }
        public void AddChild(System.Security.Policy.CodeGroup group) { }
        public abstract System.Security.Policy.CodeGroup Copy();
        protected virtual void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { throw null; }
        public bool Equals(System.Security.Policy.CodeGroup cg, bool compareChildren) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        protected virtual void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public void RemoveChild(System.Security.Policy.CodeGroup group) { }
        public abstract System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence);
        public abstract System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence);
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Evidence : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public Evidence() { }
        [System.ObsoleteAttribute]
        public Evidence(object[] hostEvidence, object[] assemblyEvidence) { }
        public Evidence(System.Security.Policy.Evidence evidence) { }
        [System.ObsoleteAttribute]
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public bool Locked { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        [System.ObsoleteAttribute]
        public void AddAssembly(object id) { }
        [System.ObsoleteAttribute]
        public void AddHost(object id) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void Clear() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.Policy.Evidence Clone() { throw null; }
        [System.ObsoleteAttribute]
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetAssemblyEnumerator() { throw null; }
        [System.ObsoleteAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.Collections.IEnumerator GetHostEnumerator() { throw null; }
        public void Merge(System.Security.Policy.Evidence evidence) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void RemoveType(System.Type t) { }
    }
    public abstract partial class EvidenceBase
    {
        protected EvidenceBase() { }
        public virtual System.Security.Policy.EvidenceBase Clone() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileCodeGroup : System.Security.Policy.CodeGroup
    {
        public FileCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Permissions.FileIOPermissionAccess access) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string AttributeString { get { throw null; } }
        public override string MergeLogic { get { throw null; } }
        public override string PermissionSetName { get { throw null; } }
        public override System.Security.Policy.CodeGroup Copy() { throw null; }
        protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { throw null; }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FirstMatchCodeGroup : System.Security.Policy.CodeGroup
    {
        public FirstMatchCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string MergeLogic { get { throw null; } }
        public override System.Security.Policy.CodeGroup Copy() { throw null; }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { throw null; }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacInstalled : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public GacInstalled() { }
        public object Copy() { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public GacMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Hash : System.Security.Policy.EvidenceBase, System.Runtime.Serialization.ISerializable
    {
        public Hash(System.Reflection.Assembly assembly) { }
        public byte[] MD5 { get { throw null; } }
        public byte[] SHA1 { get { throw null; } }
        public static System.Security.Policy.Hash CreateMD5(byte[] md5) { throw null; }
        public static System.Security.Policy.Hash CreateSHA1(byte[] sha1) { throw null; }
        public byte[] GenerateHash(System.Security.Cryptography.HashAlgorithm hashAlg) { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class HashMembershipCondition : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable, System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public HashMembershipCondition(System.Security.Cryptography.HashAlgorithm hashAlg, byte[] value) { }
        public System.Security.Cryptography.HashAlgorithm HashAlgorithm { get { throw null; } set { } }
        public byte[] HashValue { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IApplicationTrustManager : System.Security.ISecurityEncodable
    {
        System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.ActivationContext activationContext, System.Security.Policy.TrustManagerContext context);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IIdentityPermissionFactory
    {
        System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
    {
        bool Check(System.Security.Policy.Evidence evidence);
        System.Security.Policy.IMembershipCondition Copy();
        bool Equals(object obj);
        string ToString();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class NetCodeGroup : System.Security.Policy.CodeGroup
    {
        public static readonly string AbsentOriginScheme;
        public static readonly string AnyOtherOriginScheme;
        public NetCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string AttributeString { get { throw null; } }
        public override string MergeLogic { get { throw null; } }
        public override string PermissionSetName { get { throw null; } }
        public void AddConnectAccess(string originScheme, System.Security.Policy.CodeConnectAccess connectAccess) { }
        public override System.Security.Policy.CodeGroup Copy() { throw null; }
        protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { throw null; }
        public System.Collections.DictionaryEntry[] GetConnectAccessRules() { throw null; }
        public override int GetHashCode() { throw null; }
        protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public void ResetConnectAccess() { }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { throw null; }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PermissionRequestEvidence : System.Security.Policy.EvidenceBase
    {
        public PermissionRequestEvidence(System.Security.PermissionSet request, System.Security.PermissionSet optional, System.Security.PermissionSet denied) { }
        public System.Security.PermissionSet DeniedPermissions { get { throw null; } }
        public System.Security.PermissionSet OptionalPermissions { get { throw null; } }
        public System.Security.PermissionSet RequestedPermissions { get { throw null; } }
        public System.Security.Policy.PermissionRequestEvidence Copy() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PolicyException : System.SystemException
    {
        public PolicyException() { }
        protected PolicyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PolicyException(string message) { }
        public PolicyException(string message, System.Exception exception) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PolicyLevel
    {
        internal PolicyLevel() { }
        public System.Collections.IList FullTrustAssemblies { get { throw null; } }
        public string Label { get { throw null; } }
        public System.Collections.IList NamedPermissionSets { get { throw null; } }
        public System.Security.Policy.CodeGroup RootCodeGroup { get { throw null; } set { } }
        public string StoreLocation { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.PolicyLevelType Type { get { throw null; } }
        public void AddFullTrustAssembly(System.Security.Policy.StrongName sn) { }
        public void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
        public void AddNamedPermissionSet(System.Security.NamedPermissionSet permSet) { }
        public System.Security.NamedPermissionSet ChangeNamedPermissionSet(string name, System.Security.PermissionSet pSet) { throw null; }
        public static System.Security.Policy.PolicyLevel CreateAppDomainLevel() { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public System.Security.NamedPermissionSet GetNamedPermissionSet(string name) { throw null; }
        public void Recover() { }
        public void RemoveFullTrustAssembly(System.Security.Policy.StrongName sn) { }
        public void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
        public System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet permSet) { throw null; }
        public System.Security.NamedPermissionSet RemoveNamedPermissionSet(string name) { throw null; }
        public void Reset() { }
        public System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PolicyStatement : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
    {
        public PolicyStatement(System.Security.PermissionSet permSet) { }
        public PolicyStatement(System.Security.PermissionSet permSet, System.Security.Policy.PolicyStatementAttribute attributes) { }
        public System.Security.Policy.PolicyStatementAttribute Attributes { get { throw null; } set { } }
        public string AttributeString { get { throw null; } }
        public System.Security.PermissionSet PermissionSet { get { throw null; } set { } }
        public System.Security.Policy.PolicyStatement Copy() { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { throw null; }
        public void FromXml(System.Security.SecurityElement et) { }
        public void FromXml(System.Security.SecurityElement et, System.Security.Policy.PolicyLevel level) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PolicyStatementAttribute
    {
        All = 3,
        Exclusive = 1,
        LevelFinal = 2,
        Nothing = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Publisher : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Publisher(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { throw null; } }
        public object Copy() { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public PublisherMembershipCondition(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Site : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Site(string name) { }
        public string Name { get { throw null; } }
        public object Copy() { throw null; }
        public static System.Security.Policy.Site CreateFromUrl(string url) { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SiteMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public SiteMembershipCondition(string site) { }
        public string Site { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongName : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public StrongName(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { throw null; } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { throw null; } }
        public System.Version Version { get { throw null; } }
        public object Copy() { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public StrongNameMembershipCondition(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { throw null; } set { } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { throw null; } set { } }
        public System.Version Version { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TrustManagerContext
    {
        public TrustManagerContext() { }
        public TrustManagerContext(System.Security.Policy.TrustManagerUIContext uiContext) { }
        public virtual bool IgnorePersistedDecision { get { throw null; } set { } }
        public virtual bool KeepAlive { get { throw null; } set { } }
        public virtual bool NoPrompt { get { throw null; } set { } }
        public virtual bool Persist { get { throw null; } set { } }
        public virtual System.ApplicationIdentity PreviousApplicationIdentity { get { throw null; } set { } }
        public virtual System.Security.Policy.TrustManagerUIContext UIContext { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TrustManagerUIContext
    {
        Install = 0,
        Run = 2,
        Upgrade = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnionCodeGroup : System.Security.Policy.CodeGroup
    {
        public UnionCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string MergeLogic { get { throw null; } }
        public override System.Security.Policy.CodeGroup Copy() { throw null; }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { throw null; }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Url : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Url(string name) { }
        public string Value { get { throw null; } }
        public object Copy() { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public UrlMembershipCondition(string url) { }
        public string Url { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Zone : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Zone(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { throw null; } }
        public object Copy() { throw null; }
        public static System.Security.Policy.Zone CreateFromUrl(string url) { throw null; }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { throw null; }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public ZoneMembershipCondition(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { throw null; } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { throw null; }
        public System.Security.Policy.IMembershipCondition Copy() { throw null; }
        public override bool Equals(object o) { throw null; }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
        public System.Security.SecurityElement ToXml() { throw null; }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { throw null; }
    }
}
namespace System.Xml
{
    public partial class XmlSecureResolver : System.Xml.XmlResolver
    {
        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.PermissionSet permissionSet) { }
        public XmlSecureResolver(System.Xml.XmlResolver resolver, System.Security.Policy.Evidence evidence) { }
        public XmlSecureResolver(System.Xml.XmlResolver resolver, string securityUrl) { }
        public override System.Net.ICredentials Credentials { set { } }
        public static System.Security.Policy.Evidence CreateEvidenceForUrl(string securityUrl) { throw null; }
        public override object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn) { throw null; }
        public override System.Uri ResolveUri(System.Uri baseUri, string relativeUri) { throw null; }
    }
}
