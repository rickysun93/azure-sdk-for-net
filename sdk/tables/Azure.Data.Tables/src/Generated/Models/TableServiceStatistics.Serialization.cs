// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    public partial class TableServiceStatistics
    {
        internal static TableServiceStatistics DeserializeTableServiceStatistics(XElement element)
        {
            TableGeoReplication geoReplication = default;
            if (element.Element("GeoReplication") is XElement geoReplicationElement)
            {
                geoReplication = TableGeoReplication.DeserializeTableGeoReplication(geoReplicationElement);
            }
            return new TableServiceStatistics(geoReplication);
        }
    }
}
