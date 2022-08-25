// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The Enum13. </summary>
    public readonly partial struct Enum13 : IEquatable<Enum13>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum13"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum13(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExpansionValue = "Expansion";
        private const string ActivityValue = "Activity";

        /// <summary> Expansion. </summary>
        public static Enum13 Expansion { get; } = new Enum13(ExpansionValue);
        /// <summary> Activity. </summary>
        public static Enum13 Activity { get; } = new Enum13(ActivityValue);
        /// <summary> Determines if two <see cref="Enum13"/> values are the same. </summary>
        public static bool operator ==(Enum13 left, Enum13 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum13"/> values are not the same. </summary>
        public static bool operator !=(Enum13 left, Enum13 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum13"/>. </summary>
        public static implicit operator Enum13(string value) => new Enum13(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum13 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum13 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
