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
    /// Extension methods for ExpressRouteCircuitPeeringsOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitPeeringsOperationsExtensions
    {
            /// <summary>
            /// The delete peering operation deletes the specified peering from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void Delete(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).DeleteAsync(resourceGroupName, circuitName, peeringName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete peering operation deletes the specified peering from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete peering operation deletes the specified peering from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void BeginDelete(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).BeginDeleteAsync(resourceGroupName, circuitName, peeringName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete peering operation deletes the specified peering from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The GET peering operation retrieves the specified authorization from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static ExpressRouteCircuitPeering Get(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).GetAsync(resourceGroupName, circuitName, peeringName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The GET peering operation retrieves the specified authorization from the
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ExpressRouteCircuitPeering> GetAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put Peering operation creates/updates an peering in the specified
            /// ExpressRouteCircuits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create/update ExpressRouteCircuit Peering
            /// operation
            /// </param>
            public static ExpressRouteCircuitPeering CreateOrUpdate(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).CreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, peeringParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put Peering operation creates/updates an peering in the specified
            /// ExpressRouteCircuits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create/update ExpressRouteCircuit Peering
            /// operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ExpressRouteCircuitPeering> CreateOrUpdateAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, peeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put Peering operation creates/updates an peering in the specified
            /// ExpressRouteCircuits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create/update ExpressRouteCircuit Peering
            /// operation
            /// </param>
            public static ExpressRouteCircuitPeering BeginCreateOrUpdate(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, circuitName, peeringName, peeringParameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put Peering operation creates/updates an peering in the specified
            /// ExpressRouteCircuits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='peeringParameters'>
            /// Parameters supplied to the create/update ExpressRouteCircuit Peering
            /// operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ExpressRouteCircuitPeering> BeginCreateOrUpdateAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, string peeringName, ExpressRouteCircuitPeering peeringParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, peeringParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List peering operation retrieves all the peerings in an
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ExpressRouteCircuitPeering> List(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).ListAsync(resourceGroupName, circuitName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List peering operation retrieves all the peerings in an
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ExpressRouteCircuitPeering>> ListAsync(this IExpressRouteCircuitPeeringsOperations operations, string resourceGroupName, string circuitName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, circuitName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List peering operation retrieves all the peerings in an
            /// ExpressRouteCircuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ExpressRouteCircuitPeering> ListNext(this IExpressRouteCircuitPeeringsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IExpressRouteCircuitPeeringsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List peering operation retrieves all the peerings in an
            /// ExpressRouteCircuit.
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
            public static async Task<Microsoft.Rest.Azure.IPage<ExpressRouteCircuitPeering>> ListNextAsync(this IExpressRouteCircuitPeeringsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
