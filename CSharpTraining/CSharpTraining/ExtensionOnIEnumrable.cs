using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpTraining
{
    public static class ExtensionOnIEnumrable
    {
        public static bool CustomAll(this IEnumerable<int> list ,Func<int, bool> delFun)
        {
            return list.All(delFun);
        }
        public static bool CustomAny(this IEnumerable<int> list, Func<int, bool> delFun)
        {
            return list.Any(delFun);
        }
        public static int CustomMax(this IEnumerable<int> list, Func<int, int> delFun)
        {
            return list.Max(delFun);
        }
        public static int CustomMin(this IEnumerable<int> list, Func<int, int> delFun)
        {
            return list.Min(delFun);
        }
        public static IEnumerable<int> CustomWhere(this IEnumerable<int> list, Func<int, bool> delFun)
        {
            return list.Where(delFun);
        }
        public static IEnumerable<int> CustomSelect(this IEnumerable<int> list, Func<int,int> delFun)
        {
            return list.Select(delFun);
        }

    }
}
