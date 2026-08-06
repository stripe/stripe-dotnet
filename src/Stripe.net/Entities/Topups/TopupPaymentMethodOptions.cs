// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TopupPaymentMethodOptions : StripeEntity<TopupPaymentMethodOptions>
    {
        /// <summary>
        /// If this top-up is to be used with a <c>us_bank_account</c> payment method, this sub-hash
        /// contains configuration for it.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public TopupPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
