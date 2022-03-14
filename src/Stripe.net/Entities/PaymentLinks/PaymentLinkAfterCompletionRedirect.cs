// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkAfterCompletionRedirect : StripeEntity<PaymentLinkAfterCompletionRedirect>
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
