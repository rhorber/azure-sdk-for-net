// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Storage properties.
/// </summary>
public partial class ManagedEnvironmentStorageProperties : ProvisionableConstruct
{
    /// <summary>
    /// Azure file properties.
    /// </summary>
    public ContainerAppAzureFileProperties AzureFile 
    {
        get { Initialize(); return _azureFile!; }
        set { Initialize(); AssignOrReplace(ref _azureFile, value); }
    }
    private ContainerAppAzureFileProperties? _azureFile;

    /// <summary>
    /// NFS Azure file properties.
    /// </summary>
    public ContainerAppNfsAzureFileProperties NfsAzureFile 
    {
        get { Initialize(); return _nfsAzureFile!; }
        set { Initialize(); AssignOrReplace(ref _nfsAzureFile, value); }
    }
    private ContainerAppNfsAzureFileProperties? _nfsAzureFile;

    /// <summary>
    /// Creates a new ManagedEnvironmentStorageProperties.
    /// </summary>
    public ManagedEnvironmentStorageProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedEnvironmentStorageProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _azureFile = DefineModelProperty<ContainerAppAzureFileProperties>("AzureFile", ["azureFile"]);
        _nfsAzureFile = DefineModelProperty<ContainerAppNfsAzureFileProperties>("NfsAzureFile", ["nfsAzureFile"]);
    }
}
