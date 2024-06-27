using EQX.Core.Common;

namespace EQX.Core.Sequence
{
    public interface IProcess<TESequence> : IIdentifier, IProcessExecutor where TESequence : Enum
    {
        /// <summary>
        /// Set wait time for waiting before running next step
        /// </summary>
        int WaitTime { get; set; }

        /// <summary>
        /// Parent process of current process. It may be null if it's the Root Process
        /// </summary>
        IProcess<TESequence>? Parent { get; }

        IList<IProcess<TESequence>>? Childs { get; }

        /// <summary>
        /// Add Children process to handle
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        int AddChild(IProcess<TESequence> child);

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
        TESequence Sequence { get; set; }

        bool Start();
        bool Stop();
    }
}
