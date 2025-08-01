// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.Health.Deidentification
{
    /// <summary> Details of a single document in a job. </summary>
    public partial class DeidentificationDocumentDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="DeidentificationDocumentDetails"/>. </summary>
        /// <param name="inputLocation"> Location for the input. </param>
        /// <param name="status"> Status of the document. </param>
        internal DeidentificationDocumentDetails(DeidentificationDocumentLocation inputLocation, OperationStatus status)
        {
            InputLocation = inputLocation;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="DeidentificationDocumentDetails"/>. </summary>
        /// <param name="id"> Id of the document details. </param>
        /// <param name="inputLocation"> Location for the input. </param>
        /// <param name="outputLocation"> Location for the output. </param>
        /// <param name="status"> Status of the document. </param>
        /// <param name="error"> Error when document fails. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal DeidentificationDocumentDetails(string id, DeidentificationDocumentLocation inputLocation, DeidentificationDocumentLocation outputLocation, OperationStatus status, ResponseError error, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            InputLocation = inputLocation;
            OutputLocation = outputLocation;
            Status = status;
            Error = error;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Id of the document details. </summary>
        public string Id { get; }

        /// <summary> Location for the input. </summary>
        public DeidentificationDocumentLocation InputLocation { get; }

        /// <summary> Location for the output. </summary>
        public DeidentificationDocumentLocation OutputLocation { get; }

        /// <summary> Status of the document. </summary>
        public OperationStatus Status { get; }

        /// <summary> Error when document fails. </summary>
        public ResponseError Error { get; }
    }
}
