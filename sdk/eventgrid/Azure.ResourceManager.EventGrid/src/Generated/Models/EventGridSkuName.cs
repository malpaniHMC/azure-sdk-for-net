// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The name of the SKU. </summary>
    public readonly partial struct EventGridSkuName : IEquatable<EventGridSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";

        /// <summary> Standard. </summary>
        public static EventGridSkuName Standard { get; } = new EventGridSkuName(StandardValue);
        /// <summary> Determines if two <see cref="EventGridSkuName"/> values are the same. </summary>
        public static bool operator ==(EventGridSkuName left, EventGridSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridSkuName"/> values are not the same. </summary>
        public static bool operator !=(EventGridSkuName left, EventGridSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridSkuName"/>. </summary>
        public static implicit operator EventGridSkuName(string value) => new EventGridSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
