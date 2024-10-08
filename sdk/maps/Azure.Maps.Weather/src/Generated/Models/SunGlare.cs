// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather.Models
{
    /// <summary> A rating that indicates how blinding the sun is for the driver. </summary>
    public partial class SunGlare
    {
        /// <summary> Initializes a new instance of <see cref="SunGlare"/>. </summary>
        internal SunGlare()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SunGlare"/>. </summary>
        /// <param name="calculatedVehicleHeading"> If the vehicle heading value is not provided for a waypoint, then the service will calculate a heading based upon the location of neighboring waypoints if provided. </param>
        /// <param name="glareIndex"> An index from 0 to 100 indicating sun glare intensity for a driver. A value of 50 and above can be considered a hazard for some drivers and a value of 100 signifies the driver is driving straight into the sun and atmospheric conditions are clear allowing for the full intensity of the sun to blind the driver. </param>
        internal SunGlare(int? calculatedVehicleHeading, int? glareIndex)
        {
            CalculatedVehicleHeading = calculatedVehicleHeading;
            GlareIndex = glareIndex;
        }

        /// <summary> If the vehicle heading value is not provided for a waypoint, then the service will calculate a heading based upon the location of neighboring waypoints if provided. </summary>
        public int? CalculatedVehicleHeading { get; }
        /// <summary> An index from 0 to 100 indicating sun glare intensity for a driver. A value of 50 and above can be considered a hazard for some drivers and a value of 100 signifies the driver is driving straight into the sun and atmospheric conditions are clear allowing for the full intensity of the sun to blind the driver. </summary>
        public int? GlareIndex { get; }
    }
}
