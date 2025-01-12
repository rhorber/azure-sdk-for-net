// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// An ARM Resource SKU.
/// </summary>
public partial class SqlSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of the SKU, typically, a letter + Number code, e.g. P3.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The tier or edition of the particular SKU, e.g. Basic, Premium.
    /// </summary>
    public BicepValue<string> Tier 
    {
        get { Initialize(); return _tier!; }
        set { Initialize(); _tier!.Assign(value); }
    }
    private BicepValue<string>? _tier;

    /// <summary>
    /// Size of the particular SKU.
    /// </summary>
    public BicepValue<string> Size 
    {
        get { Initialize(); return _size!; }
        set { Initialize(); _size!.Assign(value); }
    }
    private BicepValue<string>? _size;

    /// <summary>
    /// If the service has different generations of hardware, for the same SKU,
    /// then that can be captured here.
    /// </summary>
    public BicepValue<string> Family 
    {
        get { Initialize(); return _family!; }
        set { Initialize(); _family!.Assign(value); }
    }
    private BicepValue<string>? _family;

    /// <summary>
    /// Capacity of the particular SKU.
    /// </summary>
    public BicepValue<int> Capacity 
    {
        get { Initialize(); return _capacity!; }
        set { Initialize(); _capacity!.Assign(value); }
    }
    private BicepValue<int>? _capacity;

    /// <summary>
    /// Creates a new SqlSku.
    /// </summary>
    public SqlSku()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SqlSku.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _tier = DefineProperty<string>("Tier", ["tier"]);
        _size = DefineProperty<string>("Size", ["size"]);
        _family = DefineProperty<string>("Family", ["family"]);
        _capacity = DefineProperty<int>("Capacity", ["capacity"]);
    }
}
