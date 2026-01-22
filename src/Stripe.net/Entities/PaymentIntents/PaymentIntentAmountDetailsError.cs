// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsError : StripeEntity<PaymentIntentAmountDetailsError>
    {
        /// <summary>
        /// The code of the error that occurred when validating the current amount details.
        /// One of: <c>amount_details_amount_mismatch</c>, or
        /// <c>amount_details_tax_shipping_discount_greater_than_amount</c>.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// A message providing more details about the error.
        /// </summary>
        [JsonProperty("message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("message")]
#endif
        public string Message { get; set; }
    }
}
