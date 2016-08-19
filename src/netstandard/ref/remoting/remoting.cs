// Broken APIs
/*
    public sealed partial class Activator
    {
        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) { throw null; }
        public static System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext, string[] activationCustomData) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(System.AppDomain domain, string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public static T CreateInstance<T>() { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.ObsoleteAttribute("Methods which use Evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(System.AppDomain domain, string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.ObsoleteAttribute("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityInfo) { throw null; }
        public static System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static object GetObject(System.Type type, string url) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static object GetObject(System.Type type, string url, object state) { throw null; }
    }
    public sealed partial class AppDomain
    {
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { throw null; }
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { throw null; }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { throw null; }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { throw null; }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { throw null; }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { throw null; }
    }
    public partial class AppDomainManager : System.MarshalByRefObject
    {
        public virtual System.Runtime.Hosting.ApplicationActivator ApplicationActivator { get { throw null; } }
    }
    public sealed partial class AppDomainSetup
    {
        public AppDomainSetup(System.Runtime.Hosting.ActivationArguments activationArguments) { }
        public System.Runtime.Hosting.ActivationArguments ActivationArguments { get { throw null; } set { } }
    }
    public sealed partial class BinaryFormatter : System.Runtime.Serialization.IFormatter
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public object DeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public object UnsafeDeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { throw null; }
    }
    public sealed partial class Thread
    {
        public static System.Runtime.Remoting.Contexts.Context CurrentContext { get { throw null; } }
    }
    public abstract partial class MarshalByRefObject
    {
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Infrastructure=true)]
        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType) { throw null; }
    }
}
*/
namespace System.Runtime.Hosting
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ActivationArguments : System.Security.Policy.EvidenceBase
    {
        public ActivationArguments(System.ActivationContext activationData) { }
        public ActivationArguments(System.ActivationContext activationContext, string[] activationData) { }
        public ActivationArguments(System.ApplicationIdentity applicationIdentity) { }
        public ActivationArguments(System.ApplicationIdentity applicationIdentity, string[] activationData) { }
        public System.ActivationContext ActivationContext { get { throw null; } }
        public string[] ActivationData { get { throw null; } }
        public System.ApplicationIdentity ApplicationIdentity { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ApplicationActivator
    {
        public ApplicationActivator() { }
        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext) { throw null; }
        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext, string[] activationCustomData) { throw null; }
        protected static System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup adSetup) { throw null; }
    }
}
namespace System.Runtime.Remoting
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActivatedClientTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) { }
        public ActivatedClientTypeEntry(System.Type type, string appUrl) { }
        public string ApplicationUrl { get { throw null; } }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { throw null; } set { } }
        public System.Type ObjectType { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActivatedServiceTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }
        public ActivatedServiceTypeEntry(System.Type type) { }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { throw null; } set { } }
        public System.Type ObjectType { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CustomErrorsModes
    {
        Off = 1,
        On = 0,
        RemoteOnly = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelInfo
    {
        object[] ChannelData { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IEnvoyInfo
    {
        System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InternalRemotingServices
    {
        public InternalRemotingServices() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void DebugOutChnl(string s) { }
        public static System.Runtime.Remoting.Metadata.SoapAttribute GetCachedSoapAttribute(object reflectionObject) { throw null; }
        [System.Diagnostics.ConditionalAttribute("_DEBUG")]
        public static void RemotingAssert(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void RemotingTrace(params object[] messages) { }
        [System.CLSCompliantAttribute(false)]
        public static void SetServerIdentity(System.Runtime.Remoting.Messaging.MethodCall m, object srvID) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("C460E2B4-E199-412a-8456-84DC3E4838C3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IObjectHandle
    {
        object Unwrap();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IRemotingTypeInfo
    {
        string TypeName { get; set; }
        bool CanCastTo(System.Type fromType, object o);
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjectHandle : System.MarshalByRefObject, System.Runtime.Remoting.IObjectHandle
    {
        public ObjectHandle(object o) { }
        public override object InitializeLifetimeService() { throw null; }
        public object Unwrap() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjRef : System.Runtime.Serialization.IObjectReference, System.Runtime.Serialization.ISerializable
    {
        public ObjRef() { }
        public ObjRef(System.MarshalByRefObject o, System.Type requestedType) { }
        protected ObjRef(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Runtime.Remoting.IChannelInfo ChannelInfo { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { throw null; } set { } }
        public virtual System.Runtime.Remoting.IEnvoyInfo EnvoyInfo { get { throw null; } set { } }
        public virtual System.Runtime.Remoting.IRemotingTypeInfo TypeInfo { get { throw null; } set { } }
        public virtual string URI { get { throw null; } set { } }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context) { throw null; }
        public bool IsFromThisAppDomain() { throw null; }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public bool IsFromThisProcess() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class RemotingConfiguration
    {
        public static string ApplicationId { get { throw null; } }
        public static string ApplicationName { get { throw null; } set { } }
        public static System.Runtime.Remoting.CustomErrorsModes CustomErrorsMode { get { throw null; } set { } }
        public static string ProcessId { get { throw null; } }
        [System.ObsoleteAttribute("Use Configure(String,Boolean)")]
        public static void Configure(string filename) { }
        public static void Configure(string filename, bool ensureSecurity) { }
        public static bool CustomErrorsEnabled(bool isLocalRequest) { throw null; }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes() { throw null; }
        public static System.Runtime.Remoting.ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes() { throw null; }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes() { throw null; }
        public static System.Runtime.Remoting.WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes() { throw null; }
        public static bool IsActivationAllowed(System.Type svrType) { throw null; }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName) { throw null; }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry IsRemotelyActivatedClientType(System.Type svrType) { throw null; }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName) { throw null; }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry IsWellKnownClientType(System.Type svrType) { throw null; }
        public static void RegisterActivatedClientType(System.Runtime.Remoting.ActivatedClientTypeEntry entry) { }
        public static void RegisterActivatedClientType(System.Type type, string appUrl) { }
        public static void RegisterActivatedServiceType(System.Runtime.Remoting.ActivatedServiceTypeEntry entry) { }
        public static void RegisterActivatedServiceType(System.Type type) { }
        public static void RegisterWellKnownClientType(System.Runtime.Remoting.WellKnownClientTypeEntry entry) { }
        public static void RegisterWellKnownClientType(System.Type type, string objectUrl) { }
        public static void RegisterWellKnownServiceType(System.Runtime.Remoting.WellKnownServiceTypeEntry entry) { }
        public static void RegisterWellKnownServiceType(System.Type type, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingException : System.SystemException
    {
        public RemotingException() { }
        protected RemotingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RemotingException(string message) { }
        public RemotingException(string message, System.Exception InnerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class RemotingServices
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Connect(System.Type classToProxy, string url) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Connect(System.Type classToProxy, string url, object data) { throw null; }
        public static bool Disconnect(System.MarshalByRefObject obj) { throw null; }
        public static System.Runtime.Remoting.Messaging.IMethodReturnMessage ExecuteMessage(System.MarshalByRefObject target, System.Runtime.Remoting.Messaging.IMethodCallMessage reqMsg) { throw null; }
        public static System.Runtime.Remoting.Messaging.IMessageSink GetEnvoyChainForProxy(System.MarshalByRefObject obj) { throw null; }
        public static object GetLifetimeService(System.MarshalByRefObject obj) { throw null; }
        public static System.Reflection.MethodBase GetMethodBaseFromMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) { throw null; }
        public static void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static string GetObjectUri(System.MarshalByRefObject obj) { throw null; }
        public static System.Runtime.Remoting.ObjRef GetObjRefForProxy(System.MarshalByRefObject obj) { throw null; }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static System.Runtime.Remoting.Proxies.RealProxy GetRealProxy(object proxy) { throw null; }
        public static System.Type GetServerTypeForUri(string URI) { throw null; }
        public static string GetSessionIdForMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) { throw null; }
        public static bool IsMethodOverloaded(System.Runtime.Remoting.Messaging.IMethodMessage msg) { throw null; }
        public static bool IsObjectOutOfAppDomain(object tp) { throw null; }
        public static bool IsObjectOutOfContext(object tp) { throw null; }
        public static bool IsOneWay(System.Reflection.MethodBase method) { throw null; }
        public static bool IsTransparentProxy(object proxy) { throw null; }
        [System.Diagnostics.ConditionalAttribute("REMOTING_PERF")]
        [System.ObsoleteAttribute("It existed for only internal use in .NET and unimplemented in mono")]
        public static void LogRemotingStage(int stage) { }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj) { throw null; }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj, string URI) { throw null; }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj, string ObjURI, System.Type RequestedType) { throw null; }
        public static void SetObjectUriForMarshal(System.MarshalByRefObject obj, string uri) { }
        public static object Unmarshal(System.Runtime.Remoting.ObjRef objectRef) { throw null; }
        public static object Unmarshal(System.Runtime.Remoting.ObjRef objectRef, bool fRefine) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingTimeoutException : System.Runtime.Remoting.RemotingException
    {
        public RemotingTimeoutException() { }
        public RemotingTimeoutException(string message) { }
        public RemotingTimeoutException(string message, System.Exception InnerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServerException : System.SystemException
    {
        public ServerException() { }
        public ServerException(string message) { }
        public ServerException(string message, System.Exception InnerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapServices
    {
        internal SoapServices() { }
        public static string XmlNsForClrType { get { throw null; } }
        public static string XmlNsForClrTypeWithAssembly { get { throw null; } }
        public static string XmlNsForClrTypeWithNs { get { throw null; } }
        public static string XmlNsForClrTypeWithNsAndAssembly { get { throw null; } }
        public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { throw null; }
        public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, out string typeNamespace, out string assemblyName) { typeNamespace = default(string); assemblyName = default(string); throw null; }
        public static void GetInteropFieldTypeAndNameFromXmlAttribute(System.Type containingType, string xmlAttribute, string xmlNamespace, out System.Type type, out string name) { type = default(System.Type); name = default(string); }
        public static void GetInteropFieldTypeAndNameFromXmlElement(System.Type containingType, string xmlElement, string xmlNamespace, out System.Type type, out string name) { type = default(System.Type); name = default(string); }
        public static System.Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace) { throw null; }
        public static System.Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace) { throw null; }
        public static string GetSoapActionFromMethodBase(System.Reflection.MethodBase mb) { throw null; }
        public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, out string typeName, out string methodName) { typeName = default(string); methodName = default(string); throw null; }
        public static bool GetXmlElementForInteropType(System.Type type, out string xmlElement, out string xmlNamespace) { xmlElement = default(string); xmlNamespace = default(string); throw null; }
        public static string GetXmlNamespaceForMethodCall(System.Reflection.MethodBase mb) { throw null; }
        public static string GetXmlNamespaceForMethodResponse(System.Reflection.MethodBase mb) { throw null; }
        public static bool GetXmlTypeForInteropType(System.Type type, out string xmlType, out string xmlTypeNamespace) { xmlType = default(string); xmlTypeNamespace = default(string); throw null; }
        public static bool IsClrTypeNamespace(string namespaceString) { throw null; }
        public static bool IsSoapActionValidForMethodBase(string soapAction, System.Reflection.MethodBase mb) { throw null; }
        public static void PreLoad(System.Reflection.Assembly assembly) { }
        public static void PreLoad(System.Type type) { }
        public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, System.Type type) { }
        public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, System.Type type) { }
        public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb) { }
        public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb, string soapAction) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TypeEntry
    {
        protected TypeEntry() { }
        public string AssemblyName { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WellKnownClientTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }
        public WellKnownClientTypeEntry(System.Type type, string objectUrl) { }
        public string ApplicationUrl { get { throw null; } set { } }
        public System.Type ObjectType { get { throw null; } }
        public string ObjectUrl { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum WellKnownObjectMode
    {
        SingleCall = 2,
        Singleton = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WellKnownServiceTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
        public WellKnownServiceTypeEntry(System.Type type, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { throw null; } set { } }
        public System.Runtime.Remoting.WellKnownObjectMode Mode { get { throw null; } }
        public System.Type ObjectType { get { throw null; } }
        public string ObjectUri { get { throw null; } }
        public override string ToString() { throw null; }
    }
}
namespace System.Runtime.Remoting.Activation
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ActivatorLevel
    {
        AppDomain = 12,
        Construction = 4,
        Context = 8,
        Machine = 20,
        Process = 16,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IActivator
    {
        System.Runtime.Remoting.Activation.ActivatorLevel Level { get; }
        System.Runtime.Remoting.Activation.IActivator NextActivator { get; set; }
        System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IConstructionCallMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        System.Type ActivationType { get; }
        string ActivationTypeName { get; }
        System.Runtime.Remoting.Activation.IActivator Activator { get; set; }
        object[] CallSiteActivationAttributes { get; }
        System.Collections.IList ContextProperties { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IConstructionReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlAttribute : System.Runtime.Remoting.Contexts.ContextAttribute
    {
        public UrlAttribute(string callsiteURL) : base (default(string)) { }
        public string UrlValue { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        public override int GetHashCode() { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { throw null; }
    }
}
namespace System.Runtime.Remoting.Channels
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelObjectWithProperties : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        protected BaseChannelObjectWithProperties() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsFixedSize { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[object key] { get { throw null; } set { } }
        public virtual System.Collections.ICollection Keys { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual System.Collections.ICollection Values { get { throw null; } }
        public virtual void Add(object key, object value) { }
        public virtual void Clear() { }
        public virtual bool Contains(object key) { throw null; }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public virtual void Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelSinkWithProperties : System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties
    {
        protected BaseChannelSinkWithProperties() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelWithProperties : System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties
    {
        protected System.Runtime.Remoting.Channels.IChannelSinkBase SinksWithProperties;
        protected BaseChannelWithProperties() { }
        public override System.Collections.IDictionary Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ChannelDataStore : System.Runtime.Remoting.Channels.IChannelDataStore
    {
        public ChannelDataStore(string[] channelURIs) { }
        public string[] ChannelUris { get { throw null; } set { } }
        public object this[object key] { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ChannelServices
    {
        internal ChannelServices() { }
        public static System.Runtime.Remoting.Channels.IChannel[] RegisteredChannels { get { throw null; } }
        public static System.Runtime.Remoting.Messaging.IMessageCtrl AsyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { throw null; }
        public static System.Runtime.Remoting.Channels.IServerChannelSink CreateServerChannelSinkChain(System.Runtime.Remoting.Channels.IServerChannelSinkProvider provider, System.Runtime.Remoting.Channels.IChannelReceiver channel) { throw null; }
        public static System.Runtime.Remoting.Channels.ServerProcessing DispatchMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, out System.Runtime.Remoting.Messaging.IMessage replyMsg) { replyMsg = default(System.Runtime.Remoting.Messaging.IMessage); throw null; }
        public static System.Runtime.Remoting.Channels.IChannel GetChannel(string name) { throw null; }
        public static System.Collections.IDictionary GetChannelSinkProperties(object obj) { throw null; }
        public static string[] GetUrlsForObject(System.MarshalByRefObject obj) { throw null; }
        [System.ObsoleteAttribute("Use RegisterChannel(IChannel,Boolean)")]
        public static void RegisterChannel(System.Runtime.Remoting.Channels.IChannel chnl) { }
        public static void RegisterChannel(System.Runtime.Remoting.Channels.IChannel chnl, bool ensureSecurity) { }
        public static System.Runtime.Remoting.Messaging.IMessage SyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg) { throw null; }
        public static void UnregisterChannel(System.Runtime.Remoting.Channels.IChannel chnl) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ClientChannelSinkStack : System.Runtime.Remoting.Channels.IClientChannelSinkStack, System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack
    {
        public ClientChannelSinkStack() { }
        public ClientChannelSinkStack(System.Runtime.Remoting.Messaging.IMessageSink replySink) { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public void DispatchException(System.Exception e) { }
        public void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg) { }
        public object Pop(System.Runtime.Remoting.Channels.IClientChannelSink sink) { throw null; }
        public void Push(System.Runtime.Remoting.Channels.IClientChannelSink sink, object state) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannel
    {
        string ChannelName { get; }
        int ChannelPriority { get; }
        string Parse(string url, out string objectURI);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelDataStore
    {
        string[] ChannelUris { get; }
        object this[object key] { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelReceiver : System.Runtime.Remoting.Channels.IChannel
    {
        object ChannelData { get; }
        string[] GetUrlsForUri(string objectURI);
        void StartListening(object data);
        void StopListening(object data);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelReceiverHook
    {
        string ChannelScheme { get; }
        System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get; }
        bool WantsToListen { get; }
        void AddHookChannelUri(string channelUri);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelSender : System.Runtime.Remoting.Channels.IChannel
    {
        System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelSinkBase
    {
        System.Collections.IDictionary Properties { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase
    {
        System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get; }
        void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
        void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSinkProvider
    {
        System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get; set; }
        System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSinkStack : System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack
    {
        object Pop(System.Runtime.Remoting.Channels.IClientChannelSink sink);
        void Push(System.Runtime.Remoting.Channels.IClientChannelSink sink, object state);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Messaging.IMessageSink
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientResponseChannelSinkStack
    {
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        void DispatchException(System.Exception e);
        void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg);
    }
    public partial interface ISecurableChannel
    {
        bool IsSecured { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase
    {
        System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get; }
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
        System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSinkProvider
    {
        System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get; set; }
        System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel);
        void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSinkStack : System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack
    {
        object Pop(System.Runtime.Remoting.Channels.IServerChannelSink sink);
        void Push(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
        void ServerCallback(System.IAsyncResult ar);
        void Store(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
        void StoreAndDispatch(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerResponseChannelSinkStack
    {
        void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ITransportHeaders
    {
        object this[object key] { get; set; }
        System.Collections.IEnumerator GetEnumerator();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServerChannelSinkStack : System.Runtime.Remoting.Channels.IServerChannelSinkStack, System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack
    {
        public ServerChannelSinkStack() { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public object Pop(System.Runtime.Remoting.Channels.IServerChannelSink sink) { throw null; }
        public void Push(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
        public void ServerCallback(System.IAsyncResult ar) { }
        public void Store(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
        public void StoreAndDispatch(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ServerProcessing
    {
        Async = 2,
        Complete = 0,
        OneWay = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SinkProviderData
    {
        public SinkProviderData(string name) { }
        public System.Collections.IList Children { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransportHeaders : System.Runtime.Remoting.Channels.ITransportHeaders
    {
        public TransportHeaders() { }
        public object this[object key] { get { throw null; } set { } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
}
namespace System.Runtime.Remoting.Contexts
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Context
    {
        public Context() { }
        public virtual int ContextID { get { throw null; } }
        public virtual System.Runtime.Remoting.Contexts.IContextProperty[] ContextProperties { get { throw null; } }
        public static System.Runtime.Remoting.Contexts.Context DefaultContext { get { throw null; } }
        public static System.LocalDataStoreSlot AllocateDataSlot() { throw null; }
        public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) { throw null; }
        public void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate deleg) { }
        ~Context() { }
        public static void FreeNamedDataSlot(string name) { }
        public virtual void Freeze() { }
        public static object GetData(System.LocalDataStoreSlot slot) { throw null; }
        public static System.LocalDataStoreSlot GetNamedDataSlot(string name) { throw null; }
        public virtual System.Runtime.Remoting.Contexts.IContextProperty GetProperty(string name) { throw null; }
        public static bool RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty prop, System.ContextBoundObject obj, System.Runtime.Remoting.Contexts.Context ctx) { throw null; }
        public static void SetData(System.LocalDataStoreSlot slot, object data) { }
        public virtual void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty prop) { }
        public override string ToString() { throw null; }
        public static bool UnregisterDynamicProperty(string name, System.ContextBoundObject obj, System.Runtime.Remoting.Contexts.Context ctx) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute, System.Runtime.Remoting.Contexts.IContextProperty
    {
        protected string AttributeName;
        public ContextAttribute(string name) { }
        public virtual string Name { get { throw null; } }
        public override bool Equals(object o) { throw null; }
        public virtual void Freeze(System.Runtime.Remoting.Contexts.Context newContext) { }
        public override int GetHashCode() { throw null; }
        public virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        public virtual bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { throw null; }
        public virtual bool IsNewContextOK(System.Runtime.Remoting.Contexts.Context newCtx) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextProperty
    {
        internal ContextProperty() { }
        public virtual string Name { get { throw null; } }
        public virtual object Property { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void CrossContextDelegate();
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextAttribute
    {
        void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextProperty
    {
        string Name { get; }
        void Freeze(System.Runtime.Remoting.Contexts.Context newContext);
        bool IsNewContextOK(System.Runtime.Remoting.Contexts.Context newCtx);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextPropertyActivator
    {
        void CollectFromClientContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        void CollectFromServerContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg);
        bool DeliverClientContextToServerContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        bool DeliverServerContextToClientContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg);
        bool IsOKToActivate(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeClientContextSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeDynamicSink
    {
        System.Runtime.Remoting.Contexts.IDynamicMessageSink GetDynamicSink();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeEnvoySink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetEnvoySink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeObjectSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetObjectSink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeServerContextSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDynamicMessageSink
    {
        void ProcessMessageFinish(System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync);
        void ProcessMessageStart(System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDynamicProperty
    {
        string Name { get; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SynchronizationAttribute : System.Runtime.Remoting.Contexts.ContextAttribute, System.Runtime.Remoting.Contexts.IContributeClientContextSink, System.Runtime.Remoting.Contexts.IContributeServerContextSink
    {
        public const int NOT_SUPPORTED = 1;
        public const int REQUIRED = 4;
        public const int REQUIRES_NEW = 8;
        public const int SUPPORTED = 2;
        public SynchronizationAttribute() : base (default(string)) { }
        public SynchronizationAttribute(bool reEntrant) : base (default(string)) { }
        public SynchronizationAttribute(int flag) : base (default(string)) { }
        public SynchronizationAttribute(int flag, bool reEntrant) : base (default(string)) { }
        public virtual bool IsReEntrant { get { throw null; } }
        public virtual bool Locked { get { throw null; } set { } }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { throw null; }
    }
}
namespace System.Runtime.Remoting.Lifetime
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ClientSponsor : System.MarshalByRefObject, System.Runtime.Remoting.Lifetime.ISponsor
    {
        public ClientSponsor() { }
        public ClientSponsor(System.TimeSpan renewalTime) { }
        public System.TimeSpan RenewalTime { get { throw null; } set { } }
        public void Close() { }
        ~ClientSponsor() { }
        public override object InitializeLifetimeService() { throw null; }
        public bool Register(System.MarshalByRefObject obj) { throw null; }
        public System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease lease) { throw null; }
        public void Unregister(System.MarshalByRefObject obj) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ILease
    {
        System.TimeSpan CurrentLeaseTime { get; }
        System.Runtime.Remoting.Lifetime.LeaseState CurrentState { get; }
        System.TimeSpan InitialLeaseTime { get; set; }
        System.TimeSpan RenewOnCallTime { get; set; }
        System.TimeSpan SponsorshipTimeout { get; set; }
        void Register(System.Runtime.Remoting.Lifetime.ISponsor obj);
        void Register(System.Runtime.Remoting.Lifetime.ISponsor obj, System.TimeSpan renewalTime);
        System.TimeSpan Renew(System.TimeSpan renewalTime);
        void Unregister(System.Runtime.Remoting.Lifetime.ISponsor obj);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISponsor
    {
        System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease lease);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum LeaseState
    {
        Active = 2,
        Expired = 4,
        Initial = 1,
        Null = 0,
        Renewing = 3,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class LifetimeServices
    {
        [System.ObsoleteAttribute("Call the static methods directly on this type instead", true)]
        public LifetimeServices() { }
        public static System.TimeSpan LeaseManagerPollTime { get { throw null; } set { } }
        public static System.TimeSpan LeaseTime { get { throw null; } set { } }
        public static System.TimeSpan RenewOnCallTime { get { throw null; } set { } }
        public static System.TimeSpan SponsorshipTimeout { get { throw null; } set { } }
    }
}
namespace System.Runtime.Remoting.Messaging
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AsyncResult : System.IAsyncResult, System.Runtime.Remoting.Messaging.IMessageSink
    {
        internal AsyncResult() { }
        public virtual object AsyncDelegate { get { throw null; } }
        public virtual object AsyncState { get { throw null; } }
        public virtual System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        public virtual bool CompletedSynchronously { get { throw null; } }
        public bool EndInvokeCalled { get { throw null; } set { } }
        public virtual bool IsCompleted { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { throw null; } }
        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { throw null; }
        public virtual System.Runtime.Remoting.Messaging.IMessage GetReplyMessage() { throw null; }
        public virtual void SetMessageCtrl(System.Runtime.Remoting.Messaging.IMessageCtrl mc) { }
        public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class CallContext
    {
        internal CallContext() { }
        public static object HostContext { [System.Security.SecurityCriticalAttribute]get { throw null; } [System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecurityCriticalAttribute]
        public static void FreeNamedDataSlot(string name) { }
        [System.Security.SecurityCriticalAttribute]
        public static object GetData(string name) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.Messaging.Header[] GetHeaders() { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static object LogicalGetData(string name) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static void LogicalSetData(string name, object data) { }
        [System.Security.SecurityCriticalAttribute]
        public static void SetData(string name, object data) { }
        [System.Security.SecurityCriticalAttribute]
        public static void SetHeaders(System.Runtime.Remoting.Messaging.Header[] headers) { }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ConstructionCall : System.Runtime.Remoting.Messaging.MethodCall, System.Runtime.Remoting.Activation.IConstructionCallMessage, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        public ConstructionCall(System.Runtime.Remoting.Messaging.Header[] headers) : base (default(System.Runtime.Remoting.Messaging.Header[])) { }
        public ConstructionCall(System.Runtime.Remoting.Messaging.IMessage m) : base (default(System.Runtime.Remoting.Messaging.Header[])) { }
        public System.Type ActivationType { get { throw null; } }
        public string ActivationTypeName { get { throw null; } }
        public System.Runtime.Remoting.Activation.IActivator Activator { get { throw null; } set { } }
        public object[] CallSiteActivationAttributes { get { throw null; } }
        public System.Collections.IList ContextProperties { get { throw null; } }
        public override System.Collections.IDictionary Properties { get { throw null; } }
        public new void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ConstructionResponse : System.Runtime.Remoting.Messaging.MethodResponse, System.Runtime.Remoting.Activation.IConstructionReturnMessage, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public ConstructionResponse(System.Runtime.Remoting.Messaging.Header[] h, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) : base (default(System.Runtime.Remoting.Messaging.Header[]), default(System.Runtime.Remoting.Messaging.IMethodCallMessage)) { }
        public override System.Collections.IDictionary Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ILogicalThreadAffinative
    {
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessage
    {
        System.Collections.IDictionary Properties { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessageCtrl
    {
        void Cancel(int msToCancel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessageSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink NextSink { get; }
        System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink);
        System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodCallMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        int InArgCount { get; }
        object[] InArgs { get; }
        object GetInArg(int argNum);
        string GetInArgName(int index);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodMessage : System.Runtime.Remoting.Messaging.IMessage
    {
        int ArgCount { get; }
        object[] Args { get; }
        bool HasVarArgs { get; }
        System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get; }
        System.Reflection.MethodBase MethodBase { get; }
        string MethodName { get; }
        object MethodSignature { get; }
        string TypeName { get; }
        string Uri { get; }
        object GetArg(int argNum);
        string GetArgName(int index);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        System.Exception Exception { get; }
        int OutArgCount { get; }
        object[] OutArgs { get; }
        object ReturnValue { get; }
        object GetOutArg(int argNum);
        string GetOutArgName(int index);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InternalMessageWrapper
    {
        protected System.Runtime.Remoting.Messaging.IMessage WrappedMessage;
        public InternalMessageWrapper(System.Runtime.Remoting.Messaging.IMessage msg) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IRemotingFormatter : System.Runtime.Serialization.IFormatter
    {
        object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler);
        void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class LogicalCallContext : System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        internal LogicalCallContext() { }
        public bool HasInfo { [System.Security.SecurityCriticalAttribute]get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        public object Clone() { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public void FreeNamedDataSlot(string name) { }
        [System.Security.SecurityCriticalAttribute]
        public object GetData(string name) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.Security.SecurityCriticalAttribute]
        public void SetData(string name, object data) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate bool MessageSurrogateFilter(string key, object value);
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodCall : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Serialization.ISerializable
    {
        protected System.Collections.IDictionary ExternalProperties;
        protected System.Collections.IDictionary InternalProperties;
        public MethodCall(System.Runtime.Remoting.Messaging.Header[] h1) { }
        public MethodCall(System.Runtime.Remoting.Messaging.IMessage msg) { }
        public int ArgCount { get { throw null; } }
        public object[] Args { get { throw null; } }
        public bool HasVarArgs { get { throw null; } }
        public int InArgCount { get { throw null; } }
        public object[] InArgs { get { throw null; } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { throw null; } }
        public System.Reflection.MethodBase MethodBase { get { throw null; } }
        public string MethodName { get { throw null; } }
        public object MethodSignature { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string Uri { get { throw null; } set { } }
        public object GetArg(int argNum) { throw null; }
        public string GetArgName(int index) { throw null; }
        public object GetInArg(int argNum) { throw null; }
        public string GetInArgName(int index) { throw null; }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual object HeaderHandler(System.Runtime.Remoting.Messaging.Header[] h) { throw null; }
        public virtual void Init() { }
        public void ResolveMethod() { }
        public void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodCallMessageWrapper : System.Runtime.Remoting.Messaging.InternalMessageWrapper, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        public MethodCallMessageWrapper(System.Runtime.Remoting.Messaging.IMethodCallMessage msg) : base (default(System.Runtime.Remoting.Messaging.IMessage)) { }
        public virtual int ArgCount { get { throw null; } }
        public virtual object[] Args { get { throw null; } set { } }
        public virtual bool HasVarArgs { get { throw null; } }
        public virtual int InArgCount { get { throw null; } }
        public virtual object[] InArgs { get { throw null; } }
        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { throw null; } }
        public virtual System.Reflection.MethodBase MethodBase { get { throw null; } }
        public virtual string MethodName { get { throw null; } }
        public virtual object MethodSignature { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual string TypeName { get { throw null; } }
        public virtual string Uri { get { throw null; } set { } }
        public virtual object GetArg(int argNum) { throw null; }
        public virtual string GetArgName(int index) { throw null; }
        public virtual object GetInArg(int argNum) { throw null; }
        public virtual string GetInArgName(int index) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodResponse : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage, System.Runtime.Serialization.ISerializable
    {
        protected System.Collections.IDictionary ExternalProperties;
        protected System.Collections.IDictionary InternalProperties;
        public MethodResponse(System.Runtime.Remoting.Messaging.Header[] h1, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public int ArgCount { get { throw null; } }
        public object[] Args { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
        public bool HasVarArgs { get { throw null; } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { throw null; } }
        public System.Reflection.MethodBase MethodBase { get { throw null; } }
        public string MethodName { get { throw null; } }
        public object MethodSignature { get { throw null; } }
        public int OutArgCount { get { throw null; } }
        public object[] OutArgs { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public object ReturnValue { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string Uri { get { throw null; } set { } }
        public object GetArg(int argNum) { throw null; }
        public string GetArgName(int index) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public object GetOutArg(int argNum) { throw null; }
        public string GetOutArgName(int index) { throw null; }
        public virtual object HeaderHandler(System.Runtime.Remoting.Messaging.Header[] h) { throw null; }
        public void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodReturnMessageWrapper : System.Runtime.Remoting.Messaging.InternalMessageWrapper, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public MethodReturnMessageWrapper(System.Runtime.Remoting.Messaging.IMethodReturnMessage msg) : base (default(System.Runtime.Remoting.Messaging.IMessage)) { }
        public virtual int ArgCount { get { throw null; } }
        public virtual object[] Args { get { throw null; } set { } }
        public virtual System.Exception Exception { get { throw null; } set { } }
        public virtual bool HasVarArgs { get { throw null; } }
        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { throw null; } }
        public virtual System.Reflection.MethodBase MethodBase { get { throw null; } }
        public virtual string MethodName { get { throw null; } }
        public virtual object MethodSignature { get { throw null; } }
        public virtual int OutArgCount { get { throw null; } }
        public virtual object[] OutArgs { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual object ReturnValue { get { throw null; } set { } }
        public virtual string TypeName { get { throw null; } }
        public string Uri { get { throw null; } set { } }
        public virtual object GetArg(int argNum) { throw null; }
        public virtual string GetArgName(int index) { throw null; }
        public virtual object GetOutArg(int argNum) { throw null; }
        public virtual string GetOutArgName(int index) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OneWayAttribute : System.Attribute
    {
        public OneWayAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingSurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
    {
        public RemotingSurrogateSelector() { }
        public System.Runtime.Remoting.Messaging.MessageSurrogateFilter Filter { get { throw null; } set { } }
        public virtual void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector) { }
        public virtual System.Runtime.Serialization.ISurrogateSelector GetNextSelector() { throw null; }
        public object GetRootObject() { throw null; }
        public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector ssout) { ssout = default(System.Runtime.Serialization.ISurrogateSelector); throw null; }
        public void SetRootObject(object obj) { }
        public virtual void UseSoapFormat() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public ReturnMessage(System.Exception e, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public ReturnMessage(object ret, object[] outArgs, int outArgsCount, System.Runtime.Remoting.Messaging.LogicalCallContext callCtx, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public int ArgCount { get { throw null; } }
        public object[] Args { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
        public bool HasVarArgs { get { throw null; } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { throw null; } }
        public System.Reflection.MethodBase MethodBase { get { throw null; } }
        public string MethodName { get { throw null; } }
        public object MethodSignature { get { throw null; } }
        public int OutArgCount { get { throw null; } }
        public object[] OutArgs { get { throw null; } }
        public virtual System.Collections.IDictionary Properties { get { throw null; } }
        public virtual object ReturnValue { get { throw null; } }
        public string TypeName { get { throw null; } }
        public string Uri { get { throw null; } set { } }
        public object GetArg(int argNum) { throw null; }
        public string GetArgName(int index) { throw null; }
        public object GetOutArg(int argNum) { throw null; }
        public string GetOutArgName(int index) { throw null; }
    }
}
namespace System.Runtime.Remoting.Metadata
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapAttribute : System.Attribute
    {
        protected string ProtXmlNamespace;
        protected object ReflectInfo;
        public SoapAttribute() { }
        public virtual bool Embedded { get { throw null; } set { } }
        public virtual bool UseAttribute { get { throw null; } set { } }
        public virtual string XmlNamespace { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapFieldAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapFieldAttribute() { }
        public int Order { get { throw null; } set { } }
        public string XmlElementName { get { throw null; } set { } }
        public bool IsInteropXmlElement() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMethodAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapMethodAttribute() { }
        public string ResponseXmlElementName { get { throw null; } set { } }
        public string ResponseXmlNamespace { get { throw null; } set { } }
        public string ReturnXmlElementName { get { throw null; } set { } }
        public string SoapAction { get { throw null; } set { } }
        public override bool UseAttribute { get { throw null; } set { } }
        public override string XmlNamespace { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoapOption
    {
        AlwaysIncludeTypes = 1,
        EmbedAll = 4,
        None = 0,
        Option1 = 8,
        Option2 = 16,
        XsdString = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapParameterAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapParameterAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1052))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapTypeAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapTypeAttribute() { }
        public System.Runtime.Remoting.Metadata.SoapOption SoapOptions { get { throw null; } set { } }
        public override bool UseAttribute { get { throw null; } set { } }
        public string XmlElementName { get { throw null; } set { } }
        public System.Runtime.Remoting.Metadata.XmlFieldOrderOption XmlFieldOrder { get { throw null; } set { } }
        public override string XmlNamespace { get { throw null; } set { } }
        public string XmlTypeName { get { throw null; } set { } }
        public string XmlTypeNamespace { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum XmlFieldOrderOption
    {
        All = 0,
        Choice = 2,
        Sequence = 1,
    }
}
namespace System.Runtime.Remoting.Metadata.W3cXsd2001
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISoapXsd
    {
        string GetXsdType();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapAnyUri : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapAnyUri() { }
        public SoapAnyUri(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapBase64Binary : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapBase64Binary() { }
        public SoapBase64Binary(byte[] value) { }
        public byte[] Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDate : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapDate() { }
        public SoapDate(System.DateTime value) { }
        public SoapDate(System.DateTime value, int sign) { }
        public int Sign { get { throw null; } set { } }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDateTime
    {
        public SoapDateTime() { }
        public static string XsdType { get { throw null; } }
        public static System.DateTime Parse(string value) { throw null; }
        public static string ToString(System.DateTime value) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDay : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapDay() { }
        public SoapDay(System.DateTime value) { }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDuration
    {
        public SoapDuration() { }
        public static string XsdType { get { throw null; } }
        public static System.TimeSpan Parse(string value) { throw null; }
        public static string ToString(System.TimeSpan timeSpan) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapEntities : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapEntities() { }
        public SoapEntities(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapEntity : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapEntity() { }
        public SoapEntity(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapHexBinary : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapHexBinary() { }
        public SoapHexBinary(byte[] value) { }
        public byte[] Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapId : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapId() { }
        public SoapId(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapIdref : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapIdref() { }
        public SoapIdref(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapIdrefs : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapIdrefs() { }
        public SoapIdrefs(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapInteger() { }
        public SoapInteger(decimal value) { }
        public decimal Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapLanguage : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapLanguage() { }
        public SoapLanguage(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMonth : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapMonth() { }
        public SoapMonth(System.DateTime value) { }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMonthDay : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapMonthDay() { }
        public SoapMonthDay(System.DateTime value) { }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapName() { }
        public SoapName(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNcName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNcName() { }
        public SoapNcName(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNegativeInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNegativeInteger() { }
        public SoapNegativeInteger(decimal value) { }
        public decimal Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNmtoken : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNmtoken() { }
        public SoapNmtoken(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNmtokens : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNmtokens() { }
        public SoapNmtokens(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNonNegativeInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNonNegativeInteger() { }
        public SoapNonNegativeInteger(decimal value) { }
        public decimal Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNonPositiveInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNonPositiveInteger() { }
        public SoapNonPositiveInteger(decimal value) { }
        public decimal Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNormalizedString : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNormalizedString() { }
        public SoapNormalizedString(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNotation : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNotation() { }
        public SoapNotation(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapPositiveInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapPositiveInteger() { }
        public SoapPositiveInteger(decimal value) { }
        public decimal Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapQName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapQName() { }
        public SoapQName(string value) { }
        public SoapQName(string key, string name) { }
        public SoapQName(string key, string name, string namespaceValue) { }
        public string Key { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapTime : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapTime() { }
        public SoapTime(System.DateTime value) { }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapToken : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapToken() { }
        public SoapToken(string value) { }
        public string Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapYear : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapYear() { }
        public SoapYear(System.DateTime value) { }
        public SoapYear(System.DateTime value, int sign) { }
        public int Sign { get { throw null; } set { } }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapYearMonth : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapYearMonth() { }
        public SoapYearMonth(System.DateTime value) { }
        public SoapYearMonth(System.DateTime value, int sign) { }
        public int Sign { get { throw null; } set { } }
        public System.DateTime Value { get { throw null; } set { } }
        public static string XsdType { get { throw null; } }
        public string GetXsdType() { throw null; }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth Parse(string value) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Runtime.Remoting.Proxies
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ProxyAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute
    {
        public ProxyAttribute() { }
        public virtual System.MarshalByRefObject CreateInstance(System.Type serverType) { throw null; }
        public virtual System.Runtime.Remoting.Proxies.RealProxy CreateProxy(System.Runtime.Remoting.ObjRef objRef, System.Type serverType, object serverObject, System.Runtime.Remoting.Contexts.Context serverContext) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class RealProxy
    {
        protected RealProxy() { }
        protected RealProxy(System.Type classToProxy) { }
        protected RealProxy(System.Type classToProxy, System.IntPtr stub, object stubData) { }
        protected void AttachServer(System.MarshalByRefObject s) { }
        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType) { throw null; }
        protected System.MarshalByRefObject DetachServer() { throw null; }
        public virtual System.IntPtr GetCOMIUnknown(bool fIsMarshalled) { throw null; }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Type GetProxiedType() { throw null; }
        public static object GetStubData(System.Runtime.Remoting.Proxies.RealProxy rp) { throw null; }
        public virtual object GetTransparentProxy() { throw null; }
        protected System.MarshalByRefObject GetUnwrappedServer() { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Runtime.Remoting.Activation.IConstructionReturnMessage InitializeServerObject(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { throw null; }
        public abstract System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage msg);
        public virtual void SetCOMIUnknown(System.IntPtr i) { }
        public static void SetStubData(System.Runtime.Remoting.Proxies.RealProxy rp, object stubData) { }
        public virtual System.IntPtr SupportsInterface(ref System.Guid iid) { throw null; }
    }
}
namespace System.Runtime.Remoting.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class EnterpriseServicesHelper
    {
        public EnterpriseServicesHelper() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static System.Runtime.Remoting.Activation.IConstructionReturnMessage CreateConstructionReturnMessage(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg, System.MarshalByRefObject retObj) { throw null; }
        public static void SwitchWrappers(System.Runtime.Remoting.Proxies.RealProxy oldcp, System.Runtime.Remoting.Proxies.RealProxy newcp) { }
        public static object WrapIUnknownWithComObject(System.IntPtr punk) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ITrackingHandler
    {
        void DisconnectedObject(object obj);
        void MarshaledObject(object obj, System.Runtime.Remoting.ObjRef or);
        void UnmarshaledObject(object obj, System.Runtime.Remoting.ObjRef or);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TrackingServices
    {
        public TrackingServices() { }
        public static System.Runtime.Remoting.Services.ITrackingHandler[] RegisteredHandlers { get { throw null; } }
        public static void RegisterTrackingHandler(System.Runtime.Remoting.Services.ITrackingHandler handler) { }
        public static void UnregisterTrackingHandler(System.Runtime.Remoting.Services.ITrackingHandler handler) { }
    }
}
namespace System.Runtime.Serialization.Formatters
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IFieldInfo
    {
        string[] FieldNames { [System.Security.SecurityCriticalAttribute]get; [System.Security.SecurityCriticalAttribute]set; }
        System.Type[] FieldTypes { [System.Security.SecurityCriticalAttribute]get; [System.Security.SecurityCriticalAttribute]set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class InternalRM
    {
        public InternalRM() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void InfoSoap(params object[] messages) { }
        public static bool SoapCheckEnabled() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class InternalST
    {
        internal InternalST() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void InfoSoap(params object[] messages) { }
        public static System.Reflection.Assembly LoadAssemblyFromString(string assemblyString) { throw null; }
        public static void SerializationSetValue(System.Reflection.FieldInfo fi, object target, object value) { }
        [System.Diagnostics.ConditionalAttribute("SER_LOGGING")]
        public static void Soap(params object[] messages) { }
        [System.Diagnostics.ConditionalAttribute("_DEBUG")]
        public static void SoapAssert(bool condition, string message) { }
        public static bool SoapCheckEnabled() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISoapMessage
    {
        System.Runtime.Remoting.Messaging.Header[] Headers { get; set; }
        string MethodName { get; set; }
        string[] ParamNames { get; set; }
        System.Type[] ParamTypes { get; set; }
        object[] ParamValues { get; set; }
        string XmlNameSpace { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.Remoting.Metadata.SoapTypeAttribute(Embedded=true)]
    public sealed partial class ServerFault
    {
        public ServerFault(string exceptionType, string message, string stackTrace) { }
        public string ExceptionMessage { get { throw null; } set { } }
        public string ExceptionType { get { throw null; } set { } }
        public string StackTrace { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.Remoting.Metadata.SoapTypeAttribute(Embedded=true)]
    public sealed partial class SoapFault : System.Runtime.Serialization.ISerializable
    {
        public SoapFault() { }
        public SoapFault(string faultCode, string faultString, string faultActor, System.Runtime.Serialization.Formatters.ServerFault serverFault) { }
        public object Detail { get { throw null; } set { } }
        public string FaultActor { get { throw null; } set { } }
        public string FaultCode { get { throw null; } set { } }
        public string FaultString { get { throw null; } set { } }
        [System.Security.SecurityCriticalAttribute]
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapMessage : System.Runtime.Serialization.Formatters.ISoapMessage
    {
        public SoapMessage() { }
        public System.Runtime.Remoting.Messaging.Header[] Headers { get { throw null; } set { } }
        public string MethodName { get { throw null; } set { } }
        public string[] ParamNames { get { throw null; } set { } }
        public System.Type[] ParamTypes { get { throw null; } set { } }
        public object[] ParamValues { get { throw null; } set { } }
        public string XmlNameSpace { get { throw null; } set { } }
    }
}