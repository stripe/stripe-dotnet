// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputePaymentMethodDetailsPaypal : StripeEntity<DisputePaymentMethodDetailsPaypal>
    {
        /// <summary>
        /// The ID of the dispute in PayPal.
        /// </summary>
        [JsonProperty("case_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("case_id")]
#endif
        public string CaseId { get; set; }

        /// <summary>
        /// The reason for the dispute as defined by PayPal.
        /// </summary>
        [JsonProperty("reason_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason_code")]
#endif
        public string ReasonCode { get; set; }
    }
}
