// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents.Persistent;

[CodeGenSerialization(nameof(ExpiredAt), DeserializationValueHook = nameof(DeserializeNullableDateTimeOffset))]
[CodeGenSerialization(nameof(CompletedAt), DeserializationValueHook = nameof(DeserializeNullableDateTimeOffset))]
[CodeGenSerialization(nameof(CancelledAt), DeserializationValueHook = nameof(DeserializeNullableDateTimeOffset))]
[CodeGenSerialization(nameof(FailedAt), DeserializationValueHook = nameof(DeserializeNullableDateTimeOffset))]
public partial class RunStep
{
    /*
    * CUSTOM CODE DESCRIPTION:
    *
    * This change allows us to complete the customization of hiding an unnecessary "Object" discriminator.
    */
    internal string Object { get; }

    /*
     * CUSTOM CODE DESCRIPTION:
     *
     * "Required but nullable" utcDateTime doesn't emit the appropriate deserialization logic by default.
     *
     */

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void DeserializeNullableDateTimeOffset(
        JsonProperty property,
        ref DateTimeOffset? targetDateTimeOffset)
        => CustomSerializationHelpers.DeserializeNullableDateTimeOffset(property, ref targetDateTimeOffset);
}
