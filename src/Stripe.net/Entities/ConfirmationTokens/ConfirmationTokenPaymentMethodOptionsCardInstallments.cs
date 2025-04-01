// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodOptionsCardInstallments : StripeEntity<ConfirmationTokenPaymentMethodOptionsCardInstallments>
    {
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public ConfirmationTokenPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
