// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The ServiceAccountQuotaLimit.
/// </summary>
public partial class ServiceAccountQuotaLimit : ProvisionableConstruct
{
    /// <summary>
    /// Gets the count.
    /// </summary>
    public BicepValue<float> Count { get => _count; }
    private readonly BicepValue<float> _count;

    /// <summary>
    /// Gets the renewal period.
    /// </summary>
    public BicepValue<float> RenewalPeriod { get => _renewalPeriod; }
    private readonly BicepValue<float> _renewalPeriod;

    /// <summary>
    /// Gets the rules.
    /// </summary>
    public BicepList<ServiceAccountThrottlingRule> Rules { get => _rules; }
    private readonly BicepList<ServiceAccountThrottlingRule> _rules;

    /// <summary>
    /// Creates a new ServiceAccountQuotaLimit.
    /// </summary>
    public ServiceAccountQuotaLimit()
    {
        _count = BicepValue<float>.DefineProperty(this, "Count", ["count"], isOutput: true);
        _renewalPeriod = BicepValue<float>.DefineProperty(this, "RenewalPeriod", ["renewalPeriod"], isOutput: true);
        _rules = BicepList<ServiceAccountThrottlingRule>.DefineProperty(this, "Rules", ["rules"], isOutput: true);
    }
}
