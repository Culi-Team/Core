using EQX.Core.InOut;

namespace EQX.Core.InOut
{
    public class DOutput
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public bool Value
        {
            get => _dOutputDevice[Id];
            set => _dOutputDevice[Id] = value;
        }

        public DOutput(int id, string name, IDOutputDevice dOutputDevice)
        {
            Id = id;
            Name = name;
            _dOutputDevice = dOutputDevice;
        }

        private readonly IDOutputDevice _dOutputDevice;
    }
}
