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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// This is the main client class for interacting with the Azure SQL
    /// Database REST APIs.
    /// </summary>
    public static partial class RecoverableDatabaseOperationsExtensions
    {
        /// <summary>
        /// Returns information about a recoverable Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IRecoverableDatabaseOperations.
        /// </param>
        /// <param name='targetServerName'>
        /// Required. The name of the Azure SQL Database Server on which to
        /// recover the source database.
        /// </param>
        /// <param name='sourceServerName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database was hosted.
        /// </param>
        /// <param name='sourceDatabaseName'>
        /// Required. The name of the recoverable Azure SQL Database to be
        /// obtained.
        /// </param>
        /// <returns>
        /// Contains the response to the Get Recoverable Database request.
        /// </returns>
        public static RecoverableDatabaseGetResponse Get(this IRecoverableDatabaseOperations operations, string targetServerName, string sourceServerName, string sourceDatabaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoverableDatabaseOperations)s).GetAsync(targetServerName, sourceServerName, sourceDatabaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about a recoverable Azure SQL Database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IRecoverableDatabaseOperations.
        /// </param>
        /// <param name='targetServerName'>
        /// Required. The name of the Azure SQL Database Server on which to
        /// recover the source database.
        /// </param>
        /// <param name='sourceServerName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database was hosted.
        /// </param>
        /// <param name='sourceDatabaseName'>
        /// Required. The name of the recoverable Azure SQL Database to be
        /// obtained.
        /// </param>
        /// <returns>
        /// Contains the response to the Get Recoverable Database request.
        /// </returns>
        public static Task<RecoverableDatabaseGetResponse> GetAsync(this IRecoverableDatabaseOperations operations, string targetServerName, string sourceServerName, string sourceDatabaseName)
        {
            return operations.GetAsync(targetServerName, sourceServerName, sourceDatabaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns a collection of databases that can be recovered from a
        /// specified server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IRecoverableDatabaseOperations.
        /// </param>
        /// <param name='targetServerName'>
        /// Required. The name of the Azure SQL Database Server on which to
        /// recover the source database.
        /// </param>
        /// <param name='sourceServerName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// databases were hosted.
        /// </param>
        /// <returns>
        /// Contains the response to the List Recoverable Databases request.
        /// </returns>
        public static RecoverableDatabaseListResponse List(this IRecoverableDatabaseOperations operations, string targetServerName, string sourceServerName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoverableDatabaseOperations)s).ListAsync(targetServerName, sourceServerName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns a collection of databases that can be recovered from a
        /// specified server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IRecoverableDatabaseOperations.
        /// </param>
        /// <param name='targetServerName'>
        /// Required. The name of the Azure SQL Database Server on which to
        /// recover the source database.
        /// </param>
        /// <param name='sourceServerName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// databases were hosted.
        /// </param>
        /// <returns>
        /// Contains the response to the List Recoverable Databases request.
        /// </returns>
        public static Task<RecoverableDatabaseListResponse> ListAsync(this IRecoverableDatabaseOperations operations, string targetServerName, string sourceServerName)
        {
            return operations.ListAsync(targetServerName, sourceServerName, CancellationToken.None);
        }
    }
}
