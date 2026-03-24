// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardWalletsGooglePay : StripeEntity<CardWalletsGooglePay>
    {
        /// <summary>
        /// Google Pay Eligibility.
        /// </summary>
        [JsonProperty("eligible")]
        [STJS.JsonPropertyName("eligible")]
        public bool Eligible { get; set; }

        /// <summary>
        /// Reason the card is ineligible for Google Pay.
        /// One of: <c>missing_agreement</c>, <c>missing_cardholder_contact</c>, or
        /// <c>unsupported_region</c>.
        /// </summary>
        [JsonProperty("ineligible_reason")]
        [STJS.JsonPropertyName("ineligible_reason")]
        public string IneligibleReason { get; set; }

        /// <summary>
        /// Unique identifier for the card in Google Pay.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
        [STJS.JsonPropertyName("primary_account_identifier")]
        public string PrimaryAccountIdentifier { get; set; }
    }
}
