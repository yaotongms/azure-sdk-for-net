// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    [PersistableModelProxy(typeof(UnknownProcedureRecommendation))]
    public partial class ProcedureRecommendation : IUtf8JsonSerializable, IJsonModel<ProcedureRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProcedureRecommendation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProcedureRecommendation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcedureRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcedureRecommendation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsCollectionDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ProcedureRecommendation IJsonModel<ProcedureRecommendation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcedureRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcedureRecommendation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProcedureRecommendation(document.RootElement, options);
        }

        internal static ProcedureRecommendation DeserializeProcedureRecommendation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "genericProcedureRecommendation": return GenericProcedureRecommendation.DeserializeGenericProcedureRecommendation(element, options);
                    case "imagingProcedureRecommendation": return ImagingProcedureRecommendation.DeserializeImagingProcedureRecommendation(element, options);
                }
            }
            return UnknownProcedureRecommendation.DeserializeUnknownProcedureRecommendation(element, options);
        }

        BinaryData IPersistableModel<ProcedureRecommendation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcedureRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureHealthInsightsRadiologyInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ProcedureRecommendation)} does not support writing '{options.Format}' format.");
            }
        }

        ProcedureRecommendation IPersistableModel<ProcedureRecommendation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcedureRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProcedureRecommendation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProcedureRecommendation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProcedureRecommendation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ProcedureRecommendation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeProcedureRecommendation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
