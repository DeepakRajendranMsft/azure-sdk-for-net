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
using Microsoft.Azure.Management.Sql.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the response to a Get Database request.
    /// </summary>
    public partial class ServerListResponse : OperationResponse, IEnumerable<Server>
    {
        private IList<Server> _servers;
        
        /// <summary>
        /// Optional. Gets or sets the list of Azure Sql Database servers.
        /// </summary>
        public IList<Server> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServerListResponse class.
        /// </summary>
        public ServerListResponse()
        {
            this._servers = new List<Server>();
        }
        
        /// <summary>
        /// Gets the sequence of Servers.
        /// </summary>
        public IEnumerator<Server> GetEnumerator()
        {
            return this.Servers.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Servers.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
