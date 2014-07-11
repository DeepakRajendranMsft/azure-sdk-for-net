// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// The response to the request for a listing of namespaces.
    /// </summary>
    public partial class ServiceBusNamespacesResponse : OperationResponse, IEnumerable<ServiceBusNamespace>
    {
        private IList<ServiceBusNamespace> _namespaces;
        
        /// <summary>
        /// Optional. The list of namespaces.
        /// </summary>
        public IList<ServiceBusNamespace> Namespaces
        {
            get { return this._namespaces; }
            set { this._namespaces = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceBusNamespacesResponse
        /// class.
        /// </summary>
        public ServiceBusNamespacesResponse()
        {
            this.Namespaces = new List<ServiceBusNamespace>();
        }
        
        /// <summary>
        /// Gets the sequence of Namespaces.
        /// </summary>
        public IEnumerator<ServiceBusNamespace> GetEnumerator()
        {
            return this.Namespaces.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Namespaces.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
