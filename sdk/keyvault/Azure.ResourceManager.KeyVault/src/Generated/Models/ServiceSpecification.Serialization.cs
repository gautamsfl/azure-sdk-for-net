// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ServiceSpecification
    {
        internal static ServiceSpecification DeserializeServiceSpecification(JsonElement element)
        {
            IReadOnlyList<LogSpecification> logSpecifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logSpecifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogSpecification> array = new List<LogSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LogSpecification.DeserializeLogSpecification(item));
                        }
                    }
                    logSpecifications = array;
                    continue;
                }
            }
            return new ServiceSpecification(logSpecifications);
        }
    }
}
