// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedCreditListOptions : V2.ListOptions
    {
        /// <summary>
        /// Hash of options for filtering on creation time.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public ReceivedCreditListCreatedOptions Created { get; set; }
    }
}
