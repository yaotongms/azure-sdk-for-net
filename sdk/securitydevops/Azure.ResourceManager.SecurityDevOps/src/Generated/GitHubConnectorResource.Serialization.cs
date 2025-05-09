// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityDevOps
{
    public partial class GitHubConnectorResource : IJsonModel<GitHubConnectorData>
    {
        void IJsonModel<GitHubConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GitHubConnectorData>)Data).Write(writer, options);

        GitHubConnectorData IJsonModel<GitHubConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GitHubConnectorData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GitHubConnectorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GitHubConnectorData>(Data, options, AzureResourceManagerSecurityDevOpsContext.Default);

        GitHubConnectorData IPersistableModel<GitHubConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GitHubConnectorData>(data, options, AzureResourceManagerSecurityDevOpsContext.Default);

        string IPersistableModel<GitHubConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GitHubConnectorData>)Data).GetFormatFromOptions(options);
    }
}
