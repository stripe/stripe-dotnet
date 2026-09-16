// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PayoutPayoutMethodOptionsFinancialAccountOptions : INestedOptions
    {
        /// <summary>
        /// Identifies the currency to credit in the destination Financial Account. Must be a
        /// currency supported by the target Financial Account. When omitted, the payout uses the
        /// currency parameter.
        /// </summary>
        [JsonProperty("destination_currency")]
        [STJS.JsonPropertyName("destination_currency")]
        public string DestinationCurrency { get; set; }
    }
}
