// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoPublishingOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableVideoPreviewImage))
            {
                writer.WritePropertyName("enableVideoPreviewImage"u8);
                writer.WriteStringValue(EnableVideoPreviewImage);
            }
            writer.WriteEndObject();
        }

        internal static VideoPublishingOptions DeserializeVideoPublishingOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string enableVideoPreviewImage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableVideoPreviewImage"u8))
                {
                    enableVideoPreviewImage = property.Value.GetString();
                    continue;
                }
            }
            return new VideoPublishingOptions(enableVideoPreviewImage);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VideoPublishingOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeVideoPublishingOptions(document.RootElement);
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
