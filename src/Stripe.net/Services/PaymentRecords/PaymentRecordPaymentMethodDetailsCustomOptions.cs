// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordPaymentMethodDetailsCustomOptions : INestedOptions
    {
        /// <summary>
        /// Display name for the custom (user-defined) payment method type used to make this
        /// payment.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
