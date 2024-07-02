using EQX.Core.Common;

namespace EQX.Core.Vision.Tool
{
    public delegate void ToolRunCallback(string errorMessage, IObjectCollection outputs);

    public interface IVisionTool : IIdentifier, IAsyncRunable
    {
        string ErrorMessage { get; }
        ToolRunCallback ToolRunFinished { get; set; }

        IObjectCollection Parameters { get; }

        /// <summary>
        /// Including input image
        /// </summary>
        IObjectCollection Inputs { get; }
        IObjectCollection Outputs { get; }
    }
}