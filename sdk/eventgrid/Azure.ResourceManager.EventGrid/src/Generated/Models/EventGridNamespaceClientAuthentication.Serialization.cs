// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridNamespaceClientAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateThumbprint))
            {
                writer.WritePropertyName("certificateThumbprint"u8);
                writer.WriteObjectValue(CertificateThumbprint);
            }
            if (Optional.IsDefined(CertificateSubject))
            {
                writer.WritePropertyName("certificateSubject"u8);
                writer.WriteObjectValue(CertificateSubject);
            }
            writer.WriteEndObject();
        }

        internal static EventGridNamespaceClientAuthentication DeserializeEventGridNamespaceClientAuthentication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ClientCertificateThumbprint> certificateThumbprint = default;
            Optional<ClientCertificateSubjectDistinguishedName> certificateSubject = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateThumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateThumbprint = ClientCertificateThumbprint.DeserializeClientCertificateThumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateSubject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificateSubject = ClientCertificateSubjectDistinguishedName.DeserializeClientCertificateSubjectDistinguishedName(property.Value);
                    continue;
                }
            }
            return new EventGridNamespaceClientAuthentication(certificateThumbprint.Value, certificateSubject.Value);
        }
    }
}
