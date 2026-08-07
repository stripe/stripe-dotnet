// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The result of resolving an address to its tax precision level.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OperationsResolveAddressResult : StripeEntity<OperationsResolveAddressResult>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The normalized form of the input address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public OperationsResolveAddressResultAddress Address { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The precision level of the resolved address.
        /// One of: <c>none</c>, <c>address</c>, <c>city</c>, <c>country</c>, <c>postal_code</c>,
        /// <c>state</c>, or <c>street</c>.
        /// </summary>
        [JsonProperty("precision")]
        [STJS.JsonPropertyName("precision")]
        public string Precision { get; set; }

        /// <summary>
        /// Details about the precision, including any issues.
        /// </summary>
        [JsonProperty("precision_details")]
        [STJS.JsonPropertyName("precision_details")]
        public OperationsResolveAddressResultPrecisionDetails PrecisionDetails { get; set; }
    }
}
