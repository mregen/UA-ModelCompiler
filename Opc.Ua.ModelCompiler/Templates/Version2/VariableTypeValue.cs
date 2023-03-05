// ***START***
#region _ClassName_Value Class
/// <remarks />
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
public class _ClassName_Value : BaseVariableValue
{
    #region Constructors
    /// <remarks />
    public _ClassName_Value(_ClassName_State variable, _DataType_ value, object dataLock) : base(dataLock)
    {
        m_value = value;

        if (m_value == null)
        {
            m_value = new _DataType_();
        }

        Initialize(variable);
    }
    #endregion

    #region Public Members
    /// <remarks />
    public _ClassName_State Variable
    {
        get { return m_variable; }
    }

    /// <remarks />
    public _DataType_ Value
    {
        get { return m_value; }
        set { m_value = value; }
    }
    #endregion

    #region Private Methods
    private void Initialize(_ClassName_State variable)
    {
        lock (Lock)
        {
            m_variable = variable;

            variable.Value = m_value;

            variable.OnReadValue = OnReadValue;
            variable.OnSimpleWriteValue = OnWriteValue;

            BaseVariableState instance = null;
            List<BaseInstanceState> updateList = new List<BaseInstanceState>();
            updateList.Add(variable);

            // ListOfChildInitializers

            SetUpdateList(updateList);
        }
    }

    /// <remarks />
    protected ServiceResult OnReadValue(
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

            if (m_value != null)
            {
                value = m_value;
            }

            return Read(context, node, indexRange, dataEncoding, ref value, ref statusCode, ref timestamp);
        }
    }

    private ServiceResult OnWriteValue(ISystemContext context, NodeState node, ref object value)
    {
        lock (Lock)
        {
            _DataType_ newValue;
            if (value is ExtensionObject extensionObject)
            {
                newValue = (_DataType_)extensionObject.Body;
            }
            else
            {
                newValue = (_DataType_)value;
            }

            if (m_value != newValue)
            {
                Timestamp = DateTime.UtcNow;
                UpdateChildrenChangeMasks(context, newValue);
                m_value = (_DataType_)Write(newValue);
                m_variable.UpdateChangeMasks(NodeStateChangeMasks.Value);
                m_variable.ClearChangeMasks(context, true);
            }
        }

        return ServiceResult.Good;
    }

    private void UpdateChildrenChangeMasks(ISystemContext context, _DataType_ newValue)
    {
        // ListOfUpdateChildrenChangeMasks
    }

    private void UpdateParent(ISystemContext context)
    {
        Timestamp = DateTime.UtcNow;
        m_variable.UpdateChangeMasks(NodeStateChangeMasks.Value);
        m_variable.ClearChangeMasks(context, false);
    }

    // ListOfChildMethods
    #endregion

    #region Private Fields
    private _DataType_ m_value;
    private _ClassName_State m_variable;
    #endregion
}
#endregion
// ***END***
