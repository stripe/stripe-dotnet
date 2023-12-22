// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions>
    {
        /// <summary>
        /// Mandate collection method.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }
    }
}
