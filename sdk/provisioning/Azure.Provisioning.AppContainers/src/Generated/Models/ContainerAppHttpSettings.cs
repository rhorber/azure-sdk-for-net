// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the HTTP requests for authentication and
/// authorization requests made against ContainerApp Service
/// Authentication/Authorization.
/// </summary>
public partial class ContainerAppHttpSettings : ProvisionableConstruct
{
    /// <summary>
    /// &lt;code&gt;false&lt;/code&gt; if the authentication/authorization
    /// responses not having the HTTPS scheme are permissible; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> RequireHttps { get => _requireHttps; set => _requireHttps.Assign(value); }
    private readonly BicepValue<bool> _requireHttps;

    /// <summary>
    /// The prefix that should precede all the authentication/authorization
    /// paths.
    /// </summary>
    public BicepValue<string> RoutesApiPrefix { get => _routesApiPrefix; set => _routesApiPrefix.Assign(value); }
    private readonly BicepValue<string> _routesApiPrefix;

    /// <summary>
    /// The configuration settings of a forward proxy used to make the requests.
    /// </summary>
    public BicepValue<ContainerAppForwardProxy> ForwardProxy { get => _forwardProxy; set => _forwardProxy.Assign(value); }
    private readonly BicepValue<ContainerAppForwardProxy> _forwardProxy;

    /// <summary>
    /// Creates a new ContainerAppHttpSettings.
    /// </summary>
    public ContainerAppHttpSettings()
    {
        _requireHttps = BicepValue<bool>.DefineProperty(this, "RequireHttps", ["requireHttps"]);
        _routesApiPrefix = BicepValue<string>.DefineProperty(this, "RoutesApiPrefix", ["routes", "apiPrefix"]);
        _forwardProxy = BicepValue<ContainerAppForwardProxy>.DefineProperty(this, "ForwardProxy", ["forwardProxy"]);
    }
}
