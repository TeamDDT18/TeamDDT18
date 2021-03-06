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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace TankPlant
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 15026;

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public const uint Plant1_Tank1 = 15027;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController Object.
        /// </summary>
        public const uint Plant1_Tank1_LevelController = 15028;

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe Object.
        /// </summary>
        public const uint Plant1_Tank1_InputPipe = 15033;

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe_FillValve Object.
        /// </summary>
        public const uint Plant1_Tank1_InputPipe_FillValve = 15034;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe Object.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe = 15036;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_DischargeValve Object.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_DischargeValve = 15037;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter Object.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter = 15039;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton = 15045;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StartButton = 15046;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StopButton = 15048;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_ResetButton = 15050;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_modeButton = 15052;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public const uint GenericControllerType = 15001;

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public const uint AnalogOutputType = 15006;

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public const uint AnalogInputType = 15008;

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public const uint DigitalType = 15014;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15016;

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public const uint AnalogSensorType = 15018;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 15024;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public const uint GenericControllerType_SetPoint = 15002;

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public const uint GenericControllerType_Ki = 15003;

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public const uint GenericControllerType_Kp = 15004;

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public const uint GenericControllerType_Kd = 15005;

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public const uint AnalogOutputType_Input = 15007;

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public const uint AnalogInputType_Output = 15009;

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimt Variable.
        /// </summary>
        public const uint AnalogInputType_HighLimt = 15010;

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimit Variable.
        /// </summary>
        public const uint AnalogInputType_LowLimit = 15011;

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimtAlarm Variable.
        /// </summary>
        public const uint AnalogInputType_HighLimtAlarm = 15012;

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimitAlarm Variable.
        /// </summary>
        public const uint AnalogInputType_LowLimitAlarm = 15013;

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public const uint DigitalType_Value = 15015;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_SetPoint Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_SetPoint = 15029;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Ki Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Ki = 15030;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kp Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Kp = 15031;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kd Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Kd = 15032;

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe_FillValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank1_InputPipe_FillValve_Input = 15035;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_DischargeValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_DischargeValve_Input = 15038;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_Output Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter_Output = 15040;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_HighLimt Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter_HighLimt = 15041;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_LowLimit Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter_LowLimit = 15042;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_HighLimtAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter_HighLimtAlarm = 15043;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_LowLimitAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OutputPipe_FlowMeter_LowLimitAlarm = 15044;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StartButton_Value = 15047;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StopButton_Value = 15049;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_ResetButton_Value = 15051;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_modeButton_Value = 15053;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(TankPlant.Objects.Plant1, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1 = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_LevelController, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_InputPipe = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_InputPipe, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe_FillValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_InputPipe_FillValve = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_InputPipe_FillValve, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OutputPipe, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_DischargeValve = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OutputPipe_DischargeValve, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OutputPipe_FlowMeter, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OperationButton, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StartButton = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OperationButton_StartButton, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StopButton = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OperationButton_StopButton, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_ResetButton = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OperationButton_ResetButton, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_modeButton = new ExpandedNodeId(TankPlant.Objects.Plant1_Tank1_OperationButton_modeButton, TankPlant.Namespaces.TankPlant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(TankPlant.ObjectTypes.GenericControllerType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType = new ExpandedNodeId(TankPlant.ObjectTypes.AnalogOutputType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType = new ExpandedNodeId(TankPlant.ObjectTypes.AnalogInputType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType = new ExpandedNodeId(TankPlant.ObjectTypes.DigitalType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(TankPlant.ObjectTypes.ValveType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType = new ExpandedNodeId(TankPlant.ObjectTypes.AnalogSensorType, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ButtonType = new ExpandedNodeId(TankPlant.ObjectTypes.ButtonType, TankPlant.Namespaces.TankPlant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(TankPlant.Variables.GenericControllerType_SetPoint, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Ki = new ExpandedNodeId(TankPlant.Variables.GenericControllerType_Ki, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kp = new ExpandedNodeId(TankPlant.Variables.GenericControllerType_Kp, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kd = new ExpandedNodeId(TankPlant.Variables.GenericControllerType_Kd, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_Input = new ExpandedNodeId(TankPlant.Variables.AnalogOutputType_Input, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Output = new ExpandedNodeId(TankPlant.Variables.AnalogInputType_Output, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimt Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_HighLimt = new ExpandedNodeId(TankPlant.Variables.AnalogInputType_HighLimt, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimit Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_LowLimit = new ExpandedNodeId(TankPlant.Variables.AnalogInputType_LowLimit, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimtAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_HighLimtAlarm = new ExpandedNodeId(TankPlant.Variables.AnalogInputType_HighLimtAlarm, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimitAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_LowLimitAlarm = new ExpandedNodeId(TankPlant.Variables.AnalogInputType_LowLimitAlarm, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Value = new ExpandedNodeId(TankPlant.Variables.DigitalType_Value, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_SetPoint = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_LevelController_SetPoint, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Ki = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_LevelController_Ki, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Kp = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_LevelController_Kp, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Kd = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_LevelController_Kd, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_InputPipe_FillValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_InputPipe_FillValve_Input = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_InputPipe_FillValve_Input, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_DischargeValve_Input = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_DischargeValve_Input, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter_Output = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_FlowMeter_Output, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_HighLimt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter_HighLimt = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_FlowMeter_HighLimt, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_LowLimit Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter_LowLimit = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_FlowMeter_LowLimit, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_HighLimtAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter_HighLimtAlarm = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_FlowMeter_HighLimtAlarm, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OutputPipe_FlowMeter_LowLimitAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OutputPipe_FlowMeter_LowLimitAlarm = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OutputPipe_FlowMeter_LowLimitAlarm, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StartButton_Value = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OperationButton_StartButton_Value, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StopButton_Value = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OperationButton_StopButton_Value, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_ResetButton_Value = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OperationButton_ResetButton_Value, TankPlant.Namespaces.TankPlant);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_modeButton_Value = new ExpandedNodeId(TankPlant.Variables.Plant1_Tank1_OperationButton_modeButton_Value, TankPlant.Namespaces.TankPlant);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AnalogInputType component.
        /// </summary>
        public const string AnalogInputType = "AnalogInputType";

        /// <summary>
        /// The BrowseName for the AnalogOutputType component.
        /// </summary>
        public const string AnalogOutputType = "AnalogOutputType";

        /// <summary>
        /// The BrowseName for the AnalogSensorType component.
        /// </summary>
        public const string AnalogSensorType = "AnalogSensorType";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the DigitalType component.
        /// </summary>
        public const string DigitalType = "DigitalType";

        /// <summary>
        /// The BrowseName for the GenericControllerType component.
        /// </summary>
        public const string GenericControllerType = "GenericControllerType";

        /// <summary>
        /// The BrowseName for the HighLimt component.
        /// </summary>
        public const string HighLimt = "HighLimt";

        /// <summary>
        /// The BrowseName for the HighLimtAlarm component.
        /// </summary>
        public const string HighLimtAlarm = "HighLimtAlarm";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the Kd component.
        /// </summary>
        public const string Kd = "Kd";

        /// <summary>
        /// The BrowseName for the Ki component.
        /// </summary>
        public const string Ki = "Ki";

        /// <summary>
        /// The BrowseName for the Kp component.
        /// </summary>
        public const string Kp = "Kp";

        /// <summary>
        /// The BrowseName for the LowLimit component.
        /// </summary>
        public const string LowLimit = "LowLimit";

        /// <summary>
        /// The BrowseName for the LowLimitAlarm component.
        /// </summary>
        public const string LowLimitAlarm = "LowLimitAlarm";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant 1";

        /// <summary>
        /// The BrowseName for the SetPoint component.
        /// </summary>
        public const string SetPoint = "SetPoint";

        /// <summary>
        /// The BrowseName for the Tank1 component.
        /// </summary>
        public const string Tank1 = "Tank 1";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the TankPlant namespace (.NET code namespace is 'TankPlant').
        /// </summary>
        public const string TankPlant = "http://opcfoundation.org/TankPlant";
    }
    #endregion
}