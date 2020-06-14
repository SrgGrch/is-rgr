// ReSharper disable InconsistentNaming

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RGR.models {
    public enum EventType {
        Workshop,
        Lecture,
        Networking,
        Meeting,
        Lifestyle,
        Cinema
    }
    //
    // public sealed class JsonStringEnumConverter : JsonConverterFactory {
    //     public override bool CanConvert(Type typeToConvert) {
    //         throw new NotImplementedException();
    //     }
    //
    //     public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) {
    //         throw new NotImplementedException();
    //     }
    // }
}