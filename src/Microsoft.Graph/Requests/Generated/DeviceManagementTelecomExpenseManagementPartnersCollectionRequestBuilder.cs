// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementTelecomExpenseManagementPartnersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementTelecomExpenseManagementPartnersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITelecomExpenseManagementPartnerRequestBuilder"/> for the specified DeviceManagementTelecomExpenseManagementPartner.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementTelecomExpenseManagementPartner.</param>
        /// <returns>The <see cref="ITelecomExpenseManagementPartnerRequestBuilder"/>.</returns>
        public ITelecomExpenseManagementPartnerRequestBuilder this[string id]
        {
            get
            {
                return new TelecomExpenseManagementPartnerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
