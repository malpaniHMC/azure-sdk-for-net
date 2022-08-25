// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SourceShareSynchronizationSetting
    {
        internal static SourceShareSynchronizationSetting DeserializeSourceShareSynchronizationSetting(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ScheduleBased": return ScheduledSourceSynchronizationSetting.DeserializeScheduledSourceSynchronizationSetting(element);
                }
            }
            SourceShareSynchronizationSettingKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new SourceShareSynchronizationSettingKind(property.Value.GetString());
                    continue;
                }
            }
            return new SourceShareSynchronizationSetting(kind);
        }
    }
}
