using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Recipe
{
    public interface IRecipe : IBackupable<IRecipe>, IIdentifier
    {
    }

    public static class RecipeHelpers
    {
        public static void Clone(this IRecipe targetRecipe, IRecipe sourceRecipe)
        {
            PropertyInfo[] properties = targetRecipe.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object sourceValue = property.GetValue(sourceRecipe, null);
                property.SetValue(targetRecipe, sourceValue);
            }
        }
    }
}
