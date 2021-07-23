// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region DeploymentExtended
        /// <summary> Gets an object representing a DeploymentExtendedContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedContainer" /> object. </returns>
        public static DeploymentExtendedContainer GetDeploymentExtendeds(this ResourceGroupOperations resourceGroup)
        {
            return new DeploymentExtendedContainer(resourceGroup);
        }
        #endregion

        #region DeploymentScript
        /// <summary> Gets an object representing a DeploymentScriptContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentScriptContainer" /> object. </returns>
        public static DeploymentScriptContainer GetDeploymentScripts(this ResourceGroupOperations resourceGroup)
        {
            return new DeploymentScriptContainer(resourceGroup);
        }
        #endregion

        #region Application
        /// <summary> Gets an object representing a ApplicationContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ApplicationContainer" /> object. </returns>
        public static ApplicationContainer GetApplications(this ResourceGroupOperations resourceGroup)
        {
            return new ApplicationContainer(resourceGroup);
        }
        #endregion

        #region ApplicationDefinition
        /// <summary> Gets an object representing a ApplicationDefinitionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ApplicationDefinitionContainer" /> object. </returns>
        public static ApplicationDefinitionContainer GetApplicationDefinitions(this ResourceGroupOperations resourceGroup)
        {
            return new ApplicationDefinitionContainer(resourceGroup);
        }
        #endregion

        #region JitRequestDefinition
        /// <summary> Gets an object representing a JitRequestDefinitionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="JitRequestDefinitionContainer" /> object. </returns>
        public static JitRequestDefinitionContainer GetJitRequestDefinitions(this ResourceGroupOperations resourceGroup)
        {
            return new JitRequestDefinitionContainer(resourceGroup);
        }
        #endregion
    }
}
