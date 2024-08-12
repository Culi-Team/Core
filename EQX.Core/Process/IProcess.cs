using EQX.Core.Common;
using Newtonsoft.Json;

namespace EQX.Core.Sequence
{
    public delegate void AlarmWarningRaisedHandler(int alarmId, string alarmSource);

    public interface IProcess<TESequence> : ILogable, INameable, IProcessExecutor where TESequence : Enum
    {
        event AlarmWarningRaisedHandler? AlarmRaised;
        event AlarmWarningRaisedHandler? WarningRaised;
        event EventHandler? ProcessModeUpdated;

        int NotificationStartIndex { get; set; }

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
        /// Step of the process
        /// </summary>
        IProcessStep Step { get; }
        IProcessTimer ProcessTimer { get; }
        /// <summary>
        /// Client define RunMode (Sequence of the Automation Machine)<br/>
        /// For example: FirstInspect -> Pick -> SecondInspect -> Place...
        /// </summary>
        TESequence Sequence { get; set; }

        bool Start();
        bool Stop();

        void RaiseAlarm(int alarmId);
        void RaiseAlarm(int alarmId, string alarmSource);

        void RaiseWarning(int warningId);
        void RaiseWarning(int warningId, string warningSource);

        /// <summary>
        /// Process wait for exactly timeout
        /// </summary>
        /// <param name="timeout">time to wait (ms)</param>
        void Wait(int timeout);
        /// <summary>
        /// Process wait for which come first, exactly timeout or action return true
        /// </summary>
        /// <param name="timeout">time to wait (ms)</param>
        /// <param name="waitUntil">Action return true will break waiting</param>
        void Wait(int timeout, Func<bool> waitUntil);
    }
}
