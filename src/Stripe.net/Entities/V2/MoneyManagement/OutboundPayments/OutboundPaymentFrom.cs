// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentFrom : StripeEntity<OutboundPaymentFrom>
    {
        /// <summary>
        /// The monetary amount debited from the sender, only set on responses.
        /// </summary>
        [JsonProperty("debited")]
        [STJS.JsonPropertyName("debited")]
        public V2.Amount Debited { get; set; }

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }
    }
}
