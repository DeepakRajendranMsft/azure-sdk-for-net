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
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the runbook version type.
    /// </summary>
    public partial class RunbookVersion
    {
        private string _accountId;
        
        /// <summary>
        /// Optional. The account ID.
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        
        private DateTime _creationTime;
        
        /// <summary>
        /// Optional. The creation time of the runbook version.
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The runbook version ID.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private bool _isDraft;
        
        /// <summary>
        /// Optional. True or false, to indicate whether the runbook version is
        /// draft or not.
        /// </summary>
        public bool IsDraft
        {
            get { return this._isDraft; }
            set { this._isDraft = value; }
        }
        
        private DateTime _lastModifiedTime;
        
        /// <summary>
        /// Optional. The last modified time of the runbook version.
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private Runbook _runbook;
        
        /// <summary>
        /// Optional. The runbook of the runbook version.
        /// </summary>
        public Runbook Runbook
        {
            get { return this._runbook; }
            set { this._runbook = value; }
        }
        
        private string _runbookId;
        
        /// <summary>
        /// Optional. The runbook ID.
        /// </summary>
        public string RunbookId
        {
            get { return this._runbookId; }
            set { this._runbookId = value; }
        }
        
        private int _versionNumber;
        
        /// <summary>
        /// Optional. The version number of the runbook version.
        /// </summary>
        public int VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RunbookVersion class.
        /// </summary>
        public RunbookVersion()
        {
        }
    }
}
