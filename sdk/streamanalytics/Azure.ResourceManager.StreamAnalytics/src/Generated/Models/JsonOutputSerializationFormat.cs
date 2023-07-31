// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Specifies the format of the JSON the output will be written in. The currently supported values are 'lineSeparated' indicating the output will be formatted by having each JSON object separated by a new line and 'array' indicating the output will be formatted as an array of JSON objects. </summary>
    public readonly partial struct JsonOutputSerializationFormat : IEquatable<JsonOutputSerializationFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JsonOutputSerializationFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JsonOutputSerializationFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LineSeparatedValue = "LineSeparated";
        private const string ArrayValue = "Array";

        /// <summary> LineSeparated. </summary>
        public static JsonOutputSerializationFormat LineSeparated { get; } = new JsonOutputSerializationFormat(LineSeparatedValue);
        /// <summary> Array. </summary>
        public static JsonOutputSerializationFormat Array { get; } = new JsonOutputSerializationFormat(ArrayValue);
        /// <summary> Determines if two <see cref="JsonOutputSerializationFormat"/> values are the same. </summary>
        public static bool operator ==(JsonOutputSerializationFormat left, JsonOutputSerializationFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonOutputSerializationFormat"/> values are not the same. </summary>
        public static bool operator !=(JsonOutputSerializationFormat left, JsonOutputSerializationFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonOutputSerializationFormat"/>. </summary>
        public static implicit operator JsonOutputSerializationFormat(string value) => new JsonOutputSerializationFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonOutputSerializationFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonOutputSerializationFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
