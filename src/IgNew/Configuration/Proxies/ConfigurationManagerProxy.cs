// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationManagerProxy.cs" company="IgNew LLC">
//   Copywright (c) 2012 IgNew LLC. All rights reserved.
// </copyright>
// <summary>
//   Proxy interface for <see cref="ConfigurationManager" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region Using Directives

using System;
using System.Configuration;
using System.Threading;

#endregion

namespace IgNew.Configuration.Proxies
{
    /// <summary>
    /// Proxy interface for <see cref="ConfigurationManager"/>.
    /// </summary>
    public sealed class ConfigurationManagerProxy : IConfigurationManagerProxy
    {
        #region Fields and Constants

        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static readonly Lazy<IConfigurationManagerProxy> Singleton =
            new Lazy<IConfigurationManagerProxy>(
                () => new ConfigurationManagerProxy(), LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationManagerProxy"/> class. 
        /// </summary>
        public ConfigurationManagerProxy()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the singleton instance of <see cref="ConfigurationManagerProxy"/>.
        /// </summary>
        public static IConfigurationManagerProxy Instance
        {
            get
            {
                return Singleton.Value;
            }
        }

        #endregion

        #region Methods

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
        public object GetSection(string sectionName)
        {
            return ConfigurationManager.GetSection(sectionName);
        }

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
        public T GetSection<T>(string sectionName)
            where T : ConfigurationSection
        {
            var section = this.GetSection(sectionName);

            if (section == null)
            {
                throw new ConfigurationErrorsException("Error loading harvestProxy configuration section.");
            }

            return (T)section;
        }

        #endregion
    }
}