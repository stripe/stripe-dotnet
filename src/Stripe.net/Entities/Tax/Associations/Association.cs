// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Tax Association exposes the Tax Transactions that Stripe attempted to create on your
    /// behalf based on the PaymentIntent input.
    /// </summary>
    public class Association : StripeEntity<Association>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax/calculations/object">Tax Calculation</a>
        /// that was included in PaymentIntent.
        /// </summary>
        [JsonProperty("calculation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation")]
#endif
        public string Calculation { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/payment_intents/object">PaymentIntent</a> that
        /// this Tax Association is tracking.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Status of the Tax Association.
        /// One of: <c>committed</c>, or <c>errored</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public AssociationStatusDetails StatusDetails { get; set; }
    }
}
