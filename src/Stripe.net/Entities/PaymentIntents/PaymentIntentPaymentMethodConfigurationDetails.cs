// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodConfigurationDetails : StripeEntity<PaymentIntentPaymentMethodConfigurationDetails>, IHasId
    {
        /// <summary>
        /// ID of the payment method configuration used.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// ID of the parent payment method configuration used.
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }
    }
}
