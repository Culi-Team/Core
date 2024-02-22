using EQX.Core.Common;

namespace EQX.Core.Sequence
{
    public interface IProcess<TERunMode> : IIdentifier, IProcessExecutor where TERunMode : Enum
    {
        /// <summary>
        /// Parent process of current process. It may be null if it's the Root Process
        /// </summary>
        IProcess<TERunMode>? Parent { get; }

        IList<IProcess<TERunMode>>? Childs { get; }

        /// <summary>
        /// Add Children process to handle
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        int AddChild(IProcess<TERunMode> child);

        /// <summary>
        /// Process Mode of the process. None / Stop / Warning / Alarm / Run...
        /// </summary>
        EProcessMode ProcessMode { get; set; }
        /// <summary>
        /// Status of ProcessMode execution. ToStopDone / ToOriginDone...
        /// </summary>
        EProcessStatus ProcessStatus { get; set; }

        /// <summary>
        /// Current Step of the process
        /// </summary>
        int Step { get; set; }
        /// <summary>
        /// Client define RunMode (Sequence of the Automation Machine)<br/>
        /// For example: FirstInspect -> Pick -> SecondInspect -> Place...
        /// </summary>
        TERunMode RunMode { get; set; }

        bool Start();
        bool Stop();
    }
}
