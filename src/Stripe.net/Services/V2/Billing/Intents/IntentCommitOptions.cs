// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCommitOptions : BaseOptions
    {
        /// <summary>
        /// ID of the PaymentIntent associated with this commit.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
