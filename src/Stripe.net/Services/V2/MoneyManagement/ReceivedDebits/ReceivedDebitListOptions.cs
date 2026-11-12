// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedDebitListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter ReceivedDebits by their creation time.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public ReceivedDebitListCreatedOptions Created { get; set; }
    }
}
