// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenUsageDetails : StripeEntity<GrantedTokenUsageDetails>
    {
        /// <summary>
        /// The total amount captured using this SharedPaymentToken.
        /// </summary>
        [JsonProperty("amount_captured")]
        [STJS.JsonPropertyName("amount_captured")]
        public GrantedTokenUsageDetailsAmountCaptured AmountCaptured { get; set; }
    }
}
