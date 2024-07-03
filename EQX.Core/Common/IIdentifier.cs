namespace EQX.Core.Common
{
    /// <summary>
    /// Check if the Id and Name is null in Initialize
    /// </summary>
    public interface IIdentifier
    {
        int Id { get; }
        string Name { get; }
    }
}
