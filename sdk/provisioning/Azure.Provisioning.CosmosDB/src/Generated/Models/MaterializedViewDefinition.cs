// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Materialized View definition for the container.
/// </summary>
public partial class MaterializedViewDefinition : ProvisionableConstruct
{
    /// <summary>
    /// An unique identifier for the source collection. This is a system
    /// generated property.
    /// </summary>
    public BicepValue<string> SourceCollectionRid 
    {
        get { Initialize(); return _sourceCollectionRid!; }
    }
    private BicepValue<string>? _sourceCollectionRid;

    /// <summary>
    /// The name of the source container on which the Materialized View will be
    /// created.
    /// </summary>
    public BicepValue<string> SourceCollectionId 
    {
        get { Initialize(); return _sourceCollectionId!; }
        set { Initialize(); _sourceCollectionId!.Assign(value); }
    }
    private BicepValue<string>? _sourceCollectionId;

    /// <summary>
    /// The definition should be an SQL query which would be used to fetch data
    /// from the source container to populate into the Materialized View
    /// container.
    /// </summary>
    public BicepValue<string> Definition 
    {
        get { Initialize(); return _definition!; }
        set { Initialize(); _definition!.Assign(value); }
    }
    private BicepValue<string>? _definition;

    /// <summary>
    /// Creates a new MaterializedViewDefinition.
    /// </summary>
    public MaterializedViewDefinition()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of MaterializedViewDefinition.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _sourceCollectionRid = DefineProperty<string>("SourceCollectionRid", ["sourceCollectionRid"], isOutput: true);
        _sourceCollectionId = DefineProperty<string>("SourceCollectionId", ["sourceCollectionId"]);
        _definition = DefineProperty<string>("Definition", ["definition"]);
    }
}
