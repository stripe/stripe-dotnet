// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions>
    {
        /// <summary>
        /// Mandate collection method.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif

        public string CollectionMethod { get; set; }
    }
}
