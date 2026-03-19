// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardLifecycleControlsCancelAfterOptions : INestedOptions
    {
        /// <summary>
        /// The card is automatically cancelled when it makes this number of non-zero payment
        /// authorizations and transactions. The count includes penny authorizations, but doesn't
        /// include non-payment actions, such as authorization advice.
        /// </summary>
        [JsonProperty("payment_count")]
        [STJS.JsonPropertyName("payment_count")]
        public long? PaymentCount { get; set; }
    }
}
