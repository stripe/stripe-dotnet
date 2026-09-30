// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceStatusDetails : StripeEntity<InvoiceStatusDetails>
    {
        [JsonProperty("uncollectible")]
        [STJS.JsonPropertyName("uncollectible")]
        public InvoiceStatusDetailsUncollectible Uncollectible { get; set; }
    }
}
