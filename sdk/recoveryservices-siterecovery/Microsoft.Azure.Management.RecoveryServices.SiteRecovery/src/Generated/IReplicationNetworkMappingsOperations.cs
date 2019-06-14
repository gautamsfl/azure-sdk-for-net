// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReplicationNetworkMappingsOperations operations.
    /// </summary>
    public partial interface IReplicationNetworkMappingsOperations
    {
        /// <summary>
        /// Gets all the network mappings under a network.
        /// </summary>
        /// <remarks>
        /// Lists all ASR network mappings for the specified network.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NetworkMapping>>> ListByReplicationNetworksWithHttpMessagesAsync(string fabricName, string networkName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets network mapping by name.
        /// </summary>
        /// <remarks>
        /// Gets the details of an ASR network mapping
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// Network mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NetworkMapping>> GetWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to create an ASR network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// Network mapping name.
        /// </param>
        /// <param name='input'>
        /// Create network mapping input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NetworkMapping>> CreateWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to delete a network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// ARM Resource Name for network mapping.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to update an ASR network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// Network mapping name.
        /// </param>
        /// <param name='input'>
        /// Update network mapping input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NetworkMapping>> UpdateWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, UpdateNetworkMappingInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the network mappings under a vault.
        /// </summary>
        /// <remarks>
        /// Lists all ASR network mappings in the vault.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NetworkMapping>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to create an ASR network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// Network mapping name.
        /// </param>
        /// <param name='input'>
        /// Create network mapping input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NetworkMapping>> BeginCreateWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, CreateNetworkMappingInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to delete a network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// ARM Resource Name for network mapping.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates network mapping.
        /// </summary>
        /// <remarks>
        /// The operation to update an ASR network mapping.
        /// </remarks>
        /// <param name='fabricName'>
        /// Primary fabric name.
        /// </param>
        /// <param name='networkName'>
        /// Primary network name.
        /// </param>
        /// <param name='networkMappingName'>
        /// Network mapping name.
        /// </param>
        /// <param name='input'>
        /// Update network mapping input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NetworkMapping>> BeginUpdateWithHttpMessagesAsync(string fabricName, string networkName, string networkMappingName, UpdateNetworkMappingInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the network mappings under a network.
        /// </summary>
        /// <remarks>
        /// Lists all ASR network mappings for the specified network.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NetworkMapping>>> ListByReplicationNetworksNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the network mappings under a vault.
        /// </summary>
        /// <remarks>
        /// Lists all ASR network mappings in the vault.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<NetworkMapping>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}