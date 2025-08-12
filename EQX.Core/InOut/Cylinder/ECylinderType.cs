namespace EQX.Core.InOut
{
    /// <summary>
    /// <para/>Non Reverse :
    /// <para/>    Forward = Up = Right = Grip = Algin = Lock = Flip
    /// <para/>    Backward = Down = Left = Ungrip = Unalign = Unlock = Unflip
    /// 
    /// <para/>Reverse :
    /// <para/>    Forward = Down = Left = Ungrip = Unalign = Unlock = Flip
    /// <para/>    Backward = Up = Right = Grip = Algin = Lock = Unflip
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
        FlipUnflip, //Flip = 180°, Unflip = 0°
        FlipUnflipReverse
    }
}
