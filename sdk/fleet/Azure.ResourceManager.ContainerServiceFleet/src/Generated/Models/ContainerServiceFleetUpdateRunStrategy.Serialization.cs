// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerServiceFleet.Models
{
    internal partial class ContainerServiceFleetUpdateRunStrategy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("stages"u8);
            writer.WriteStartArray();
            foreach (var item in Stages)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ContainerServiceFleetUpdateRunStrategy DeserializeContainerServiceFleetUpdateRunStrategy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerServiceFleetUpdateStage> stages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stages"u8))
                {
                    List<ContainerServiceFleetUpdateStage> array = new List<ContainerServiceFleetUpdateStage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServiceFleetUpdateStage.DeserializeContainerServiceFleetUpdateStage(item));
                    }
                    stages = array;
                    continue;
                }
            }
            return new ContainerServiceFleetUpdateRunStrategy(stages);
        }
    }
}
