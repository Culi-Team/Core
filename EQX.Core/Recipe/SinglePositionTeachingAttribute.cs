using EQX.Core.Motion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Recipe
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SinglePositionTeachingAttribute : Attribute
    {
        public string Motion { get; set; }
    }
}
