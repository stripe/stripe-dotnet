// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountRejectionPlatformRejection : StripeEntity<AccountRejectionPlatformRejection>
    {
        /// <summary>
        /// The reason the platform rejected the Account.
        /// One of: <c>credit</c>, <c>fraud</c>, <c>fraud_no_intent_to_fulfill</c>,
        /// <c>fraud_other</c>, <c>fraud_payment_method_casher</c>,
        /// <c>fraud_payment_method_tester</c>, <c>other</c>, or <c>terms_of_service</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
