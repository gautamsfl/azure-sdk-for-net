// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DataFlowStagingInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (LinkedService != null)
            {
                writer.WritePropertyName("linkedService");
                writer.WriteObjectValue(LinkedService);
            }
            if (FolderPath != null)
            {
                writer.WritePropertyName("folderPath");
                writer.WriteStringValue(FolderPath);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowStagingInfo DeserializeDataFlowStagingInfo(JsonElement element)
        {
            LinkedServiceReference linkedService = default;
            string folderPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("folderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowStagingInfo(linkedService, folderPath);
        }
    }
}
