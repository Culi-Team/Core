using EQX.Core.Common;

namespace EQX.Core.InOut
{
    /// <summary>
    /// Digital input device (multiple input contact, like a Input Driver)
    /// </summary>
    public interface IDInputDevice : IIdentifier, IHandleConnection
    {
        bool this[int index] { get; }
        List<IDInput> Inputs { get; }

        bool Initialize();

        void InverseStatus(IDInput input);
        void InverseStatus(IList<IDInput> inputs);
    }
}
