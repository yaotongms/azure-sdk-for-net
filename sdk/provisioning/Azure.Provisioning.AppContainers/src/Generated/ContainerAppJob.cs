// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppJob.
/// </summary>
public partial class ContainerAppJob : ProvisionableResource
{
    /// <summary>
    /// Job Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Container Apps Job configuration properties.
    /// </summary>
    public BicepValue<ContainerAppJobConfiguration> Configuration { get => _configuration; set => _configuration.Assign(value); }
    private readonly BicepValue<ContainerAppJobConfiguration> _configuration;

    /// <summary>
    /// Resource ID of environment.
    /// </summary>
    public BicepValue<string> EnvironmentId { get => _environmentId; set => _environmentId.Assign(value); }
    private readonly BicepValue<string> _environmentId;

    /// <summary>
    /// Managed identities needed by a container app job to interact with other
    /// Azure services to not maintain any secrets or credentials in code.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; set => _identity.Assign(value); }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Container Apps job definition.
    /// </summary>
    public BicepValue<ContainerAppJobTemplate> Template { get => _template; set => _template.Assign(value); }
    private readonly BicepValue<ContainerAppJobTemplate> _template;

    /// <summary>
    /// Workload profile name to pin for container apps job execution.
    /// </summary>
    public BicepValue<string> WorkloadProfileName { get => _workloadProfileName; set => _workloadProfileName.Assign(value); }
    private readonly BicepValue<string> _workloadProfileName;

    /// <summary>
    /// The endpoint of the eventstream of the container apps job.
    /// </summary>
    public BicepValue<string> EventStreamEndpoint { get => _eventStreamEndpoint; }
    private readonly BicepValue<string> _eventStreamEndpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Outbound IP Addresses of a container apps job.
    /// </summary>
    public BicepList<string> OutboundIPAddresses { get => _outboundIPAddresses; }
    private readonly BicepList<string> _outboundIPAddresses;

    /// <summary>
    /// Provisioning state of the Container Apps Job.
    /// </summary>
    public BicepValue<ContainerAppJobProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerAppJobProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ContainerAppJob.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppJob resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppJob.</param>
    public ContainerAppJob(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.App/jobs", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _configuration = BicepValue<ContainerAppJobConfiguration>.DefineProperty(this, "Configuration", ["properties", "configuration"]);
        _environmentId = BicepValue<string>.DefineProperty(this, "EnvironmentId", ["properties", "environmentId"]);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _template = BicepValue<ContainerAppJobTemplate>.DefineProperty(this, "Template", ["properties", "template"]);
        _workloadProfileName = BicepValue<string>.DefineProperty(this, "WorkloadProfileName", ["properties", "workloadProfileName"]);
        _eventStreamEndpoint = BicepValue<string>.DefineProperty(this, "EventStreamEndpoint", ["properties", "eventStreamEndpoint"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _outboundIPAddresses = BicepList<string>.DefineProperty(this, "OutboundIPAddresses", ["properties", "outboundIpAddresses"], isOutput: true);
        _provisioningState = BicepValue<ContainerAppJobProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ContainerAppJob resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerAppJob.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ContainerAppJob resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ContainerAppJob.</param>
    /// <returns>The existing ContainerAppJob resource.</returns>
    public static ContainerAppJob FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
