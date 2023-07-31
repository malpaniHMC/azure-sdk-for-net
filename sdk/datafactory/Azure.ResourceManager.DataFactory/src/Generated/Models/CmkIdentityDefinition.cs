// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Managed Identity used for CMK. </summary>
    internal partial class CmkIdentityDefinition
    {
        /// <summary> Initializes a new instance of CmkIdentityDefinition. </summary>
        public CmkIdentityDefinition()
        {
        }

        /// <summary> Initializes a new instance of CmkIdentityDefinition. </summary>
        /// <param name="userAssignedIdentity"> The resource id of the user assigned identity to authenticate to customer's key vault. </param>
        internal CmkIdentityDefinition(string userAssignedIdentity)
        {
            UserAssignedIdentity = userAssignedIdentity;
        }

        /// <summary> The resource id of the user assigned identity to authenticate to customer's key vault. </summary>
        public string UserAssignedIdentity { get; set; }
    }
}
