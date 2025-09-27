using EQX.Core.Common;

namespace EQX.Core.InOut
{
    public interface IAInput : IIdentifier
    {
        double Volt { get; }
        double Current { get; }
    }
}
