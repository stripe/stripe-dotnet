// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2BillingContractTermCreatedEventData : StripeEntity<V2BillingContractTermCreatedEventData>
    {
        /// <summary>
        /// The Contract containing this term.
        /// </summary>
        [JsonProperty("contract")]
        [STJS.JsonPropertyName("contract")]
        public string Contract { get; set; }
    }
}
