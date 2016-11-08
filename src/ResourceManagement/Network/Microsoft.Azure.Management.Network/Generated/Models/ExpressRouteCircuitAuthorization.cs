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
    /// Authorization in a ExpressRouteCircuit resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitAuthorization : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitAuthorization
        /// class.
        /// </summary>
        public ExpressRouteCircuitAuthorization() { }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitAuthorization
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="authorizationKey">Gets or sets the authorization
        /// key</param>
        /// <param name="authorizationUseStatus">Gets or sets
        /// AuthorizationUseStatus. Possible values include: 'Available',
        /// 'InUse'</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public ExpressRouteCircuitAuthorization(string id = default(string), string authorizationKey = default(string), string authorizationUseStatus = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            AuthorizationKey = authorizationKey;
            AuthorizationUseStatus = authorizationUseStatus;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets the authorization key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationUseStatus. Possible values include:
        /// 'Available', 'InUse'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.authorizationUseStatus")]
        public string AuthorizationUseStatus { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
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
