// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Billing information related properties of a server.
/// </summary>
public partial class PostgreSqlSku : ProvisionableConstruct
{
    /// <summary>
    /// The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1,
    /// GP_Gen5_8.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The tier of the particular SKU, e.g. Basic.
    /// </summary>
    public BicepValue<PostgreSqlSkuTier> Tier { get => _tier; set => _tier.Assign(value); }
    private readonly BicepValue<PostgreSqlSkuTier> _tier;

    /// <summary>
    /// The scale up/out capacity, representing server&apos;s compute units.
    /// </summary>
    public BicepValue<int> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<int> _capacity;

    /// <summary>
    /// The size code, to be interpreted by resource as appropriate.
    /// </summary>
    public BicepValue<string> Size { get => _size; set => _size.Assign(value); }
    private readonly BicepValue<string> _size;

    /// <summary>
    /// The family of hardware.
    /// </summary>
    public BicepValue<string> Family { get => _family; set => _family.Assign(value); }
    private readonly BicepValue<string> _family;

    /// <summary>
    /// Creates a new PostgreSqlSku.
    /// </summary>
    public PostgreSqlSku()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _tier = BicepValue<PostgreSqlSkuTier>.DefineProperty(this, "Tier", ["tier"]);
        _capacity = BicepValue<int>.DefineProperty(this, "Capacity", ["capacity"]);
        _size = BicepValue<string>.DefineProperty(this, "Size", ["size"]);
        _family = BicepValue<string>.DefineProperty(this, "Family", ["family"]);
    }
}
