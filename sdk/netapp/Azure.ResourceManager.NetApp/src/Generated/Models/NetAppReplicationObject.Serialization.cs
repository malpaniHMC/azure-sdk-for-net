// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppReplicationObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicationId))
            {
                writer.WritePropertyName("replicationId");
                writer.WriteStringValue(ReplicationId);
            }
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("endpointType");
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationSchedule))
            {
                writer.WritePropertyName("replicationSchedule");
                writer.WriteStringValue(ReplicationSchedule.Value.ToString());
            }
            writer.WritePropertyName("remoteVolumeResourceId");
            writer.WriteStringValue(RemoteVolumeResourceId);
            if (Optional.IsDefined(RemoteVolumeRegion))
            {
                writer.WritePropertyName("remoteVolumeRegion");
                writer.WriteStringValue(RemoteVolumeRegion);
            }
            writer.WriteEndObject();
        }

        internal static NetAppReplicationObject DeserializeNetAppReplicationObject(JsonElement element)
        {
            Optional<string> replicationId = default;
            Optional<EndpointType> endpointType = default;
            Optional<NetAppReplicationSchedule> replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationId"))
                {
                    replicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replicationSchedule = new NetAppReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"))
                {
                    remoteVolumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
            }
            return new NetAppReplicationObject(replicationId.Value, Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value);
        }
    }
}
