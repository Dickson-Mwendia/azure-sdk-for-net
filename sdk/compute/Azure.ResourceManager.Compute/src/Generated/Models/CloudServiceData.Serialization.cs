// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class CloudServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WriteEndObject();
        }

        internal static CloudServiceData DeserializeCloudServiceData(JsonElement element)
        {
            Optional<CloudServiceProperties> properties = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = CloudServiceProperties.DeserializeCloudServiceProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new CloudServiceData(id, name, type, tags, location, properties.Value);
        }
    }
}
