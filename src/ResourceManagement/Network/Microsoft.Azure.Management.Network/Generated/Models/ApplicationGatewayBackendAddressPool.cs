// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Backend Address Pool of application gateway
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayBackendAddressPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendAddressPool class.
        /// </summary>
        public ApplicationGatewayBackendAddressPool() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendAddressPool class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="backendIPConfigurations">Collection of references to
        /// IPs defined in NICs</param>
        /// <param name="backendAddresses">Backend addresses</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// address pool resource Updating/Deleting/Failed</param>
        /// <param name="name">Resource that is unique within a resource
        /// group. This name can be used to access the resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ApplicationGatewayBackendAddressPool(string id = default(string), System.Collections.Generic.IList<NetworkInterfaceIPConfiguration> backendIPConfigurations = default(System.Collections.Generic.IList<NetworkInterfaceIPConfiguration>), System.Collections.Generic.IList<ApplicationGatewayBackendAddress> backendAddresses = default(System.Collections.Generic.IList<ApplicationGatewayBackendAddress>), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            BackendIPConfigurations = backendIPConfigurations;
            BackendAddresses = backendAddresses;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets collection of references to IPs defined in NICs
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendIPConfigurations")]
        public System.Collections.Generic.IList<NetworkInterfaceIPConfiguration> BackendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets backend addresses
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendAddresses")]
        public System.Collections.Generic.IList<ApplicationGatewayBackendAddress> BackendAddresses { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend address pool
        /// resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets resource that is unique within a resource group. This
        /// name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
