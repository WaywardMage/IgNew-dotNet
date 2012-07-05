// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConfigurationManagerProxy.cs" company="IgNew LLC">
//   Copywright (c) 2012 IgNew LLC. All rights reserved.
// </copyright>
// <summary>
//   Proxy interface for <see cref="ConfigurationManager" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region Using Directives

using System.Configuration;

#endregion

namespace IgNew.Configuration.Proxies
{
    /// <summary>
    /// Proxy interface for <see cref="ConfigurationManager"/>.
    /// </summary>
    public interface IConfigurationManagerProxy
    {
        #region Method

        /// <summary>
        /// Retrieves a specified configuration section for the current application's default configuration.
        /// </summary>
        /// <param name="sectionName">
        /// The section Name.
        /// </param>
        /// <returns>
        /// The configuration section path and name.
        /// </returns>
        /// <exception cref="ConfigurationErrorsException">A configuration file could not be loaded.</exception>
        object GetSection(string sectionName);

        /// <summary>
        /// Retrieves a specified configuration section for the current application's default configuration.
        /// </summary>
        /// <typeparam name="T">
        /// Type of configuration section to get.
        /// </typeparam>
        /// <param name="sectionName">
        /// The section Name.
        /// </param>
        /// <returns>
        /// The configuration section path and name.
        /// </returns>
        /// <exception cref="ConfigurationErrorsException">
        /// A configuration file could not be loaded.
        /// </exception>
        T GetSection<T>(string sectionName) where T : ConfigurationSection;

        #endregion
    }
}