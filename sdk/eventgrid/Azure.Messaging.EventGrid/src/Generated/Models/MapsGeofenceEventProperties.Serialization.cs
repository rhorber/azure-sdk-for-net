// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MapsGeofenceEventProperties
    {
        internal static MapsGeofenceEventProperties DeserializeMapsGeofenceEventProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> expiredGeofenceGeometryId = default;
            IReadOnlyList<MapsGeofenceGeometry> geometries = default;
            IReadOnlyList<string> invalidPeriodGeofenceGeometryId = default;
            bool? isEventPublished = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiredGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    expiredGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("geometries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
                if (property.NameEquals("invalidPeriodGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidPeriodGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("isEventPublished"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEventPublished = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MapsGeofenceEventProperties(expiredGeofenceGeometryId ?? new ChangeTrackingList<string>(), geometries ?? new ChangeTrackingList<MapsGeofenceGeometry>(), invalidPeriodGeofenceGeometryId ?? new ChangeTrackingList<string>(), isEventPublished);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MapsGeofenceEventProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMapsGeofenceEventProperties(document.RootElement);
        }
    }
}
