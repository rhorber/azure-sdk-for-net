// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents
{
    public partial class SuggestOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(UseFuzzyMatching))
            {
                writer.WritePropertyName("fuzzy"u8);
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (Optional.IsDefined(HighlightPostTag))
            {
                writer.WritePropertyName("highlightPostTag"u8);
                writer.WriteStringValue(HighlightPostTag);
            }
            if (Optional.IsDefined(HighlightPreTag))
            {
                writer.WritePropertyName("highlightPreTag"u8);
                writer.WriteStringValue(HighlightPreTag);
            }
            if (Optional.IsDefined(MinimumCoverage))
            {
                writer.WritePropertyName("minimumCoverage"u8);
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (Optional.IsDefined(OrderByRaw))
            {
                writer.WritePropertyName("orderby"u8);
                writer.WriteStringValue(OrderByRaw);
            }
            writer.WritePropertyName("search"u8);
            writer.WriteStringValue(SearchText);
            if (Optional.IsDefined(SearchFieldsRaw))
            {
                writer.WritePropertyName("searchFields"u8);
                writer.WriteStringValue(SearchFieldsRaw);
            }
            if (Optional.IsDefined(SelectRaw))
            {
                writer.WritePropertyName("select"u8);
                writer.WriteStringValue(SelectRaw);
            }
            writer.WritePropertyName("suggesterName"u8);
            writer.WriteStringValue(SuggesterName);
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Size.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
