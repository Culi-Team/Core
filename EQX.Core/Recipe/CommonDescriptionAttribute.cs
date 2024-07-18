using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Recipe
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CommonDescriptionAttribute : SingleRecipeDescriptionAttribute
    {
        public string Detail { get; set; }
    }
}
