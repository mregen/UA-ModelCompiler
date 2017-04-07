using System;
using System.Collections.Generic;

namespace _Prefix_
{
// ***START***
#region I_ServiceSet_Server Interface
/// <summary>
/// An interface to a UA server implementation.
/// </summary>
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.CodeGenerator", "1.0.0.0")]
public interface I_ServiceSet_Server : IServerBase
{
    // _ServerApi_
}
#endregion

#if (OPCUA_ASYNC_TASK || NET_STANDARD)
#region I_ServiceSet_ServerAsync Interface
/// <summary>
/// An interface to a UA server implementation using asynchronous Task based callbacks.
/// </summary>
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.CodeGenerator", "1.0.0.0")]
public interface I_ServiceSet_ServerAsync : IServerAsyncBase
{
    // _ServerAsyncApi_
}
#endregion
#endif

#region _ServiceSet_ServerBase Class
/// <summary>
/// A basic implementation of the UA server.
/// </summary>
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.CodeGenerator", "1.0.0.0")]
public partial class _ServiceSet_ServerBase : ServerBase, I_ServiceSet_Server
{
    // _ServerStubs_
}
#endregion
// ***END***
}
