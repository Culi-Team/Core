namespace EQX.Core.Common
{
    /// <summary>
    /// Check if the Id and Name is null in Initializate
    /// </summary>
    public interface IIdentifier
    {
        int Id { get; init; }
        string Name { get; init; }
    }
}
