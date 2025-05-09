// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Parameters for updating an Storage sync service. </summary>
    public partial class StorageSyncServicePatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageSyncServicePatch"/>. </summary>
        public StorageSyncServicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServicePatch"/>. </summary>
        /// <param name="tags"> The user-specified tags associated with the storage sync service. </param>
        /// <param name="identity"> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </param>
        /// <param name="incomingTrafficPolicy"> Incoming Traffic Policy. </param>
        /// <param name="useIdentity"> Use Identity authorization when customer have finished setup RBAC permissions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageSyncServicePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, IncomingTrafficPolicy? incomingTrafficPolicy, bool? useIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            IncomingTrafficPolicy = incomingTrafficPolicy;
            UseIdentity = useIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user-specified tags associated with the storage sync service. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> managed identities for the Container App to interact with other Azure services without maintaining any secrets or credentials in code. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Incoming Traffic Policy. </summary>
        public IncomingTrafficPolicy? IncomingTrafficPolicy { get; set; }
        /// <summary> Use Identity authorization when customer have finished setup RBAC permissions. </summary>
        public bool? UseIdentity { get; set; }
    }
}
