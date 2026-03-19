// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodOptionsCardInstallments : StripeEntity<ConfirmationTokenPaymentMethodOptionsCardInstallments>
    {
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public ConfirmationTokenPaymentMethodOptionsCardInstallmentsPlan Plan { get; set; }
    }
}
