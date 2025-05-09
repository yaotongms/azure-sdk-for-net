// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryTokenResource"/> and their operations.
    /// Each <see cref="ContainerRegistryTokenResource"/> in the collection will belong to the same instance of <see cref="ContainerRegistryResource"/>.
    /// To get a <see cref="ContainerRegistryTokenCollection"/> instance call the GetContainerRegistryTokens method from an instance of <see cref="ContainerRegistryResource"/>.
    /// </summary>
    public partial class ContainerRegistryTokenCollection : ArmCollection, IEnumerable<ContainerRegistryTokenResource>, IAsyncEnumerable<ContainerRegistryTokenResource>
    {
        private readonly ClientDiagnostics _containerRegistryTokenTokensClientDiagnostics;
        private readonly TokensRestOperations _containerRegistryTokenTokensRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTokenCollection"/> class for mocking. </summary>
        protected ContainerRegistryTokenCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryTokenCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerRegistryTokenCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerRegistryTokenTokensClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryTokenResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryTokenResource.ResourceType, out string containerRegistryTokenTokensApiVersion);
            _containerRegistryTokenTokensRestClient = new TokensRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryTokenTokensApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a token for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="data"> The parameters for creating a token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryTokenResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string tokenName, ContainerRegistryTokenData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryTokenTokensRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTokenResource>(new ContainerRegistryTokenOperationSource(Client), _containerRegistryTokenTokensClientDiagnostics, Pipeline, _containerRegistryTokenTokensRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a token for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="data"> The parameters for creating a token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryTokenResource> CreateOrUpdate(WaitUntil waitUntil, string tokenName, ContainerRegistryTokenData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryTokenTokensRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryTokenResource>(new ContainerRegistryTokenOperationSource(Client), _containerRegistryTokenTokensClientDiagnostics, Pipeline, _containerRegistryTokenTokensRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryTokenResource>> GetAsync(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryTokenTokensRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTokenResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified token.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual Response<ContainerRegistryTokenResource> Get(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryTokenTokensRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTokenResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the tokens for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryTokenResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryTokenResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTokenTokensRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTokenTokensRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryTokenResource(Client, ContainerRegistryTokenData.DeserializeContainerRegistryTokenData(e)), _containerRegistryTokenTokensClientDiagnostics, Pipeline, "ContainerRegistryTokenCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the tokens for the specified container registry.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryTokenResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryTokenResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryTokenTokensRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryTokenTokensRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryTokenResource(Client, ContainerRegistryTokenData.DeserializeContainerRegistryTokenData(e)), _containerRegistryTokenTokensClientDiagnostics, Pipeline, "ContainerRegistryTokenCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryTokenTokensRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual Response<bool> Exists(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryTokenTokensRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerRegistryTokenResource>> GetIfExistsAsync(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerRegistryTokenTokensRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryTokenResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTokenResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/tokens/{tokenName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tokens_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryTokenResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tokenName"> The name of the token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tokenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenName"/> is null. </exception>
        public virtual NullableResponse<ContainerRegistryTokenResource> GetIfExists(string tokenName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tokenName, nameof(tokenName));

            using var scope = _containerRegistryTokenTokensClientDiagnostics.CreateScope("ContainerRegistryTokenCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerRegistryTokenTokensRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tokenName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryTokenResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryTokenResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryTokenResource> IEnumerable<ContainerRegistryTokenResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryTokenResource> IAsyncEnumerable<ContainerRegistryTokenResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
