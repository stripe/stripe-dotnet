namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptions : StripeEntity<SetupIntentPaymentMethodOptions>
    {
        /// <summary>
        /// If the SetupIntent’s payment method types include <c>card</c>, this hash contains the
        /// configurations that will be applied to each setup attempt of that type.
        /// </summary>
        [JsonProperty("card")]
        public SetupIntentPaymentMethodOptionsCard Card { get; set; }
    }
}
