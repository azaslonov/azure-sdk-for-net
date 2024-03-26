// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiCenter;

namespace Azure.ResourceManager.ApiCenter.Models
{
    public partial class ApiDefinitionProperties : IUtf8JsonSerializable, IJsonModel<ApiDefinitionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiDefinitionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiDefinitionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiDefinitionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiDefinitionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("title"u8);
            writer.WriteStringValue(Title);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Specification))
            {
                writer.WritePropertyName("specification"u8);
                writer.WriteObjectValue(Specification);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApiDefinitionProperties IJsonModel<ApiDefinitionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiDefinitionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiDefinitionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiDefinitionProperties(document.RootElement, options);
        }

        internal static ApiDefinitionProperties DeserializeApiDefinitionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string title = default;
            string description = default;
            ApiDefinitionPropertiesSpecification specification = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("specification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    specification = ApiDefinitionPropertiesSpecification.DeserializeApiDefinitionPropertiesSpecification(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiDefinitionProperties(title, description, specification, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiDefinitionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiDefinitionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiDefinitionProperties)} does not support '{options.Format}' format.");
            }
        }

        ApiDefinitionProperties IPersistableModel<ApiDefinitionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiDefinitionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiDefinitionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiDefinitionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiDefinitionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
