// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of virtual network gateway vpn client connection health.
    /// </summary>
    public partial class VpnClientConnectionHealthDetailListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VpnClientConnectionHealthDetailListResult class.
        /// </summary>
        public VpnClientConnectionHealthDetailListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VpnClientConnectionHealthDetailListResult class.
        /// </summary>
        /// <param name="value">List of vpn client connection health.</param>
        public VpnClientConnectionHealthDetailListResult(IList<VpnClientConnectionHealthDetail> value = default(IList<VpnClientConnectionHealthDetail>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of vpn client connection health.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<VpnClientConnectionHealthDetail> Value { get; set; }

    }
}