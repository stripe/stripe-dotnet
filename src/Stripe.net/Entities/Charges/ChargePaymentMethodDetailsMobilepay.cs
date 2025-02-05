// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsMobilepay : StripeEntity<ChargePaymentMethodDetailsMobilepay>
    {
        /// <summary>
        /// Internal card details.
        /// </summary>
        [JsonProperty("card")]
        public ChargePaymentMethodDetailsMobilepayCard Card { get; set; }
    }
}
