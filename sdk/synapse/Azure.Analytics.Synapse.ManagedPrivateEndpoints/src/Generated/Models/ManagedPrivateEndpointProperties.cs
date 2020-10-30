// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models
{
    /// <summary> Properties of a managed private endpoint. </summary>
    public partial class ManagedPrivateEndpointProperties
    {
        /// <summary> Initializes a new instance of ManagedPrivateEndpointProperties. </summary>
        public ManagedPrivateEndpointProperties()
        {
        }

        /// <summary> Initializes a new instance of ManagedPrivateEndpointProperties. </summary>
        /// <param name="privateLinkResourceId"> The ARM resource ID of the resource to which the managed private endpoint is created. </param>
        /// <param name="groupId"> The groupId to which the managed private endpoint is created. </param>
        /// <param name="provisioningState"> The managed private endpoint provisioning state. </param>
        /// <param name="connectionState"> The managed private endpoint connection state. </param>
        /// <param name="isReserved"> Denotes whether the managed private endpoint is reserved. </param>
        internal ManagedPrivateEndpointProperties(string privateLinkResourceId, string groupId, string provisioningState, ManagedPrivateEndpointConnectionState connectionState, bool? isReserved)
        {
            PrivateLinkResourceId = privateLinkResourceId;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            ConnectionState = connectionState;
            IsReserved = isReserved;
        }

        /// <summary> The ARM resource ID of the resource to which the managed private endpoint is created. </summary>
        public string PrivateLinkResourceId { get; set; }
        /// <summary> The groupId to which the managed private endpoint is created. </summary>
        public string GroupId { get; set; }
        /// <summary> The managed private endpoint provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> The managed private endpoint connection state. </summary>
        public ManagedPrivateEndpointConnectionState ConnectionState { get; set; }
        /// <summary> Denotes whether the managed private endpoint is reserved. </summary>
        public bool? IsReserved { get; }
    }
}