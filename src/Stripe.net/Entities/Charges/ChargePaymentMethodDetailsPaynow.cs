// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsPaynow : StripeEntity<ChargePaymentMethodDetailsPaynow>
    {
        /// <summary>
        /// Reference number associated with this PayNow payment.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
