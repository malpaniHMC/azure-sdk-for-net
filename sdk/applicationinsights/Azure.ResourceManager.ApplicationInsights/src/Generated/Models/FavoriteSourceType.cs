// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The FavoriteSourceType. </summary>
    public readonly partial struct FavoriteSourceType : IEquatable<FavoriteSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FavoriteSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FavoriteSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RetentionValue = "retention";
        private const string NotebookValue = "notebook";
        private const string SessionsValue = "sessions";
        private const string EventsValue = "events";
        private const string UserflowsValue = "userflows";
        private const string FunnelValue = "funnel";
        private const string ImpactValue = "impact";
        private const string SegmentationValue = "segmentation";

        /// <summary> retention. </summary>
        public static FavoriteSourceType Retention { get; } = new FavoriteSourceType(RetentionValue);
        /// <summary> notebook. </summary>
        public static FavoriteSourceType Notebook { get; } = new FavoriteSourceType(NotebookValue);
        /// <summary> sessions. </summary>
        public static FavoriteSourceType Sessions { get; } = new FavoriteSourceType(SessionsValue);
        /// <summary> events. </summary>
        public static FavoriteSourceType Events { get; } = new FavoriteSourceType(EventsValue);
        /// <summary> userflows. </summary>
        public static FavoriteSourceType Userflows { get; } = new FavoriteSourceType(UserflowsValue);
        /// <summary> funnel. </summary>
        public static FavoriteSourceType Funnel { get; } = new FavoriteSourceType(FunnelValue);
        /// <summary> impact. </summary>
        public static FavoriteSourceType Impact { get; } = new FavoriteSourceType(ImpactValue);
        /// <summary> segmentation. </summary>
        public static FavoriteSourceType Segmentation { get; } = new FavoriteSourceType(SegmentationValue);
        /// <summary> Determines if two <see cref="FavoriteSourceType"/> values are the same. </summary>
        public static bool operator ==(FavoriteSourceType left, FavoriteSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FavoriteSourceType"/> values are not the same. </summary>
        public static bool operator !=(FavoriteSourceType left, FavoriteSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FavoriteSourceType"/>. </summary>
        public static implicit operator FavoriteSourceType(string value) => new FavoriteSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FavoriteSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FavoriteSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
