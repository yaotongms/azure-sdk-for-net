// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerDatabaseReplicationLinkResource : IJsonModel<SqlServerDatabaseReplicationLinkData>
    {
        void IJsonModel<SqlServerDatabaseReplicationLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDatabaseReplicationLinkData>)Data).Write(writer, options);

        SqlServerDatabaseReplicationLinkData IJsonModel<SqlServerDatabaseReplicationLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerDatabaseReplicationLinkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SqlServerDatabaseReplicationLinkData>(Data, options, AzureResourceManagerSqlContext.Default);

        SqlServerDatabaseReplicationLinkData IPersistableModel<SqlServerDatabaseReplicationLinkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerDatabaseReplicationLinkData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<SqlServerDatabaseReplicationLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerDatabaseReplicationLinkData>)Data).GetFormatFromOptions(options);
    }
}
