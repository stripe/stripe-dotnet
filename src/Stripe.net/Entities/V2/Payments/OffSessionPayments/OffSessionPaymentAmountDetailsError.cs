// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentAmountDetailsError : StripeEntity<OffSessionPaymentAmountDetailsError>
    {
        /// <summary>
        /// The code of the error that occurred when validating the current amount details.
        /// One of: <c>amount_details_amount_mismatch</c>, or
        /// <c>amount_details_amount_greater_than_tax_shipping_discount</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// A message providing more details about the error.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
