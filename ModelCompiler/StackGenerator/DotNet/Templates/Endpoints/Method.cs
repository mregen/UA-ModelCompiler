class Placeholder
{
// ***START***
#region _NAME_ Service
#if (!OPCUA_EXCLUDE__NAME_)
/// <summary>
/// Invokes the _NAME_ service.
/// </summary>
public IServiceResponse _NAME_(IServiceRequest incoming)
{
    _NAME_Response response = null;

    try
    {
        OnRequestReceived(incoming);

        _NAME_Request request = (_NAME_Request)incoming;

        // DeclareResponseParameters

        response = new _NAME_Response();

        InvokeService();

        // SetResponseParameters
    }
    finally
    {
        OnResponseSent(response);
    }

    return response;
}

#if (OPCUA_USE_SYNCHRONOUS_ENDPOINTS)
/// <summary>
/// The operation contract for the _NAME_ service.
/// </summary>
public virtual _NAME_ResponseMessage _NAME_(_NAME_Message request)
{
    _NAME_Response response = null;

    try
    {
        // OnRequestReceived(message._NAME_Request);

        SetRequestContext(RequestEncoding.Xml);
        response = (_NAME_Response)_NAME_(request._NAME_Request);

        // OnResponseSent(response);
        return new _NAME_ResponseMessage(response);
    }
    catch (Exception e)
    {
        Exception fault = CreateSoapFault(request._NAME_Request, e);
        // OnResponseFaultSent(fault);
        throw fault;
    }
}
#else

#if (NET_STANDARD_ASYNC)
/// <summary>
/// Asynchronously calls the _NAME_ service.
/// </summary>
public virtual Task<_NAME_ResponseMessage> _NAME_Async(_NAME_Message message)
{
    var tcs = new TaskCompletionSource<_NAME_ResponseMessage>();
    Begin_NAME_(message, 
        new AsyncCallback((result) => 
        {
            var completion = (System.Threading.Tasks.TaskCompletionSource<_NAME_ResponseMessage>)result.AsyncState;
            try 
            {
                completion.SetResult(End_NAME_(result));
            }
            catch(Exception ex)
            {
                completion.SetException(ex);
            }
        }), tcs);
    return tcs.Task;
}
#endif

/// <summary>
/// Asynchronously calls the _NAME_ service.
/// </summary>
public virtual IAsyncResult Begin_NAME_(_NAME_Message message, AsyncCallback callback, object callbackData)
{
    try
    {
        // check for bad data.
        if (message == null) throw new ArgumentNullException(nameof(message));

        OnRequestReceived(message._NAME_Request);

        // set the request context.
        SetRequestContext(RequestEncoding.Xml);

        // create handler.
        ProcessRequestAsyncResult result = new ProcessRequestAsyncResult(this, callback, callbackData, 0);
        return result.BeginProcessRequest(SecureChannelContext.Current, message._NAME_Request);
    }
    catch (Exception e)
    {
        Exception fault = CreateSoapFault(message._NAME_Request, e);
        OnResponseFaultSent(fault);
        throw fault;
    }
}

/// <summary>
/// Waits for an asynchronous call to the _NAME_ service to complete.
/// </summary>
public virtual _NAME_ResponseMessage End_NAME_(IAsyncResult ar)
{
    try
    {
        IServiceResponse response = ProcessRequestAsyncResult.WaitForComplete(ar, true);
        OnResponseSent(response);
        return new _NAME_ResponseMessage((_NAME_Response)response);
    }
    catch (Exception e)
    {
        Exception fault = CreateSoapFault(ProcessRequestAsyncResult.GetRequest(ar), e);
        OnResponseFaultSent(fault);
        throw fault;
    }
}
#endif
#endif
#endregion
    // ***END***
}
