// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Broker Protocol types. </summary>
    public readonly partial struct BrokerProtocolType : IEquatable<BrokerProtocolType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BrokerProtocolType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BrokerProtocolType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MqttValue = "Mqtt";
        private const string WebSocketsValue = "WebSockets";

        /// <summary> protocol broker. </summary>
        public static BrokerProtocolType Mqtt { get; } = new BrokerProtocolType(MqttValue);
        /// <summary> protocol websocket. </summary>
        public static BrokerProtocolType WebSockets { get; } = new BrokerProtocolType(WebSocketsValue);
        /// <summary> Determines if two <see cref="BrokerProtocolType"/> values are the same. </summary>
        public static bool operator ==(BrokerProtocolType left, BrokerProtocolType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BrokerProtocolType"/> values are not the same. </summary>
        public static bool operator !=(BrokerProtocolType left, BrokerProtocolType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BrokerProtocolType"/>. </summary>
        public static implicit operator BrokerProtocolType(string value) => new BrokerProtocolType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BrokerProtocolType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BrokerProtocolType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
