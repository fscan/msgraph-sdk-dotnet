// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type CallRoute.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class CallRoute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRoute"/> class.
        /// </summary>
        public CallRoute()
        {
            this.ODataType = "microsoft.graph.callRoute";
        }

        /// <summary>
        /// Gets or sets routingType.
        /// Possible values are: forwarded, lookup, selfFork.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routingType", Required = Newtonsoft.Json.Required.Default)]
        public RoutingType? RoutingType { get; set; }
    
        /// <summary>
        /// Gets or sets original.
        /// The identity that was originally used in the call.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "original", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Original { get; set; }
    
        /// <summary>
        /// Gets or sets final.
        /// The identity that was resolved to in the call.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "final", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Final { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
