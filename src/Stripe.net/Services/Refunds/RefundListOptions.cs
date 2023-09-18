// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return refunds for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Only return refunds for the PaymentIntent specified by this ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
