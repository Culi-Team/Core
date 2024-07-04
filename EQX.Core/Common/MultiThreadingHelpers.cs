using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Common
{
    public static class MultiThreadingHelpers
    {
        public static void SafeSetValue<T>(ref T target, T value) where T : class
        {
            Interlocked.Exchange<T>(ref target, value);
        }

        public static void SafeSetValue<T>(ref int target, T value) where T : Enum
        {
            Interlocked.Exchange(ref target, Convert.ToInt32(value));
        }

        public static void SafeSetValue(ref int target, int value)
        {
            Interlocked.Exchange(ref target, value);
        }
    }
}
