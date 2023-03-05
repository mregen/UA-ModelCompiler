public class _ClassName_Value
{
// ***START***
#region _ChildName_ Access Methods
/// <remarks />
private ServiceResult OnRead__ChildName_(
    ISystemContext context,
    NodeState node,
    NumericRange indexRange,
    QualifiedName dataEncoding,
    ref object value,
    ref StatusCode statusCode,
    ref DateTime timestamp)
{
    lock (Lock)
    {
        DoBeforeReadProcessing(context, node);

        var childVariable = m_variable?._ChildPath_;
        if (childVariable != null &&
            StatusCode.IsBad(childVariable.StatusCode))
        {
            value = null;
            statusCode = childVariable.StatusCode;
            return new ServiceResult(statusCode);
        }

        if (m_value != null)
        {
            value = m_value._ChildPath_;
        }

        var result = Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);

        if (childVariable != null && ServiceResult.IsNotBad(result))
        {
            timestamp = childVariable.Timestamp;
            statusCode = childVariable.StatusCode;
            return new ServiceResult(statusCode);
        }

        return result;
    }
}

/// <remarks />
private ServiceResult OnWrite__ChildName_(
    ISystemContext context,
    NodeState node,
    NumericRange indexRange,
    QualifiedName dataEncoding,
    ref object value,
    ref StatusCode statusCode,
    ref DateTime timestamp)
{
    lock (Lock)
    {
        _ChildDataType_ newValue;
        if (value is ExtensionObject extensionObject)
        {
            newValue = (_ChildDataType_)extensionObject.Body;
        }
        else
        {
            newValue = (_ChildDataType_)value;
        }

        if (newValue != m_value._ChildPath_)
        {
            m_variable._ChildPath_.StatusCode = statusCode;
            m_variable._ChildPath_.Timestamp = timestamp;
            m_value._ChildPath_ = (_ChildDataType_)Write(newValue);
            UpdateParent(context, ref statusCode, ref timestamp);
        }
    }

    return ServiceResult.Good;
}
#endregion
// ***END***
}
