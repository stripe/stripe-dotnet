// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TopupPaymentMethodOptionsUsBankAccount : StripeEntity<TopupPaymentMethodOptionsUsBankAccount>
    {
        /// <summary>
        /// The US bank transfer network used for this top-up. The default is <c>ach</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
