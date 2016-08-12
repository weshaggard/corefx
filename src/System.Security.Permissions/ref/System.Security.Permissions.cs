// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System
{
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ActivationContext : System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        internal ActivationContext() { }
        public System.ActivationContext.ContextForm Form { get { return default(System.ActivationContext.ContextForm); } }
        public System.ApplicationIdentity Identity { get { return default(System.ApplicationIdentity); } }
        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity identity) { return default(System.ActivationContext); }
        public static System.ActivationContext CreatePartialActivationContext(System.ApplicationIdentity identity, string[] manifestPaths) { return default(System.ActivationContext); }
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
        public string Culture { get { return default(string); } }
        public string Name { get { return default(string); } }
        public string ProcessorArchitecture { get { return default(string); } }
        public byte[] PublicKeyToken { get { return default(byte[]); } }
        public System.Version Version { get { return default(System.Version); } }
        public System.ApplicationId Copy() { return default(System.ApplicationId); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationIdentity : System.Runtime.Serialization.ISerializable
    {
        public ApplicationIdentity(string applicationIdentityFullName) { }
        public string CodeBase { get { return default(string); } }
        public string FullName { get { return default(string); } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }
}
namespace System.Security
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, ControlEvidence=true, ControlPolicy=true)]
    public abstract partial class CodeAccessPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk
    {
        protected CodeAccessPermission() { }
        public void Assert() { }
        public abstract System.Security.IPermission Copy();
        public void Demand() { }
        public void Deny() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public abstract void FromXml(System.Security.SecurityElement elem);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public abstract System.Security.IPermission Intersect(System.Security.IPermission target);
        public abstract bool IsSubsetOf(System.Security.IPermission target);
        public void PermitOnly() { }
        public static void RevertAll() { }
        public static void RevertAssert() { }
        public static void RevertDeny() { }
        public static void RevertPermitOnly() { }
        public override string ToString() { return default(string); }
        public abstract System.Security.SecurityElement ToXml();
        public virtual System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
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
        public string Description { get { return default(string); } set { } }
        public string Name { get { return default(string); } set { } }
        public override System.Security.PermissionSet Copy() { return default(System.Security.PermissionSet); }
        public System.Security.NamedPermissionSet Copy(string name) { return default(System.Security.NamedPermissionSet); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public override void FromXml(System.Security.SecurityElement et) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PermissionSet : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Security.ISecurityEncodable, System.Security.IStackWalk
    {
        public PermissionSet(System.Security.Permissions.PermissionState state) { }
        public PermissionSet(System.Security.PermissionSet permSet) { }
        public virtual int Count { get { return default(int); } }
        public virtual bool IsReadOnly { get { return default(bool); } }
        public virtual bool IsSynchronized { get { return default(bool); } }
        public virtual object SyncRoot { get { return default(object); } }
        public System.Security.IPermission AddPermission(System.Security.IPermission perm) { return default(System.Security.IPermission); }
        public void Assert() { }
        public bool ContainsNonCodeAccessPermissions() { return default(bool); }
        public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat) { return default(byte[]); }
        public virtual System.Security.PermissionSet Copy() { return default(System.Security.PermissionSet); }
        public virtual void CopyTo(System.Array array, int index) { }
        public void Demand() { }
        public void Deny() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public virtual void FromXml(System.Security.SecurityElement et) { }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public System.Security.IPermission GetPermission(System.Type permClass) { return default(System.Security.IPermission); }
        public System.Security.PermissionSet Intersect(System.Security.PermissionSet other) { return default(System.Security.PermissionSet); }
        public bool IsEmpty() { return default(bool); }
        public bool IsSubsetOf(System.Security.PermissionSet target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public void PermitOnly() { }
        public System.Security.IPermission RemovePermission(System.Type permClass) { return default(System.Security.IPermission); }
        public static void RevertAssert() { }
        public System.Security.IPermission SetPermission(System.Security.IPermission perm) { return default(System.Security.IPermission); }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        public override string ToString() { return default(string); }
        public virtual System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.PermissionSet Union(System.Security.PermissionSet other) { return default(System.Security.PermissionSet); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PolicyLevelType
    {
        AppDomain = 3,
        Enterprise = 2,
        Machine = 1,
        User = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityElement
    {
        public SecurityElement(string tag) { }
        public SecurityElement(string tag, string text) { }
        public System.Collections.Hashtable Attributes { get { return default(System.Collections.Hashtable); } set { } }
        public System.Collections.ArrayList Children { get { return default(System.Collections.ArrayList); } set { } }
        public string Tag { get { return default(string); } set { } }
        public string Text { get { return default(string); } set { } }
        public void AddAttribute(string name, string value) { }
        public void AddChild(System.Security.SecurityElement child) { }
        public string Attribute(string name) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.SecurityElement Copy() { return default(System.Security.SecurityElement); }
        public bool Equal(System.Security.SecurityElement other) { return default(bool); }
        public static string Escape(string str) { return default(string); }
        public static System.Security.SecurityElement FromString(string xml) { return default(System.Security.SecurityElement); }
        public static bool IsValidAttributeName(string name) { return default(bool); }
        public static bool IsValidAttributeValue(string value) { return default(bool); }
        public static bool IsValidTag(string tag) { return default(bool); }
        public static bool IsValidText(string text) { return default(bool); }
        public System.Security.SecurityElement SearchForChildByTag(string tag) { return default(System.Security.SecurityElement); }
        public string SearchForTextOfTag(string tag) { return default(string); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class SecurityManager
    {
        [System.ObsoleteAttribute]
        public static bool CheckExecutionRights { get { return default(bool); } set { } }
        [System.ObsoleteAttribute("The security manager cannot be turned off on MS runtime")]
        public static bool SecurityEnabled { get { return default(bool); } set { } }
        public static bool CurrentThreadRequiresSecurityContextCapture() { return default(bool); }
        public static System.Security.PermissionSet GetStandardSandbox(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
        [System.Security.Permissions.StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, PublicKey="0x00000000000000000400000000000000")]
        public static void GetZoneAndOrigin(out System.Collections.ArrayList zone, out System.Collections.ArrayList origin) { zone = default(System.Collections.ArrayList); origin = default(System.Collections.ArrayList); }
        [System.ObsoleteAttribute]
        public static bool IsGranted(System.Security.IPermission perm) { return default(bool); }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromFile(string path, System.Security.PolicyLevelType type) { return default(System.Security.Policy.PolicyLevel); }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromString(string str, System.Security.PolicyLevelType type) { return default(System.Security.Policy.PolicyLevel); }
        [System.ObsoleteAttribute]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true)]
        public static System.Collections.IEnumerator PolicyHierarchy() { return default(System.Collections.IEnumerator); }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence, System.Security.PermissionSet reqdPset, System.Security.PermissionSet optPset, System.Security.PermissionSet denyPset, out System.Security.PermissionSet denied) { denied = default(System.Security.PermissionSet); return default(System.Security.PermissionSet); }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence[] evidences) { return default(System.Security.PermissionSet); }
        [System.ObsoleteAttribute]
        public static System.Collections.IEnumerator ResolvePolicyGroups(System.Security.Policy.Evidence evidence) { return default(System.Collections.IEnumerator); }
        [System.ObsoleteAttribute]
        public static System.Security.PermissionSet ResolveSystemPolicy(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(5188), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SuppressUnmanagedCodeSecurityAttribute : System.Attribute
    {
        public SuppressUnmanagedCodeSecurityAttribute() { }
    }
}
namespace System.Security.AccessControl
{
    [System.FlagsAttribute]
    public enum AccessControlActions
    {
        Change = 2,
        None = 0,
        View = 1,
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
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public string GetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag) { return default(string); }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public void SetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
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
        public string All { get { return default(string); } set { } }
        public string Read { get { return default(string); } set { } }
        public string Write { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileDialogPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public FileDialogPermission(System.Security.Permissions.FileDialogPermissionAccess access) { }
        public FileDialogPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.FileDialogPermissionAccess Access { get { return default(System.Security.Permissions.FileDialogPermissionAccess); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
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
        public bool Open { get { return default(bool); } set { } }
        public bool Save { get { return default(bool); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileIOPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string path) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string[] pathList) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public FileIOPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public string[] GetPathList(System.Security.Permissions.FileIOPermissionAccess access) { return default(string[]); }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
        public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
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
        public string All { get { return default(string); } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public string Append { get { return default(string); } set { } }
        public string ChangeAccessControl { get { return default(string); } set { } }
        public string PathDiscovery { get { return default(string); } set { } }
        public string Read { get { return default(string); } set { } }
        public string ViewAccessControl { get { return default(string); } set { } }
        public string ViewAndModify { get { return default(string); } set { } }
        public string Write { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacIdentityPermission : System.Security.CodeAccessPermission
    {
        public GacIdentityPermission() { }
        public GacIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public GacIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4205), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class HostProtectionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public HostProtectionAttribute() : base (default(System.Security.Permissions.SecurityAction)) { }
        public HostProtectionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool ExternalProcessMgmt { get { return default(bool); } set { } }
        public bool ExternalThreading { get { return default(bool); } set { } }
        public bool MayLeakOnAbort { get { return default(bool); } set { } }
        public System.Security.Permissions.HostProtectionResource Resources { get { return default(System.Security.Permissions.HostProtectionResource); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool SecurityInfrastructure { get { return default(bool); } set { } }
        public bool SelfAffectingProcessMgmt { get { return default(bool); } set { } }
        public bool SelfAffectingThreading { get { return default(bool); } set { } }
        public bool SharedState { get { return default(bool); } set { } }
        public bool Synchronization { get { return default(bool); } set { } }
        public bool UI { get { return default(bool); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
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
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFilePermissionAttribute : System.Security.Permissions.IsolatedStoragePermissionAttribute
    {
        public IsolatedStorageFilePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        protected IsolatedStoragePermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { return default(System.Security.Permissions.IsolatedStorageContainment); } set { } }
        public long UserQuota { get { return default(long); } set { } }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        protected IsolatedStoragePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { return default(System.Security.Permissions.IsolatedStorageContainment); } set { } }
        public long UserQuota { get { return default(long); } set { } }
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
        public System.Security.Permissions.KeyContainerPermissionAccessEntryCollection AccessEntries { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntryCollection); } }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntry
    {
        /*
            Excluding to avoid pulling a dependency on "System.Security.Cryptography.Csp" which is Windows specfic
        public KeyContainerPermissionAccessEntry(System.Security.Cryptography.CspParameters parameters, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        */
        public KeyContainerPermissionAccessEntry(string keyContainerName, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } set { } }
        public string KeyContainerName { get { return default(string); } set { } }
        public int KeySpec { get { return default(int); } set { } }
        public string KeyStore { get { return default(string); } set { } }
        public string ProviderName { get { return default(string); } set { } }
        public int ProviderType { get { return default(int); } set { } }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntryCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal KeyContainerPermissionAccessEntryCollection() { }
        public int Count { get { return default(int); } }
        public bool IsSynchronized { get { return default(bool); } }
        public System.Security.Permissions.KeyContainerPermissionAccessEntry this[int index] { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntry); } }
        public object SyncRoot { get { return default(object); } }
        public int Add(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { return default(int); }
        public void Clear() { }
        public void CopyTo(System.Security.Permissions.KeyContainerPermissionAccessEntry[] array, int index) { }
        public System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator GetEnumerator() { return default(System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator); }
        public int IndexOf(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { return default(int); }
        public void Remove(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAccessEntryEnumerator : System.Collections.IEnumerator
    {
        internal KeyContainerPermissionAccessEntryEnumerator() { }
        public System.Security.Permissions.KeyContainerPermissionAccessEntry Current { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntry); } }
        object System.Collections.IEnumerator.Current { get { return default(object); } }
        public bool MoveNext() { return default(bool); }
        public void Reset() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeyContainerPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public KeyContainerPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } set { } }
        public string KeyContainerName { get { return default(string); } set { } }
        public int KeySpec { get { return default(int); } set { } }
        public string KeyStore { get { return default(string); } set { } }
        public string ProviderName { get { return default(string); } set { } }
        public int ProviderType { get { return default(int); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
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
        public string File { get { return default(string); } set { } }
        public string Hex { get { return default(string); } set { } }
        public string Name { get { return default(string); } set { } }
        public bool UnicodeEncoded { get { return default(bool); } set { } }
        public string XML { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
        public System.Security.PermissionSet CreatePermissionSet() { return default(System.Security.PermissionSet); }
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
        public System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public void Demand() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public void FromXml(System.Security.SecurityElement elem) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PrincipalPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PrincipalPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool Authenticated { get { return default(bool); } set { } }
        public string Name { get { return default(string); } set { } }
        public string Role { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherIdentityPermission : System.Security.CodeAccessPermission
    {
        public PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public PublisherIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public PublisherIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string CertFile { get { return default(string); } set { } }
        public string SignedFile { get { return default(string); } set { } }
        public string X509Certificate { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ReflectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public ReflectionPermission(System.Security.Permissions.PermissionState state) { }
        public ReflectionPermission(System.Security.Permissions.ReflectionPermissionFlag flag) { }
        public System.Security.Permissions.ReflectionPermissionFlag Flags { get { return default(System.Security.Permissions.ReflectionPermissionFlag); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ReflectionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.ReflectionPermissionFlag Flags { get { return default(System.Security.Permissions.ReflectionPermissionFlag); } set { } }
        public bool MemberAccess { get { return default(bool); } set { } }
        [System.ObsoleteAttribute]
        public bool ReflectionEmit { get { return default(bool); } set { } }
        public bool RestrictedMemberAccess { get { return default(bool); } set { } }
        [System.ObsoleteAttribute("not enforced in 2.0+")]
        public bool TypeInformation { get { return default(bool); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
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
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public string GetPathList(System.Security.Permissions.RegistryPermissionAccess access) { return default(string); }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public void SetPathList(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
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
        public string All { get { return default(string); } set { } }
        public string ChangeAccessControl { get { return default(string); } set { } }
        public string Create { get { return default(string); } set { } }
        public string Read { get { return default(string); } set { } }
        public string ViewAccessControl { get { return default(string); } set { } }
        public string ViewAndModify { get { return default(string); } set { } }
        public string Write { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SecurityAction
    {
        Assert = 3,
        Demand = 2,
        Deny = 4,
        InheritanceDemand = 7,
        LinkDemand = 6,
        PermitOnly = 5,
        RequestMinimum = 8,
        RequestOptional = 9,
        RequestRefuse = 10,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class SecurityAttribute : System.Attribute
    {
        protected SecurityAttribute(System.Security.Permissions.SecurityAction action) { }
        public System.Security.Permissions.SecurityAction Action { get { return default(System.Security.Permissions.SecurityAction); } set { } }
        public bool Unrestricted { get { return default(bool); } set { } }
        public abstract System.Security.IPermission CreatePermission();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public SecurityPermission(System.Security.Permissions.PermissionState state) { }
        public SecurityPermission(System.Security.Permissions.SecurityPermissionFlag flag) { }
        public System.Security.Permissions.SecurityPermissionFlag Flags { get { return default(System.Security.Permissions.SecurityPermissionFlag); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SecurityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool Assertion { get { return default(bool); } set { } }
        public bool BindingRedirects { get { return default(bool); } set { } }
        public bool ControlAppDomain { get { return default(bool); } set { } }
        public bool ControlDomainPolicy { get { return default(bool); } set { } }
        public bool ControlEvidence { get { return default(bool); } set { } }
        public bool ControlPolicy { get { return default(bool); } set { } }
        public bool ControlPrincipal { get { return default(bool); } set { } }
        public bool ControlThread { get { return default(bool); } set { } }
        public bool Execution { get { return default(bool); } set { } }
        public System.Security.Permissions.SecurityPermissionFlag Flags { get { return default(System.Security.Permissions.SecurityPermissionFlag); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool Infrastructure { get { return default(bool); } set { } }
        public bool RemotingConfiguration { get { return default(bool); } set { } }
        public bool SerializationFormatter { get { return default(bool); } set { } }
        public bool SkipVerification { get { return default(bool); } set { } }
        public bool UnmanagedCode { get { return default(bool); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
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
        public string Site { get { return default(string); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SiteIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public SiteIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Site { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameIdentityPermission : System.Security.CodeAccessPermission
    {
        public StrongNameIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public StrongNameIdentityPermission(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { return default(string); } set { } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } set { } }
        public System.Version Version { get { return default(System.Version); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement e) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Name { get { return default(string); } set { } }
        public string PublicKey { get { return default(string); } set { } }
        public string Version { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNamePublicKeyBlob
    {
        public StrongNamePublicKeyBlob(byte[] publicKey) { }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UIPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public UIPermission(System.Security.Permissions.PermissionState state) { }
        public UIPermission(System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
        public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag) { }
        public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag, System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
        public System.Security.Permissions.UIPermissionClipboard Clipboard { get { return default(System.Security.Permissions.UIPermissionClipboard); } set { } }
        public System.Security.Permissions.UIPermissionWindow Window { get { return default(System.Security.Permissions.UIPermissionWindow); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UIPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public UIPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.UIPermissionClipboard Clipboard { get { return default(System.Security.Permissions.UIPermissionClipboard); } set { } }
        public System.Security.Permissions.UIPermissionWindow Window { get { return default(System.Security.Permissions.UIPermissionWindow); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
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
        public string Url { get { return default(string); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public UrlIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Url { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneIdentityPermission : System.Security.CodeAccessPermission
    {
        public ZoneIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public ZoneIdentityPermission(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } set { } }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ZoneIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.SecurityZone Zone { get { return default(System.Security.SecurityZone); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
}
namespace System.Security.Policy
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AllMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public AllMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationDirectory : System.Security.Policy.EvidenceBase
    {
        public ApplicationDirectory(string name) { }
        public string Directory { get { return default(string); } }
        public object Copy() { return default(object); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationDirectoryMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public ApplicationDirectoryMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationSecurityInfo
    {
        public ApplicationSecurityInfo(System.ActivationContext activationContext) { }
        public System.Security.Policy.Evidence ApplicationEvidence { get { return default(System.Security.Policy.Evidence); } set { } }
        public System.ApplicationId ApplicationId { get { return default(System.ApplicationId); } set { } }
        public System.Security.PermissionSet DefaultRequestSet { get { return default(System.Security.PermissionSet); } set { } }
        public System.ApplicationId DeploymentId { get { return default(System.ApplicationId); } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class ApplicationSecurityManager
    {
        public static System.Security.Policy.IApplicationTrustManager ApplicationTrustManager { get { return default(System.Security.Policy.IApplicationTrustManager); } }
        public static System.Security.Policy.ApplicationTrustCollection UserApplicationTrusts { get { return default(System.Security.Policy.ApplicationTrustCollection); } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, ControlPolicy=true, ControlEvidence=true)]
        public static bool DetermineApplicationTrust(System.ActivationContext activationContext, System.Security.Policy.TrustManagerContext context) { return default(bool); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrust : System.Security.Policy.EvidenceBase, System.Security.ISecurityEncodable
    {
        public ApplicationTrust() { }
        public ApplicationTrust(System.ApplicationIdentity applicationIdentity) { }
        public ApplicationTrust(System.Security.PermissionSet defaultGrantSet, System.Collections.Generic.IEnumerable<System.Security.Policy.StrongName> fullTrustAssemblies) { }
        public System.ApplicationIdentity ApplicationIdentity { get { return default(System.ApplicationIdentity); } set { } }
        public System.Security.Policy.PolicyStatement DefaultGrantSet { get { return default(System.Security.Policy.PolicyStatement); } set { } }
        public object ExtraInfo { get { return default(object); } set { } }
        public System.Collections.Generic.IList<System.Security.Policy.StrongName> FullTrustAssemblies { get { return default(System.Collections.Generic.IList<System.Security.Policy.StrongName>); } }
        public bool IsApplicationTrustedToRun { get { return default(bool); } set { } }
        public bool Persist { get { return default(bool); } set { } }
        public void FromXml(System.Security.SecurityElement element) { }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrustCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal ApplicationTrustCollection() { }
        public int Count { get { return default(int); } }
        public bool IsSynchronized { get { return default(bool); } }
        public System.Security.Policy.ApplicationTrust this[int index] { get { return default(System.Security.Policy.ApplicationTrust); } }
        public System.Security.Policy.ApplicationTrust this[string appFullName] { get { return default(System.Security.Policy.ApplicationTrust); } }
        public object SyncRoot { get { return default(object); } }
        public int Add(System.Security.Policy.ApplicationTrust trust) { return default(int); }
        public void AddRange(System.Security.Policy.ApplicationTrust[] trusts) { }
        public void AddRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
        public void Clear() { }
        public void CopyTo(System.Security.Policy.ApplicationTrust[] array, int index) { }
        public System.Security.Policy.ApplicationTrustCollection Find(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { return default(System.Security.Policy.ApplicationTrustCollection); }
        public System.Security.Policy.ApplicationTrustEnumerator GetEnumerator() { return default(System.Security.Policy.ApplicationTrustEnumerator); }
        public void Remove(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { }
        public void Remove(System.Security.Policy.ApplicationTrust trust) { }
        public void RemoveRange(System.Security.Policy.ApplicationTrust[] trusts) { }
        public void RemoveRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ApplicationTrustEnumerator : System.Collections.IEnumerator
    {
        internal ApplicationTrustEnumerator() { }
        public System.Security.Policy.ApplicationTrust Current { get { return default(System.Security.Policy.ApplicationTrust); } }
        object System.Collections.IEnumerator.Current { get { return default(object); } }
        public bool MoveNext() { return default(bool); }
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
        public int Port { get { return default(int); } }
        public string Scheme { get { return default(string); } }
        public static System.Security.Policy.CodeConnectAccess CreateAnySchemeAccess(int allowPort) { return default(System.Security.Policy.CodeConnectAccess); }
        public static System.Security.Policy.CodeConnectAccess CreateOriginSchemeAccess(int allowPort) { return default(System.Security.Policy.CodeConnectAccess); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class CodeGroup
    {
        protected CodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) { }
        public virtual string AttributeString { get { return default(string); } }
        public System.Collections.IList Children { get { return default(System.Collections.IList); } set { } }
        public string Description { get { return default(string); } set { } }
        public System.Security.Policy.IMembershipCondition MembershipCondition { get { return default(System.Security.Policy.IMembershipCondition); } set { } }
        public abstract string MergeLogic { get; }
        public string Name { get { return default(string); } set { } }
        public virtual string PermissionSetName { get { return default(string); } }
        public System.Security.Policy.PolicyStatement PolicyStatement { get { return default(System.Security.Policy.PolicyStatement); } set { } }
        public void AddChild(System.Security.Policy.CodeGroup group) { }
        public abstract System.Security.Policy.CodeGroup Copy();
        protected virtual void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { return default(bool); }
        public bool Equals(System.Security.Policy.CodeGroup cg, bool compareChildren) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        protected virtual void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public void RemoveChild(System.Security.Policy.CodeGroup group) { }
        public abstract System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence);
        public abstract System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence);
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Evidence : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public Evidence() { }
        [System.ObsoleteAttribute]
        public Evidence(object[] hostEvidence, object[] assemblyEvidence) { }
        public Evidence(System.Security.Policy.Evidence evidence) { }
        [System.ObsoleteAttribute]
        public int Count { get { return default(int); } }
        public bool IsReadOnly { get { return default(bool); } }
        public bool IsSynchronized { get { return default(bool); } }
        public bool Locked { get { return default(bool); } set { } }
        public object SyncRoot { get { return default(object); } }
        [System.ObsoleteAttribute]
        public void AddAssembly(object id) { }
        [System.ObsoleteAttribute]
        public void AddHost(object id) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void Clear() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.Policy.Evidence Clone() { return default(System.Security.Policy.Evidence); }
        [System.ObsoleteAttribute]
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetAssemblyEnumerator() { return default(System.Collections.IEnumerator); }
        [System.ObsoleteAttribute]
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        public System.Collections.IEnumerator GetHostEnumerator() { return default(System.Collections.IEnumerator); }
        public void Merge(System.Security.Policy.Evidence evidence) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void RemoveType(System.Type t) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Unrestricted=true)]
    public abstract partial class EvidenceBase
    {
        protected EvidenceBase() { }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, SerializationFormatter=true)]
        public virtual System.Security.Policy.EvidenceBase Clone() { return default(System.Security.Policy.EvidenceBase); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FileCodeGroup : System.Security.Policy.CodeGroup
    {
        public FileCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Permissions.FileIOPermissionAccess access) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string AttributeString { get { return default(string); } }
        public override string MergeLogic { get { return default(string); } }
        public override string PermissionSetName { get { return default(string); } }
        public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
        protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class FirstMatchCodeGroup : System.Security.Policy.CodeGroup
    {
        public FirstMatchCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
        public override string MergeLogic { get { return default(string); } }
        public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacInstalled : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public GacInstalled() { }
        public object Copy() { return default(object); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class GacMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public GacMembershipCondition() { }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Hash : System.Security.Policy.EvidenceBase, System.Runtime.Serialization.ISerializable
    {
        public Hash(System.Reflection.Assembly assembly) { }
        public byte[] MD5 { get { return default(byte[]); } }
        public byte[] SHA1 { get { return default(byte[]); } }
        public static System.Security.Policy.Hash CreateMD5(byte[] md5) { return default(System.Security.Policy.Hash); }
        public static System.Security.Policy.Hash CreateSHA1(byte[] sha1) { return default(System.Security.Policy.Hash); }
        public byte[] GenerateHash(System.Security.Cryptography.HashAlgorithm hashAlg) { return default(byte[]); }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class HashMembershipCondition : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable, System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public HashMembershipCondition(System.Security.Cryptography.HashAlgorithm hashAlg, byte[] value) { }
        public System.Security.Cryptography.HashAlgorithm HashAlgorithm { get { return default(System.Security.Cryptography.HashAlgorithm); } set { } }
        public byte[] HashValue { get { return default(byte[]); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
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
        public override string AttributeString { get { return default(string); } }
        public override string MergeLogic { get { return default(string); } }
        public override string PermissionSetName { get { return default(string); } }
        public void AddConnectAccess(string originScheme, System.Security.Policy.CodeConnectAccess connectAccess) { }
        public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
        protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
        public override bool Equals(object o) { return default(bool); }
        public System.Collections.DictionaryEntry[] GetConnectAccessRules() { return default(System.Collections.DictionaryEntry[]); }
        public override int GetHashCode() { return default(int); }
        protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public void ResetConnectAccess() { }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PermissionRequestEvidence : System.Security.Policy.EvidenceBase
    {
        public PermissionRequestEvidence(System.Security.PermissionSet request, System.Security.PermissionSet optional, System.Security.PermissionSet denied) { }
        public System.Security.PermissionSet DeniedPermissions { get { return default(System.Security.PermissionSet); } }
        public System.Security.PermissionSet OptionalPermissions { get { return default(System.Security.PermissionSet); } }
        public System.Security.PermissionSet RequestedPermissions { get { return default(System.Security.PermissionSet); } }
        public System.Security.Policy.PermissionRequestEvidence Copy() { return default(System.Security.Policy.PermissionRequestEvidence); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class PolicyException : System.Exception
    // Removing SystemException and _Exception: System.SystemException, System.Runtime.InteropServices._Exception
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
        [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
        public System.Collections.IList FullTrustAssemblies { get { return default(System.Collections.IList); } }
        public string Label { get { return default(string); } }
        public System.Collections.IList NamedPermissionSets { get { return default(System.Collections.IList); } }
        public System.Security.Policy.CodeGroup RootCodeGroup { get { return default(System.Security.Policy.CodeGroup); } set { } }
        public string StoreLocation { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.PolicyLevelType Type { get { return default(System.Security.PolicyLevelType); } }
        [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
        public void AddFullTrustAssembly(System.Security.Policy.StrongName sn) { }
        [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
        public void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
        public void AddNamedPermissionSet(System.Security.NamedPermissionSet permSet) { }
        public System.Security.NamedPermissionSet ChangeNamedPermissionSet(string name, System.Security.PermissionSet pSet) { return default(System.Security.NamedPermissionSet); }
        public static System.Security.Policy.PolicyLevel CreateAppDomainLevel() { return default(System.Security.Policy.PolicyLevel); }
        public void FromXml(System.Security.SecurityElement e) { }
        public System.Security.NamedPermissionSet GetNamedPermissionSet(string name) { return default(System.Security.NamedPermissionSet); }
        public void Recover() { }
        [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
        public void RemoveFullTrustAssembly(System.Security.Policy.StrongName sn) { }
        [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
        public void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
        public System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet permSet) { return default(System.Security.NamedPermissionSet); }
        public System.Security.NamedPermissionSet RemoveNamedPermissionSet(string name) { return default(System.Security.NamedPermissionSet); }
        public void Reset() { }
        public System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PolicyStatement : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable
    {
        public PolicyStatement(System.Security.PermissionSet permSet) { }
        public PolicyStatement(System.Security.PermissionSet permSet, System.Security.Policy.PolicyStatementAttribute attributes) { }
        public System.Security.Policy.PolicyStatementAttribute Attributes { get { return default(System.Security.Policy.PolicyStatementAttribute); } set { } }
        public string AttributeString { get { return default(string); } }
        public System.Security.PermissionSet PermissionSet { get { return default(System.Security.PermissionSet); } set { } }
        public System.Security.Policy.PolicyStatement Copy() { return default(System.Security.Policy.PolicyStatement); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object obj) { return default(bool); }
        public void FromXml(System.Security.SecurityElement et) { }
        public void FromXml(System.Security.SecurityElement et, System.Security.Policy.PolicyLevel level) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
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
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
        public object Copy() { return default(object); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PublisherMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public PublisherMembershipCondition(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Site : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Site(string name) { }
        public string Name { get { return default(string); } }
        public object Copy() { return default(object); }
        public static System.Security.Policy.Site CreateFromUrl(string url) { return default(System.Security.Policy.Site); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SiteMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public SiteMembershipCondition(string site) { }
        public string Site { get { return default(string); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongName : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public StrongName(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { return default(string); } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } }
        public System.Version Version { get { return default(System.Version); } }
        public object Copy() { return default(object); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class StrongNameMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public StrongNameMembershipCondition(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
        public string Name { get { return default(string); } set { } }
        public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } set { } }
        public System.Version Version { get { return default(System.Version); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TrustManagerContext
    {
        public TrustManagerContext() { }
        public TrustManagerContext(System.Security.Policy.TrustManagerUIContext uiContext) { }
        public virtual bool IgnorePersistedDecision { get { return default(bool); } set { } }
        public virtual bool KeepAlive { get { return default(bool); } set { } }
        public virtual bool NoPrompt { get { return default(bool); } set { } }
        public virtual bool Persist { get { return default(bool); } set { } }
        public virtual System.ApplicationIdentity PreviousApplicationIdentity { get { return default(System.ApplicationIdentity); } set { } }
        public virtual System.Security.Policy.TrustManagerUIContext UIContext { get { return default(System.Security.Policy.TrustManagerUIContext); } set { } }
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
        public override string MergeLogic { get { return default(string); } }
        public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
        public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
        public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Url : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Url(string name) { }
        public string Value { get { return default(string); } }
        public object Copy() { return default(object); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public UrlMembershipCondition(string url) { }
        public string Url { get { return default(string); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Zone : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory
    {
        public Zone(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } }
        public object Copy() { return default(object); }
        public static System.Security.Policy.Zone CreateFromUrl(string url) { return default(System.Security.Policy.Zone); }
        public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ZoneMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition
    {
        public ZoneMembershipCondition(System.Security.SecurityZone zone) { }
        public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } set { } }
        public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
        public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
        public override bool Equals(object o) { return default(bool); }
        public void FromXml(System.Security.SecurityElement e) { }
        public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
        public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
    }
}