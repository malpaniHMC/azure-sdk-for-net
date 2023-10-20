// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class RuleEngineWorkerSelectorAttachment
    {
        internal static RuleEngineWorkerSelectorAttachment DeserializeRuleEngineWorkerSelectorAttachment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule rule = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rule"u8))
                {
                    rule = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new RuleEngineWorkerSelectorAttachment(kind, rule);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RuleEngineWorkerSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRuleEngineWorkerSelectorAttachment(document.RootElement);
        }
    }
}
