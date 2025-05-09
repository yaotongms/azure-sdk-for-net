// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.FluidRelay
{
    public partial class FluidRelayContainerResource : IJsonModel<FluidRelayContainerData>
    {
        void IJsonModel<FluidRelayContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FluidRelayContainerData>)Data).Write(writer, options);

        FluidRelayContainerData IJsonModel<FluidRelayContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FluidRelayContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FluidRelayContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FluidRelayContainerData>(Data, options, AzureResourceManagerFluidRelayContext.Default);

        FluidRelayContainerData IPersistableModel<FluidRelayContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FluidRelayContainerData>(data, options, AzureResourceManagerFluidRelayContext.Default);

        string IPersistableModel<FluidRelayContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FluidRelayContainerData>)Data).GetFormatFromOptions(options);
    }
}
