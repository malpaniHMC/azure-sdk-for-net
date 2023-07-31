// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SparkConfigurationParametrizationReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ReferenceType.ToString());
            writer.WritePropertyName("referenceName"u8);
            JsonSerializer.Serialize(writer, ReferenceName);
            writer.WriteEndObject();
        }

        internal static SparkConfigurationParametrizationReference DeserializeSparkConfigurationParametrizationReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkConfigurationReferenceType type = default;
            DataFactoryElement<string> referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new SparkConfigurationReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
            }
            return new SparkConfigurationParametrizationReference(type, referenceName);
        }
    }
}
