// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BankAccountRequirementsErrorDetails : StripeEntity<BankAccountRequirementsErrorDetails>
    {
        /// <summary>
        /// The rejection code as received from our payment method partner.
        /// </summary>
        [JsonProperty("partner_rejection_code")]
        [STJS.JsonPropertyName("partner_rejection_code")]
        public string PartnerRejectionCode { get; set; }
    }
}
