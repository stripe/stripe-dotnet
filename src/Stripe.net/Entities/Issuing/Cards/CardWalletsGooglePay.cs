// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardWalletsGooglePay : StripeEntity<CardWalletsGooglePay>
    {
        /// <summary>
        /// Google Pay Eligibility.
        /// </summary>
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }

        /// <summary>
        /// Reason the card is ineligible for Google Pay.
        /// One of: <c>missing_agreement</c>, <c>missing_cardholder_contact</c>, or
        /// <c>unsupported_region</c>.
        /// </summary>
        [JsonProperty("ineligible_reason")]
        public string IneligibleReason { get; set; }
    }
}
