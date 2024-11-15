// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardWalletsGooglePay : StripeEntity<CardWalletsGooglePay>
    {
        /// <summary>
        /// Google Pay Eligibility.
        /// </summary>
        [JsonProperty("eligible")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eligible")]
#endif

        public bool Eligible { get; set; }

        /// <summary>
        /// Reason the card is ineligible for Google Pay.
        /// One of: <c>missing_agreement</c>, <c>missing_cardholder_contact</c>, or
        /// <c>unsupported_region</c>.
        /// </summary>
        [JsonProperty("ineligible_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ineligible_reason")]
#endif

        public string IneligibleReason { get; set; }
    }
}
