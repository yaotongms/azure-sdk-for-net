// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricIPPrefixOperationSource : IOperationSource<NetworkFabricIPPrefixResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricIPPrefixOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricIPPrefixResource IOperationSource<NetworkFabricIPPrefixResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricIPPrefixData.DeserializeNetworkFabricIPPrefixData(document.RootElement);
            return new NetworkFabricIPPrefixResource(_client, data);
        }

        async ValueTask<NetworkFabricIPPrefixResource> IOperationSource<NetworkFabricIPPrefixResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricIPPrefixData.DeserializeNetworkFabricIPPrefixData(document.RootElement);
            return new NetworkFabricIPPrefixResource(_client, data);
        }
    }
}
