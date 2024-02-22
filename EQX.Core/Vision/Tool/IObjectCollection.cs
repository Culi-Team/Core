namespace EQX.Core.Vision.Tool
{
    public interface IObjectCollection
    {
        object? this[string key] { get; set; }
    }
}