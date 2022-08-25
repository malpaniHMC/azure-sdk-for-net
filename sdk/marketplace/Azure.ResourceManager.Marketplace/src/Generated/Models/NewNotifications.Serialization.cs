// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class NewNotifications
    {
        internal static NewNotifications DeserializeNewNotifications(JsonElement element)
        {
            Optional<string> offerId = default;
            Optional<string> displayName = default;
            Optional<bool> isFuturePlansEnabled = default;
            Optional<long> messageCode = default;
            Optional<string> icon = default;
            Optional<IReadOnlyList<PlanNotificationDetails>> plans = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerId"))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isFuturePlansEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isFuturePlansEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("messageCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    messageCode = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("icon"))
                {
                    icon = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("plans"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PlanNotificationDetails> array = new List<PlanNotificationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlanNotificationDetails.DeserializePlanNotificationDetails(item));
                    }
                    plans = array;
                    continue;
                }
            }
            return new NewNotifications(offerId.Value, displayName.Value, Optional.ToNullable(isFuturePlansEnabled), Optional.ToNullable(messageCode), icon.Value, Optional.ToList(plans));
        }
    }
}
