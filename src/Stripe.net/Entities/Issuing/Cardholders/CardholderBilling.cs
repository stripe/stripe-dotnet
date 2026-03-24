// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardholderBilling : StripeEntity<CardholderBilling>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }
    }
}
