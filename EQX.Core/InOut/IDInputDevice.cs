using EQX.Core.Common;

namespace EQX.Core.InOut
{
    /// <summary>
    /// Digital input device (multiple input contact)
    /// </summary>
    public interface IDInputDevice : IIdentifier, IHandleConnection
    {
        bool this[int index] { get; }
        List<IDInput> Inputs { get; }
    }
}
