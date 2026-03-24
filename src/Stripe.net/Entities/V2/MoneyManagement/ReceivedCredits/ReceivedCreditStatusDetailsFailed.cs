// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditStatusDetailsFailed : StripeEntity<ReceivedCreditStatusDetailsFailed>
    {
        /// <summary>
        /// Open Enum. The <c>failed</c> status reason.
        /// One of: <c>capability_inactive</c>, <c>currency_unsupported_on_financial_address</c>,
        /// <c>financial_address_inactive</c>, or <c>stripe_rejected</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
