// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalCustomerRiskAdditionalDetailsIndicator : StripeEntity<AccountSignalCustomerRiskAdditionalDetailsIndicator>
    {
        /// <summary>
        /// The name of the customer risk indicator.
        /// One of: <c>card_testing_on_stripe</c>, <c>customer_recently_created</c>,
        /// <c>disposable_email_use_on_stripe</c>, <c>distributed_fraud_on_stripe</c>,
        /// <c>high_distinct_card_count_on_stripe</c>, <c>high_distinct_email_count_on_stripe</c>,
        /// <c>high_distinct_ip_count_on_stripe</c>, <c>high_distinct_phone_count_on_stripe</c>,
        /// <c>high_fraudulent_dispute_count_on_stripe</c>,
        /// <c>high_name_verification_failure_count_on_stripe</c>,
        /// <c>high_refund_count_on_stripe</c>, <c>low_auth_rate_on_stripe</c>,
        /// <c>new_identity_on_stripe</c>, <c>proxy_ip_usage_on_stripe</c>,
        /// <c>shared_browser_fingerprint_many_customers</c>, or <c>shared_card_many_customers</c>.
        /// </summary>
        [JsonProperty("indicator")]
        [STJS.JsonPropertyName("indicator")]
        public string Indicator { get; set; }
    }
}
