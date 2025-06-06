// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> The CreateVectorStoreFileRequest. </summary>
    internal partial class CreateVectorStoreFileRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateVectorStoreFileRequest"/>. </summary>
        internal CreateVectorStoreFileRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CreateVectorStoreFileRequest"/>. </summary>
        /// <param name="fileId"> Identifier of the file. </param>
        /// <param name="dataSource"> Azure asset ID. </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file. If not set, uses the auto strategy.
        /// Please note <see cref="VectorStoreChunkingStrategy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategy"/> and <see cref="VectorStoreStaticChunkingStrategyRequest"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateVectorStoreFileRequest(string fileId, VectorStoreDataSource dataSource, VectorStoreChunkingStrategy chunkingStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            DataSource = dataSource;
            ChunkingStrategy = chunkingStrategy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identifier of the file. </summary>
        public string FileId { get; }
        /// <summary> Azure asset ID. </summary>
        public VectorStoreDataSource DataSource { get; }
        /// <summary>
        /// The chunking strategy used to chunk the file. If not set, uses the auto strategy.
        /// Please note <see cref="VectorStoreChunkingStrategy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategy"/> and <see cref="VectorStoreStaticChunkingStrategyRequest"/>.
        /// </summary>
        public VectorStoreChunkingStrategy ChunkingStrategy { get; }
    }
}
