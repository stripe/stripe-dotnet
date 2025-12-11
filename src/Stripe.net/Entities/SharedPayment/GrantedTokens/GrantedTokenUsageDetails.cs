// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class GrantedTokenUsageDetails : StripeEntity<GrantedTokenUsageDetails>
    {
        /// <summary>
        /// The total amount captured using this SharedPaymentToken.
        /// </summary>
        [JsonProperty("amount_captured")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_captured")]
#endif
        public GrantedTokenUsageDetailsAmountCaptured AmountCaptured { get; set; }
    }
}
