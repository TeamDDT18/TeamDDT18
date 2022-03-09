/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TankPlant
{
    #region GenericControllerState Class
    #if (!OPCUA_EXCLUDE_GenericControllerState)
    /// <summary>
    /// Stores an instance of the GenericControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.GenericControllerType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQAdAAAA" +
           "R2VuZXJpY0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////BAAAABVgiQoCAAAAAQAI" +
           "AAAAU2V0UG9pbnQBAZo6AC4ARJo6AAAAC/////8DA/////8AAAAAFWCJCgIAAAABAAIAAABLaQEBmzoA" +
           "LgBEmzoAAAAL/////wMD/////wAAAAAVYIkKAgAAAAEAAgAAAEtwAQGcOgAuAEScOgAAAAv/////AwP/" +
           "////AAAAABVgiQoCAAAAAQACAAAAS2QBAZ06AC4ARJ06AAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<double> SetPoint
        {
            get
            {
                return m_setPoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setPoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setPoint = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Ki
        {
            get
            {
                return m_ki;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ki, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ki = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kp
        {
            get
            {
                return m_kp;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kp, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kp = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Kd
        {
            get
            {
                return m_kd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_kd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_kd = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_setPoint != null)
            {
                children.Add(m_setPoint);
            }

            if (m_ki != null)
            {
                children.Add(m_ki);
            }

            if (m_kp != null)
            {
                children.Add(m_kp);
            }

            if (m_kd != null)
            {
                children.Add(m_kd);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TankPlant.BrowseNames.SetPoint:
                {
                    if (createOrReplace)
                    {
                        if (SetPoint == null)
                        {
                            if (replacement == null)
                            {
                                SetPoint = new PropertyState<double>(this);
                            }
                            else
                            {
                                SetPoint = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = SetPoint;
                    break;
                }

                case TankPlant.BrowseNames.Ki:
                {
                    if (createOrReplace)
                    {
                        if (Ki == null)
                        {
                            if (replacement == null)
                            {
                                Ki = new PropertyState<double>(this);
                            }
                            else
                            {
                                Ki = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Ki;
                    break;
                }

                case TankPlant.BrowseNames.Kp:
                {
                    if (createOrReplace)
                    {
                        if (Kp == null)
                        {
                            if (replacement == null)
                            {
                                Kp = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kp = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kp;
                    break;
                }

                case TankPlant.BrowseNames.Kd:
                {
                    if (createOrReplace)
                    {
                        if (Kd == null)
                        {
                            if (replacement == null)
                            {
                                Kd = new PropertyState<double>(this);
                            }
                            else
                            {
                                Kd = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Kd;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_setPoint;
        private PropertyState<double> m_ki;
        private PropertyState<double> m_kp;
        private PropertyState<double> m_kd;
        #endregion
    }
    #endif
    #endregion

    #region AnalogOutputState Class
    #if (!OPCUA_EXCLUDE_AnalogOutputState)
    /// <summary>
    /// Stores an instance of the AnalogOutputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogOutputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogOutputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.AnalogOutputType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQAYAAAA" +
           "QW5hbG9nT3V0cHV0VHlwZUluc3RhbmNlAQGeOgEBnjqeOgAA/////wEAAAAVYIkKAgAAAAEABQAAAElu" +
           "cHV0AQGfOgAvAD+fOgAAAAv/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TankPlant.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Input = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_input;
        #endregion
    }
    #endif
    #endregion

    #region AnalogInputState Class
    #if (!OPCUA_EXCLUDE_AnalogInputState)
    /// <summary>
    /// Stores an instance of the AnalogInputType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogInputState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogInputState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.AnalogInputType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQAXAAAA" +
           "QW5hbG9nSW5wdXRUeXBlSW5zdGFuY2UBAaA6AQGgOqA6AAD/////BQAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGhOgAvAD+hOgAAAAv/////AwP/////AAAAABVgiQoCAAAAAQAIAAAASGlnaExpbXQBAaI6AC8A" +
           "P6I6AAAAC/////8DA/////8AAAAAFWCJCgIAAAABAAgAAABMb3dMaW1pdAEBozoALwA/ozoAAAAL////" +
           "/wMD/////wAAAAAVYIkKAgAAAAEADQAAAEhpZ2hMaW10QWxhcm0BAaQ6AC8AP6Q6AAAAAf////8DA///" +
           "//8AAAAAFWCJCgIAAAABAA0AAABMb3dMaW1pdEFsYXJtAQGlOgAvAD+lOgAAAAH/////AwP/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> HighLimt
        {
            get
            {
                return m_highLimt;
            }

            set
            {
                if (!Object.ReferenceEquals(m_highLimt, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_highLimt = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<double> LowLimit
        {
            get
            {
                return m_lowLimit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lowLimit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lowLimit = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> HighLimtAlarm
        {
            get
            {
                return m_highLimtAlarm;
            }

            set
            {
                if (!Object.ReferenceEquals(m_highLimtAlarm, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_highLimtAlarm = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<bool> LowLimitAlarm
        {
            get
            {
                return m_lowLimitAlarm;
            }

            set
            {
                if (!Object.ReferenceEquals(m_lowLimitAlarm, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lowLimitAlarm = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_highLimt != null)
            {
                children.Add(m_highLimt);
            }

            if (m_lowLimit != null)
            {
                children.Add(m_lowLimit);
            }

            if (m_highLimtAlarm != null)
            {
                children.Add(m_highLimtAlarm);
            }

            if (m_lowLimitAlarm != null)
            {
                children.Add(m_lowLimitAlarm);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TankPlant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                Output = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case TankPlant.BrowseNames.HighLimt:
                {
                    if (createOrReplace)
                    {
                        if (HighLimt == null)
                        {
                            if (replacement == null)
                            {
                                HighLimt = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                HighLimt = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = HighLimt;
                    break;
                }

                case TankPlant.BrowseNames.LowLimit:
                {
                    if (createOrReplace)
                    {
                        if (LowLimit == null)
                        {
                            if (replacement == null)
                            {
                                LowLimit = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                LowLimit = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = LowLimit;
                    break;
                }

                case TankPlant.BrowseNames.HighLimtAlarm:
                {
                    if (createOrReplace)
                    {
                        if (HighLimtAlarm == null)
                        {
                            if (replacement == null)
                            {
                                HighLimtAlarm = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                HighLimtAlarm = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = HighLimtAlarm;
                    break;
                }

                case TankPlant.BrowseNames.LowLimitAlarm:
                {
                    if (createOrReplace)
                    {
                        if (LowLimitAlarm == null)
                        {
                            if (replacement == null)
                            {
                                LowLimitAlarm = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                LowLimitAlarm = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = LowLimitAlarm;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_output;
        private BaseDataVariableState<double> m_highLimt;
        private BaseDataVariableState<double> m_lowLimit;
        private BaseDataVariableState<bool> m_highLimtAlarm;
        private BaseDataVariableState<bool> m_lowLimitAlarm;
        #endregion
    }
    #endif
    #endregion

    #region DigitalState Class
    #if (!OPCUA_EXCLUDE_DigitalState)
    /// <summary>
    /// Stores an instance of the DigitalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DigitalState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DigitalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.DigitalType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQATAAAA" +
           "RGlnaXRhbFR5cGVJbnN0YW5jZQEBpjoBAaY6pjoAAP////8BAAAAFWCJCgIAAAABAAUAAABWYWx1ZQEB" +
           "pzoALwA/pzoAAAAB/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case TankPlant.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                Value = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = Value;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_value;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : AnalogOutputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.ValveType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQARAAAA" +
           "VmFsdmVUeXBlSW5zdGFuY2UBAag6AQGoOqg6AAD/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAak6" +
           "AC8AP6k6AAAAC/////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorState)
    /// <summary>
    /// Stores an instance of the AnalogSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorState : AnalogInputState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.AnalogSensorType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQAYAAAA" +
           "QW5hbG9nU2Vuc29yVHlwZUluc3RhbmNlAQGqOgEBqjqqOgAA/////wUAAAAVYIkKAgAAAAEABgAAAE91" +
           "dHB1dAEBqzoALwA/qzoAAAAL/////wMD/////wAAAAAVYIkKAgAAAAEACAAAAEhpZ2hMaW10AQGsOgAv" +
           "AD+sOgAAAAv/////AwP/////AAAAABVgiQoCAAAAAQAIAAAATG93TGltaXQBAa06AC8AP606AAAAC///" +
           "//8DA/////8AAAAAFWCJCgIAAAABAA0AAABIaWdoTGltdEFsYXJtAQGuOgAvAD+uOgAAAAH/////AwP/" +
           "////AAAAABVgiQoCAAAAAQANAAAATG93TGltaXRBbGFybQEBrzoALwA/rzoAAAAB/////wMD/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ButtonState Class
    #if (!OPCUA_EXCLUDE_ButtonState)
    /// <summary>
    /// Stores an instance of the ButtonType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ButtonState : DigitalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ButtonState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(TankPlant.ObjectTypes.ButtonType, TankPlant.Namespaces.TankPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACIAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVGFua1BsYW50/////wRggAIBAAAAAQASAAAA" +
           "QnV0dG9uVHlwZUluc3RhbmNlAQGwOgEBsDqwOgAA/////wEAAAAVYIkKAgAAAAEABQAAAFZhbHVlAQGx" +
           "OgAvAD+xOgAAAAH/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}