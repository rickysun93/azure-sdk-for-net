// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The ConfigurationQueriesTestInput. </summary>
    public partial class ConfigurationQueriesTestInput
    {
        /// <summary> Initializes a new instance of ConfigurationQueriesTestInput. </summary>
        public ConfigurationQueriesTestInput()
        {
            CustomMetricQueries = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The query used to define targeted devices or modules. The query is based on twin tags and/or reported properties. </summary>
        public string TargetCondition { get; set; }
        /// <summary> The key-value pairs with queries and their identifier. </summary>
        public IDictionary<string, string> CustomMetricQueries { get; }
    }
}
