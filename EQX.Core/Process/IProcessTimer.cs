namespace EQX.Core.Sequence
{
    public interface IProcessTimer
    {
        int StepElapsedTime { get; }
        int StepStartTime { get; }
        /// <summary>
        /// Set wait time for waiting before running next step
        /// </summary>
        int WaitTime { get; }

        /// <summary>
        /// User free to use
        /// </summary>
        int SpareTime { get; set; }
    }
}