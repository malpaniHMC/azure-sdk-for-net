// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Salesforce. </summary>
    public partial class SalesforceLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of SalesforceLinkedService. </summary>
        public SalesforceLinkedService()
        {
            LinkedServiceType = "Salesforce";
        }

        /// <summary> Initializes a new instance of SalesforceLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="environmentUri"> The URL of Salesforce instance. Default is 'https://login.salesforce.com'. To copy data from sandbox, specify 'https://test.salesforce.com'. To copy data from custom domain, specify, for example, 'https://[domain].my.salesforce.com'. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username for Basic authentication of the Salesforce instance. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password for Basic authentication of the Salesforce instance. </param>
        /// <param name="securityToken"> The security token is optional to remotely access Salesforce instance. </param>
        /// <param name="apiVersion"> The Salesforce API version used in ADF. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SalesforceLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> environmentUri, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, DataFactorySecretBaseDefinition securityToken, DataFactoryElement<string> apiVersion, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            EnvironmentUri = environmentUri;
            Username = username;
            Password = password;
            SecurityToken = securityToken;
            ApiVersion = apiVersion;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Salesforce";
        }

        /// <summary> The URL of Salesforce instance. Default is 'https://login.salesforce.com'. To copy data from sandbox, specify 'https://test.salesforce.com'. To copy data from custom domain, specify, for example, 'https://[domain].my.salesforce.com'. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EnvironmentUri { get; set; }
        /// <summary> The username for Basic authentication of the Salesforce instance. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password for Basic authentication of the Salesforce instance. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The security token is optional to remotely access Salesforce instance. </summary>
        public DataFactorySecretBaseDefinition SecurityToken { get; set; }
        /// <summary> The Salesforce API version used in ADF. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ApiVersion { get; set; }
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
