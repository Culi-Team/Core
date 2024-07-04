using EQX.Core.Common;
using Newtonsoft.Json;

namespace EQX.Core.Sequence
{
    public interface IProcessStep
    {
        int OriginStep { get; set; }
        int RunStep { get; set; }
    }

    public interface IProcess<TESequence> : ILogable, IIdentifier, IProcessExecutor where TESequence : Enum
    {
        /// <summary>
        /// Set wait time for waiting before running next step
        /// </summary>
        int WaitTime { get; set; }

        /// <summary>
        /// Parent process of current process. It may be null if it's the Root Process
        /// </summary>
        [JsonIgnore]
        IProcess<TESequence>? Parent { get; }

        [JsonIgnore]
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
