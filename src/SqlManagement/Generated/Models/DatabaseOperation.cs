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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Contains all the information pertaining to a database operation that
    /// transpired.
    /// </summary>
    public partial class DatabaseOperation : SqlModelCommon
    {
        private string _databaseName;
        
        /// <summary>
        /// Optional. Gets the name of the Azure SQL Database on which the
        /// operation is performed.
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private string _error;
        
        /// <summary>
        /// Optional. Gets the description of the error that occurred during a
        /// failed operation.
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }
        
        private int _errorCode;
        
        /// <summary>
        /// Optional. Gets the code indicating the error that occurred during a
        /// failed operation.
        /// </summary>
        public int ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }
        
        private int _errorSeverity;
        
        /// <summary>
        /// Optional. Gets the severity level of the error that occurred during
        /// a failed operation.
        /// </summary>
        public int ErrorSeverity
        {
            get { return this._errorSeverity; }
            set { this._errorSeverity = value; }
        }
        
        private int _errorState;
        
        /// <summary>
        /// Optional. Gets the error state of the operation.
        /// </summary>
        public int ErrorState
        {
            get { return this._errorState; }
            set { this._errorState = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Gets a unique identifier for this database operation.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private DateTime _lastModifyTime;
        
        /// <summary>
        /// Optional. Gets the timestamp when the record was last modified for
        /// a long running operation.
        /// </summary>
        public DateTime LastModifyTime
        {
            get { return this._lastModifyTime; }
            set { this._lastModifyTime = value; }
        }
        
        private int _percentComplete;
        
        /// <summary>
        /// Optional. Gets the percentage of the operation that has completed.
        /// </summary>
        public int PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }
        
        private string _sessionActivityId;
        
        /// <summary>
        /// Optional. Gets the unique Guid that identifies the session that
        /// this operation occured in. This is helpful if contacting support
        /// for an issue.
        /// </summary>
        public string SessionActivityId
        {
            get { return this._sessionActivityId; }
            set { this._sessionActivityId = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. Gets the timestamp when the operation started.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private int _stateId;
        
        /// <summary>
        /// Optional. Gets a unique identifier for the service activity
        /// representing the operation. This activity id can be provided to
        /// the service support for investigating an operation.
        /// </summary>
        public int StateId
        {
            get { return this._stateId; }
            set { this._stateId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseOperation class.
        /// </summary>
        public DatabaseOperation()
        {
        }
    }
}
