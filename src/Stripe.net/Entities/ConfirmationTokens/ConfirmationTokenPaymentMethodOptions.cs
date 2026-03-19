// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodOptions : StripeEntity<ConfirmationTokenPaymentMethodOptions>
    {
        /// <summary>
        /// This hash contains the card payment method options.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public ConfirmationTokenPaymentMethodOptionsCard Card { get; set; }
    }
}
