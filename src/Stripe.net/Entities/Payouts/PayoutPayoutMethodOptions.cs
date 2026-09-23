// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutPayoutMethodOptions : StripeEntity<PayoutPayoutMethodOptions>
    {
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public PayoutPayoutMethodOptionsFinancialAccount FinancialAccount { get; set; }
    }
}
