namespace EQX.Core.InOut
{
    /// <summary>
    /// <para/>Non Reverse :
    /// <para/>    Forward = Up = Right = Grip = Algin = Lock
    /// <para/>    Backward = Down = Left = Ungrip = Unalign = Unlock
    /// 
    /// <para/>Reverse :
    /// <para/>    Forward = Down = Left = Ungrip = Unalign = Unlock
    /// <para/>    Backward = Up = Right = Grip = Algin = Lock
    /// </summary>
    public enum ECylinderType
    {
        ForwardBackward,
        ForwardBackwardReverse,
        UpDown,
        UpDownReverse,
        RightLeft,
        RightLeftReverse,
        GripUngrip,
        GripUngripReverse,
        AlignUnalign,
        AlignUnalignReverse,
        LockUnlock,
        LockUnlockReverse,
    }
}
