// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The ServiceAccountThrottlingMatchPattern.
/// </summary>
public partial class ServiceAccountThrottlingMatchPattern : ProvisionableConstruct
{
    /// <summary>
    /// Gets the path.
    /// </summary>
    public BicepValue<string> Path { get => _path; }
    private readonly BicepValue<string> _path;

    /// <summary>
    /// Gets the method.
    /// </summary>
    public BicepValue<string> Method { get => _method; }
    private readonly BicepValue<string> _method;

    /// <summary>
    /// Creates a new ServiceAccountThrottlingMatchPattern.
    /// </summary>
    public ServiceAccountThrottlingMatchPattern()
    {
        _path = BicepValue<string>.DefineProperty(this, "Path", ["path"], isOutput: true);
        _method = BicepValue<string>.DefineProperty(this, "Method", ["method"], isOutput: true);
    }
}
