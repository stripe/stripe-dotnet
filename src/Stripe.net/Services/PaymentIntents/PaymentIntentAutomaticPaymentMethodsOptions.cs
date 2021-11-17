// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAutomaticPaymentMethodsOptions : INestedOptions
    {
        /// <summary>
        /// Whether this feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
