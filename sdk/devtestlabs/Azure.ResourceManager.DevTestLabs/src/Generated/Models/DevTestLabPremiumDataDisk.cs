// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary>
    /// The setting to enable usage of premium data disks.
    /// When its value is 'Enabled', creation of standard or premium data disks is allowed.
    /// When its value is 'Disabled', only creation of standard data disks is allowed.
    /// </summary>
    public readonly partial struct DevTestLabPremiumDataDisk : IEquatable<DevTestLabPremiumDataDisk>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabPremiumDataDisk"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabPremiumDataDisk(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static DevTestLabPremiumDataDisk Disabled { get; } = new DevTestLabPremiumDataDisk(DisabledValue);
        /// <summary> Enabled. </summary>
        public static DevTestLabPremiumDataDisk Enabled { get; } = new DevTestLabPremiumDataDisk(EnabledValue);
        /// <summary> Determines if two <see cref="DevTestLabPremiumDataDisk"/> values are the same. </summary>
        public static bool operator ==(DevTestLabPremiumDataDisk left, DevTestLabPremiumDataDisk right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabPremiumDataDisk"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabPremiumDataDisk left, DevTestLabPremiumDataDisk right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevTestLabPremiumDataDisk"/>. </summary>
        public static implicit operator DevTestLabPremiumDataDisk(string value) => new DevTestLabPremiumDataDisk(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabPremiumDataDisk other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabPremiumDataDisk other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
