namespace EQX.Core.InOut
{
    public interface ICylinderFactory
    {
        ICylinder Create(List<IDInput> inForward, List<IDInput> inBackward, IDOutput? outForward, IDOutput? outBackward);
    }
}
