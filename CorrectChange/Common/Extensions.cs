using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Yomisoft.CorrectChange.Common
{
    public static class Extensions
    {
        /// <summary>
        /// IEnumerable lacks a ForEach LINQ operator extension method
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence) action(item);
        }

        /// <summary>
        /// Display friendly names for enumeration elements using the Description annotation.
        /// </summary>
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
