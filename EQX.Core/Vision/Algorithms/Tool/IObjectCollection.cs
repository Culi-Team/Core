using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Algorithms
{
    public class KeyType : ObservableObject
    {
        private string key;

        public string Key 
        {
            get => key;
            set
            {
                key = value;
                OnPropertyChanged(nameof(Key));
            }
        }
        public Type Type { get; set; }

        public KeyType(string key, Type type)
        {
            Key = key;
            Type = type;
        }
    }

    public interface IObjectCollection
    {
        object? this[string key] { get; set; }
        ObservableCollection<KeyType>? Keys { get; set; }
    }
}