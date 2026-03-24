// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FxQuoteUsageTransferOptions : INestedOptions
    {
        /// <summary>
        /// The Stripe account ID that the funds will be transferred to.
        ///
        /// This field should match the account ID that would be used in the Transfer’s destination
        /// field.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }
    }
}
