// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The Azure Search Index. </summary>
    public partial class AzureSearchIndexDataset : DataFactoryDatasetDefinition
    {
        /// <summary> Initializes a new instance of AzureSearchIndexDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="indexName"> The name of the Azure Search Index. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="indexName"/> is null. </exception>
        public AzureSearchIndexDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> indexName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(indexName, nameof(indexName));

            IndexName = indexName;
            DatasetType = "AzureSearchIndex";
        }

        /// <summary> Initializes a new instance of AzureSearchIndexDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="indexName"> The name of the Azure Search Index. Type: string (or Expression with resultType string). </param>
        internal AzureSearchIndexDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> indexName) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            IndexName = indexName;
            DatasetType = datasetType ?? "AzureSearchIndex";
        }

        /// <summary> The name of the Azure Search Index. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> IndexName { get; set; }
    }
}
