// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    internal partial class EventRouteCollection
    {
        internal static EventRouteCollection DeserializeEventRouteCollection(JsonElement element)
        {
            Optional<IReadOnlyList<EventRoute>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<EventRoute> array = new List<EventRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventRoute.DeserializeEventRoute(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EventRouteCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
