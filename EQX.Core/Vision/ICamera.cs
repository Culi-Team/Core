using EQX.Core.Common;

namespace EQX.Core.Vision
{
    public interface ICamera : IHandleConnection, IIdentifier
    {
        byte[]? GrabSingle();
    }
}
