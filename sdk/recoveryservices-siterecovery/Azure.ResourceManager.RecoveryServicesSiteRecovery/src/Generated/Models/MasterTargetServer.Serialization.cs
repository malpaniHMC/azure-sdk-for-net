// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MasterTargetServer
    {
        internal static MasterTargetServer DeserializeMasterTargetServer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> name = default;
            Optional<string> osType = default;
            Optional<string> agentVersion = default;
            Optional<DateTimeOffset> lastHeartbeat = default;
            Optional<string> versionStatus = default;
            Optional<IReadOnlyList<SiteRecoveryRetentionVolume>> retentionVolumes = default;
            Optional<IReadOnlyList<SiteRecoveryDataStore>> dataStores = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> validationErrors = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> healthErrors = default;
            Optional<int> diskCount = default;
            Optional<string> osVersion = default;
            Optional<DateTimeOffset> agentExpireOn = default;
            Optional<string> marsAgentVersion = default;
            Optional<DateTimeOffset> marsAgentExpireOn = default;
            Optional<SiteRecoveryVersionDetails> agentVersionDetails = default;
            Optional<SiteRecoveryVersionDetails> marsAgentVersionDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionVolumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryRetentionVolume> array = new List<SiteRecoveryRetentionVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryRetentionVolume.DeserializeSiteRecoveryRetentionVolume(item));
                    }
                    retentionVolumes = array;
                    continue;
                }
                if (property.NameEquals("dataStores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDataStore> array = new List<SiteRecoveryDataStore>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDataStore.DeserializeSiteRecoveryDataStore(item));
                    }
                    dataStores = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("diskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("marsAgentVersion"u8))
                {
                    marsAgentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marsAgentExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marsAgentExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("marsAgentVersionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marsAgentVersionDetails = SiteRecoveryVersionDetails.DeserializeSiteRecoveryVersionDetails(property.Value);
                    continue;
                }
            }
            return new MasterTargetServer(id.Value, ipAddress.Value, name.Value, osType.Value, agentVersion.Value, Optional.ToNullable(lastHeartbeat), versionStatus.Value, Optional.ToList(retentionVolumes), Optional.ToList(dataStores), Optional.ToList(validationErrors), Optional.ToList(healthErrors), Optional.ToNullable(diskCount), osVersion.Value, Optional.ToNullable(agentExpireOn), marsAgentVersion.Value, Optional.ToNullable(marsAgentExpireOn), agentVersionDetails.Value, marsAgentVersionDetails.Value);
        }
    }
}
