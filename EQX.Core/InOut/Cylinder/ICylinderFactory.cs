namespace EQX.Core.InOut
{
    public interface ICylinderFactory
    {
        ICylinder Create(IDInput? inForward, IDInput? inBackward, IDOutput? outForward, IDOutput? outBackward, Func<bool>? forwardInterlock, Func<bool>? backwardInterlock);
    }
}
