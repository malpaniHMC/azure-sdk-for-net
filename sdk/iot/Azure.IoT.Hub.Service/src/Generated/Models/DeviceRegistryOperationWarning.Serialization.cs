// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DeviceRegistryOperationWarning
    {
        internal static DeviceRegistryOperationWarning DeserializeDeviceRegistryOperationWarning(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<DeviceRegistryOperationWarningCode> warningCode = default;
            Optional<string> warningStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warningCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCode = new DeviceRegistryOperationWarningCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("warningStatus"u8))
                {
                    warningStatus = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceRegistryOperationWarning(deviceId.Value, Optional.ToNullable(warningCode), warningStatus.Value);
        }
    }
}
