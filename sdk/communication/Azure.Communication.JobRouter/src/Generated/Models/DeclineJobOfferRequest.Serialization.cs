// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class DeclineJobOfferRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RetryOfferAt))
            {
                writer.WritePropertyName("retryOfferAt"u8);
                writer.WriteStringValue(RetryOfferAt.Value, "O");
            }
            writer.WriteEndObject();
        }
    }
}
