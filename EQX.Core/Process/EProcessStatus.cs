namespace EQX.Core.Sequence
{
    public enum EProcessStatus
    {
        //ToRunFail = -9,
        //StopFail,
        //ToStopFail,
        //OriginFail,
        //ToOriginFail,
        //AlarmFail,
        //ToAlarmFail,
        //WarningFail,
        //ToWarningFail = -1,
        None = 0,           // 0
        ToWarningDone,
        WarningDone,
        ToAlarmDone,
        AlarmDone,
        ToOriginDone,
        OriginDone,
        ToStopDone,
        StopDone,
        ToRunDone,
    }
}
