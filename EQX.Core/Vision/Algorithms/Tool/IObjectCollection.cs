using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Algorithms
{
    public interface IObjectCollection
    {
        object? this[string key] { get; set; }
        ObservableCollection<string>? Keys { get; set; }
    }
}