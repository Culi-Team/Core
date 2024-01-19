namespace EQX.Core.Sequence
{
    public enum EProcessMode
    {
        None,       // 0
        ToWarning,
        Warning,
        ToAlarm,
        Alarm,
        ToOrigin,
        Origin,
        ToStop,
        Stop,
        ToRun,
        Run,        // 10
    }
}
