using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Tool
{
    public interface IObjectCollection
    {
        object? this[string key] { get; set; }
        ObservableCollection<string>? Keys { get; set; }
    }
}