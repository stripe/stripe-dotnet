// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeEntryChargedBy : StripeEntity<FeeEntryChargedBy>
    {
        /// <summary>
        /// Details for a fee charged by a Connect application.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public FeeEntryChargedByApplication Application { get; set; }

        /// <summary>
        /// Details for a fee charged by the payment network.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public FeeEntryChargedByNetwork Network { get; set; }

        /// <summary>
        /// Details for a referral fee charged by a Shared Payment Token issuer.
        /// </summary>
        [JsonProperty("shared_payment_token_issuer")]
        [STJS.JsonPropertyName("shared_payment_token_issuer")]
        public FeeEntryChargedBySharedPaymentTokenIssuer SharedPaymentTokenIssuer { get; set; }

        /// <summary>
        /// Details for a fee charged by Stripe.
        /// </summary>
        [JsonProperty("stripe")]
        [STJS.JsonPropertyName("stripe")]
        public FeeEntryChargedByStripe Stripe { get; set; }

        /// <summary>
        /// The type of entity that charged this fee.
        /// One of: <c>application</c>, <c>network</c>, <c>shared_payment_token_issuer</c>, or
        /// <c>stripe</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
