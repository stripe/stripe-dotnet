// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditStatusDetailsFailed : StripeEntity<ReceivedCreditStatusDetailsFailed>
    {
        /// <summary>
        /// Open Enum. The <c>failed</c> status reason.
        /// One of: <c>capability_inactive</c>, <c>currency_unsupported_on_financial_address</c>,
        /// <c>financial_address_inactive</c>, or <c>stripe_rejected</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
