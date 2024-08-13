using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Recipe
{
    public delegate void RecipeChangedEventHandler(object oldValue, object newValue, string? propertyName = null);

    public interface IRecipe : IBackupable<IRecipe>, IIdentifier
    {
        event RecipeChangedEventHandler? RecipeChanged;
    }

    public static class RecipeHelpers
    {
        public static void Clone(this IRecipe targetRecipe, IRecipe sourceRecipe)
        {
            PropertyInfo[] properties = targetRecipe.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.SetMethod == null) continue;

                object sourceValue = property.GetValue(sourceRecipe, null);
                property.SetValue(targetRecipe, sourceValue);
            }
        }
    }
}
