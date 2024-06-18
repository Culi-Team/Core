using EQX.Core.Common;

namespace EQX.Core.InOut
{
    /// <summary>
    /// Digital output device (multiple output contact)
    /// </summary>
    public interface IDOutputDevice : IIdentifier, IHandleConnection
    {
        bool this[int index] { get; set; }
        List<DOutput> Outputs { get; }
    }
}
