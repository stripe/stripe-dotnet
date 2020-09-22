// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
