// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetailsPaypal : StripeEntity<DisputePaymentMethodDetailsPaypal>
    {
        /// <summary>
        /// The ID of the dispute in PayPal.
        /// </summary>
        [JsonProperty("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// The reason for the dispute as defined by PayPal.
        /// </summary>
        [JsonProperty("reason_code")]
        public string ReasonCode { get; set; }
    }
}
