using EQX.Core.InOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public class DInput
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public bool Value => _dInputDevice[Id];

        public DInput(int id, string name, IDInputDevice dInputDevice)
        {
            Id = id;
            Name = name;

            _dInputDevice = dInputDevice;
        }

        private readonly IDInputDevice _dInputDevice;
    }
}
