// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownMonitorComputeIdentityBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("computeIdentityType"u8);
            writer.WriteStringValue(ComputeIdentityType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownMonitorComputeIdentityBase DeserializeUnknownMonitorComputeIdentityBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorComputeIdentityType computeIdentityType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeIdentityType"u8))
                {
                    computeIdentityType = new MonitorComputeIdentityType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownMonitorComputeIdentityBase(computeIdentityType);
        }
    }
}
