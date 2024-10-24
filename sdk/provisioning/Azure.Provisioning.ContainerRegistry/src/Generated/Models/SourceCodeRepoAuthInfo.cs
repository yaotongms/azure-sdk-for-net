// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The authorization properties for accessing the source code repository.
/// </summary>
public partial class SourceCodeRepoAuthInfo : ProvisionableConstruct
{
    /// <summary>
    /// The type of Auth token.
    /// </summary>
    public BicepValue<SourceCodeRepoAuthTokenType> TokenType { get => _tokenType; set => _tokenType.Assign(value); }
    private readonly BicepValue<SourceCodeRepoAuthTokenType> _tokenType;

    /// <summary>
    /// The access token used to access the source control provider.
    /// </summary>
    public BicepValue<string> Token { get => _token; set => _token.Assign(value); }
    private readonly BicepValue<string> _token;

    /// <summary>
    /// The refresh token used to refresh the access token.
    /// </summary>
    public BicepValue<string> RefreshToken { get => _refreshToken; set => _refreshToken.Assign(value); }
    private readonly BicepValue<string> _refreshToken;

    /// <summary>
    /// The scope of the access token.
    /// </summary>
    public BicepValue<string> Scope { get => _scope; set => _scope.Assign(value); }
    private readonly BicepValue<string> _scope;

    /// <summary>
    /// Time in seconds that the token remains valid.
    /// </summary>
    public BicepValue<int> ExpireInSeconds { get => _expireInSeconds; set => _expireInSeconds.Assign(value); }
    private readonly BicepValue<int> _expireInSeconds;

    /// <summary>
    /// Creates a new SourceCodeRepoAuthInfo.
    /// </summary>
    public SourceCodeRepoAuthInfo()
    {
        _tokenType = BicepValue<SourceCodeRepoAuthTokenType>.DefineProperty(this, "TokenType", ["tokenType"]);
        _token = BicepValue<string>.DefineProperty(this, "Token", ["token"]);
        _refreshToken = BicepValue<string>.DefineProperty(this, "RefreshToken", ["refreshToken"]);
        _scope = BicepValue<string>.DefineProperty(this, "Scope", ["scope"]);
        _expireInSeconds = BicepValue<int>.DefineProperty(this, "ExpireInSeconds", ["expiresIn"]);
    }
}
