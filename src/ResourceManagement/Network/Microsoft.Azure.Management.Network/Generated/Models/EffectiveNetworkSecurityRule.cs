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
    /// Effective NetworkSecurityRules
    /// </summary>
    public partial class EffectiveNetworkSecurityRule
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        public EffectiveNetworkSecurityRule() { }

        /// <summary>
        /// Initializes a new instance of the EffectiveNetworkSecurityRule
        /// class.
        /// </summary>
        /// <param name="name">Gets the name of the security rule specified by
        /// the user (if created by the user)</param>
        /// <param name="protocol">Gets Network protocol this rule applies to.
        /// Possible values include: 'Tcp', 'Udp', '*'</param>
        /// <param name="sourcePortRange">Gets source port or range</param>
        /// <param name="destinationPortRange">Gets destination port or
        /// range</param>
        /// <param name="sourceAddressPrefix">Gets source address
        /// prefix</param>
        /// <param name="destinationAddressPrefix">Gets destination address
        /// prefix</param>
        /// <param name="expandedSourceAddressPrefix">Gets expanded source
        /// address prefix</param>
        /// <param name="expandedDestinationAddressPrefix">Gets expanded
        /// destination address prefix</param>
        /// <param name="access">Gets network traffic is allowed or denied.
        /// Possible values include: 'Allow', 'Deny'</param>
        /// <param name="priority">Gets the priority of the rule</param>
        /// <param name="direction">Gets the direction of the rule. Possible
        /// values include: 'Inbound', 'Outbound'</param>
        public EffectiveNetworkSecurityRule(string name = default(string), string protocol = default(string), string sourcePortRange = default(string), string destinationPortRange = default(string), string sourceAddressPrefix = default(string), string destinationAddressPrefix = default(string), System.Collections.Generic.IList<string> expandedSourceAddressPrefix = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> expandedDestinationAddressPrefix = default(System.Collections.Generic.IList<string>), string access = default(string), int? priority = default(int?), string direction = default(string))
        {
            Name = name;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            DestinationAddressPrefix = destinationAddressPrefix;
            ExpandedSourceAddressPrefix = expandedSourceAddressPrefix;
            ExpandedDestinationAddressPrefix = expandedDestinationAddressPrefix;
            Access = access;
            Priority = priority;
            Direction = direction;
        }

        /// <summary>
        /// Gets the name of the security rule specified by the user (if
        /// created by the user)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets Network protocol this rule applies to. Possible values
        /// include: 'Tcp', 'Udp', '*'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets source port or range
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourcePortRange")]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// Gets destination port or range
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinationPortRange")]
        public string DestinationPortRange { get; set; }

        /// <summary>
        /// Gets source address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets destination address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinationAddressPrefix")]
        public string DestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets expanded source address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expandedSourceAddressPrefix")]
        public System.Collections.Generic.IList<string> ExpandedSourceAddressPrefix { get; set; }

        /// <summary>
        /// Gets expanded destination address prefix
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expandedDestinationAddressPrefix")]
        public System.Collections.Generic.IList<string> ExpandedDestinationAddressPrefix { get; set; }

        /// <summary>
        /// Gets network traffic is allowed or denied. Possible values
        /// include: 'Allow', 'Deny'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "access")]
        public string Access { get; set; }

        /// <summary>
        /// Gets the priority of the rule
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets the direction of the rule. Possible values include:
        /// 'Inbound', 'Outbound'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

    }
}
