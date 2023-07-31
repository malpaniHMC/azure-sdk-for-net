// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackMobilityAgentDetails
    {
        internal static InMageRcmFailbackMobilityAgentDetails DeserializeInMageRcmFailbackMobilityAgentDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> version = default;
            Optional<string> latestVersion = default;
            Optional<string> driverVersion = default;
            Optional<string> latestUpgradableVersionWithoutReboot = default;
            Optional<DateTimeOffset> agentVersionExpireOn = default;
            Optional<DateTimeOffset> driverVersionExpireOn = default;
            Optional<DateTimeOffset> lastHeartbeatUtc = default;
            Optional<IReadOnlyList<AgentUpgradeBlockedReason>> reasonsBlockingUpgrade = default;
            Optional<string> isUpgradeable = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestVersion"u8))
                {
                    latestVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverVersion"u8))
                {
                    driverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestUpgradableVersionWithoutReboot"u8))
                {
                    latestUpgradableVersionWithoutReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("driverVersionExpiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driverVersionExpireOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastHeartbeatUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeatUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("reasonsBlockingUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgentUpgradeBlockedReason> array = new List<AgentUpgradeBlockedReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AgentUpgradeBlockedReason(item.GetString()));
                    }
                    reasonsBlockingUpgrade = array;
                    continue;
                }
                if (property.NameEquals("isUpgradeable"u8))
                {
                    isUpgradeable = property.Value.GetString();
                    continue;
                }
            }
            return new InMageRcmFailbackMobilityAgentDetails(version.Value, latestVersion.Value, driverVersion.Value, latestUpgradableVersionWithoutReboot.Value, Optional.ToNullable(agentVersionExpireOn), Optional.ToNullable(driverVersionExpireOn), Optional.ToNullable(lastHeartbeatUtc), Optional.ToList(reasonsBlockingUpgrade), isUpgradeable.Value);
        }
    }
}
