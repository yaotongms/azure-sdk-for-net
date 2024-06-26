// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// Patching mode enum
    /// Serialized Name: PatchingMode
    /// </summary>
    public readonly partial struct PatchingMode : IEquatable<PatchingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PatchingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PatchingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RollingValue = "Rolling";
        private const string NonRollingValue = "NonRolling";

        /// <summary>
        /// Rolling patching
        /// Serialized Name: PatchingMode.Rolling
        /// </summary>
        public static PatchingMode Rolling { get; } = new PatchingMode(RollingValue);
        /// <summary>
        /// Non Rolling patching
        /// Serialized Name: PatchingMode.NonRolling
        /// </summary>
        public static PatchingMode NonRolling { get; } = new PatchingMode(NonRollingValue);
        /// <summary> Determines if two <see cref="PatchingMode"/> values are the same. </summary>
        public static bool operator ==(PatchingMode left, PatchingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PatchingMode"/> values are not the same. </summary>
        public static bool operator !=(PatchingMode left, PatchingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PatchingMode"/>. </summary>
        public static implicit operator PatchingMode(string value) => new PatchingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PatchingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PatchingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
