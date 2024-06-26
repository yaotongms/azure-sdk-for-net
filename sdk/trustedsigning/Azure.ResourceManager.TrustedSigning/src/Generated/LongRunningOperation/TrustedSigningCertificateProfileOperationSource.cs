// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.TrustedSigning
{
    internal class TrustedSigningCertificateProfileOperationSource : IOperationSource<TrustedSigningCertificateProfileResource>
    {
        private readonly ArmClient _client;

        internal TrustedSigningCertificateProfileOperationSource(ArmClient client)
        {
            _client = client;
        }

        TrustedSigningCertificateProfileResource IOperationSource<TrustedSigningCertificateProfileResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = TrustedSigningCertificateProfileData.DeserializeTrustedSigningCertificateProfileData(document.RootElement);
            return new TrustedSigningCertificateProfileResource(_client, data);
        }

        async ValueTask<TrustedSigningCertificateProfileResource> IOperationSource<TrustedSigningCertificateProfileResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = TrustedSigningCertificateProfileData.DeserializeTrustedSigningCertificateProfileData(document.RootElement);
            return new TrustedSigningCertificateProfileResource(_client, data);
        }
    }
}
