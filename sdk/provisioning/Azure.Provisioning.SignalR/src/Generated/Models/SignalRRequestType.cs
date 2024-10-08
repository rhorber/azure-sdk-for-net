// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// The incoming request type to the service.
/// </summary>
public enum SignalRRequestType
{
    /// <summary>
    /// ClientConnection.
    /// </summary>
    ClientConnection,

    /// <summary>
    /// ServerConnection.
    /// </summary>
    ServerConnection,

    /// <summary>
    /// RESTAPI.
    /// </summary>
    [DataMember(Name = "RESTAPI")]
    RestApi,

    /// <summary>
    /// Trace.
    /// </summary>
    Trace,
}
