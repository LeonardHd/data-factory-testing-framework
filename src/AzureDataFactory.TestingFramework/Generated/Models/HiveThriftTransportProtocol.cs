// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The transport protocol to use in the Thrift layer. </summary>
    public readonly partial struct HiveThriftTransportProtocol : IEquatable<HiveThriftTransportProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HiveThriftTransportProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HiveThriftTransportProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BinaryValue = "Binary";
        private const string SaslValue = "SASL";
        private const string HttpValue = "HTTP ";

        /// <summary> Binary. </summary>
        public static HiveThriftTransportProtocol Binary { get; } = new HiveThriftTransportProtocol(BinaryValue);
        /// <summary> SASL. </summary>
        public static HiveThriftTransportProtocol Sasl { get; } = new HiveThriftTransportProtocol(SaslValue);
        /// <summary> HTTP. </summary>
        public static HiveThriftTransportProtocol Http { get; } = new HiveThriftTransportProtocol(HttpValue);
        /// <summary> Determines if two <see cref="HiveThriftTransportProtocol"/> values are the same. </summary>
        public static bool operator ==(HiveThriftTransportProtocol left, HiveThriftTransportProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HiveThriftTransportProtocol"/> values are not the same. </summary>
        public static bool operator !=(HiveThriftTransportProtocol left, HiveThriftTransportProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HiveThriftTransportProtocol"/>. </summary>
        public static implicit operator HiveThriftTransportProtocol(string value) => new HiveThriftTransportProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HiveThriftTransportProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HiveThriftTransportProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}