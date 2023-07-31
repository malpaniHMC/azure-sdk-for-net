// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class KubernetesClusterNode
    {
        internal static KubernetesClusterNode DeserializeKubernetesClusterNode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentPoolId = default;
            Optional<string> availabilityZone = default;
            Optional<string> bareMetalMachineId = default;
            Optional<long> cpuCores = default;
            Optional<KubernetesClusterNodeDetailedStatus> detailedStatus = default;
            Optional<string> detailedStatusMessage = default;
            Optional<long> diskSizeGB = default;
            Optional<string> image = default;
            Optional<string> kubernetesVersion = default;
            Optional<IReadOnlyList<KubernetesLabel>> labels = default;
            Optional<long> memorySizeGB = default;
            Optional<NetworkCloudAgentPoolMode> mode = default;
            Optional<string> name = default;
            Optional<IReadOnlyList<NetworkAttachment>> networkAttachments = default;
            Optional<KubernetesNodePowerState> powerState = default;
            Optional<KubernetesNodeRole> role = default;
            Optional<IReadOnlyList<KubernetesLabel>> taints = default;
            Optional<string> vmSkuName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentPoolId"u8))
                {
                    agentPoolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availabilityZone"u8))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bareMetalMachineId"u8))
                {
                    bareMetalMachineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCores = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("detailedStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detailedStatus = new KubernetesClusterNodeDetailedStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("detailedStatusMessage"u8))
                {
                    detailedStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("memorySizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memorySizeGB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new NetworkCloudAgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkAttachments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkAttachment> array = new List<NetworkAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkAttachment.DeserializeNetworkAttachment(item));
                    }
                    networkAttachments = array;
                    continue;
                }
                if (property.NameEquals("powerState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    powerState = new KubernetesNodePowerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new KubernetesNodeRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item));
                    }
                    taints = array;
                    continue;
                }
                if (property.NameEquals("vmSkuName"u8))
                {
                    vmSkuName = property.Value.GetString();
                    continue;
                }
            }
            return new KubernetesClusterNode(agentPoolId.Value, availabilityZone.Value, bareMetalMachineId.Value, Optional.ToNullable(cpuCores), Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, Optional.ToNullable(diskSizeGB), image.Value, kubernetesVersion.Value, Optional.ToList(labels), Optional.ToNullable(memorySizeGB), Optional.ToNullable(mode), name.Value, Optional.ToList(networkAttachments), Optional.ToNullable(powerState), Optional.ToNullable(role), Optional.ToList(taints), vmSkuName.Value);
        }
    }
}
