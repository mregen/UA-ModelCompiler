class Placeholder
{
// ***START***
#if (!OPCUA_EXCLUDE__NAME_)
#if (!OPCUA_ASYNC_TASK)
/// <summary>
/// The operation contract for the _NAME_ service.
/// </summary>
[OperationContractAttribute(AsyncPattern=true, Action=Namespaces._ServicesNamespace_ + "/_NAME_", ReplyAction = Namespaces._ServicesNamespace_ + "/_NAME_Response")]
[FaultContract(typeof(ServiceFault), Action = Namespaces._ServicesNamespace_ + "/_NAME_Fault", Name = "ServiceFault", Namespace = Namespaces._TypesNamespace_)]
IAsyncResult Begin_NAME_(_NAME_Message request, AsyncCallback callback, object asyncState);

/// <summary>
/// The method used to retrieve the results of a _NAME_ service request.
/// </summary>
_NAME_ResponseMessage End_NAME_(IAsyncResult result);

#else
/// <summary>
/// The operation contract for the _NAME_ service.
/// </summary>
[OperationContractAttribute(Action=Namespaces._ServicesNamespace_ + "/_NAME_", ReplyAction = Namespaces._ServicesNamespace_ + "/_NAME_Response")]
[FaultContract(typeof(ServiceFault), Action = Namespaces._ServicesNamespace_ + "/_NAME_Fault", Name = "ServiceFault", Namespace = Namespaces._TypesNamespace_)]
System.Threading.Tasks.Task<_NAME_ResponseMessage> _NAME_Async(_NAME_Message request);
#endif
#endif
// ***END***
}
