// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkAfterCompletionRedirect : StripeEntity<PaymentLinkAfterCompletionRedirect>
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
