using EQX.Core.Common;

namespace EQX.Core.Vision.Tool
{
    public interface IVisionFlow : IIdentifier, IRunable
    {
        IEnumerable<IVisionTool> VisionTools { get; }

        /// <summary>
        /// (The_Tool, [Tool that get The_Tool output as input])
        /// </summary>
        IEnumerable<(object, IEnumerable<object>)> ToolOutputs { get; }
    }
}