class Placeholder
{
// ***START***
#region _NAME_ Methods
#if (!OPCUA_EXCLUDE__NAME_)
/// <summary>
/// Invokes the _NAME_ service.
/// </summary>
void SyncCall()
{
    _NAME_Request request = new _NAME_Request();
    _NAME_Response response = null;

    // RequestParameters

    UpdateRequestHeader(request, requestHeader == null, "_NAME_");

    try
    {
        if (UseTransportChannel)
        {
            IServiceResponse genericResponse = TransportChannel.SendRequest(request);

            if (genericResponse == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            ValidateResponse(genericResponse.ResponseHeader);
            response = (_NAME_Response)genericResponse;
        }
        else
        {
            _NAME_ResponseMessage responseMessage = InnerChannel._NAME_(new _NAME_Message(request));

            if (responseMessage == null || responseMessage._NAME_Response == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            response = responseMessage._NAME_Response;
            ValidateResponse(response.ResponseHeader);
        }

        // ResponseParameters
    }
    finally
    {
        RequestCompleted(request, response, "_NAME_");
    }

    return response.ResponseHeader;
}

#if (OPCUA_ASYNC_TASK || NET_STANDARD)
/// <summary>
/// Invokes the _NAME_ service using async Task based request.
/// </summary>
void AsyncCall()
{
    _NAME_Request request = new _NAME_Request();
    _NAME_Response response = null;

    // RequestParameters

    UpdateRequestHeader(request, requestHeader == null, "_NAME_");

    try
    {
        if (UseTransportChannel)
        {
            IServiceResponse genericResponse = await TransportChannel.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

            if (genericResponse == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            ValidateResponse(genericResponse.ResponseHeader);
            response = (_NAME_Response)genericResponse;
        }
        else
        {
            _NAME_ResponseMessage responseMessage = await System.Threading.Tasks.Task.Factory.FromAsync(
                InnerChannel.Begin_NAME_, InnerChannel.End_NAME_, new _NAME_Message(request), 
                null, System.Threading.Tasks.TaskCreationOptions.None).ConfigureAwait(false);

            if (responseMessage == null || responseMessage._NAME_Response == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            response = responseMessage._NAME_Response;
            ValidateResponse(response.ResponseHeader);
        }
    }
    finally
    {
        RequestCompleted(request, response, "_NAME_");
    }

    return response;
}
#endif

/// <summary>
/// Begins an asynchronous invocation of the _NAME_ service.
/// </summary>
void BeginAsyncCall()
{
    _NAME_Request request = new _NAME_Request();

    // RequestParameters

    UpdateRequestHeader(request, requestHeader == null, "_NAME_");

    if (UseTransportChannel)
    {
        return TransportChannel.BeginSendRequest(request, callback, asyncState);
    }

    return InnerChannel.Begin_NAME_(new _NAME_Message(request), callback, asyncState);
}

/// <summary>
/// Finishes an asynchronous invocation of the _NAME_ service.
/// </summary>
void EndAsyncCall()
{
    _NAME_Response response = null;

    try
    {
        if (UseTransportChannel)
        {
            IServiceResponse genericResponse = TransportChannel.EndSendRequest(result);

            if (genericResponse == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            ValidateResponse(genericResponse.ResponseHeader);
            response = (_NAME_Response)genericResponse;
        }
        else
        {
            _NAME_ResponseMessage responseMessage = InnerChannel.End_NAME_(result);

            if (responseMessage == null || responseMessage._NAME_Response == null)
            {
                throw new ServiceResultException(StatusCodes.BadUnknownResponse);
            }

            response = responseMessage._NAME_Response;
            ValidateResponse(response.ResponseHeader);
        }

        // ResponseParameters
    }
    finally
    {
        RequestCompleted(null, response, "_NAME_");
    }

    return response.ResponseHeader;
}
#endif
#endregion
// ***END***
}
