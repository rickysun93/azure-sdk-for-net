// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the information about the filters for the DataStore.
    /// </summary>
    public partial class DataStoreFilter
    {
        /// <summary>
        /// Initializes a new instance of the DataStoreFilter class.
        /// </summary>
        public DataStoreFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataStoreFilter class.
        /// </summary>
        /// <param name="dataStoreTypeId">The data store type id.</param>
        public DataStoreFilter(string dataStoreTypeId = default(string))
        {
            DataStoreTypeId = dataStoreTypeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data store type id.
        /// </summary>
        [JsonProperty(PropertyName = "dataStoreTypeId")]
        public string DataStoreTypeId { get; set; }

    }
}