// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    public partial class CostManagementExportData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Optional.IsDefined(DeliveryInfo))
            {
                writer.WritePropertyName("deliveryInfo"u8);
                writer.WriteObjectValue(DeliveryInfo);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteObjectValue(Definition);
            }
            if (Optional.IsDefined(RunHistory))
            {
                writer.WritePropertyName("runHistory"u8);
                writer.WriteObjectValue(RunHistory);
            }
            if (Optional.IsDefined(PartitionData))
            {
                writer.WritePropertyName("partitionData"u8);
                writer.WriteBooleanValue(PartitionData.Value);
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
