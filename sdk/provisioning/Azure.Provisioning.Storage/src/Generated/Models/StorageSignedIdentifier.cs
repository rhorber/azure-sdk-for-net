// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The StorageSignedIdentifier.
/// </summary>
public partial class StorageSignedIdentifier : ProvisionableConstruct
{
    /// <summary>
    /// An unique identifier of the stored access policy.
    /// </summary>
    public BicepValue<string> Id { get => _id; set => _id.Assign(value); }
    private readonly BicepValue<string> _id;

    /// <summary>
    /// Access policy.
    /// </summary>
    public BicepValue<StorageServiceAccessPolicy> AccessPolicy { get => _accessPolicy; set => _accessPolicy.Assign(value); }
    private readonly BicepValue<StorageServiceAccessPolicy> _accessPolicy;

    /// <summary>
    /// Creates a new StorageSignedIdentifier.
    /// </summary>
    public StorageSignedIdentifier()
    {
        _id = BicepValue<string>.DefineProperty(this, "Id", ["id"]);
        _accessPolicy = BicepValue<StorageServiceAccessPolicy>.DefineProperty(this, "AccessPolicy", ["accessPolicy"]);
    }
}
