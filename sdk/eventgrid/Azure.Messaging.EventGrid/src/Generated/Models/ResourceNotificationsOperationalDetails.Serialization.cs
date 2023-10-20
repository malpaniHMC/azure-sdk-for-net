// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceNotificationsOperationalDetails
    {
        internal static ResourceNotificationsOperationalDetails DeserializeResourceNotificationsOperationalDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> resourceEventTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceEventTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceEventTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ResourceNotificationsOperationalDetails(Optional.ToNullable(resourceEventTime));
        }
    }
}
