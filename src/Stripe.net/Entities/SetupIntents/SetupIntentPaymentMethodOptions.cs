namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
