using EQX.Core.Common;

namespace EQX.Core.InOut
{
    /// <summary>
    /// Digital output contact (single contact)
    /// </summary>
    public interface IDOutput : IIdentifier
    {
        bool Value { get; set; }
    }
}
