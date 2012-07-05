// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BooleanExtensions.cs" company="IgNew LLC">
//   Copywright (c) 2012 IgNew LLC. All rights reserved.
// </copyright>
// <summary>
//   <see cref="Boolean" /> extension methods.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
#region Using Directives

using System;

#endregion

namespace IgNew.Extensions
{

    /// <summary>
    /// <see cref="Boolean"/> extension methods.
    /// </summary>
    public static class BooleanExtensions
    {
        #region Method

        /// <summary>
        /// Allows for representation of the boolean as a string pair
        /// </summary>
        /// <example>
        /// <code>
        ///     bool myBool = true;
        ///     Console.WriteLine(myBool.ToString("yes", "no"));
        ///     Console.WriteLine(myBool.ToString("Y", "N"));
        ///     Console.WriteLine(myBool.ToString("On", "Off"));
        /// </code>
        /// </example>
        /// <param name="target">Object being extended.</param>
        /// <param name="trueString">True string representation.</param>
        /// <param name="falseString">False string representation.</param>
        /// <returns><paramref name="trueString"/> if true, <paramref name="falseString"/> otherwise.</returns>
        public static string ToString(this bool target, string trueString, string falseString)
        {
            return target ? trueString : falseString;
        }

        #endregion
    }
}