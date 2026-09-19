// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutPayoutMethodOptionsFinancialAccount : StripeEntity<PayoutPayoutMethodOptionsFinancialAccount>
    {
        /// <summary>
        /// The currency credited to the destination Financial Account.
        /// </summary>
        [JsonProperty("destination_currency")]
        [STJS.JsonPropertyName("destination_currency")]
        public string DestinationCurrency { get; set; }
    }
}
