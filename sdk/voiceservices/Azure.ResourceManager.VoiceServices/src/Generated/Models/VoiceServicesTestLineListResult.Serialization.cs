// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.VoiceServices;

namespace Azure.ResourceManager.VoiceServices.Models
{
    internal partial class VoiceServicesTestLineListResult
    {
        internal static VoiceServicesTestLineListResult DeserializeVoiceServicesTestLineListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<VoiceServicesTestLineData> value = default;
            Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<VoiceServicesTestLineData> array = new List<VoiceServicesTestLineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VoiceServicesTestLineData.DeserializeVoiceServicesTestLineData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new VoiceServicesTestLineListResult(value, nextLink.Value);
        }
    }
}
