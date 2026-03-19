// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountStatusDetails : StripeEntity<FinancialAccountStatusDetails>
    {
        /// <summary>
        /// Details related to the closed state of the FinancialAccount.
        /// </summary>
        [JsonProperty("closed")]
        [STJS.JsonPropertyName("closed")]
        public FinancialAccountStatusDetailsClosed Closed { get; set; }
    }
}
