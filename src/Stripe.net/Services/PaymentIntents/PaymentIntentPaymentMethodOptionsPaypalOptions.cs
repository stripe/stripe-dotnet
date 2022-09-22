// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsPaypalOptions : INestedOptions
    {
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("preferred_locale")]
        public string PreferredLocale { get; set; }
    }
}
