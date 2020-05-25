/******************************************************************************
    Style Guidelines:
        * Readability - code is easy to read and to understand
        * Standardisation - all team members are aligned with same code style
        * Self-descriptive code - code is easy to understand without comments
        * Debuggable - code is easy to debug (IDE friendly)
 ******************************************************************************/

// using (import) of other namespaces will be wrapped with region "Using"
#region Using
using System;
using System.Collections.Generic;
using MyNameSpace.Enums;
using UnityEngine;

#endregion

// types are defined within the scope of namespace
// space name starts with Upper case letter
// each following word starts with upper Case letter
// sub-spaces are divided by '.' (dot)
// here "MyNameSpace" is main space and "Conditions" is sub-space
namespace MyNameSpace.Conditions
{
    /// <summary>
    /// type name starts with Upper case letter
    /// each following word starts with Upper case letter
    /// <remarks>
    /// type = class, enum, struct, delegate. interface, etc
    /// </remarks>
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// function name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <remarks>
        /// boolean functions/properties usually start with "Is" word
        /// </remarks>
        /// <param name="myEnum">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </param>
        /// <param name="enumMember">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </param>
        /// <returns>
        /// specification of what will be returned is very useful in function comment header
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// exception(s) thrown in function are specified in it's comment header
        /// </exception>
        public static bool IsSame(this MyEnum myEnum, MyEnum enumMember)
        {
            // since 'result' is initialized with 'false' value, 'var' can be used here
            var result = false;
            switch (myEnum)
            {
                case MyEnum.EnumMember1:
                    if (enumMember == MyEnum.EnumMember1)
                    {
                        result = true;
                    }
                    break;
                
                case MyEnum.EnumMember2:
                    if (enumMember == MyEnum.EnumMember2)
                    {
                        result = true;
                    }
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(myEnum), myEnum, null);
            }
            return result;
        }

        /// <summary>
        /// function name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </summary>
        /// <param name="string">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// if parameter name collides with type name(s) '@' character predicate can be used
        /// </param>
        /// <returns>
        /// specification of what will be returned is very useful in function comment header
        /// </returns>
        public static bool IsNullOrEmpty(this string @string)
        {
            // 'var' can be used here instead of 'bool' since it is clear
            // what value type is returned from 'string.IsNullOrEmpty(@string);' 
            var result = string.IsNullOrEmpty(@string);
            // result variable is used here to capture the value for better debugging experience
            return result;
        }

        /// <summary>
        /// function name starts with Upper case letter
        /// each following word starts with Upper case letter 
        /// </summary>
        /// <param name="array">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter 
        /// </param>
        /// <typeparam name="T">
        /// generic type parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// in case of single parameter, single letter 'T' can be used
        /// </typeparam>
        public static void Reset<T>(this T[] array)
        { // <- opening parenthesis, new line after method name
            for (var i = 0; i < array.Length; i++)
            { // <- opening parenthesis, new line after 'for' loop definition line
                array[i] = default(T);
                // alternative: array[i] = default; // no need to specify (T)
            } // <- closing parenthesis, new line after last loop code line
        } // <- closing parenthesis, new line after last method code line

        /// <summary>
        /// function name starts with Upper case letter
        /// each following word starts with Upper case letter 
        /// </summary>
        /// <param name="list">
        /// parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// </param>
        /// <typeparam name="T">
        /// generic type parameter name starts with Upper case letter
        /// each following word starts with Upper case letter
        /// in case of single parameter, single letter 'T' can be used
        /// </typeparam>
        public static void Print<T>(this IEnumerable<T> list)
        {
            // disposable resources will be defined within scope of 'using' statement
            using (var e = list.GetEnumerator())
            { // <- opening parenthesis, new line after 'using' definition line
                while (e.MoveNext())
                { // <- opening parenthesis, new line after 'while' loop definition line
                    Debug.Log(e.Current);
                } // <- closing parenthesis, new line after last loop code line
            } // <- closing parenthesis, new line after last 'using' code line
        }
    }
}