// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions>
    {
        /// <summary>
        /// Mandate collection method.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }
    }
}
