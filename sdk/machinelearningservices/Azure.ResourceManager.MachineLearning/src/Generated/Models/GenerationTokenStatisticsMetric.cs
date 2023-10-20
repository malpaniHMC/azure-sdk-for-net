// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Generation token statistics metric enum. </summary>
    public readonly partial struct GenerationTokenStatisticsMetric : IEquatable<GenerationTokenStatisticsMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GenerationTokenStatisticsMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GenerationTokenStatisticsMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TotalTokenCountValue = "TotalTokenCount";
        private const string TotalTokenCountPerGroupValue = "TotalTokenCountPerGroup";

        /// <summary> TotalTokenCount. </summary>
        public static GenerationTokenStatisticsMetric TotalTokenCount { get; } = new GenerationTokenStatisticsMetric(TotalTokenCountValue);
        /// <summary> TotalTokenCountPerGroup. </summary>
        public static GenerationTokenStatisticsMetric TotalTokenCountPerGroup { get; } = new GenerationTokenStatisticsMetric(TotalTokenCountPerGroupValue);
        /// <summary> Determines if two <see cref="GenerationTokenStatisticsMetric"/> values are the same. </summary>
        public static bool operator ==(GenerationTokenStatisticsMetric left, GenerationTokenStatisticsMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GenerationTokenStatisticsMetric"/> values are not the same. </summary>
        public static bool operator !=(GenerationTokenStatisticsMetric left, GenerationTokenStatisticsMetric right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GenerationTokenStatisticsMetric"/>. </summary>
        public static implicit operator GenerationTokenStatisticsMetric(string value) => new GenerationTokenStatisticsMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GenerationTokenStatisticsMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GenerationTokenStatisticsMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
