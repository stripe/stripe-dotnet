// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsCarRentalDatumDistanceOptions : INestedOptions
    {
        /// <summary>
        /// Distance traveled.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Unit of measurement for the distance traveled. One of <c>miles</c> or <c>kilometers</c>.
        /// One of: <c>kilometers</c>, or <c>miles</c>.
        /// </summary>
        [JsonProperty("unit")]
        [STJS.JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
