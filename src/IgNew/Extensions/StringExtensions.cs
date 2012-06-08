// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="IgNew LLC">
//   Copywright (c) 2012 IgNew LLC. All rights reserved.
// </copyright>
// <summary>
//   <see cref="String" /> extension methods.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IgNew.Extensions
{
    #region Using Directives

    using System;

    #endregion

    /// <summary>
    /// <see cref="String"/> extension methods.
    /// </summary>
    public static class StringExtensions
    {
        #region Methods

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value while ignoring case.
        /// </summary>
        /// <param name="target">Object being extended.</param>
        /// <param name="value">The string to compare to this instance. </param>
        /// <returns>True if the <paramref name="value"/> parameter is the same as this instance; otherwise, false.</returns>
        public static bool EqualsIgnoreCase(this string target, string value)
        {
            return string.Equals(target, value, StringComparison.OrdinalIgnoreCase);
        }

        #endregion
    }
}