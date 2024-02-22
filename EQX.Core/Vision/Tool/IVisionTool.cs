using EQX.Core.Common;

namespace EQX.Core.Vision.Tool
{
    public interface IVisionTool : IIdentifier, IRunable
    {
        IObjectCollection Parameters { get; }

        /// <summary>
        /// Including input image
        /// </summary>
        IObjectCollection Inputs { get; }
        IObjectCollection Outputs { get; }
    }
}