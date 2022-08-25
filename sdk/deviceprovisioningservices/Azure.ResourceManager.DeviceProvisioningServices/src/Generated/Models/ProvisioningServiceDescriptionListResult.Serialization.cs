// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal partial class ProvisioningServiceDescriptionListResult
    {
        internal static ProvisioningServiceDescriptionListResult DeserializeProvisioningServiceDescriptionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ProvisioningServiceDescriptionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProvisioningServiceDescriptionData> array = new List<ProvisioningServiceDescriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProvisioningServiceDescriptionData.DeserializeProvisioningServiceDescriptionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisioningServiceDescriptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
