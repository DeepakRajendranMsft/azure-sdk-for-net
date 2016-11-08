// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for PublicIPAddressesOperations.
    /// </summary>
    public static partial class PublicIPAddressesOperationsExtensions
    {
            /// <summary>
            /// The delete publicIpAddress operation deletes the specified publicIpAddress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            public static void Delete(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).DeleteAsync(resourceGroupName, publicIpAddressName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete publicIpAddress operation deletes the specified publicIpAddress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete publicIpAddress operation deletes the specified publicIpAddress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            public static void BeginDelete(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).BeginDeleteAsync(resourceGroupName, publicIpAddressName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete publicIpAddress operation deletes the specified publicIpAddress.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get publicIpAddress operation retrieves information about the
            /// specified pubicIpAddress
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            public static PublicIPAddress Get(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).GetAsync(resourceGroupName, publicIpAddressName, expand), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get publicIpAddress operation retrieves information about the
            /// specified pubicIpAddress
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the subnet.
            /// </param>
            /// <param name='expand'>
            /// expand references resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PublicIPAddress> GetAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put PublicIPAddress operation creates/updates a stable/dynamic
            /// PublicIP address
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the publicIpAddress.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update PublicIPAddress operation
            /// </param>
            public static PublicIPAddress CreateOrUpdate(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).CreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put PublicIPAddress operation creates/updates a stable/dynamic
            /// PublicIP address
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the publicIpAddress.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update PublicIPAddress operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PublicIPAddress> CreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put PublicIPAddress operation creates/updates a stable/dynamic
            /// PublicIP address
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the publicIpAddress.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update PublicIPAddress operation
            /// </param>
            public static PublicIPAddress BeginCreateOrUpdate(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put PublicIPAddress operation creates/updates a stable/dynamic
            /// PublicIP address
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='publicIpAddressName'>
            /// The name of the publicIpAddress.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update PublicIPAddress operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PublicIPAddress> BeginCreateOrUpdateAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, publicIpAddressName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PublicIPAddress> ListAll(this IPublicIPAddressesOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAllAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PublicIPAddress>> ListAllAsync(this IPublicIPAddressesOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PublicIPAddress> List(this IPublicIPAddressesOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PublicIPAddress>> ListAsync(this IPublicIPAddressesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PublicIPAddress> ListAllNext(this IPublicIPAddressesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListAllNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PublicIPAddress>> ListAllNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PublicIPAddress> ListNext(this IPublicIPAddressesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPublicIPAddressesOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List publicIpAddress operation retrieves all the publicIpAddresses in
            /// a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PublicIPAddress>> ListNextAsync(this IPublicIPAddressesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
