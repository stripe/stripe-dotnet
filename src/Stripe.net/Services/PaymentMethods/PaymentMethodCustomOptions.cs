// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodCustomOptions : INestedOptions
    {
        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. This field is used by Stripe products'
        /// internal code to support CPMs.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
