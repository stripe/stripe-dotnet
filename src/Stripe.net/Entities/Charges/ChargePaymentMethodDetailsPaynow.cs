// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsPaynow : StripeEntity<ChargePaymentMethodDetailsPaynow>
    {
        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        /// <summary>
        /// Reference number associated with this PayNow payment.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
