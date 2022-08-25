// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorPrivateLinkAccessModeSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("queryAccessMode");
            writer.WriteStringValue(QueryAccessMode.ToString());
            writer.WritePropertyName("ingestionAccessMode");
            writer.WriteStringValue(IngestionAccessMode.ToString());
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MonitorPrivateLinkAccessModeSettings DeserializeMonitorPrivateLinkAccessModeSettings(JsonElement element)
        {
            MonitorPrivateLinkAccessMode queryAccessMode = default;
            MonitorPrivateLinkAccessMode ingestionAccessMode = default;
            Optional<IList<MonitorPrivateLinkAccessModeSettingsExclusion>> exclusions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryAccessMode"))
                {
                    queryAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionAccessMode"))
                {
                    ingestionAccessMode = new MonitorPrivateLinkAccessMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exclusions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MonitorPrivateLinkAccessModeSettingsExclusion> array = new List<MonitorPrivateLinkAccessModeSettingsExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorPrivateLinkAccessModeSettingsExclusion.DeserializeMonitorPrivateLinkAccessModeSettingsExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
            }
            return new MonitorPrivateLinkAccessModeSettings(queryAccessMode, ingestionAccessMode, Optional.ToList(exclusions));
        }
    }
}
