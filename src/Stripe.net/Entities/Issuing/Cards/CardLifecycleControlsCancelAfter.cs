// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardLifecycleControlsCancelAfter : StripeEntity<CardLifecycleControlsCancelAfter>
    {
        /// <summary>
        /// The card is automatically cancelled when it makes this number of non-zero payment
        /// authorizations and transactions. The count includes penny authorizations, but doesn't
        /// include non-payment actions, such as authorization advice.
        /// </summary>
        [JsonProperty("payment_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_count")]
#endif
        public long PaymentCount { get; set; }
    }
}
