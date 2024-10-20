// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.Net;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Message envelope that contains the common Azure resource manager properties
/// and the resource provider specific content.
/// </summary>
public partial class ResponseMessageEnvelopeRemotePrivateEndpointConnection : ProvisionableConstruct
{
    /// <summary>
    /// Azure-AsyncOperation Error info.
    /// </summary>
    public BicepValue<ResponseError> Error { get => _error; }
    private readonly BicepValue<ResponseError> _error;

    /// <summary>
    /// Geographical region resource belongs to e.g. SouthCentralUS,
    /// SouthEastAsia.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Tags associated with resource.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Azure resource manager plan.
    /// </summary>
    public BicepValue<AppServiceArmPlan> Plan { get => _plan; }
    private readonly BicepValue<AppServiceArmPlan> _plan;

    /// <summary>
    /// Resource specific properties.
    /// </summary>
    public BicepValue<RemotePrivateEndpointConnection> Properties { get => _properties; }
    private readonly BicepValue<RemotePrivateEndpointConnection> _properties;

    /// <summary>
    /// SKU description of the resource.
    /// </summary>
    public BicepValue<AppServiceSkuDescription> Sku { get => _sku; }
    private readonly BicepValue<AppServiceSkuDescription> _sku;

    /// <summary>
    /// Azure-AsyncOperation Status info.
    /// </summary>
    public BicepValue<string> Status { get => _status; }
    private readonly BicepValue<string> _status;

    /// <summary>
    /// MSI resource.
    /// </summary>
    public BicepValue<ManagedServiceIdentity> Identity { get => _identity; }
    private readonly BicepValue<ManagedServiceIdentity> _identity;

    /// <summary>
    /// Logical Availability Zones the service is hosted in.
    /// </summary>
    public BicepList<string> Zones { get => _zones; }
    private readonly BicepList<string> _zones;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ResponseMessageEnvelopeRemotePrivateEndpointConnection.
    /// </summary>
    public ResponseMessageEnvelopeRemotePrivateEndpointConnection()
    {
        _error = BicepValue<ResponseError>.DefineProperty(this, "Error", ["error"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"], isOutput: true);
        _plan = BicepValue<AppServiceArmPlan>.DefineProperty(this, "Plan", ["plan"], isOutput: true);
        _properties = BicepValue<RemotePrivateEndpointConnection>.DefineProperty(this, "Properties", ["properties"], isOutput: true);
        _sku = BicepValue<AppServiceSkuDescription>.DefineProperty(this, "Sku", ["sku"], isOutput: true);
        _status = BicepValue<string>.DefineProperty(this, "Status", ["status"], isOutput: true);
        _identity = BicepValue<ManagedServiceIdentity>.DefineProperty(this, "Identity", ["identity"], isOutput: true);
        _zones = BicepList<string>.DefineProperty(this, "Zones", ["zones"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }
}
